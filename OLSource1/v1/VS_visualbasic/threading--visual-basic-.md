---
title: "Threading (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: 704bb04b-ff23-471d-ab12-3cec1c2bca59
caps.latest.revision: 4
ms.author: "shoag"
manager: "wpickett"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Threading (Visual Basic)
Threading enables your Visual Basic program to perform concurrent processing so that you can do more than one operation at a time. For example, you can use threading to monitor input from the user, perform background tasks, and handle simultaneous streams of input.  
  
 Threads have the following properties:  
  
-   Threads enable your program to perform concurrent processing.  
  
-   The .NET Framework \<xref:System.Threading> namespace makes using threads easier.  
  
-   Threads share the application's resources. For more information, see [Using Threads and Threading](../Topic/Using%20Threads%20and%20Threading.md).  
  
 By default, a Visual Basic program has one thread. However, auxiliary threads can be created and used to execute code in parallel with the primary thread. These threads are often called *worker threads*.  
  
 Worker threads can be used to perform time-consuming or time-critical tasks without tying up the primary thread. For example, worker threads are often used in server applications to fulfill incoming requests without waiting for the previous request to be completed. Worker threads are also used to perform "background" tasks in desktop applications so that the main thread--which drives user interface elements--remains responsive to user actions.  
  
 Threading solves problems with throughput and responsiveness, but it can also introduce resource-sharing issues such as deadlocks and race conditions. Multiple threads are best for tasks that require different resources such as file handles and network connections. Assigning multiple threads to a single resource is likely to cause synchronization issues, and having threads frequently blocked when waiting for other threads defeats the purpose of using multiple threads.  
  
 A common strategy is to use worker threads to perform time-consuming or time-critical tasks that do not require many of the resources used by other threads. Naturally, some resources in your program must be accessed by multiple threads. For these cases, the \<xref:System.Threading> namespace provides classes for synchronizing threads. These classes include \<xref:System.Threading.Mutex>, \<xref:System.Threading.Monitor>, \<xref:System.Threading.Interlocked>, \<xref:System.Threading.AutoResetEvent>, and \<xref:System.Threading.ManualResetEvent>.  
  
 You can use some or all these classes to synchronize the activities of multiple threads, but some support for threading is supported by the Visual Basic language. For example, the [SyncLock Statement](../VS_visualbasic/synclock-statement.md) provides synchronization features through implicit use of \<xref:System.Threading.Monitor>.  
  
> [!NOTE]
>  Beginning with the [!INCLUDE[net_v40_long](../VS_visualbasic/includes/net_v40_long_md.md)], multithreaded programming is greatly simplified with the \<xref:System.Threading.Tasks.Parallel?displayProperty=fullName> and \<xref:System.Threading.Tasks.Task?displayProperty=fullName> classes, [Parallel LINQ (PLINQ)](../Topic/Parallel%20LINQ%20\(PLINQ\).md), new concurrent collection classes in the \<xref:System.Collections.Concurrent?displayProperty=fullName> namespace, and a new programming model that is based on the concept of tasks rather than threads. For more information, see [Parallel Programming](../Topic/Parallel%20Programming%20in%20the%20.NET%20Framework.md).  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Multithreaded Applications (Visual Basic)](../VS_visualbasic/multithreaded-applications--visual-basic-.md)|Describes how to create and use threads.|  
|[Parameters and Return Values for Multithreaded Procedures (Visual Basic)](../VS_visualbasic/parameters-and-return-values-for-multithreaded-procedures--visual-basic-.md)|Describes how to pass and return parameters with multithreaded applications.|  
|[Walkthrough: Multithreading with the BackgroundWorker Component (Visual Basic)](../VS_visualbasic/walkthrough--multithreading-with-the-backgroundworker-component--visual-basic-.md)|Shows how to create a simple multithreaded application.|  
|[Thread Synchronization (Visual Basic)](../VS_visualbasic/thread-synchronization--visual-basic-.md)|Describes how to control the interactions of threads.|  
|[Thread Timers (Visual Basic)](../VS_visualbasic/thread-timers--visual-basic-.md)|Describes how to run procedures on separate threads at fixed intervals.|  
|[Thread Pooling (Visual Basic)](../VS_visualbasic/thread-pooling--visual-basic-.md)|Describes how to use a pool of worker threads that are managed by the system.|  
|[How to: Use a Thread Pool (Visual Basic)](../VS_visualbasic/how-to--use-a-thread-pool--visual-basic-.md)|Demonstrates synchronized use of multiple threads in the thread pool.|  
|[Threading](../Topic/Managed%20Threading.md)|Describes how to implement threading in the .NET Framework.|