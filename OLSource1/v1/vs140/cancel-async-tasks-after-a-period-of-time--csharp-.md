---
title: "Cancel Async Tasks after a Period of Time (C#)"
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
ms.assetid: 194282c2-399f-46da-a7a6-96674e00b0b3
caps.latest.revision: 7
---
# Cancel Async Tasks after a Period of Time (C#)
You can cancel an asynchronous operation after a period of time by using the  \<xref:System.Threading.CancellationTokenSource.CancelAfter*?displayProperty=fullName> method if you don't want to wait for the operation to finish. This method schedules the cancellation of any associated tasks that aren’t complete within the period of time that’s designated by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> expression.  
  
 This example adds to the code that’s developed in [Cancel an Async Task or a List of Tasks (C#)](../vs140/cancel-an-async-task-or-a-list-of-tasks--csharp-.md) to download a list of websites and to display the length of the contents of each one.  
  
> [!NOTE]
>  To run the examples, you must have Visual Studio 2012 or newer and the .NET Framework 4.5 or newer installed on your computer.  
  
## Downloading the Example  
 You can download the complete Windows Presentation Foundation (WPF) project from [Async Sample: Fine Tuning Your Application](http://go.microsoft.com/fwlink/?LinkId=255046) and then follow these steps.  
  
1.  Decompress the file that you downloaded, and then start Visual Studio.  
  
2.  On the menu bar, choose **File**, **Open**, **Project/Solution**.  
  
3.  In the **Open Project** dialog box, open the folder that holds the sample code that you decompressed, and then open the solution (.sln) file for AsyncFineTuningCS.  
  
4.  In **Solution Explorer**, open the shortcut menu for the **CancelAfterTime** project, and then choose **Set as StartUp Project**.  
  
5.  Choose the F5 key to run the project.  
  
     Choose the Ctrl+F5 keys to run the project without debugging it.  
  
6.  Run the program several times to verify that the output might show output for all websites, no websites, or some web sites.  
  
 If you don't want to download the project, you can review the MainWindow.xaml.cs file at the end of this topic.  
  
## Building the Example  
 The example in this topic adds to the project that's developed in [Cancel an Async Task or a List of Tasks (C#)](../vs140/cancel-an-async-task-or-a-list-of-tasks--csharp-.md) to cancel a list of tasks. The example uses the same UI, although the **Cancel** button isn’t used explicitly.  
  
 To build the example yourself, step by step, follow the instructions in the "Downloading the Example" section, but choose **CancelAListOfTasks** as the **StartUp Project**. Add the changes in this topic to that project.  
  
 To specify a maximum time before the tasks are marked as canceled, add a call to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, as the following example shows. The addition is marked with asterisks.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Run the program several times to verify that the output might show output for all websites, no websites, or some web sites. The following output is a sample.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Complete Example  
 The following code is the complete text of the MainWindow.xaml.cs file for the example. Asterisks mark the elements that were added for this example.  
  
 Notice that you must add a reference for \<xref:System.Net.Http*>.  
  
 You can download the project from [Async Sample: Fine Tuning Your Application](http://go.microsoft.com/fwlink/?LinkId=255046).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Asynchronous Programming with async and await (C#)](../vs140/asynchronous-programming-with-async-and-await--csharp-.md)   
 [Walkthrough: Accessing the Web by Using async and await (C#)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--csharp-.md)   
 [Cancel an Async Task or a List of Tasks (C#)](../vs140/cancel-an-async-task-or-a-list-of-tasks--csharp-.md)   
 [Fine-Tuning Your Async Application (C#)](../vs140/fine-tuning-your-async-application--csharp-.md)   
 [Async Sample: Fine Tuning Your Application](http://go.microsoft.com/fwlink/?LinkId=255046)