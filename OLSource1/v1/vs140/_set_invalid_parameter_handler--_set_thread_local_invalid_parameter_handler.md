---
title: "_set_invalid_parameter_handler, _set_thread_local_invalid_parameter_handler"
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
  - "_set_invalid_parameter_handler"
  - "_set_thread_local_invalid_parameter_handler"
apilocation: 
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "api-ms-win-crt-runtime-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "set_invalid_parameter_handler"
  - "_set_invalid_parameter_handler"
  - "_set_thread_local_invalid_parameter_handler"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "invalid parameter handler"
  - "set_invalid_parameter_handler function"
  - "_set_invalid_parameter_handler function"
  - "_set_thread_local_invalid_parameter_handler function"
ms.assetid: c0e67934-1a41-4016-ad8e-972828f3ac11
caps.latest.revision: 29
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _set_invalid_parameter_handler, _set_thread_local_invalid_parameter_handler
Sets a function to be called when the CRT detects an invalid argument.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The function pointer to the new invalid parameter handler.  
  
## Return Value  
 A pointer to the invalid parameter handler before the call.  
  
## Remarks  
 Many C runtime functions check the validity of arguments passed to them. If an invalid argument is passed, the function can set the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> error number or return an error code. In such cases, the invalid parameter handler is also called. The C runtime supplies a default global invalid parameter handler that terminates the program and displays a runtime error message. You can use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to set your own function as the global invalid parameter handler. The C runtime also supports a thread-local invalid parameter handler. If a thread-local parameter handler is set in a thread by using <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the C runtime functions called from the thread use that handler instead of the global handler. Only one function can be specified as the global invalid argument handler at a time. Only one function can be specified as the thread-local invalid argument handler per thread, but different threads can have different thread-local handlers. This allows you to change the handler used in one part of your code without affecting the behavior of other threads.  
  
 When the runtime calls the invalid parameter function, it usually means that a nonrecoverable error occurred. The invalid parameter handler function you supply should save any data it can and then abort. It should not return control to the main function unless you are confident that the error is recoverable.  
  
 The invalid parameter handler function must have the following prototype:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> argument is a wide string representation of the argument expression that raised the error. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> argument is the name of the CRT function that received the invalid argument. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> argument is the name of the CRT source file that contains the function. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> argument is the line number in that file. The last argument is reserved. The parameters all have the value <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> unless a debug version of the CRT library is used.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|C: \<stdlib.h>\<br />\<br /> C++: \<cstdlib> or \<stdlib.h>|  
  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> functions are Microsoft specific. For compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
 In the following example, an invalid parameter error handler is used to print the function that received the invalid parameter and the file and line in CRT sources. When the debug CRT library is used, invalid parameter errors also raise an assertion, which is disabled in this example using [_CrtSetReportMode](../vs140/_crtsetreportmode.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Invalid parameter detected in function common_vfprintf. File: minkernel\crts\ucrt\src\appcrt\stdio\output.cpp Line: 32**  
**Expression: format != nullptr**   
## See Also  
 [_get_invalid_parameter_handler, _get_thread_local_invalid_parameter_handler](../vs140/_get_invalid_parameter_handler--_get_thread_local_invalid_parameter_handler.md)   
 [Security-Enhanced Versions of CRT Functions](../vs140/security-enhanced-versions-of-crt-functions.md)   
 [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md)