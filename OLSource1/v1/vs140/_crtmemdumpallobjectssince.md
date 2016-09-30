---
title: "_CrtMemDumpAllObjectsSince"
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
  - "_CrtMemDumpAllObjectsSince"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "CrtMemDumpAllObjectsSince"
  - "_CrtMemDumpAllObjectsSince"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_CrtMemDumpAllObjectsSince function"
  - "CrtMemDumpAllObjectsSince function"
ms.assetid: c48a447a-e6bb-475c-9271-a3021182a0dc
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _CrtMemDumpAllObjectsSince
Dumps information about objects in the heap from the start of program execution or from a specified heap state (debug version only).  
  
## Syntax  
  
```  
  
      void _CrtMemDumpAllObjectsSince(   
   const _CrtMemState *state   
);  
```  
  
#### Parameters  
 `state`  
 Pointer to the heap state to begin dumping from or **NULL**.  
  
## Remarks  
 The `_CrtMemDumpAllObjectsSince` function dumps the debug header information of objects allocated in the heap in a user-readable form. The dump information can be used by the application to track allocations and detect memory problems. When [_DEBUG](../vs140/_debug.md) is not defined, calls to `_CrtMemDumpAllObjectsSince` are removed during preprocessing.  
  
 `_CrtMemDumpAllObjectsSince` uses the value of the `state` parameter to determine where to initiate the dump operation. To begin dumping from a specified heap state, the `state` parameter must be a pointer to a **_CrtMemState** structure that has been filled in by [_CrtMemCheckpoint](../vs140/_crtmemcheckpoint.md) before `_CrtMemDumpAllObjectsSince` was called. When `state` is **NULL**, the function begins the dump from the start of program execution.  
  
 If the application has installed a dump hook function by calling [_CrtSetDumpClient](../vs140/_crtsetdumpclient.md), then every time `_CrtMemDumpAllObjectsSince` dumps information about a `_CLIENT_BLOCK` type of block, it calls the application-supplied dump function as well. By default, internal C run-time blocks (`_CRT_BLOCK`) are not included in memory dump operations. The [_CrtSetDbgFlag](../vs140/_crtsetdbgflag.md) function can be used to turn on the `_CRTDBG_CHECK_CRT_DF` bit of **_crtDbgFlag** to include these blocks. In addition, blocks marked as freed or ignored (**_FREE_BLOCK**, **_IGNORE_BLOCK**) are not included in the memory dump.  
  
 For more information about heap state functions and the `_CrtMemState` structure, see [Heap State Reporting Functions](../vs140/crt-debug-heap-details.md#BKMK_Heap_State_Reporting_Functions). For more information about how memory blocks are allocated, initialized, and managed in the debug version of the base heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|**_CrtMemDumpAll-ObjectsSince**|\<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## Example  
 For a sample of how to use `_CrtMemDumpAllObjectsSince`, see [crt_dbg2](assetId:///21e1346a-6a17-4f57-b275-c76813089167).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)   
 [_crtDbgFlag](../vs140/_crtdbgflag.md)