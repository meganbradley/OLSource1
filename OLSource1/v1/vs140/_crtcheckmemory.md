---
title: "_CrtCheckMemory"
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
  - "_CrtCheckMemory"
apilocation: 
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "CrtCheckMemory"
  - "_CrtCheckMemory"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_CrtCheckMemory function"
  - "CrtCheckMemory function"
ms.assetid: 457cc72e-60fd-4177-ab5c-6ae26a420765
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _CrtCheckMemory
Confirms the integrity of the memory blocks allocated in the debug heap (debug version only).  
  
## Syntax  
  
```  
  
int _CrtCheckMemory( void );  
```  
  
## Return Value  
 If successful, `_CrtCheckMemory` returns TRUE; otherwise, the function returns FALSE.  
  
## Remarks  
 The `_CrtCheckMemory` function validates memory allocated by the debug heap manager by verifying the underlying base heap and inspecting every memory block. If an error or memory inconsistency is encountered in the underlying base heap, the debug header information, or the overwrite buffers, `_CrtCheckMemory` generates a debug report with information describing the error condition. When [_DEBUG](../vs140/_debug.md) is not defined, calls to `_CrtCheckMemory` are removed during preprocessing.  
  
 The behavior of `_CrtCheckMemory` can be controlled by setting the bit fields of the [_crtDbgFlag](../vs140/_crtdbgflag.md) flag using the [_CrtSetDbgFlag](../vs140/_crtsetdbgflag.md) function. Turning the **_CRTDBG_CHECK_ALWAYS_DF** bit field ON results in `_CrtCheckMemory` being called every time a memory allocation operation is requested. Although this method slows down execution, it is useful for catching errors quickly. Turning the **_CRTDBG_ALLOC_MEM_DF** bit field OFF causes `_CrtCheckMemory` to not verify the heap and immediately return **TRUE**.  
  
 Because this function returns **TRUE** or **FALSE**, it can be passed to one of the [_ASSERT](../vs140/_assert--_asserte--_assert_expr-macros.md) macros to create a simple debugging error handling mechanism. The following example causes an assertion failure if corruption is detected in the heap:  
  
```  
_ASSERTE( _CrtCheckMemory( ) );  
```  
  
 For more information about how `_CrtCheckMemory` can be used with other debug functions, see [Heap State Reporting Functions](../vs140/crt-debug-heap-details.md#BKMK_Heap_State_Reporting_Functions). For an overview of memory management and the debug heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_CrtCheckMemory`|<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## Example  
 For a sample of how to use `_CrtCheckMemory`, see [crt_dbg1](assetId:///17b4b20c-e849-48f5-8eb5-dca6509cbaf9).  
  
## .NET Framework Equivalent  
 [System::Diagnostics::PerformanceCounter](https://msdn.microsoft.com/en-us/library/system.diagnostics.performancecounter.aspx)  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)   
 [_crtDbgFlag](../vs140/_crtdbgflag.md)   
 [_CrtSetDbgFlag](../vs140/_crtsetdbgflag.md)