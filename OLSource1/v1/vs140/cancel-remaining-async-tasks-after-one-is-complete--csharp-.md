---
title: "Cancel Remaining Async Tasks after One Is Complete (C#)"
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
ms.assetid: d3cebc74-c392-497b-b1e6-62a262eabe05
caps.latest.revision: 7
---
# Cancel Remaining Async Tasks after One Is Complete (C#)
By using the \<xref:System.Threading.Tasks.Task.WhenAny*?displayProperty=fullName> method together with a \<xref:System.Threading.CancellationToken*>, you can cancel all remaining tasks when one task is complete. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method takes an argument that’s a collection of tasks. The method starts all the tasks and returns a single task. The single task is complete when any task in the collection is complete.  
  
 This example demonstrates how to use a cancellation token in conjunction with <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to hold onto the first task to finish from the collection of tasks and to cancel the remaining tasks. Each task downloads the contents of a website. The example displays the length of the contents of the first download to complete and cancels the other downloads.  
  
> [!NOTE]
>  To run the examples, you must have Visual Studio 2012 or newer and the .NET Framework 4.5 or newer installed on your computer.  
  
## Downloading the Example  
 You can download the complete Windows Presentation Foundation (WPF) project from [Async Sample: Fine Tuning Your Application](http://go.microsoft.com/fwlink/?LinkId=255046) and then follow these steps.  
  
1.  Decompress the file that you downloaded, and then start Visual Studio.  
  
2.  On the menu bar, choose **File**, **Open**, **Project/Solution**.  
  
3.  In the **Open Project** dialog box, open the folder that holds the sample code that you decompressed, and then open the solution (.sln) file for AsyncFineTuningCS.  
  
4.  In **Solution Explorer**, open the shortcut menu for the **CancelAfterOneTask** project, and then choose **Set as StartUp Project**.  
  
5.  Choose the F5 key to run the project.  
  
     Choose the Ctrl+F5 keys to run the project without debugging it.  
  
6.  Run the program several times to verify that different downloads finish first.  
  
 If you don't want to download the project, you can review the MainWindow.xaml.cs file at the end of this topic.  
  
## Building the Example  
 The example in this topic adds to the project that's developed in [Cancel an Async Task or a List of Tasks (C#)](../vs140/cancel-an-async-task-or-a-list-of-tasks--csharp-.md) to cancel a list of tasks. The example uses the same UI, although the **Cancel** button isn’t used explicitly.  
  
 To build the example yourself, step by step, follow the instructions in the "Downloading the Example" section, but choose **CancelAListOfTasks** as the **StartUp Project**. Add the changes in this topic to that project.  
  
 In the MainWindow.xaml.cs file of the **CancelAListOfTasks** project, start the transition by moving the processing steps for each website from the loop in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to the following async method.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, this example uses a query, the  \<xref:System.Linq.Enumerable.ToArray*> method, and the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method to create and start an array of tasks. The application of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to the array returns a single task that, when awaited, evaluates to the first task to reach completion in the array of tasks.  
  
 Make the following changes in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Asterisks mark the changes in the code file.  
  
1.  Comment out or delete the loop.  
  
2.  Create a query that, when executed, produces a collection of generic tasks. Each call to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> returns a <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>TResult<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>ToArray<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>WhenAny<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>ToArray<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>WhenAny<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>WhenAny<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>Task(Of Task(Of Integer))<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>Task<Task<int>><CodeContentPlaceHolder>23\</CodeContentPlaceHolder>WhenAny<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>Task(Of Integer)<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>Task<int><CodeContentPlaceHolder>26\</CodeContentPlaceHolder>firstFinishedTask<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>firstFinishedTask<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>1*> where <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is an integer because that's the return type of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
5.  In this example, you’re interested only in the task that finishes first. Therefore, use \<xref:System.Threading.CancellationTokenSource.Cancel*?displayProperty=fullName> to cancel the remaining tasks.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
6.  Finally, await <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> to retrieve the length of the downloaded content.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Run the program several times to verify that different downloads finish first.  
  
## Complete Example  
 The following code is the complete MainWindow.xaml.cs file for the example. Asterisks mark the elements that were added for this example.  
  
 Notice that you must add a reference for \<xref:System.Net.Http*>.  
  
 You can download the project from [Async Sample: Fine Tuning Your Application](http://go.microsoft.com/fwlink/?LinkId=255046).  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Threading.Tasks.Task.WhenAny*>   
 [Fine-Tuning Your Async Application (C#)](../vs140/fine-tuning-your-async-application--csharp-.md)   
 [Asynchronous Programming with async and await (C#)](../vs140/asynchronous-programming-with-async-and-await--csharp-.md)   
 [Async Sample: Fine Tuning Your Application](http://go.microsoft.com/fwlink/?LinkId=255046)