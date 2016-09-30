---
title: "_CrtMemCheckpoint"
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
  - "_CrtMemCheckpoint"
apilocation: 
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcrd.dll"
  - "msvcr100.dll"
  - "ucrtbased.dll"
apitype: "DLLExport"
f1_keywords: 
  - "CrtMemCheckpoint"
  - "_CrtMemCheckpoint"
  - "crtdbg/_CrtMemCheckpoint"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "CrtMemCheckpoint function"
  - "_CrtMemCheckpoint function"
ms.assetid: f1bacbaa-5a0c-498a-ac7a-b6131d83dfbc
caps.latest.revision: 22
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _CrtMemCheckpoint
Obtains the current state of the debug heap and stores in an application-supplied <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure (debug version only).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure to fill with the memory checkpoint.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function creates a snapshot of the current state of the debug heap at any given moment. This snapshot can be used by other heap state functions such as [_CrtMemDifference](../vs140/_crtmemdifference.md) to help detect memory leaks and other problems. When [_DEBUG](../vs140/_debug.md) is not defined, calls to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> are removed during preprocessing.  
  
 The application must pass a pointer to a previously allocated instance of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure, defined in Crtdbg.h, in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> encounters an error during the checkpoint creation, the function generates a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> debug report describing the problem.  
  
 For more information about heap state functions and the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> structure, see [Heap State Reporting Functions](../vs140/crt-debug-heap-details.md#BKMK_Heap_State_Reporting_Functions). For more information about how memory blocks are allocated, initialized, and managed in the debug version of the base heap, see [CRT Debug Heap Details](../vs140/crt-debug-heap-details.md).  
  
 If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) is set to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and the function returns.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|\<crtdbg.h>, \<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
 **Libraries:** Debug versions of the UCRT only.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)   
 [_CrtMemDifference](../vs140/_crtmemdifference.md)