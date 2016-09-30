---
title: "How to: Use parallel_invoke to Write a Parallel Sort Routine"
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
  - "task_handle class, example"
  - "task_group class, example"
  - "make_task function, example"
  - "structured_task_group class, example"
  - "improving parallel performance with task groups [Concurrency Runtime]"
ms.assetid: 53979a2a-525d-4437-8952-f1ff85b37673
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use parallel_invoke to Write a Parallel Sort Routine
This document describes how to use the [parallel_invoke](../vs140/parallel_invoke-function.md) algorithm to improve the performance of the bitonic sort algorithm. The bitonic sort algorithm recursively divides the input sequence into smaller sorted partitions. The bitonic sort algorithm can run in parallel because each partition operation is independent of all other operations.  
  
 Although the bitonic sort is an example of a *sorting network* that sorts all combinations of input sequences, this example sorts sequences whose lengths are a power of two.  
  
> [!NOTE]
>  This example uses a parallel sort routine for illustration. You can also use the built-in sorting algorithms that the PPL provides: [concurrency::parallel_sort](../vs140/parallel_sort-function.md), [concurrency::parallel_buffered_sort](../vs140/parallel_buffered_sort-function.md), and [concurrency::parallel_radixsort](../vs140/parallel_radixsort-function.md). For more information, see [Parallel Algorithms](../vs140/parallel-algorithms.md).  
  
##  \<a name="top">\</a> Sections  
 This document describes the following tasks:  
  
-   [Performing Bitonic Sort Serially](#serial)  
  
-   [Using parallel_invoke to Perform Bitonic Sort in Parallel](#parallel)  
  
##  \<a name="serial">\</a> Performing Bitonic Sort Serially  
 The following example shows the serial version of the bitonic sort algorithm. The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> function divides the sequence into two partitions, sorts those partitions in opposite directions, and then merges the results. This function calls itself two times recursively to sort each partition.  
  
 [!code[concrt-parallel-bitonic-sort#1](../vs140/codesnippet/CPP/how-to--use-parallel_invoke-to-write-a-parallel-sort-routine_1.cpp)]  
  
 [[Top](#top)]  
  
##  \<a name="parallel">\</a> Using parallel_invoke to Perform Bitonic Sort in Parallel  
 This section describes how to use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> algorithm to perform the bitonic sort algorithm in parallel.  
  
### Procedures  
  
##### To perform the bitonic sort algorithm in parallel  
  
1.  Add a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> directive for the header file ppl.h.  
  
     [!code[concrt-parallel-bitonic-sort#10](../vs140/codesnippet/CPP/how-to--use-parallel_invoke-to-write-a-parallel-sort-routine_2.cpp)]  
  
2.  Add a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> directive for the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> namespace.  
  
     [!code[concrt-parallel-bitonic-sort#11](../vs140/codesnippet/CPP/how-to--use-parallel_invoke-to-write-a-parallel-sort-routine_3.cpp)]  
  
3.  Create a new function, called <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, which uses the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> algorithm to merge the sequences in parallel if there is sufficient amount of work to do. Otherwise, call <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to merge the sequences serially.  
  
     [!code[concrt-parallel-bitonic-sort#2](../vs140/codesnippet/CPP/how-to--use-parallel_invoke-to-write-a-parallel-sort-routine_4.cpp)]  
  
4.  Perform a process that resembles the one in the previous step, but for the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function.  
  
     [!code[concrt-parallel-bitonic-sort#3](../vs140/codesnippet/CPP/how-to--use-parallel_invoke-to-write-a-parallel-sort-routine_5.cpp)]  
  
5.  Create an overloaded version of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function that sorts the array in increasing order.  
  
     [!code[concrt-parallel-bitonic-sort#4](../vs140/codesnippet/CPP/how-to--use-parallel_invoke-to-write-a-parallel-sort-routine_6.cpp)]  
  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> algorithm reduces overhead by performing the last of the series of tasks on the calling context. For example, in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function, the first task runs on a separate context, and the second task runs on the calling context.  
  
 [!code[concrt-parallel-bitonic-sort#5](../vs140/codesnippet/CPP/how-to--use-parallel_invoke-to-write-a-parallel-sort-routine_7.cpp)]  
  
 The following complete example performs both the serial and the parallel versions of the bitonic sort algorithm. The example also prints to the console the time that is required to perform each computation.  
  
 [!code[concrt-parallel-bitonic-sort#8](../vs140/codesnippet/CPP/how-to--use-parallel_invoke-to-write-a-parallel-sort-routine_8.cpp)]  
  
 The following sample output is for a computer that has four processors.  
  
 **serial time: 4353**  
**parallel time: 1248** [[Top](#top)]  
  
## Compiling the Code  
 To compile the code, copy it and then paste it in a Visual Studio project, or paste it in a file that is named <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and then run the following command in a Visual Studio Command Prompt window.  
  
 **cl.exe /EHsc parallel-bitonic-sort.cpp**  
  
## Robust Programming  
 This example uses the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> algorithm instead of the [concurrency::task_group](../vs140/task_group-class.md) class because the lifetime of each task group does not extend beyond a function. We recommend that you use <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> when you can because it has less execution overhead than <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> objects, and therefore lets you write better performing code.  
  
 The parallel versions of some algorithms perform better only when there is sufficient work to do. For example, the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> function calls the serial version, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, if there are 500 or fewer elements in the sequence. You can also plan your overall sorting strategy based on the amount of work. For example, it might be more efficient to use the serial version of the quick sort algorithm if the array contains fewer than 500 items, as shown in the following example:  
  
 [!code[concrt-parallel-bitonic-sort#9](../vs140/codesnippet/CPP/how-to--use-parallel_invoke-to-write-a-parallel-sort-routine_9.cpp)]  
  
 As with any parallel algorithm, we recommend that you profile and tune your code as appropriate.  
  
## See Also  
 [Task Parallelism](../vs140/task-parallelism--concurrency-runtime-.md)   
 [parallel_invoke Function](../vs140/parallel_invoke-function.md)