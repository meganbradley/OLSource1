---
title: "_get_terminate"
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
  - "_get_terminate"
apilocation: 
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "get_terminate"
  - "_get_terminate"
  - "__get_terminate"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "__get_terminate function"
  - "get_terminate function"
  - "_get_terminate function"
ms.assetid: c8f168c4-0ad5-4832-a522-dd1ef383c208
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _get_terminate
Returns the termination routine to be called by `terminate`.  
  
## Syntax  
  
```  
terminate_function _get_terminate( void );  
```  
  
## Return Value  
 Returns a pointer to the function registered by [set_terminate](../VS_csharp/set_terminate--crt-.md). If no function has been set, the return value may be used to restore the default behavior; this value may be NULL.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_get_terminate`|<eh.h>|  
  
 For additional compatibility information, see [Compatibility](../VS_csharp/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Exception Handling Routines](../VS_csharp/exception-handling-routines.md)   
 [abort](../VS_csharp/abort.md)   
 [set_unexpected](../VS_csharp/set_unexpected--crt-.md)   
 [terminate](../VS_csharp/terminate--crt-.md)   
 [unexpected](../VS_csharp/unexpected--crt-.md)