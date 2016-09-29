---
title: "_CrtMemDumpStatistics"
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
  - "_CrtMemDumpStatistics"
apilocation: 
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "CrtMemDumpStatistics"
  - "_CrtMemDumpStatistics"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_CrtMemDumpStatistics function"
  - "CrtMemDumpStatistics function"
ms.assetid: 27b9d731-3184-4a2d-b9a7-6566ab28a9fe
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _CrtMemDumpStatistics
Dumps the debug header information for a specified heap state in a user-readable form (debug version only).  
  
## Syntax  
  
```  
void _CrtMemDumpStatistics(   
   const _CrtMemState *state   
);  
```  
  
#### Parameters  
 `state`  
 Pointer to the heap state to dump.  
  
## Remarks  
 The `_CrtMemDumpStatistics` function dumps the debug header information for a specified state of the heap in a user-readable form. The dump statistics can be used by the application to track allocations and detect memory problems. The memory state can contain a specific heap state or the difference between two states. When [_DEBUG](../vs140/_debug.md) is not defined, calls to `_CrtMemDumpStatistics` are removed during preprocessing.  
  
 The `state` parameter must be a pointer to a `_CrtMemState` structure that has been filled in by [_CrtMemCheckpoint](../vs140/_crtmemcheckpoint.md) or returned by [_CrtMemDifference](../vs140/_crtmemdifference.md) before `_CrtMemDumpStatistics` is called. If `state` is `NULL`, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, `errno` is set to `EINVAL` and no action is taken. For more information, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 For more information about heap state functions and the `_CrtMemState` structure, see [Heap State Reporting Functions](../vs140/crt-debug-heap-details.md#BKMK_Heap_State_Reporting_Functions). For more information about how memory blocks are allocated, initialized, and managed in the debug version of the base heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md).  
  
## Requirements  
  
|Routine|Required header|Optional headers|  
|-------------|---------------------|----------------------|  
|`_CrtMemDumpStatistics`|<crtdbg.h>|<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
 **Libraries:** Debug versions of [CRT Library Features](../vs140/crt-library-features.md) only.  
  
## .NET Framework Equivalent  
 <xref:System.Diagnostics.PerformanceCounter*?displayProperty=fullName>  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)