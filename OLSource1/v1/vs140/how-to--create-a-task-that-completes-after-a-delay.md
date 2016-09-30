---
title: "How to: Create a Task that Completes After a Delay"
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
  - "task_completion_event class, example"
  - "create a task that completes after a delay, example [C++]"
ms.assetid: 3fc0a194-3fdb-4eba-8b8a-b890981a985d
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create a Task that Completes After a Delay
This example shows how to use the [concurrency::task](../vs140/task-class--concurrency-runtime-.md), [concurrency::cancellation_token_source](../vs140/cancellation_token_source-class.md), [concurrency::cancellation_token](../vs140/cancellation_token-class.md), [concurrency::task_completion_event](../vs140/task_completion_event-class.md), [concurrency::timer](../vs140/timer-class.md), and [concurrency::call](../vs140/call-class.md) classes to create a task that completes after a delay. You can use this method to build loops that occasionally poll for data, introduce timeouts, delay handling of user input for a predetermined time, and so on.  
  
## Example  
 The following example shows the `complete_after` and `cancel_after_timeout` functions. The `complete_after` function creates a `task` object that completes after the specified delay. It uses a `timer` object and a `call` object to set a `task_completion_event` object after the specified delay. By using the `task_completion_event` class, you can define a task that completes after a thread or another task signals that a value is available. When the event is set, listener tasks complete and their continuations are scheduled to run.  
  
> [!TIP]
>  For more information about the `timer` and `call` classes, which are part of the Asynchronous Agents Library, see [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md).  
  
 The `cancel_after_timeout` function builds on the `complete_after` function to cancel a task if that task does not complete before a given timeout. The `cancel_after_timeout` function creates two tasks. The first task indicates success and completes after the provided task completes; the second task indicates failure and completes after the specified timeout. The `cancel_after_timeout` function creates a continuation task that runs when the success or failure task completes. If the failure task completes first, the continuation cancels the token source to cancel the overall task.  
  
 [!code[concrt-task-delay#1](../vs140/codesnippet/CPP/how-to--create-a-task-that-completes-after-a-delay_1.cpp)]  
  
## Example  
 The following example computes the count of prime numbers in the range [0, 100000] multiple times. The operation fails if it does not complete in a given time limit. The `count_primes` function demonstrates how to use the `cancel_after_timeout` function. It counts the number of primes in the given range and fails if the task does not complete in the provided time. The `wmain` function calls the `count_primes` function multiple times. Each time, it halves the time limit. The program finishes after the operation does not complete in the current time limit.  
  
 [!code[concrt-task-delay#2](../vs140/codesnippet/CPP/how-to--create-a-task-that-completes-after-a-delay_2.cpp)]  
  
 When you use this technique to cancel tasks after a delay, any unstarted tasks will not start after the overall task is canceled. However, it is important for any long-running tasks to respond to cancellation in a timely manner. In this example, the `count_primes` method calls the [concurrency::is_task_cancellation_requested](../vs140/is_task_cancellation_requested-function.md) and `cancel_current_task` functions to respond to cancellation. (Alternatively, you can call the [concurrency::interruption_point](../vs140/interruption_point-function.md) function). For more information about task cancellation, see [Cancellation in the PPL](../vs140/cancellation-in-the-ppl.md).  
  
## Example  
 Here is the complete code for this example:  
  
 [!code[concrt-task-delay#3](../vs140/codesnippet/CPP/how-to--create-a-task-that-completes-after-a-delay_3.cpp)]  
  
## Compiling the Code  
 To compile the code, copy it and then paste it in a Visual Studio project, or paste it in a file that is named `task-delay.cpp` and then run the following command in a Visual Studio Command Prompt window.  
  
 **cl.exe /EHsc task-delay.cpp**  
  
## See Also  
 [Task Parallelism (Concurrency Runtime)](../vs140/task-parallelism--concurrency-runtime-.md)   
 [task Class](../vs140/task-class--concurrency-runtime-.md)   
 [cancellation_token_source Class](../vs140/cancellation_token_source-class.md)   
 [cancellation_token Class](../vs140/cancellation_token-class.md)   
 [task_completion_event Class](../vs140/task_completion_event-class.md)   
 [is_task_cancellation_requested Function](../vs140/is_task_cancellation_requested-function.md)   
 [cancel_current_task Function](../vs140/cancel_current_task-function.md)   
 [interruption_point Function](../vs140/interruption_point-function.md)   
 [timer Class](../vs140/timer-class.md)   
 [call Class](../vs140/call-class.md)   
 [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md)   
 [Cancellation in the PPL](../vs140/cancellation-in-the-ppl.md)