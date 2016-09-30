---
title: "Debug Multithreaded Applications in Visual Studio"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.debug.gputthreads"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "threading [Visual Studio], debugging"
  - "debugging [Visual Studio], high-performance computing"
  - "debugging [Visual Studio], multithreaded"
  - "multithreaded debugging"
  - "high-performance debugging"
ms.assetid: 9d175bc2-1d95-4c47-9bc3-9755af968a9c
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Debug Multithreaded Applications in Visual Studio
A thread is a sequence of instructions to which the operating system allocates processor time. Every process that is running in the operating system consists of at least one thread. Processes that have more than one thread are called multithreaded.  
  
 Computers with multiple processors, multi-core processors, or hyperthreading processes can run multiple threads at the same time. Parallel processing of multiple threads can greatly improve program performance, but it can also make debugging more difficult because it introduces the need to keep track of multiple threads.  
  
 In addition, multithreading introduces some new types of potential bugs. Often, for example, two or more threads have to access the same resource, but only one thread can safely access the resource at a time. Some form of mutual exclusion is necessary to make sure that only one thread is accessing the resource at a time. If mutual exclusion is performed incorrectly, it can create a *deadlock* condition where no thread can execute. Deadlocks can be a particularly hard problem to debug.  
  
 Visual Studio provides a **Threads** window, a GPU Threads window, a Parallel Watch window, and other features that make multithreaded debugging easier. The best way to learn about the threading features is by doing the walkthroughs. See [Walkthrough: Debugging a Multithreaded Application](../vs140/walkthrough--debugging-a-multithreaded-application.md) and [Walkthrough: Debugging a C++ AMP Application](../vs140/walkthrough--debugging-a-c---amp-application.md).  
  
 Visual Studio also provides powerful breakpoints and tracepoints, which can be very useful when you debug multithreaded applications. You can use breakpoint filters to place breakpoints on individual threads. See [Breakpoints: Use Hit Counts, Call Stack Functions, and Conditions to Break When and Where You Want in the Visual Studio Debugger](../vs140/using-breakpoints.md)  
  
 Debugging a multithreaded application that has a user interface can be especially difficult. In that case, you might consider running the application on a second computer and using remote debugging. For information, see [Remote Debugging Setup](../vs140/remote-debugging.md).  
  
## In This Section  
 [Debug Threads and Processes](../vs140/debug-threads-and-processes.md)  
 Explains the basics of debugging threads and processes.  
  
 [Debug Multiple Processes](../vs140/debug-multiple-processes.md)  
 Explains how to debug multiple processes.  
  
 [How to: Use the Threads Window](../vs140/how-to--use-the-threads-window.md)  
 Useful procedures for debugging threads with the **Threads** window.  
  
 [How to: Switch to Another Thread While Debugging](../vs140/how-to--switch-to-another-thread-while-debugging.md)  
 Three ways to switch the debugging context to another thread.  
  
 [How to: Flag and Unflag Threads](../vs140/how-to--flag-and-unflag-threads.md)  
 Mark or flag threads that you want to give special attention to while debugging.  
  
 [How to: Set a Thread Name in Native Code](../vs140/how-to--set-a-thread-name-in-native-code.md)  
 Give your thread a name that you view in the **Threads** window.  
  
 [How to: Set a Thread Name in Managed Code](../vs140/how-to--set-a-thread-name-in-managed-code.md)  
 Give your thread a name that you view in the **Threads** window.  
  
 [Walkthrough: Debugging a Multithreaded Application](../vs140/walkthrough--debugging-a-multithreaded-application.md).  
 A guided tour of thread debugging features, with emphasis on features how to [!INCLUDE[vs_orcas_long](../vs140/includes/vs_orcas_long_md.md)].  
  
 [How to: Debug On a High-Performance Cluster](../vs140/how-to--debug-on-a-high-performance-cluster.md)  
 Techniques for debugging an application that runs on a high-performance cluster.  
  
 [Tips for Debugging Threads in Native Code](../vs140/tips-for-debugging-threads-in-native-code.md)  
 Simple techniques that can be useful for debugging native threads.  
  
 [Using the Parallel Tasks Window](../vs140/using-the-tasks-window.md)  
 Shows a list of all the managed or native task objects including their status and other useful info.  
  
 [Using the Parallel Stacks Window](../vs140/using-the-parallel-stacks-window.md)  
 Shows call stacks of multiple threads (or tasks) in a single view and it also coalesces stack segments that are common amongst the threads (or tasks).  
  
 [Walkthrough: Debugging a Parallel Application](../vs140/walkthrough--debugging-a-parallel-application.md)  
 Walkthrough that shows how to use the Parallel Tasks and Parallel Stacks windows.  
  
 [How to: Use the Parallel Watch Window](../vs140/how-to--use-the-parallel-watch-window.md)  
 Inspect values and expressions across multiple threads.  
  
 [How to: Use the GPU Threads Window](../vs140/how-to--use-the-gpu-threads-window.md)  
 Examine and work with threads that are running on the GPU during debugging.  
  
## Related Sections  
 [Breakpoints: Use Hit Counts, Call Stack Functions, and Conditions to Break When and Where You Want in the Visual Studio Debugger](../vs140/using-breakpoints.md)  
 -   Use breakpoint filters when you want to place a breakpoint on an individual thread.  
  
-   Tracepoints enable you to trace execution of your program without breaking. This can be useful for studying problems such as deadlocks.  
  
 [Managed Threading](assetId:///7b46a7d9-c6f1-46d1-a947-ae97471bba87)  
 Threading concepts in [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] programming, including example code.  
  
 [Multithreading in Components](assetId:///2fc31e68-fb71-4544-b654-0ce720478779)  
 How to use multithreading in [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] components.  
  
 [Multithreading](../vs140/multithreading-support-for-older-code--visual-c---.md)  
 Threading concepts and example code for C++ programmers using MFC.  
  
## See Also  
 [Working with Threads and Processes](../vs140/debug-threads-and-processes.md)   
 [Remote Debugging Setup](../vs140/remote-debugging.md)