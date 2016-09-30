---
title: "Using Async for File Access (Visual Basic)"
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
ms.assetid: c989305f-08e3-4687-95c3-948465cda202
caps.latest.revision: 5
---
# Using Async for File Access (Visual Basic)
You can use the Async feature to access files. By using the Async feature, you can call into asynchronous methods without using callbacks or splitting your code across multiple methods or lambda expressions. To make synchronous code asynchronous, you just call an asynchronous method instead of a synchronous method and add a few keywords to the code.  
  
 You might consider the following reasons for adding asynchrony to file access calls:  
  
-   Asynchrony makes UI applications more responsive because the UI thread that launches the operation can perform other work. If the UI thread must execute code that takes a long time (for example, more than 50 milliseconds), the UI may freeze until the I/O is complete and the UI thread can again process keyboard and mouse input and other events.  
  
-   Asynchrony improves the scalability of ASP.NET and other server-based applications by reducing the need for threads. If the application uses a dedicated thread per response and a thousand requests are being handled simultaneously, a thousand threads are needed. Asynchronous operations often don’t need to use a thread during the wait. They use the existing I/O completion thread briefly at the end.  
  
-   The latency of a file access operation might be very low under current conditions, but the latency may greatly increase in the future. For example, a file may be moved to a server that's across the world.  
  
-   The added overhead of using the Async feature is small.  
  
-   Asynchronous tasks can easily be run in parallel.  
  
## Running the Examples  
 To run the examples in this topic, you can create a **WPF Application** or a **Windows Forms Application** and then add a **Button**. In the button's <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> event, add a call to the first method in each example.  
  
 In the following examples, include the following <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statements.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Use of the FileStream Class  
 The examples in this topic use the \<xref:System.IO.FileStream*> class, which has an option that causes asynchronous I/O to occur at the operating system level. By using this option, you can avoid blocking a ThreadPool thread in many cases. To enable this option, you specify the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> argument in the constructor call.  
  
 You can’t use this option with \<xref:System.IO.StreamReader*> and \<xref:System.IO.StreamWriter*> if you open them directly by specifying a file path. However, you can use this option if you provide them a \<xref:System.IO.Stream*> that the \<xref:System.IO.FileStream*> class opened. Note that asynchronous calls are faster in UI apps even if a ThreadPool thread is blocked, because the UI thread isn’t blocked during the wait.  
  
## Writing Text  
 The following example writes text to a file. At each await statement, the method immediately exits. When the file I/O is complete, the method resumes at the statement that follows the await statement. Note that the async modifier is in the definition of methods that use the await statement.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The original example has the statement <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, which is a contraction of the following two statements:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The first statement returns a task and causes file processing to start. The second statement with the await causes the method to immediately exit and return a different task. When the file processing later completes, execution returns to the statement that follows the await. For more information, see  [Control Flow in Async Programs (Visual Basic)](../vs140/control-flow-in-async-programs--visual-basic-.md).  
  
## Reading Text  
 The following example reads text from a file. The text is buffered and, in this case, placed into a \<xref:System.Text.StringBuilder*>. Unlike in the previous example, the evaluation of the await produces a value. The \<xref:System.IO.Stream.ReadAsync*> method returns a \<xref:System.Threading.Tasks.Task*><\<xref:System.Int32*>>, so the evaluation of the await produces an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> value (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) after the operation completes. For more information, see [Async Return Types (Visual Basic)](../vs140/async-return-types--visual-basic-.md).  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Parallel Asynchronous I/O  
 The following example demonstrates parallel processing by writing 10 text files. For each file, the \<xref:System.IO.Stream.WriteAsync*> method returns a task that is then added to a list of tasks. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statement exits the method and resumes within the method when file processing is complete for all of the tasks.  
  
 The example closes all \<xref:System.IO.FileStream*> instances in a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> block after the tasks are complete. If each <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> was instead created in a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> statement, the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> might be disposed of before the task was complete.  
  
 Note that any performance boost is almost entirely from the parallel processing and not the asynchronous processing. The advantages of asynchrony are that it doesn’t tie up multiple threads, and that it doesn’t tie up the user interface thread.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 When using the \<xref:System.IO.Stream.WriteAsync*> and \<xref:System.IO.Stream.ReadAsync*> methods, you can specify a \<xref:System.Threading.CancellationToken*>, which you can use to cancel the operation mid-stream. For more information, see [Fine-Tuning Your Async Application (Visual Basic)](../vs140/fine-tuning-your-async-application--visual-basic-.md) and [Cancellation in Managed Threads](assetId:///eea11fe5-d8b0-4314-bb5d-8a58166fb1c3).  
  
## See Also  
 [Asynchronous Programming with Async and Await (Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--visual-basic-.md)   
 [Async Return Types (Visual Basic)](../vs140/async-return-types--visual-basic-.md)   
 [Control Flow in Async Programs (Visual Basic)](../vs140/control-flow-in-async-programs--visual-basic-.md)