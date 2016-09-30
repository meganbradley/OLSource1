---
title: "How to: Make Multiple Web Requests in Parallel by Using async and await (C#)"
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
ms.assetid: 19745899-f97a-4499-a7c7-e813d1447580
caps.latest.revision: 7
---
# How to: Make Multiple Web Requests in Parallel by Using async and await (C#)
In an async method, tasks are started when they’re created. The [await](../vs140/await--csharp-reference-.md) operator is applied to the task at the point in the method where processing can’t continue until the task finishes. Often a task is awaited as soon as it’s created, as the following example shows.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 However, you can separate creating the task from awaiting the task if your program has other work to accomplish that doesn’t depend on the completion of the task.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Between starting a task and awaiting it, you can start other tasks. The additional tasks implicitly run in parallel, but no additional threads are created.  
  
 The following program starts three asynchronous web downloads and then awaits them in the order in which they’re called. Notice, when you run the program, that the tasks don’t always finish in the order in which they’re created and awaited. They start to run when they’re created, and one or more of the tasks might finish before the method reaches the await expressions.  
  
> [!NOTE]
>  To complete this project, you must have Visual Studio 2012 or higher and the .NET Framework 4.5 or higher installed on your computer.  
  
 For another example that starts multiple tasks at the same time, see [How to: Extend the async Walkthrough by Using Task.WhenAll (C#)](../vs140/how-to--extend-the-async-walkthrough-by-using-task.whenall--csharp-.md).  
  
 You can download the code for this example from [Developer Code Samples](http://go.microsoft.com/fwlink/?LinkId=254906).  
  
### To set up the project  
  
1.  To set up a WPF application, complete the following steps. You can find detailed instructions for these steps in [Walkthrough: Accessing the Web by Using async and await (C#)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--csharp-.md).  
  
    -   Create a WPF application that contains a text box and a button. Name the button <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and name the text box <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
    -   Add a reference for \<xref:System.Net.Http*>.  
  
    -   In the MainWindow.xaml.cs file, add a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> directive for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
### To add the code  
  
1.  In the design window, MainWindow.xaml, double-click the button to create the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> event handler in MainWindow.xaml.cs.  
  
2.  Copy the following code, and paste it into the body of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in MainWindow.xaml.cs.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     The code calls an asynchronous method, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, which drives the application.  
  
3.  Add the following support methods to the project:  
  
    -   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> uses an \<xref:System.Net.Http.HttpClient*> method to download the contents of a website as a byte array. The support method, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> then displays and returns the length of the array.  
  
    -   <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> displays the number of bytes in the byte array for each URL. This display shows when each task has finished downloading.  
  
     Copy the following methods, and paste them after the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> event handler in MainWindow.xaml.cs.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
4.  Finally, define method <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, which performs the following steps.  
  
    -   The method declares an <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object,which you need  to access method \<xref:System.Net.Http.HttpClient.GetByteArrayAsync*> in <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
    -   The method creates and starts three tasks of type <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>TResult<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>DisplayResults<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>CreateMultipleTasksAsync<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>ProcessURLAsync` from each completed task.  
  
    -   When the tasks have been completed and the integer values have been retrieved, the method sums the lengths of the websites and displays the result.  
  
     Copy the following method, and paste it into your solution.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
5.  Choose the F5 key to run the program, and then choose the **Start** button.  
  
     Run the program several times to verify that the three tasks don’t always finish in the same order and that the order in which they finish isn't necessarily the order in which they’re created and awaited.  
  
## Example  
 The following code contains the full example.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [Walkthrough: Accessing the Web by Using async and await (C#)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--csharp-.md)   
 [Asynchronous Programming with async and await (C#)](../vs140/asynchronous-programming-with-async-and-await--csharp-.md)   
 [How to: Extend the async Walkthrough by Using Task.WhenAll (C#)](../vs140/how-to--extend-the-async-walkthrough-by-using-task.whenall--csharp-.md)