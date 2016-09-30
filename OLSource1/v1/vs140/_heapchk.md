---
title: "_heapchk"
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
  - "_heapchk"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_heapchk"
  - "heapchk"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "debugging [CRT], heap-related problems"
  - "consistency checking of heaps"
  - "heapchk function"
  - "heaps, checking consistency"
  - "_heapchk function"
ms.assetid: 859619a5-1e35-4f02-9e09-11d9fa266ec0
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _heapchk
Runs consistency checks on the heap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> returns one of the following integer manifest constants defined in Malloc.h.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Initial header information is bad or cannot be found.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Bad node has been found or heap is damaged.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer into heap is not valid.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Heap has not been initialized.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Heap appears to be consistent.  
  
 In addition, if an error occurs, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> sets <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function helps debug heap-related problems by checking for minimal consistency of the heap. If the operating system does not support <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>(for example, Windows 98), the function returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|\<malloc.h>|\<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **OK - heap is fine**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)   
 [_heapadd](../vs140/_heapadd.md)   
 [_heapmin](../vs140/_heapmin.md)   
 [_heapset](../vs140/_heapset.md)   
 [_heapwalk](../vs140/_heapwalk.md)