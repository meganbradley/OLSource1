---
title: "_CrtDumpMemoryLeaks"
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
  - "_CrtDumpMemoryLeaks"
apilocation: 
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "CRTDBG_LEAK_CHECK_DF"
  - "CRTDBG_CHECK_CRT_DF"
  - "_CRTDBG_LEAK_CHECK_DF"
  - "CrtDumpMemoryLeaks"
  - "_CrtDumpMemoryLeaks"
  - "_CRTDBG_CHECK_CRT_DF"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "CrtDumpMemoryLeaks function"
  - "CRTDBG_LEAK_CHECK_DF macro"
  - "_CRTDBG_LEAK_CHECK_DF macro"
  - "_CrtDumpMemoryLeaks function"
  - "CRTDBG_CHECK_CRT_DF macro"
  - "_CRTDBG_CHECK_CRT_DF macro"
ms.assetid: 71b2eab4-7f55-44e8-a55a-bfea4f32d34c
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _CrtDumpMemoryLeaks
Dumps all the memory blocks in the debug heap when a memory leak has occurred (debug version only).  
  
## Syntax  
  
```  
  
int _CrtDumpMemoryLeaks( void );  
```  
  
## Return Value  
 `_CrtDumpMemoryLeaks` returns TRUE if a memory leak is found. Otherwise, the function returns FALSE.  
  
## Remarks  
 The `_CrtDumpMemoryLeaks` function determines whether a memory leak has occurred since the start of program execution. When a leak is found, the debug header information for all the objects in the heap is dumped in a user-readable form. When [_DEBUG](../vs140/_debug.md) is not defined, calls to `_CrtDumpMemoryLeaks` are removed during preprocessing.  
  
 `_CrtDumpMemoryLeaks` is frequently called at the end of program execution to verify that all memory allocated by the application has been freed. The function can be called automatically at program termination by turning on the `_CRTDBG_LEAK_CHECK_DF` bit field of the [_crtDbgFlag](../vs140/_crtdbgflag.md) flag using the [_CrtSetDbgFlag](../vs140/_crtsetdbgflag.md) function.  
  
 `_CrtDumpMemoryLeaks` calls [_CrtMemCheckpoint](../vs140/_crtmemcheckpoint.md) to obtain the current state of the heap and then scans the state for blocks that have not been freed. When an unfreed block is encountered, `_CrtDumpMemoryLeaks` calls [_CrtMemDumpAllObjectsSince](../vs140/_crtmemdumpallobjectssince.md) to dump information for all the objects allocated in the heap from the start of program execution.  
  
 By default, internal C run-time blocks (`_CRT_BLOCK`) are not included in memory dump operations. The [_CrtSetDbgFlag](../vs140/_crtsetdbgflag.md) function can be used to turn on the `_CRTDBG_CHECK_CRT_DF` bit of `_crtDbgFlag` to include these blocks in the leak detection process.  
  
 For more information about heap state functions and the `_CrtMemState` structure, see [Heap State Reporting Functions](../vs140/crt-debug-heap-details.md#BKMK_Heap_State_Reporting_Functions). For more information about how memory blocks are allocated, initialized, and managed in the debug version of the base heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_CrtDumpMemoryLeaks`|<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## Example  
 For a sample of how to use `_CrtDumpMemoryLeaks`, see [crt_dbg1](assetId:///17b4b20c-e849-48f5-8eb5-dca6509cbaf9).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)