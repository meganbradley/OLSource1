---
title: "Handling Reentrancy in Async Apps (Visual Basic)"
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
ms.assetid: ef3dc73d-13fb-4c5f-a686-6b84148bbffe
caps.latest.revision: 5
---
# Handling Reentrancy in Async Apps (Visual Basic)
When you include asynchronous code in your app, you should consider and possibly prevent reentrancy, which refers to reentering an asynchronous operation before it has completed. If you don't identify and handle possibilities for reentrancy, it can cause unexpected results.  
  
 **In this topic**  
  
-   [Recognizing Reentrancy](../vs140/handling-reentrancy-in-async-apps--csharp-and-visual-basic-.md#BKMK_RecognizingReentrancy)  
  
-   [Handling Reentrancy](../vs140/handling-reentrancy-in-async-apps--csharp-and-visual-basic-.md#BKMK_HandlingReentrancy)  
  
    -   [Disable the Start Button](../vs140/handling-reentrancy-in-async-apps--csharp-and-visual-basic-.md#BKMK_DisableTheStartButton)  
  
    -   [Cancel and Restart the Operation](../vs140/handling-reentrancy-in-async-apps--csharp-and-visual-basic-.md#BKMK_CancelAndRestart)  
  
    -   [Run Multiple Operations and Queue the Output](../vs140/handling-reentrancy-in-async-apps--csharp-and-visual-basic-.md#BKMK_RunMultipleOperations)  
  
-   [Reviewing and Running the Example App](../vs140/handling-reentrancy-in-async-apps--csharp-and-visual-basic-.md#BKMD_SettingUpTheExample)  
  
> [!NOTE]
>  To run the example, you must have Visual Studio 2012 or newer and the .NET Framework 4.5 or newer installed on your computer.  
  
##  \<a name="BKMK_RecognizingReentrancy">\</a> Recognizing Reentrancy  
 In the example in this topic, users choose a **Start** button to initiate an asynchronous app that downloads a series of websites and calculates the total number of bytes that are downloaded. A synchronous version of the example would respond the same way regardless of how many times a user chooses the button because, after the first time, the UI thread ignores those events until the app finishes running. In an asynchronous app, however, the UI thread continues to respond, and you might reenter the asynchronous operation before it has completed.  
  
 The following example shows the expected output if the user chooses the **Start** button only once. A list of the downloaded websites appears with the size, in bytes, of each site. The total number of bytes appears at the end.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 However, if the user chooses the button more than once, the event handler is invoked repeatedly, and the download process is reentered each time. As a result, several asynchronous operations are running at the same time, the output interleaves the results, and the total number of bytes is confusing.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You can review the code that produces this output by scrolling to the end of this topic. You can experiment with the code by downloading the solution to your local computer and then running the WebsiteDownload project or by using the code at the end of this topic to create your own project For more information and instructions, see [Reviewing and Running the Example App](../vs140/handling-reentrancy-in-async-apps--csharp-and-visual-basic-.md#BKMD_SettingUpTheExample).  
  
##  \<a name="BKMK_HandlingReentrancy">\</a> Handling Reentrancy  
 You can handle reentrancy in a variety of ways, depending on what you want your app to do. This topic presents the following examples:  
  
-   [Disable the Start Button](../vs140/handling-reentrancy-in-async-apps--csharp-and-visual-basic-.md#BKMK_DisableTheStartButton)  
  
     Disable the **Start** button while the operation is running so that the user can't interrupt it.  
  
-   [Cancel and Restart the Operation](../vs140/handling-reentrancy-in-async-apps--csharp-and-visual-basic-.md#BKMK_CancelAndRestart)  
  
     Cancel any operation that is still running when the user chooses the **Start** button again, and then let the most recently requested operation continue.  
  
-   [Run Multiple Operations and Queue the Output](../vs140/handling-reentrancy-in-async-apps--csharp-and-visual-basic-.md#BKMK_RunMultipleOperations)  
  
     Allow all requested operations to run asynchronously, but coordinate the display of output so that the results from each operation appear together and in order.  
  
###  \<a name="BKMK_DisableTheStartButton">\</a> Disable the Start Button  
 You can block the **Start** button while an operation is running by disabling the button at the top of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> event handler. You can then reenable the button from within a  <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> block when the operation finishes so that users can run the app again.  
  
 The following code shows these changes, which are marked with asterisks. You can add the changes to the code at the end of this topic, or you can download the finished app from [Async Samples: Reentrancy in .NET Desktop Apps](http://go.microsoft.com/fwlink/?LinkId=266571). The project name is DisableStartButton.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 As a result of the changes, the button doesn't respond while <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is downloading the websites, so the process can’t be reentered.  
  
###  \<a name="BKMK_CancelAndRestart">\</a> Cancel and Restart the Operation  
 Instead of disabling the **Start** button, you can keep the button active but, if the user chooses that button again, cancel the operation that's already running and let the most recently started operation continue.  
  
 For more information about cancellation, see [Fine-Tuning Your Async Application (Visual Basic)](../vs140/fine-tuning-your-async-application--visual-basic-.md).  
  
 To set up this scenario, make the following changes to the basic code that is provided in [Reviewing and Running the Example App](../vs140/handling-reentrancy-in-async-apps--csharp-and-visual-basic-.md#BKMD_SettingUpTheExample). You also can download the finished app from [Async Samples: Reentrancy in .NET Desktop Apps](http://go.microsoft.com/fwlink/?LinkId=266571). The name of this project is CancelAndRestart.  
  
1.  Declare a \<xref:System.Threading.CancellationTokenSource*> variable, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, that’s in scope for all methods.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
2.  In <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, determine whether an operation is already underway. If the value of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, no operation is already active. If the value isn't <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, the operation that is already running is canceled.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
3.  Set <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> to a different value that represents the current process.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
4.  At the end of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, the current process is complete, so set the value of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> back to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The following code shows all the changes in <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. The additions are marked with asterisks.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 In <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, make the following changes.  
  
-   Add a parameter to accept the cancellation token from <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
-   Use the \<xref:System.Net.Http.HttpClient.GetAsync*> method to download the websites because <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> accepts a \<xref:System.Threading.CancellationToken*> argument.  
  
-   Before calling <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> to display the results for each downloaded website, check <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> to verify that the current operation hasn’t been canceled.  
  
 The following code shows these changes, which are marked with asterisks.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 If you choose the **Start** button several times while this app is running, it should produce results that resemble the following output.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 To eliminate the partial lists, uncomment the first line of code in <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> to clear the text box each time the user restarts the operation.  
  
###  \<a name="BKMK_RunMultipleOperations">\</a> Run Multiple Operations and Queue the Output  
 This third example is the most complicated in that the app starts another asynchronous operation each time that the user chooses the **Start** button, and all the operations run to completion. All the requested operations download websites from the list asynchronously, but the output from the operations is presented sequentially. That is, the actual downloading activity is interleaved, as the output in [Recognizing Reentrancy](../vs140/handling-reentrancy-in-async-apps--csharp-and-visual-basic-.md#BKMK_RecognizingReentrancy) shows, but the list of results for each group is presented separately.  
  
 The operations share a global \<xref:System.Threading.Tasks.Task*>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, which serves as a gatekeeper for the display process.  
  
 You can run this example by pasting the changes into the code in [Building the App](../vs140/handling-reentrancy-in-async-apps--csharp-and-visual-basic-.md#BKMK_BuildingTheApp), or you can follow the instructions in [Downloading the App](../vs140/handling-reentrancy-in-async-apps--csharp-and-visual-basic-.md#BKMK_DownloadingTheApp) to download the sample and then run the QueueResults project.  
  
 The following output shows the result if the user chooses the **Start** button only once. The letter label, A, indicates that the result is from the first time the **Start** button is chosen. The numbers show the order of the URLs in the list of download targets.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 If the user chooses the **Start** button three times, the app produces output that resembles the following lines. The information lines that start with a pound sign (#) trace the progress of the application.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Groups B and C start before group A has finished, but the output for the each group appears separately. All the output for group A appears first, followed by all the output for group B, and then all the output for group C. The app always displays the groups in order and, for each group, always displays the information about the individual websites in the order that the URLs appear in the list of URLs.  
  
 However, you can't predict the order in which the downloads actually happen. After multiple groups have been started, the download tasks that they generate are all active. You can't assume that A-1 will be downloaded before B-1, and you can't assume that A-1 will be downloaded before A-2.  
  
#### Global Definitions  
 The sample code contains the following two global declarations that are visible from all methods.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> variable, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, oversees the display process and prevents any group from interrupting another group's display operation. The character variable, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, labels the output from different groups to verify that results appear in the expected order.  
  
#### The Click Event Handler  
 The event handler, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, increments the group letter each time the user chooses the **Start** button. Then the handler calls <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> to run the downloading operation.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
#### The AccessTheWebAsync Method  
 This example splits <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> into two methods. The first method, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, starts all the download tasks for a group and sets up <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> to control the display process. The method uses a Language Integrated Query (LINQ query) and \<xref:System.Linq.Enumerable.ToArray*> to start all the download tasks at the same time.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> then calls <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> to await the completion of each download and display its length.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> returns a task that's assigned to <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>. That value prevents interruption by another operation before the task is complete.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
#### The FinishOneGroupAsync Method  
 This method cycles through the download tasks in a group, awaiting each one, displaying the length of the downloaded website, and adding the length to the total.  
  
 The first statement in <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> uses <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> to make sure that entering the method doesn't interfere with an operation that is already in the display process or that's already waiting. If such an operation is in progress, the entering operation must wait its turn.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 You can run this example by pasting the changes into the code in [Building the App](../vs140/handling-reentrancy-in-async-apps--csharp-and-visual-basic-.md#BKMK_BuildingTheApp), or you can follow the instructions in [Downloading the App](../vs140/handling-reentrancy-in-async-apps--csharp-and-visual-basic-.md#BKMK_DownloadingTheApp) to download the sample, and then run the QueueResults project.  
  
#### Points of Interest  
 The information lines that start with a pound sign (#) in the output clarify how this example works.  
  
 The output shows the following patterns.  
  
-   A group can be started while a previous group is displaying its output, but the display of the previous group's output isn't interrupted.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
-   The <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> task is <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> at the start of <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> only for group A, which started first. Group A hasn’t yet completed an await expression when it reaches <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>. Therefore, control hasn't returned to <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, and the first assignment to <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> hasn't occurred.  
  
-   The following two lines always appear together in the output. The code is never interrupted between starting a group's operation in <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> and assigning a task for the group to <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
     After a group enters <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, the operation doesn't complete an await expression until the operation enters <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>. Therefore, no other operation can gain control during that segment of code.  
  
##  \<a name="BKMD_SettingUpTheExample">\</a> Reviewing and Running the Example App  
 To better understand the example app, you can download it, build it yourself, or review the code at the end of this topic without implementing the app.  
  
> [!NOTE]
>  To run the example as a Windows Presentation Foundation (WPF) desktop app, you must have Visual Studio 2012 or newer and the .NET Framework 4.5 or newer installed on your computer.  
  
###  \<a name="BKMK_DownloadingTheApp">\</a> Downloading the App  
  
1.  Download the compressed file from [Async Samples: Reentrancy in .NET Desktop Apps](http://go.microsoft.com/fwlink/?LinkId=266571).  
  
2.  Decompress the file that you downloaded, and then start Visual Studio.  
  
3.  On the menu bar, choose **File**, **Open**, **Project/Solution**.  
  
4.  Navigate to the folder that holds the decompressed sample code, and then open the solution (.sln) file.  
  
5.  In **Solution Explorer**, open the shortcut menu for the project that you want to run, and then choose **Set as StartUpProject**.  
  
6.  Choose the CTRL+F5 keys to build and run the project.  
  
###  \<a name="BKMK_BuildingTheApp">\</a> Building the App  
 The following section provides the code to build the example as a WPF app.  
  
##### To build a WPF app  
  
1.  Start Visual Studio.  
  
2.  On the menu bar, choose **File**, **New**, **Project**.  
  
     The **New Project** dialog box opens.  
  
3.  In the **Installed Templates** pane, expand **Visual Basic**, and then expand **Windows**.  
  
4.  In the list of project types, choose **WPF Application**.  
  
5.  Name the project <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, and then choose the **OK** button.  
  
     The new project appears in **Solution Explorer**.  
  
6.  In the Visual Studio Code Editor, choose the **MainWindow.xaml** tab.  
  
     If the tab isn’t visible, open the shortcut menu for MainWindow.xaml in **Solution Explorer**, and then choose **View Code**.  
  
7.  In the **XAML** view of MainWindow.xaml, replace the code with the following code.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
     A simple window that contains a text box and a button appears in the **Design** view of MainWindow.xaml.  
  
8.  Add a reference for \<xref:System.Net.Http*>.  
  
9. In **Solution Explorer**, open the shortcut menu for MainWindow.xaml.vb, and then choose **View Code**.  
  
10. In MainWindow.xaml.vb , replace the code with the following code.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
11. Choose the CTRL+F5 keys to run the program, and then choose the **Start** button several times.  
  
12. Make the changes from [Disable the Start Button](../vs140/handling-reentrancy-in-async-apps--csharp-and-visual-basic-.md#BKMK_DisableTheStartButton), [Cancel and Restart the Operation](../vs140/handling-reentrancy-in-async-apps--csharp-and-visual-basic-.md#BKMK_CancelAndRestart), or [Run Multiple Operations and Queue the Output](../vs140/handling-reentrancy-in-async-apps--csharp-and-visual-basic-.md#BKMK_RunMultipleOperations) to handle the reentrancy.  
  
## See Also  
 [Walkthrough: Accessing the Web by Using Async and Await (Visual Basic)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--visual-basic-.md)   
 [Asynchronous Programming with Async and Await (Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--visual-basic-.md)