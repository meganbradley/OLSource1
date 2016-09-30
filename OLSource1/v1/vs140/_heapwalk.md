---
title: "_heapwalk"
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
  - "_heapwalk"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "heapwalk"
  - "_heapwalk"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "debugging [CRT], heap-related problems"
  - "heapwalk function"
  - "_heapwalk function"
ms.assetid: 2df67649-fb00-4570-a8b1-a4eca5738744
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _heapwalk
Traverses the heap and returns information about the next entry.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime except in Debug builds. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Buffer to contain heap information.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns one of the following integer manifest constants defined in Malloc.h.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Initial header information invalid or not found.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Heap damaged or bad node found.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> structure does not contain a valid pointer into the heap or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is a null pointer.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 End of the heap reached successfully.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Heap not initialized.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 No errors so far; <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is updated with information about the next heap entry.  
  
 In addition, if an error occurs, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> sets <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function helps debug heap-related problems in programs. The function walks through the heap, traversing one entry per call, and returns a pointer to a structure of type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> that contains information about the next heap entry. The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> type, defined in Malloc.h, contains the following elements.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Heap entry pointer.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Size of the heap entry.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Flag that indicates whether the heap entry is in use.  
  
 A call to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> that returns <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> stores the size of the entry in the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> field and sets the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> field to either <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> (both are constants defined in Malloc.h). To obtain this information about the first entry in the heap, pass <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> a pointer to a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> structure whose <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> member is <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. If the operating system does not support <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>(for example, Windows 98), the function returns <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
 This function validates its parameter. If <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is a null pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and the function returns <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|\<malloc.h>|\<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **USED block at 00310650 of size 0100**  
 **USED block at 00310758 of size 0800**  
 **USED block at 00310F60 of size 0080**  
 **FREE block at 00310FF0 of size 0398**  
 **USED block at 00311390 of size 000D**  
 **USED block at 003113A8 of size 00B4**  
 **USED block at 00311468 of size 0034**  
 **USED block at 003114A8 of size 0039**  
**...**  
 **USED block at 00312228 of size 0010**  
 **USED block at 00312240 of size 1000**  
 **FREE block at 00313250 of size 1DB0**  
**OK - end of heap**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)   
 [_heapadd](../vs140/_heapadd.md)   
 [_heapchk](../vs140/_heapchk.md)   
 [_heapmin](../vs140/_heapmin.md)   
 [_heapset](../vs140/_heapset.md)