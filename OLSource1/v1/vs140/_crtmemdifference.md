---
title: "_CrtMemDifference"
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
  - "_CrtMemDifference"
apilocation: 
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcrd.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_CrtMemDifference"
  - "CrtMemDifference"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "CrtMemDifference function"
  - "_CrtMemDifference function"
ms.assetid: 0f327278-b551-482f-958b-76941f796ba4
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _CrtMemDifference
Compares two memory states and returns their differences (debug version only).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure that is used to store the differences between the two memory states (returned).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to an earlier memory state (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure).  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to a later memory state (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure).  
  
## Return Value  
 If the memory states are significantly different, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns TRUE. Otherwise, the function returns FALSE.  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function compares <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and stores their differences in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, which can then be used by the application to detect memory leaks and other memory problems. When [_DEBUG](../vs140/_debug.md) is not defined, calls to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> are removed during preprocessing.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> must each be a valid pointer to a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> structure, defined in Crtdbg.h, that has been filled in by [_CrtMemCheckpoint](../vs140/_crtmemcheckpoint.md) before calling <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> must be a pointer to a previously allocated instance of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> structure. If <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) is set to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and the function returns FALSE.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> compares the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> field values of the blocks in <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> to those in <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and stores the result in <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. When the number of allocated block types or total number of allocated blocks for each type differs between the two memory states, the states are said to be significantly different. The difference between the largest amount ever allocated at once for the two states and the difference between total allocations for the two states are also stored in <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
 By default, internal C run-time blocks (<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>) are not included in memory state operations. The [_CrtSetDbgFlag](../vs140/_crtsetdbgflag.md) function can be used to turn on the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> bit of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to include these blocks in leak detection and other memory state operations. Freed memory blocks (<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>) do not cause <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> to return TRUE.  
  
 For more information about heap state functions and the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> structure, see [Heap State Reporting Functions](../vs140/crt-debug-heap-details.md#BKMK_Heap_State_Reporting_Functions). For information about how memory blocks are allocated, initialized, and managed in the debug version of the base heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md).  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|\<crtdbg.h>|\<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
 **Libraries:** Debug versions of [CRT Library Features](../vs140/crt-library-features.md) only.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)   
 [_crtDbgFlag](../vs140/_crtdbgflag.md)