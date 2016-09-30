---
title: "Differences in Exception Handling Behavior Under -CLR"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Differences in Exception Handling Behavior Under /CLR"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EXCEPTION_CONTINUE_EXECUTION macro"
  - "set_se_translator function"
ms.assetid: 2e7e8daf-d019-44b0-a51c-62d7aaa89104
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Differences in Exception Handling Behavior Under -CLR
[Basic Concepts in Using Managed Exceptions](../vs140/basic-concepts-in-using-managed-exceptions.md) discusses exception handling in managed applications. In this topic, differences from the standard behavior of exception handling and some restrictions are discussed in detail. For more information, see [The _set_se_translator Function](../vs140/_set_se_translator.md).  
  
##  \<a name="vcconjumpingoutofafinallyblock">\</a> Jumping Out of a Finally Block  
 In native C/C++ code, jumping out of a __**finally** block using structured exception handling (SEH) is allowed although it produces a warning.  Under [/clr](../vs140/-clr--common-language-runtime-compilation-.md), jumping out of a **finally** block causes an error:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
##  \<a name="vcconraisingexceptionswithinanexceptionfilter">\</a> Raising Exceptions Within an Exception Filter  
 When an exception is raised during the processing of an [exception filter](../vs140/writing-an-exception-filter.md) within managed code, the exception is caught and treated as if the filter returns 0.  
  
 This is in contrast to the behavior in native code where a nested exception is raised, the **ExceptionRecord** field in the **EXCEPTION_RECORD** structure (as returned by [GetExceptionInformation](http://msdn.microsoft.com/library/windows/desktop/ms679357)) is set, and the **ExceptionFlags** field sets the 0x10 bit. The following example illustrates this difference in behavior:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="vccondisassociatedrethrows">\</a> Disassociated Rethrows  
 **/clr** does not support rethrowing an exception outside of a catch handler (known as a disassociated rethrow). Exceptions of this type are treated as a standard C++ rethrow. If a disassociated rethrow is encountered when there is an active managed exception, the exception is wrapped as a C++ exception and then rethrown. Exceptions of this type can only be caught as an exception of type [System::SEHException](https://msdn.microsoft.com/en-us/library/system.runtime.interopservices.sehexception.aspx).  
  
 The following example demonstrates a managed exception rethrown as a C++ exception:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="vcconexceptionfiltersandexception_continue_execution">\</a> Exception Filters and EXCEPTION_CONTINUE_EXECUTION  
 If a filter returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in a managed application, it is treated as if the filter returned <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. For more information on these constants, see [try-except Statement](../vs140/try-except-statement.md).  
  
 The following example demonstrates this difference:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="vcconthe_set_se_translatorfunction">\</a> The _set_se_translator Function  
 The translator function, set by a call to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, affects only catches in unmanaged code. The following example demonstrates this limitation:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## See Also  
 [Exception Handling](../vs140/exception-handling---c---component-extensions-.md)   
 [safe_cast](../vs140/safe_cast--c---component-extensions-.md)   
 [Exception Handling](../vs140/exception-handling-in-visual-c--.md)