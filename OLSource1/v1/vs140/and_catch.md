---
title: "AND_CATCH"
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
  - "AND_CATCH"
  - "AFX/AND_CATCH"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AND_CATCH macro"
ms.assetid: dcbdc1c7-4cbf-44d4-84ec-c0b60d0626a1
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AND_CATCH
Defines a block of code for catching additional exception types thrown in a preceding **TRY** block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *exception_class*  
 Specifies the exception type to test for. For a list of standard exception classes, see class [CException](../vs140/cexception-class.md).  
  
 *exception_object_pointer_name*  
 A name for an exception-object pointer that will be created by the macro. You can use the pointer name to access the exception object within the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> block. This variable is declared for you.  
  
## Remarks  
 Use the **CATCH** macro to catch one exception type, then the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> macro to catch each subsequent type. End the **TRY** block with an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> macro.  
  
 The exception-processing code can interrogate the exception object, if appropriate, to get more information about the specific cause of the exception. Call the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> macro within the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> block to shift processing to the next outer exception frame. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> marks the end of the preceding **CATCH** or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> block.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> block is defined as a C++ scope (delineated by curly braces). If you declare variables in this scope, remember that they are accessible only within that scope. This also applies to the *exception_object_pointer_name* variable.  
  
## Example  
 See the example for [CATCH](../vs140/catch.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [TRY](../vs140/try.md)   
 [CATCH](../vs140/catch.md)   
 [END_CATCH](../vs140/end_catch.md)   
 [THROW](../vs140/throw--mfc-.md)   
 [THROW_LAST](../vs140/throw_last.md)   
 [AND_CATCH_ALL](../vs140/and_catch_all.md)   
 [CException Class](../vs140/cexception-class.md)