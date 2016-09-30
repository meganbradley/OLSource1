---
title: "Memory Management Functions"
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
  - "memory management functions [Concurrency Runtime]"
ms.assetid: d303dd2a-dfa4-4d90-a508-f6aa290bb9ea
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Memory Management Functions
This document describes the memory management functions that the Concurrency Runtime provides to help you allocate and free memory in a concurrent manner.  
  
> [!TIP]
>  The Concurrency Runtime provides a default scheduler, and therefore you are not required to create one in your application. Because the Task Scheduler helps you fine-tune the performance of your applications, we recommend that you start with the [Parallel Patterns Library (PPL)](../vs140/parallel-patterns-library--ppl-.md) or the [Asynchronous Agents Library](../vs140/asynchronous-agents-library.md) if you are new to the Concurrency Runtime.  
  
 The Concurrency Runtime provides two memory management functions that are optimized for allocating and freeing blocks of memory in a concurrent manner. The [concurrency::Alloc](../vs140/alloc-function.md) function allocates a block of memory by using the specified size. The [concurrency::Free](../vs140/free-function.md) function frees the memory that was allocated by <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> functions rely on each other. Use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function only to release memory that you allocate by using the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function. Also, when you use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function to allocate memory, use only the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function to release that memory.  
  
 Use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> functions when you allocate and free a fixed set of allocation sizes from different threads or tasks. The Concurrency Runtime caches memory that it allocates from the C Runtime heap. The Concurrency Runtime holds a separate memory cache for each running thread; therefore, the runtime manages memory without the use of locks or memory barriers. An application benefits more from the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> functions when the memory cache is accessed more frequently. For example, a thread that frequently calls both <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> benefits more than a thread that primarily calls <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  When you use these memory management functions, and your application uses lots of memory, the application may enter a low-memory condition sooner than you expect. Because the memory blocks that are cached by one thread are not available to any other thread, if one thread holds lots of memory, that memory is not available.  
  
## Example  
 For an example that uses the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> functions to improve memory performance, see [How-to: Use Alloc and Free to Improve Memory Performance](../vs140/how-to--use-alloc-and-free-to-improve-memory-performance.md).  
  
## See Also  
 [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md)   
 [How-to: Use Alloc and Free to Improve Memory Performance](../vs140/how-to--use-alloc-and-free-to-improve-memory-performance.md)