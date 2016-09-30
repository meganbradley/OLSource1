---
title: "_heapset"
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
  - "_heapset"
apilocation: 
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_heapset"
  - "heapset"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "checking heap"
  - "heapset function"
  - "heaps, checking"
  - "debugging [CRT], heap-related problems"
  - "_heapset function"
ms.assetid: 9667eeb0-55bc-4c19-af5f-d1fd0a142b3c
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _heapset
Checks heaps for minimal consistency and sets the free entries to a specified value.  
  
> [!IMPORTANT]
>  This function is obsolete. Beginning in Visual Studio 2015, it is not available in the CRT.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Fill character.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns one of the following integer manifest constants defined in Malloc.h.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Initial header information invalid or not found.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Heap damaged or bad node found.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Heap not initialized.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Heap appears to be consistent.  
  
 In addition, if an error occurs, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> sets <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function shows free memory locations or nodes that have been unintentionally overwritten.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> checks for minimal consistency on the heap and then sets each byte of the heap's free entries to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> value. This known value shows which memory locations of the heap contain free nodes and which contain data that were unintentionally written to freed memory. If the operating system does not support <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>(for example, Windows 98), the function returns <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|\<malloc.h>|\<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **OK - heap is fine**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)   
 [_heapadd](../vs140/_heapadd.md)   
 [_heapchk](../vs140/_heapchk.md)   
 [_heapmin](../vs140/_heapmin.md)   
 [_heapwalk](../vs140/_heapwalk.md)