---
title: "_get_purecall_handler, _set_purecall_handler"
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
  - "_set_purecall_handler"
  - "_set_purecall_handler_m"
  - "_get_purecall_handler"
apilocation: 
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr120_clr0400.dll"
  - "api-ms-win-core-crt-l2-1-0.dll"
  - "ntoskrnl.exe"
apitype: "DLLExport"
f1_keywords: 
  - "_set_purecall_handler"
  - "_set_purecall_handler_m"
  - "set_purecall_handler_m"
  - "set_purecall_handler"
  - "stdlib/_set_purecall_handler"
  - "stdlib/_get_purecall_handler"
  - "_get_purecall_handler"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_set_purecall_handler function"
  - "set_purecall_handler function"
  - "purecall_handler"
  - "set_purecall_handler_m function"
  - "_purecall_handler"
  - "_set_purecall_handler_m function"
  - "_get_purecall_handler function"
ms.assetid: 2759b878-8afa-4129-86e7-72afc2153d9c
caps.latest.revision: 22
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _get_purecall_handler, _set_purecall_handler
Gets or sets the error handler for a pure virtual function call.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The function to be called when a pure virtual function is called. A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function must have a void return type.  
  
## Return Value  
 The previous <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if there was no previous handler.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> functions are Microsoft-specific and apply only to C++ code.  
  
 A call to a pure virtual function is an error because it has no implementation. By default, the compiler generates code to invoke an error handler function when a pure virtual function is called, which terminates the program. You can install your own error handler function for pure virtual function calls, to catch them for debugging or reporting purposes. To use your own error handler, create a function that has the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> signature, then use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to make it the current handler.  
  
 Because there is only one <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> for each process, when you call <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> it immediately impacts all threads. The last caller on any thread sets the handler.  
  
 To restore the default behavior, call <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> by using a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> argument.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|\<cstdlib> or \<stdlib.h>|  
  
 For compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **In _purecall_handler.**   
## See Also  
 [Error Handling](../vs140/error-handling--crt-.md)   
 [_purecall](../vs140/_purecall.md)