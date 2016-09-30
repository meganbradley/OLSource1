---
title: "Start Multiple Async Tasks and Process Them As They Complete (C#)"
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
ms.assetid: 25331850-35a7-43b3-ab76-3908e4346b9d
caps.latest.revision: 7
---
# Start Multiple Async Tasks and Process Them As They Complete (C#)
By using \<xref:System.Threading.Tasks.Task.WhenAny*?displayProperty=fullName>, you can start multiple tasks at the same time and process them one by one as they’re completed rather than process them in the order in which they're started.  
  
 The following example uses a query to create a collection of tasks. Each task downloads the contents of a specified website. In each iteration of a while loop, an awaited call to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns the task in the collection of tasks that finishes its download first. That task is removed from the collection and processed. The loop repeats until the collection contains no more tasks.  
  
> [!NOTE]
>  To run the examples, you must have Visual Studio 2012 or newer and  the .NET Framework 4.5 or newer installed on your computer.  
  
## Downloading the Example  
 You can download the complete Windows Presentation Foundation (WPF) project from [Async Sample: Fine Tuning Your Application](http://go.microsoft.com/fwlink/?LinkId=255046) and then follow these steps.  
  
1.  Decompress the file that you downloaded, and then start Visual Studio.  
  
2.  On the menu bar, choose **File**, **Open**, **Project/Solution**.  
  
3.  In the **Open Project** dialog box, open the folder that holds the sample code that you decompressed, and then open the solution (.sln) file for AsyncFineTuningCS.  
  
4.  In **Solution Explorer**, open the shortcut menu for the **ProcessTasksAsTheyFinish** project, and then choose **Set as StartUp Project**.  
  
5.  Choose the F5 key to run the project.  
  
     Choose the Ctrl+F5 keys to run the project without debugging it.  
  
6.  Run the project several times to verify that the downloaded lengths don't always appear in the same order.  
  
 If you don't want to download the project, you can review the MainWindow.xaml.cs file at the end of this topic.  
  
## Building the Example  
 This example adds to the code that’s developed in [Cancel Remaining Async Tasks after One Is Complete (C#)](../vs140/cancel-remaining-async-tasks-after-one-is-complete--csharp-.md)[Cancel Remaining Tasks after One Is Complete (C# and Visual Basic)](../vs140/cancel-remaining-async-tasks-after-one-is-complete--csharp-and-visual-basic-.md) and uses the same UI.  
  
 To build the example yourself, step by step, follow the instructions in the "Downloading the Example" section, but choose **CancelAfterOneTask** as the **StartUp Project**. Add the changes in this topic to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method in that project. The changes are marked with asterisks.  
  
 The **CancelAfterOneTask** project already includes a query that, when executed, creates a collection of tasks. Each call to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in the following code returns a <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>TResult<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>AccessTheWebAsync<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>WhenAny<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>firstFinishedTask<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>ProcessURLAsync<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>firstFinishedTask<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>1*> where <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is an integer. The task is already complete, but you await it to retrieve the length of the downloaded website, as the following example shows.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 You should run the project several times to verify that the downloaded lengths don't always appear in the same order.  
  
> [!CAUTION]
>  You can use <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> in a loop, as described in the example, to solve problems that involve a small number of tasks. However, other approaches are more efficient if you have a large number of tasks to process. For more information and examples, see [Processing Tasks as they complete](http://go.microsoft.com/fwlink/?LinkId=260810).  
  
## Complete Example  
 The following code is the complete text of the MainWindow.xaml.cs file for the example. Asterisks mark the elements that were added for this example.  
  
 Notice that you must add a reference for \<xref:System.Net.Http*>.  
  
 You can download the project from [Async Sample: Fine Tuning Your Application](http://go.microsoft.com/fwlink/?LinkId=255046).  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Threading.Tasks.Task.WhenAny*>   
 [Fine-Tuning Your Async Application (C#)](../vs140/fine-tuning-your-async-application--csharp-.md)   
 [Asynchronous Programming with async and await (C#)](../vs140/asynchronous-programming-with-async-and-await--csharp-.md)   
 [Async Sample: Fine Tuning Your Application](http://go.microsoft.com/fwlink/?LinkId=255046)