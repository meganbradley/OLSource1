---
title: "Fine-Tuning Your Async Application (Visual Basic)"
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
ms.assetid: 4c3e7997-a95f-4fbe-a6ac-60ba042d30b9
caps.latest.revision: 5
---
# Fine-Tuning Your Async Application (Visual Basic)
You can add precision and flexibility to your async applications by using the methods and properties that the \<xref:System.Threading.Tasks.Task*> type makes available. The topics in this section show examples that use \<xref:System.Threading.CancellationToken*> and important <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> methods such as \<xref:System.Threading.Tasks.Task.WhenAll*?displayProperty=fullName> and \<xref:System.Threading.Tasks.Task.WhenAny*?displayProperty=fullName>.  
  
 By using <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, you can more easily start multiple tasks and await their completion by monitoring a single task.  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns a task that completes when any task in a collection is complete.  
  
     For examples that use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, see  [Cancel Remaining Async Tasks after One Is Complete (Visual Basic)](../vs140/cancel-remaining-async-tasks-after-one-is-complete--visual-basic-.md)and [Start Multiple Async Tasks and Process Them As They Complete (Visual Basic)](../vs140/start-multiple-async-tasks-and-process-them-as-they-complete--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns a task that completes when all tasks in a collection are complete.  
  
     For more information and an example that uses <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, see [How to: Extend the Async Walkthrough by Using Task.WhenAll (Visual Basic)](../vs140/how-to--extend-the-async-walkthrough-by-using-task.whenall--visual-basic-.md).  
  
 This section includes the following examples.  
  
-   [Cancel an Async Task or a List of Tasks (Visual Basic)](../vs140/cancel-an-async-task-or-a-list-of-tasks--visual-basic-.md).  
  
-   [Cancel Async Tasks after a Period of Time (Visual Basic)](../vs140/cancel-async-tasks-after-a-period-of-time--visual-basic-.md)  
  
-   [Cancel Remaining Async Tasks after One Is Complete (Visual Basic)](../vs140/cancel-remaining-async-tasks-after-one-is-complete--visual-basic-.md)  
  
-   [Start Multiple Async Tasks and Process Them As They Complete (Visual Basic)](../vs140/start-multiple-async-tasks-and-process-them-as-they-complete--visual-basic-.md)  
  
> [!NOTE]
>  To run the examples, you must have Visual Studio 2012 or newer and the .NET Framework 4.5 or newer installed on your computer.  
  
 The projects create a UI that contains a button that starts the process and a button that cancels it, as the following image shows. The buttons are named <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 ![WPF window with Cancel button](../vs140/media/cancellation.png "Cancellation")  
  
 You can download the complete Windows Presentation Foundation (WPF) projects from [Async Sample: Fine Tuning Your Application](http://go.microsoft.com/fwlink/?LinkId=255046).  
  
## See Also  
 [Asynchronous Programming with Async and Await (Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--visual-basic-.md)