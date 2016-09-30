---
title: "Thread Synchronization (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: 04f485d1-8333-4510-9e72-c334e7427e7e
caps.latest.revision: 7
---
# Thread Synchronization (Visual Basic)
The following sections describe features and classes that can be used to synchronize access to resources in multithreaded applications.  
  
 One of the benefits of using multiple threads in an application is that each thread executes asynchronously. For Windows applications, this allows time-consuming tasks to be performed in the background while the application window and controls remain responsive. For server applications, multithreading provides the ability to handle each incoming request with a different thread. Otherwise, each new request would not get serviced until the previous request had been fully satisfied.  
  
 However, the asynchronous nature of threads means that access to resources such as file handles, network connections, and memory must be coordinated. Otherwise, two or more threads could access the same resource at the same time, each unaware of the other's actions. The result is unpredictable data corruption.  
  
 For simple operations on integral numeric data types, synchronizing threads can be accomplished with members of the \<xref:System.Threading.Interlocked*> class. For all other data types and non thread-safe resources, multithreading can only be safely performed using the constructs in this topic.  
  
 For background information on multithreaded programming, see:  
  
-   [Managed Threading Basics](assetId:///b2944911-0e8f-427d-a8bb-077550618935)  
  
-   [Using Threads and Threading](assetId:///9b5ec2cd-121b-4d49-b075-222cf26f2344)  
  
-   [Managed Threading Best Practices](assetId:///e51988e7-7f4b-4646-a06d-1416cee8d557)  
  
## The lock and SyncLock Keywords  
 The Visual Basic <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement can be used to ensure that a block of code runs to completion without interruption by other threads. This is accomplished by obtaining a mutual-exclusion lock for a given object for the duration of the code block.  
  
 A <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement is given an object as an argument, and is followed by a code block that is to be executed by only one thread at a time. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The argument provided to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword must be an object based on a reference type, and is used to define the scope of the lock. In the example above, the lock scope is limited to this function because no references to the object <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> exist outside the function. If such a reference did exist, lock scope would extend to that object. Strictly speaking, the object provided is used solely to uniquely identify the resource being shared among multiple threads, so it can be an arbitrary class instance. In practice, however, this object usually represents the resource for which thread synchronization is necessary. For example, if a container object is to be used by multiple threads, then the container can be passed to lock, and the synchronized code block following the lock would access the container. As long as other threads locks on the same contain before accessing it, then access to the object is safely synchronized.  
  
 Generally, it is best to avoid locking on a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> type, or on object instances beyond the control of your application. For example, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> can be problematic if the instance can be accessed publicly, because code beyond your control may lock on the object as well. This could create deadlock situations where two or more threads wait for the release of the same object. Locking on a public data type, as opposed to an object, can cause problems for the same reason. Locking on literal strings is especially risky because literal strings are *interned* by the common language runtime (CLR). This means that there is one instance of any given string literal for the entire program, the exact same object represents the literal in all running application domains, on all threads. As a result, a lock placed on a string with the same contents anywhere in the application process locks all instances of that string in the application. As a result, it is best to lock a private or protected member that is not interned. Some classes provide members specifically for locking. The \<xref:System.Array*> type, for example, provides \<xref:System.Array.SyncRoot*>. Many collection types provide a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> member as well.  
  
 For more information about the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement, see the following topics:  
  
-   [SyncLock Statement](../vs140/synclock-statement.md)  
  
-   [Monitors](assetId:///33fe4aef-b44b-42fd-9e72-c908e39e75db)  
  
## Monitors  
 Like the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> keyword, monitors prevent blocks of code from simultaneous execution by multiple threads. The \<xref:System.Threading.Monitor.Enter*> method allows one and only one thread to proceed into the following statements; all other threads are blocked until the executing thread calls \<xref:System.Threading.Monitor.Exit*>. This is just like using the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> keyword. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This is equivalent to:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Using the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> keyword is generally preferred over using the \<xref:System.Threading.Monitor*> class directly, both because <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is more concise, and because <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> insures that the underlying monitor is released, even if the protected code throws an exception. This is accomplished with the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> keyword, which executes its associated code block regardless of whether an exception is thrown.  
  
## Synchronization Events and Wait Handles  
 Using a lock or monitor is useful for preventing the simultaneous execution of thread-sensitive blocks of code, but these constructs do not allow one thread to communicate an event to another. This requires *synchronization events*, which are objects that have one of two states, signaled and un-signaled, that can be used to activate and suspend threads. Threads can be suspended by being made to wait on a synchronization event that is unsignaled, and can be activated by changing the event state to signaled. If a thread attempts to wait on an event that is already signaled, then the thread continues to execute without delay.  
  
 There are two kinds of synchronization events: \<xref:System.Threading.AutoResetEvent*>, and \<xref:System.Threading.ManualResetEvent*>. They differ only in that \<xref:System.Threading.AutoResetEvent*> changes from signaled to unsignaled automatically any time it activates a thread. Conversely, a \<xref:System.Threading.ManualResetEvent*> allows any number of threads to be activated by its signaled state, and will only revert to an unsignaled state when its \<xref:System.Threading.EventWaitHandle.Reset*> method is called.  
  
 Threads can be made to wait on events by calling one of the wait methods, such as \<xref:System.Threading.WaitHandle.WaitOne*>, \<xref:System.Threading.WaitHandle.WaitAny*>, or \<xref:System.Threading.WaitHandle.WaitAll*>. \<xref:System.Threading.WaitHandle.WaitOne*?displayProperty=fullName> causes the thread to wait until a single event becomes signaled, \<xref:System.Threading.WaitHandle.WaitAny*?displayProperty=fullName> blocks a thread until one or more indicated events become signaled, and \<xref:System.Threading.WaitHandle.WaitAll*?displayProperty=fullName> blocks the thread until all of the indicated events become signaled. An event becomes signaled when its \<xref:System.Threading.EventWaitHandle.Set*> method is called.  
  
 In the following example, a thread is created and started by the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> function. The new thread waits on an event using the \<xref:System.Threading.WaitHandle.WaitOne*> method. The thread is suspended until the event becomes signaled by the primary thread that is executing the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> function. Once the event becomes signaled, the auxiliary thread returns. In this case, because the event is only used for one thread activation, either the \<xref:System.Threading.AutoResetEvent*> or \<xref:System.Threading.ManualResetEvent*> classes could be used.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Mutex Object  
 A *mutex* is similar to a monitor; it prevents the simultaneous execution of a block of code by more than one thread at a time. In fact, the name "mutex" is a shortened form of the term "mutually exclusive." Unlike monitors, however, a mutex can be used to synchronize threads across processes. A mutex is represented by the \<xref:System.Threading.Mutex*> class.  
  
 When used for inter-process synchronization, a mutex is called a *named mutex* because it is to be used in another application, and therefore it cannot be shared by means of a global or static variable. It must be given a name so that both applications can access the same mutex object.  
  
 Although a mutex can be used for intra-process thread synchronization, using \<xref:System.Threading.Monitor*> is generally preferred, because monitors were designed specifically for the .NET Framework and therefore make better use of resources. In contrast, the \<xref:System.Threading.Mutex*> class is a wrapper to a Win32 construct. While it is more powerful than a monitor, a mutex requires interop transitions that are more computationally expensive than those required by the \<xref:System.Threading.Monitor*> class. For an example of using a mutex, see [Mutex](assetId:///9dd06e25-12c0-4a9e-855a-452dc83803e2).  
  
## Interlocked Class  
 You can use the methods of the \<xref:System.Threading.Interlocked*> class to prevent problems that can occur when multiple threads attempt to simultaneously update or compare the same value. The methods of this class let you safely increment, decrement, exchange, and compare values from any thread.  
  
## ReaderWriter Locks  
 In some cases, you may want to lock a resource only when data is being written and permit multiple clients to simultaneously read data when data is not being updated. The \<xref:System.Threading.ReaderWriterLock*> class enforces exclusive access to a resource while a thread is modifying the resource, but it allows non-exclusive access when reading the resource. ReaderWriter locks are a useful alternative to exclusive locks, which cause other threads to wait, even when those threads do not need to update data.  
  
## Deadlocks  
 Thread synchronization is invaluable in multithreaded applications, but there is always the danger of creating a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, where multiple threads are waiting for each other and the application comes to a halt. A deadlock is analogous to a situation in which cars are stopped at a four-way stop and each person is waiting for the other to go. Avoiding deadlocks is important; the key is careful planning. You can often predict deadlock situations by diagramming multithreaded applications before you start coding.  
  
## See Also  
 \<xref:System.Threading.Thread*>   
 \<xref:System.Threading.WaitHandle.WaitOne*>   
 \<xref:System.Threading.WaitHandle.WaitAny*>   
 \<xref:System.Threading.WaitHandle.WaitAll*>   
 \<xref:System.Threading.Thread.Join*>   
 \<xref:System.Threading.Thread.Start*>   
 \<xref:System.Threading.Thread.Sleep*>   
 \<xref:System.Threading.Monitor*>   
 \<xref:System.Threading.Mutex*>   
 \<xref:System.Threading.AutoResetEvent*>   
 \<xref:System.Threading.ManualResetEvent*>   
 \<xref:System.Threading.Interlocked*>   
 \<xref:System.Threading.WaitHandle*>   
 \<xref:System.Threading.EventWaitHandle*>   
 \<xref:System.Threading*>   
 \<xref:System.Threading.EventWaitHandle.Set*>   
 [Multithreaded Applications (Visual Basic)](../vs140/multithreaded-applications--visual-basic-.md)   
 [SyncLock Statement](../vs140/synclock-statement.md)   
 [Mutex](assetId:///9dd06e25-12c0-4a9e-855a-452dc83803e2)   
 [Monitor](assetId:///33fe4aef-b44b-42fd-9e72-c908e39e75db)   
 [Interlocked](assetId:///cbda7114-c752-4f3e-ada1-b1e8dd262f2b)   
 [AutoResetEvent](assetId:///6d39c48d-6b37-4a9b-8631-f2924cfd9c18)   
 [Synchronizing Data for Multithreading](assetId:///b980eb4c-71d5-4860-864a-6dfe3692430a)