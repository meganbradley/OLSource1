---
title: "How to: Use Exception Handling to Break from a Parallel Loop"
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
  - "search algorithm, writing [Concurrency Runtime]"
  - "writing a search algorithm [Concurrency Runtime]"
ms.assetid: 16d7278c-2d10-4014-9f58-f1899e719ff9
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use Exception Handling to Break from a Parallel Loop
This topic shows how to write a search algorithm for a basic tree structure.  
  
 The topic [Cancellation in the PPL](../vs140/cancellation-in-the-ppl.md) explains the role of cancellation in the Parallel Patterns Library. The use of exception handling is a less efficient way to cancel parallel work than the use of the [concurrency::task_group::cancel](../vs140/task_group--cancel-method.md) and [concurrency::structured_task_group::cancel](../vs140/structured_task_group--cancel-method.md) methods. However, one scenario where the use of exception handling to cancel work is appropriate is when you call into a third-party library that uses tasks or parallel algorithms but does not provide a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object to cancel.  
  
## Example  
 The following example shows a basic <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> type that contains a data element and a list of child nodes. The following section shows the body of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method, which recursively performs a work function on each child node.  
  
 [!code[concrt-task-tree-search#2](../vs140/codesnippet/CPP/how-to--use-exception-handling-to-break-from-a-parallel-loop_1.cpp)]  
  
## Example  
 The following example shows the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method. It uses the [concurrency::parallel_for_each](../vs140/parallel_for_each-function.md) algorithm to perform a work function on each node of the tree in parallel.  
  
 [!code[concrt-task-tree-search#1](../vs140/codesnippet/CPP/how-to--use-exception-handling-to-break-from-a-parallel-loop_2.cpp)]  
  
## Example  
 The following example shows the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function, which searches for a value in the provided <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object. This function passes to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method a work function that throws when it finds a tree node that contains the provided value.  
  
 Assume that the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class is provided by a third-party library, and that you cannot modify it. In this case, the use of exception handling is appropriate because the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method does not provide a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object to the caller. Therefore, the work function is unable to directly cancel its parent task group.  
  
 When the work function that you provide to a task group throws an exception, the runtime stops all tasks that are in the task group (including any child task groups) and discards any tasks that have not yet started. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function uses a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>-<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> block to capture the exception and print the result to the console.  
  
 [!code[concrt-task-tree-search#3](../vs140/codesnippet/CPP/how-to--use-exception-handling-to-break-from-a-parallel-loop_3.cpp)]  
  
## Example  
 The following example creates a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object and searches it for several values in parallel. The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> function is shown later in this topic.  
  
 [!code[concrt-task-tree-search#4](../vs140/codesnippet/CPP/how-to--use-exception-handling-to-break-from-a-parallel-loop_4.cpp)]  
  
 This example uses the [concurrency::parallel_invoke](../vs140/parallel_invoke-function.md) algorithm to search for values in parallel. For more information about this algorithm, see [Parallel Algorithms](../vs140/parallel-algorithms.md).  
  
## Example  
 The following complete example uses exception handling to search for values in a basic tree structure.  
  
 [!code[concrt-task-tree-search#5](../vs140/codesnippet/CPP/how-to--use-exception-handling-to-break-from-a-parallel-loop_5.cpp)]  
  
 This example produces the following sample output.  
  
 **Found a node with value 32614.**  
**Found a node with value 86131.**  
**Did not find node with value 17522.**   
## Compiling the Code  
 Copy the example code and paste it in a Visual Studio project, or paste it in a file that is named <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and then run the following command in a Visual Studio Command Prompt window.  
  
 **cl.exe /EHsc task-tree-search.cpp**  
  
## See Also  
 [Cancellation in the PPL](../vs140/cancellation-in-the-ppl.md)   
 [Exception Handling in the Concurrency Runtime](../vs140/exception-handling-in-the-concurrency-runtime.md)   
 [Task Parallelism](../vs140/task-parallelism--concurrency-runtime-.md)   
 [Parallel Algorithms](../vs140/parallel-algorithms.md)   
 [task_group Class](../vs140/task_group-class.md)   
 [structured_task_group Class](../vs140/structured_task_group-class.md)   
 [parallel_for_each Function](../vs140/parallel_for_each-function.md)