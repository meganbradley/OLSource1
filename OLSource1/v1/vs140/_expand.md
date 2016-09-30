---
title: "_expand"
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
  - "_expand"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_bexpand"
  - "fexpand"
  - "expand"
  - "nexpand"
  - "_fexpand"
  - "_nexpand"
  - "bexpand"
  - "_expand"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "memory blocks, changing size"
  - "_expand function"
  - "expand function"
ms.assetid: 4ac55410-39c8-45c7-bccd-3f1042ae2ed3
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _expand
Changes the size of a memory block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to previously allocated memory block.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 New size in bytes.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns a void pointer to the reallocated memory block. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, unlike <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, cannot move a block to change its size. Thus, if there is sufficient memory available to expand the block without moving it, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is the same as the return value.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> when an error is detected during its operation. For example, if <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is used to shrink a memory block, it might detect corruption in the small block heap or an invalid block pointer and return <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 If there is insufficient memory available to expand the block to the given size without moving it, the function returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> never returns a block expanded to a size less than requested. If a failure occurs, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> indicates the nature of the failure. For more information about <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 The return value points to a storage space that is guaranteed to be suitably aligned for storage of any type of object. To check the new size of the item, use <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. To get a pointer to a type other than <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, use a type cast on the return value.  
  
## Remarks  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> function changes the size of a previously allocated memory block by trying to expand or contract the block without moving its location in the heap. The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> parameter points to the beginning of the block. The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> parameter gives the new size of the block, in bytes. The contents of the block are unchanged up to the shorter of the new and old sizes. <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> should not be a block that has been freed.  
  
> [!NOTE]
>  On 64-bit platforms, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> might not contract the block if the new size is less than the current size; in particular, if the block was less than 16K in size and therefore allocated in the Low Fragmentation Heap, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> leaves the block unchanged and returns <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 When the application is linked with a debug version of the C run-time libraries, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> resolves to [_expand_dbg](../vs140/_expand_dbg.md). For more information about how the heap is managed during the debugging process, see [The CRT Debug Heap](../vs140/crt-debug-heap-details.md).  
  
 This function validates its parameters. If <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is a null pointer, this function invokes an invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and the function returns <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is greater than <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and the function returns <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|\<malloc.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Allocate a 512 element buffer**  
**Allocated 512 bytes at 002C12BC**  
**Expanded block to 1024 bytes at 002C12BC**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Memory Allocation](../vs140/memory-allocation.md)   
 [calloc](../vs140/calloc.md)   
 [free](../vs140/free.md)   
 [malloc](../vs140/malloc.md)   
 [_msize](../vs140/_msize.md)   
 [realloc](../vs140/realloc.md)