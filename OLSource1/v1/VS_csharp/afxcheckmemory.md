---
title: "AfxCheckMemory"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AfxCheckMemory"
  - "AFX/AfxCheckMemory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxCheckMemory function"
  - "AfxCheckMemory"
ms.assetid: 4644da71-7d14-41dc-adc0-ee9558fd7a28
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxCheckMemory
This function validates the free memory pool and prints error messages as required.  
  
## Syntax  
  
```  
  
BOOL AfxCheckMemory( );  
```  
  
## Return Value  
 Nonzero if no memory errors; otherwise 0.  
  
## Remarks  
 If the function detects no memory corruption, it prints nothing.  
  
 All memory blocks currently allocated on the heap are checked, including those allocated by **new** but not those allocated by direct calls to underlying memory allocators, such as the `malloc` function or the **GlobalAlloc** Windows function. If any block is found to be corrupted, a message is printed to the debugger output.  
  
 If you include the line  
  
 [!code[NVC_MFCCObjectSample#14](../VS_csharp/codesnippet/CPP/afxcheckmemory_1.cpp)]  
  
 in a program module, then subsequent calls to `AfxCheckMemory` show the filename and line number where the memory was allocated.  
  
> [!NOTE]
>  If your module contains one or more implementations of serializable classes, then you must put the `#define` line after the last `IMPLEMENT_SERIAL` macro call.  
  
 This function works only in the Debug version of MFC.  
  
## Example  
 [!code[NVC_MFCCObjectSample#26](../VS_csharp/codesnippet/CPP/afxcheckmemory_2.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)