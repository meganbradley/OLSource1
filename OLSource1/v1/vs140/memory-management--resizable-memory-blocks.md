---
title: "Memory Management: Resizable Memory Blocks"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "memory blocks, resizable"
  - "memory, corruption"
  - "memory allocation, memory block size"
  - "memory blocks, allocating"
  - "blocks, memory allocation"
  - "resizable memory blocks"
ms.assetid: f0efe6f4-a3ed-4541-9195-51ec1291967a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Memory Management: Resizable Memory Blocks
The **new** and **delete** operators, described in the article [Memory Management: Examples](../vs140/memory-management--examples.md), are good for allocating and deallocating fixed-size memory blocks and objects. Occasionally, your application may need resizable memory blocks. You must use the standard C run-time library functions [malloc](../vs140/malloc.md), [realloc](../vs140/realloc.md), and [free](../vs140/free.md) to manage resizable memory blocks on the heap.  
  
> [!IMPORTANT]
>  Mixing the **new** and **delete** operators with the resizable memory-allocation functions on the same memory block will result in corrupted memory in the Debug version of MFC. You should not use <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> on a memory block allocated with **new**. Likewise, you should not allocate a memory block with the **new** operator and delete it with **free**, or use the **delete** operator on a block of memory allocated with <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## See Also  
 [Memory Management: Heap Allocation](../vs140/memory-management--heap-allocation.md)