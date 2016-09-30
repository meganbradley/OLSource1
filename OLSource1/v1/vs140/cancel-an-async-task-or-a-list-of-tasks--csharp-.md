---
title: "Cancel an Async Task or a List of Tasks (C#)"
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
ms.assetid: eec32dbb-70ea-4c88-bd27-fa2e34546914
caps.latest.revision: 7
---
# Cancel an Async Task or a List of Tasks (C#)
You can set up a button that you can use to cancel an async application if you don't want to wait for it to finish. By following the examples in this topic, you can add a cancellation button to an application that downloads the contents of one website or a list of websites.  
  
 The examples use the UI that [Fine-Tuning Your Async Application (C#)](../vs140/fine-tuning-your-async-application--csharp-.md) describes.  
  
> [!NOTE]
>  To run the examples, you must have Visual Studio 2012 or newer and the .NET Framework 4.5 or newer installed on your computer.  
  
##  \<a name="BKMK_CancelaTask">\</a> Cancel a Task  
 The first example associates the **Cancel** button with a single download task. If you choose the button while the application is downloading content, the download is canceled.  
  
### Downloading the Example  
 You can download the complete Windows Presentation Foundation (WPF) project from [Async Sample: Fine Tuning Your Application](http://go.microsoft.com/fwlink/?LinkId=255046) and then follow these steps.  
  
1.  Decompress the file that you downloaded, and then start Visual Studio.  
  
2.  On the menu bar, choose **File**, **Open**, **Project/Solution**.  
  
3.  In the **Open Project** dialog box, open the folder that holds the sample code that you decompressed, and then open the solution (.sln) file for AsyncFineTuningCS.  
  
4.  In **Solution Explorer**, open the shortcut menu for the **CancelATask** project, and then choose **Set as StartUp Project**.  
  
5.  Choose the F5 key to run the project.  
  
     Choose the Ctrl+F5 keys to run the project without debugging it.  
  
 If you don't want to download the project, you can review the MainWindow.xaml.cs files at the end of this topic.  
  
### Building the Example  
 The following changes add a **Cancel** button to an application that downloads a website. If you don't want to download or build the example, you can review the final product in the "Complete Examples" section at the end of this topic. Asterisks mark the changes in the code.  
  
 To build the example yourself, step by step, follow the instructions in the "Downloading the Example" section, but choose **StarterCode** as the **StartUp Project** instead of **CancelATask**.  
  
 Then add the following changes to the MainWindow.xaml.cs file of that project.  
  
1.  Declare a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> variable, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, that’s in scope for all methods that access it.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  Add the following event handler for the **Cancel** button. The event handler uses the \<xref:System.Threading.CancellationTokenSource.Cancel*?displayProperty=fullName> method to notify <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> when the user requests cancellation.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
3.  Make the following changes in the event handler for the **Start** button, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
    -   Instantiate the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
    -   In the call to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, which downloads the contents of a specified website, send the \<xref:System.Threading.CancellationTokenSource.Token*?displayProperty=fullName> property of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> as an argument. The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> property propagates the message if cancellation is requested. Add a catch block that displays a message if the user chooses to cancel the download operation. The following code shows the changes.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
4.  In <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, use the  \<xref:System.Net.Http.HttpClient.GetAsync(System.String,System.Threading.CancellationToken)?displayProperty=fullName> overload of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> method in the \<xref:System.Net.Http.HttpClient*> type to download the contents of a website. Pass <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, the \<xref:System.Threading.CancellationToken*> parameter of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, as the second argument. The token carries the message if the user chooses the **Cancel** button.  
  
     The following code shows the changes in <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
5.  If you don’t cancel the program, it produces the following output.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
     If you choose the **Cancel** button before the program finishes downloading the content, the program produces the following output.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="BKMK_CancelaListofTasks">\</a> Cancel a List of Tasks  
 You can extend the previous example to cancel many tasks by associating the same <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> instance with each task. If you choose the **Cancel** button, you cancel all tasks that aren’t yet complete.  
  
### Downloading the Example  
 You can download the complete Windows Presentation Foundation (WPF) project from [Async Sample: Fine Tuning Your Application](http://go.microsoft.com/fwlink/?LinkId=255046) and then follow these steps.  
  
1.  Decompress the file that you downloaded, and then start Visual Studio.  
  
2.  On the menu bar, choose **File**, **Open**, **Project/Solution**.  
  
3.  In the **Open Project** dialog box, open the folder that holds the sample code that you decompressed, and then open the solution (.sln) file for AsyncFineTuningCS.  
  
4.  In **Solution Explorer**, open the shortcut menu for the **CancelAListOfTasks** project, and then choose **Set as StartUp Project**.  
  
5.  Choose the F5 key to run the project.  
  
     Choose the Ctrl+F5 keys to run the project without debugging it.  
  
 If you don't want to download the project, you can review the MainWindow.xaml.cs files at the end of this topic.  
  
### Building the Example  
 To extend the example yourself, step by step, follow the instructions in the "Downloading the Example" section, but choose **CancelATask** as the **StartUp Project**. Add the following changes to that project. Asterisks mark the changes in the program.  
  
1.  Add a method to create a list of web addresses.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
2.  Call the method in <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
3.  Add the following loop in <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to process each web address in the list.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
4.  Because <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> displays the lengths, the method doesn't need to return anything. Remove the return statement, and change the return type of the method to \<xref:System.Threading.Tasks.Task*> instead of <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>startButton_Click` by using a statement instead of an expression.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
5.  If you don’t cancel the program, it produces the following output.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
     If you choose the **Cancel** button before the downloads are complete, the output contains the lengths of the downloads that completed before the cancellation.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
##  \<a name="BKMK_CompleteExamples">\</a> Complete Examples  
 The following sections contain the code for each of the previous examples. Notice that you must add a reference for \<xref:System.Net.Http*>.  
  
 You can download the projects from [Async Sample: Fine Tuning Your Application](http://go.microsoft.com/fwlink/?LinkId=255046).  
  
### Cancel a Task Example  
 The following code is the complete MainWindow.xaml.cs file for the example that cancels a single task.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Cancel a List of Tasks Example  
 The following code is the complete MainWindow.xaml.cs file for the example that cancels a list of tasks.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Threading.CancellationTokenSource*>   
 \<xref:System.Threading.CancellationToken*>   
 [Asynchronous Programming with async and await (C#)](../vs140/asynchronous-programming-with-async-and-await--csharp-.md)   
 [Fine-Tuning Your Async Application (C#)](../vs140/fine-tuning-your-async-application--csharp-.md)   
 [Async Sample: Fine Tuning Your Application](http://go.microsoft.com/fwlink/?LinkId=255046)