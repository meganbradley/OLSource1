---
title: "_get_invalid_parameter_handler, _get_thread_local_invalid_parameter_handler"
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
  - "_get_invalid_parameter_handler"
  - "_get_thread_local_invalid_parameter_handler"
apilocation: 
  - "api-ms-win-crt-runtime-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_get_invalid_parameter_handler"
  - "stdlib/_get_invalid_parameter_handler"
  - "_get_thread_local_invalid_parameter_handler"
  - "stdlib/_get_thread_local_invalid_parameter_handler"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "_get_thread_local_invalid_parameter_handler function"
  - "_get_invalid_parameter_handler function"
ms.assetid: a176da0e-38ca-4d99-92bb-b0e2b8072f53
caps.latest.revision: 7
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _get_invalid_parameter_handler, _get_thread_local_invalid_parameter_handler
Gets the function that is called when the CRT detects an invalid argument.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the currently set invalid parameter handler function, or a null pointer if none has been set.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function gets the currently set global invalid parameter handler. It returns a null pointer if no global invalid parameter handler was set. Similarly, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> gets the current thread-local invalid parameter handler of the thread it is called on, or a null pointer if no handler was set. For information about how to set global and thread-local invalid parameter handlers, see [_set_invalid_parameter_handler, _set_thread_local_invalid_parameter_handler](../vs140/_set_invalid_parameter_handler--_set_thread_local_invalid_parameter_handler.md).  
  
 The returned invalid parameter handler function pointer has the following type:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For details on the invalid parameter handler, see the prototype in [_set_invalid_parameter_handler, _set_thread_local_invalid_parameter_handler](../vs140/_set_invalid_parameter_handler--_set_thread_local_invalid_parameter_handler.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|C: \<stdlib.h>\<br />\<br /> C++: \<cstdlib> or \<stdlib.h>|  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> functions are Microsoft specific. For compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [_set_invalid_parameter_handler, _set_thread_local_invalid_parameter_handler](../vs140/_set_invalid_parameter_handler--_set_thread_local_invalid_parameter_handler.md)   
 [Security-Enhanced Versions of CRT Functions](../vs140/security-enhanced-versions-of-crt-functions.md)