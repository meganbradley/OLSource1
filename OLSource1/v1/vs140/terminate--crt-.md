---
title: "terminate (CRT)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "terminate"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "terminate"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "terminate function"
  - "exception handling, termination"
ms.assetid: 90e67402-08e9-4b2a-962c-66a8afd3ccb4
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# terminate (CRT)
Calls <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or a function you specify using <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function is used with C++ exception handling and is called in the following cases:  
  
-   A matching catch handler cannot be found for a thrown C++ exception.  
  
-   An exception is thrown by a destructor function during stack unwind.  
  
-   The stack is corrupted after throwing an exception.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> by default. You can change this default by writing your own termination function and calling <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> with the name of your function as its argument. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> calls the last function given as an argument to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. For more information, see [Unhandled C++ Exceptions](../vs140/unhandled-c---exceptions.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|\<eh.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **term_func() was called by terminate().**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Exception Handling Routines](../vs140/exception-handling-routines.md)   
 [abort](../vs140/abort.md)   
 [_set_se_translator](../vs140/_set_se_translator.md)   
 [set_terminate](../vs140/set_terminate--crt-.md)   
 [set_unexpected](../vs140/set_unexpected--crt-.md)   
 [unexpected](../vs140/unexpected--crt-.md)