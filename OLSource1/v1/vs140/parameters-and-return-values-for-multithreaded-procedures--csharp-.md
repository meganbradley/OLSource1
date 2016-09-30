---
title: "Parameters and Return Values for Multithreaded Procedures (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: ba63c30c-d9f0-4962-b5c7-9d83ba851e6a
caps.latest.revision: 5
---
# Parameters and Return Values for Multithreaded Procedures (C#)
Supplying and returning values in a multithreaded application is complicated because the constructor for the thread class must be passed a reference to a procedure that takes no arguments and returns no value. The following sections show some simple ways to supply parameters and return values from procedures on separate threads.  
  
## Supplying Parameters for Multithreaded Procedures  
 The best way to supply parameters for a multithreaded method call is to wrap the target method in a class and define fields for that class that will serve as parameters for the new thread. The advantage of this approach is that you can create a new instance of the class, with its own parameters, every time you want to start a new thread. For example, suppose you have a function that calculates the area of a triangle, as in the following code:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You can write a class that wraps the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function and creates fields to store input parameters, as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 To use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, you can create an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object, and set the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> properties as shown in the following code:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Notice that the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> procedure does not check the value of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> field after calling the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method. Because <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> runs on a separate thread, the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> field is not guaranteed to be set if you check it immediately after calling <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. The next section discusses a better way to return values from multithreaded procedures.  
  
## Returning Values from Multithreaded Procedures  
 Returning values from procedures that run on separate threads is complicated by the fact that the procedures cannot be functions and cannot use <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> arguments. The easiest way to return values is to use the \<xref:System.ComponentModel.BackgroundWorker*> component to manage your threads and raise an event when the task is done, and process the results with an event handler.  
  
 The following example returns a value by raising an event from a procedure running on a separate thread:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 You can provide parameters and return values to thread-pool threads by using the optional <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> state-object variable of the \<xref:System.Threading.ThreadPool.QueueUserWorkItem*> method. Thread-timer threads also support a state object for this purpose. For information on thread pooling and thread timers, see [Thread Pooling (C#)](../vs140/thread-pooling--csharp-.md) and [Thread Timers (C#)](../vs140/thread-timers--csharp-.md).  
  
## See Also  
 [Walkthrough: Multithreading with the BackgroundWorker Component (C#)](../vs140/walkthrough--multithreading-with-the-backgroundworker-component--csharp-.md)   
 [Thread Pooling (C#)](../vs140/thread-pooling--csharp-.md)   
 [Thread Synchronization (C#)](../vs140/thread-synchronization--csharp-.md)   
 [Events (C# Programming Guide)](../vs140/events--csharp-programming-guide-.md)   
 [Multithreaded Applications (C#)](../vs140/multithreaded-applications--csharp-.md)   
 [Delegates (C# Programming Guide)](../vs140/delegates--csharp-programming-guide-.md)   
 [Multithreading in Components](assetId:///2fc31e68-fb71-4544-b654-0ce720478779)