---
title: "_CrtDoForAllClientObjects"
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
  - "_CrtDoForAllClientObjects"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr120_clr0400.dll"
  - "ucrtbased.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_CrtDoForAllClientObjects"
  - "CrtDoForAllClientObjects"
  - "crtdbg/_CrdDoForAllClientObjects"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_CrtDoForAllClientObjects function"
  - "CrtDoForAllClientObjects function"
ms.assetid: d0fdb835-3cdc-45f1-9a21-54208e8df248
caps.latest.revision: 22
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _CrtDoForAllClientObjects
Calls an application-supplied function for all <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> types in the heap (debug version only).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the application-supplied function callback function. The first parameter to this function points to the data. The second parameter is the context pointer that is passed to the call to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to the application-supplied context to pass to the application-supplied function.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function searches the heap's linked list for memory blocks with the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> type and calls the application-supplied function when a block of this type is found. The found block and the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter are passed as arguments to the application-supplied function. During debugging, an application can track a specific group of allocations by explicitly calling the debug heap functions to allocate the memory and specifying that the blocks be assigned the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> block type. These blocks can then be tracked separately and reported on differently during leak detection and memory state reporting.  
  
 If the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> bit field of the [_crtDbgFlag](../vs140/_crtdbgflag.md) flag is not turned on, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> immediately returns. When [_DEBUG](../vs140/_debug.md) is not defined, calls to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> are removed during preprocessing.  
  
 For more information about the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> type and how it can be used by other debug functions, see [Types of Blocks on the Debug Heap](../vs140/crt-debug-heap-details.md#BKMK_Types_of_blocks_on_the_debug_heap). For information about how memory blocks are allocated, initialized, and managed in the debug version of the base heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md).  
  
 If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) is set to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and the function returns.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|\<crtdbg.h>, \<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
 **Libraries:** Debug versions of  universal C run-time libraries only.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)   
 [_CrtSetDbgFlag](../vs140/_crtsetdbgflag.md)   
 [Heap State Reporting Functions](../vs140/crt-debug-heap-details.md#BKMK_Heap_State_Reporting_Functions)   
 [_CrtReportBlockType](../vs140/_crtreportblocktype.md)