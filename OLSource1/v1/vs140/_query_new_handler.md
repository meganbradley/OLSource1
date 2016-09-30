---
title: "_query_new_handler"
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
  - "_query_new_handler"
apilocation: 
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_query_new_handler"
  - "query_new_handler"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "query_new_handler function"
  - "handler routines"
  - "error handling"
  - "_query_new_handler function"
ms.assetid: 9a84b5c3-fe33-4c01-83a0-be87dc3ec518
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _query_new_handler
Returns the address of the current new handler routine.  
  
## Syntax  
  
```  
  
      _PNH _query_new_handler(  
   void   
);  
```  
  
## Return Value  
 Returns the address of the current new handler routine as set by `_set_new_handler`.  
  
## Remarks  
 The C++ `_query_new_handler` function returns the address of the current exception-handling function set by the C++ [_set_new_handler](../vs140/_set_new_handler.md) function. `_set_new_handler` is used to specify an exception-handling function that is to gain control if the **new** operator fails to allocate memory. For more information, see the discussions of the [operator new](../vs140/operator-new-function.md) and [operator delete](../vs140/operator-delete-function.md) functions in *C++ Language Reference*.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_query_new_handler`|\<new.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)   
 [free](../vs140/free.md)