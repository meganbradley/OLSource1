---
title: "AND_CATCH_ALL"
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
  - "AFX/AND_CATCH_ALL"
  - "AND_CATCH_ALL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AND_CATCH_ALL macro"
ms.assetid: ac983fa5-41cc-4fcf-8e9d-485398b04063
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AND_CATCH_ALL
Defines a block of code for catching additional exception types thrown in a preceding **TRY** block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *exception_object_pointer_name*  
 A name for an exception-object pointer that will be created by the macro. You can use the pointer name to access the exception object within the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> block. This variable is declared for you.  
  
## Remarks  
 Use the **CATCH** macro to catch one exception type, then the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> macro to catch all other subsequent types. If you use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, end the **TRY** block with an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> macro.  
  
 The exception-processing code can interrogate the exception object, if appropriate, to get more information about the specific cause of the exception. Call the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> macro within the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> block to shift processing to the next outer exception frame. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> marks the end of the preceding **CATCH** or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> block.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> block is defined as a C++ scope (delineated by braces). If you declare variables in this scope, remember that they are accessible only within that scope.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [TRY](../vs140/try.md)   
 [CATCH_ALL](../vs140/catch_all.md)   
 [END_CATCH_ALL](../vs140/end_catch_all.md)   
 [THROW](../vs140/throw--mfc-.md)   
 [THROW_LAST](../vs140/throw_last.md)   
 [AND_CATCH](../vs140/and_catch.md)   
 [CException Class](../vs140/cexception-class.md)