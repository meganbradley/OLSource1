---
title: "&lt;exception&gt;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "<exception>"
  - "std::<exception>"
  - "std.<exception>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "exception header"
ms.assetid: 28900768-5dd7-4834-b907-5e37ab3407db
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;exception&gt;
Defines several types and functions related to the handling of exceptions. Exception handling is used in situations in which the system can recover from an error. It provides a means for control to be returned from a function to the program. The objective of incorporating exception handling is to increase the program's robustness while providing a way to recover from an error in an orderly fashion.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Typedefs  
  
|||  
|-|-|  
|[exception_ptr](../vs140/-exception--typedefs.md#exception_ptr)|A type that describes a pointer to an exception.|  
|[terminate_handler](../vs140/-exception--typedefs.md#terminate_handler)|A type that describes a pointer to a function suitable for use as a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.|  
|[unexpected_handler](../vs140/-exception--typedefs.md#unexpected_handler)|A type that describes a pointer to a function suitable for use as an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.|  
  
### Functions  
  
|||  
|-|-|  
|[current_exception](../vs140/-exception--functions.md#current_exception)|Obtains a pointer to the current exception.|  
|[get_terminate](../vs140/-exception--functions.md#get_terminate)|Obtains the current <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function.|  
|[get_unexpected](../vs140/-exception--functions.md#get_unexpected)|Obtains the current <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function.|  
|[make_exception_ptr](../vs140/-exception--functions.md#make_exception_ptr)|Creates an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object that holds a copy of an exception.|  
|[rethrow_exception](../vs140/-exception--functions.md#rethrow_exception)|Throws an exception passed as a parameter.|  
|[set_terminate](../vs140/-exception--functions.md#set_terminate)|Establishes a new <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to be called at the termination of the program.|  
|[set_unexpected](../vs140/-exception--functions.md#set_unexpected)|Establishes a new <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to be when an unexpected exception is encountered.|  
|[terminate](../vs140/-exception--functions.md#terminate)|Calls a terminate handler.|  
|[uncaught_exception](../vs140/-exception--functions.md#uncaught_exception)|Returns **true** only if a thrown exception is being currently processed.|  
|[unexpected](../vs140/-exception--functions.md#unexpected)|Calls an unexpected handler.|  
  
### Classes  
  
|||  
|-|-|  
|[bad_exception Class](../vs140/bad_exception-class.md)|The class describes an exception that can be thrown from an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
|[exception Class](../vs140/exception-class.md)|The class serves as the base class for all exceptions thrown by certain expressions and by the Standard C++ Library.|  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)