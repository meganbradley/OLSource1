---
title: "_purecall"
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
  - "_purecall"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr120_clr0400.dll"
  - "api-ms-win-core-crt-l2-1-0.dll"
  - "ntoskrnl.exe"
apitype: "DLLExport"
f1_keywords: 
  - "purecall"
  - "_purecall"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_purecall function"
  - "purecall function"
ms.assetid: 56135d9b-3403-4e22-822d-e714523801cc
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _purecall
The default pure virtual function call error handler. The compiler generates code to call this function when a pure virtual member function is called.  
  
## Syntax  
  
```  
extern "C" int __cdecl _purecall();  
```  
  
## Remarks  
 The `_purecall` function is a Microsoft-specific implementation detail of the Microsoft Visual C++ compiler. This function is not intended to be called by your code directly, and it has no public header declaration. It is documented here because it is a public export of the C Runtime Library.  
  
 A call to a pure virtual function is an error because it has no implementation. The compiler generates code to invoke the `_purecall` error handler function when a pure virtual function is called. By default, `_purecall` terminates the program. Before terminating, the `_purecall` function invokes a `_purecall_handler` function if one has been set for the process. You can install your own error handler function for pure virtual function calls, to catch them for debugging or reporting purposes. To use your own error handler, create a function that has the `_purecall_handler` signature, then use [_set_purecall_handler](../vs140/_get_purecall_handler--_set_purecall_handler.md) to make it the current handler.  
  
## Requirements  
 The `_purecall` function does not have a header declaration. The `_purecall_handler` typedef is defined in <stdlib.h>.  
  
## See Also  
 [Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [_get_purecall_handler, _set_purecall_handler](../vs140/_get_purecall_handler--_set_purecall_handler.md)