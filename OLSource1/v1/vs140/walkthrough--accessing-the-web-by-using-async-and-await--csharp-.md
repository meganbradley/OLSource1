---
title: "Walkthrough: Accessing the Web by Using async and await (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
dev_langs: 
  - "CSharp"
ms.assetid: c95d8d71-5a98-4bf0-aaf4-45fed2ebbacd
caps.latest.revision: 8
---
# Walkthrough: Accessing the Web by Using async and await (C#)
You can write asynchronous programs more easily and intuitively by using features that were introduced in [!INCLUDE[vs_dev11_long](../vs140/includes/vs_dev11_long_md.md)]. You can write asynchronous code that looks like synchronous code and let the compiler handle the difficult callback functions and continuations that asynchronous code usually entails.  
  
 For more information about the Async feature, see [Asynchronous Programming with async and await (C#)](../vs140/asynchronous-programming-with-async-and-await--csharp-.md).  
  
 This walkthrough starts with a synchronous Windows Presentation Foundation (WPF) application that sums the number of bytes in a list of websites. The walkthrough then converts the application to an asynchronous solution by using the new features.  
  
 If you don't want to build the applications yourself, you can download "Async Sample: Accessing the Web Walkthrough (C# and Visual Basic)" from [Developer Code Samples](http://go.microsoft.com/fwlink/?LinkId=255191).  
  
 In this walkthrough, you complete the following tasks:  
  
-   [To create a WPF application](#CreateWPFApp)  
  
-   [To design a simple WPF MainWindow](#MainWindow)  
  
-   [To add a reference](#AddRef)  
  
-   [To add necessary using directives](#usingDir)  
  
-   [To create a synchronous application](#synchronous)  
  
-   [To test the synchronous solution](#testSynch)  
  
-   [To convert GetURLContents to an asynchronous method](#GetURLContents)  
  
-   [To convert SumPageSizes to an asynchronous method](#SumPageSizes)  
  
-   [To convert startButton_Click to an asynchronous method](#startButton)  
  
-   [To test the asynchronous solution](#testAsynch)  
  
-   [To replace method GetURLContentsAsync with a .NET Framework method](#GetURLContentsAsync)  
  
-   [Example](#BKMK_CompleteCodeExamples)  
  
## Prerequisites  
 Visual Studio 2012 or later must be installed on your computer. For more information, see the [Microsoft website](http://go.microsoft.com/fwlink/?LinkId=235233).  
  
###  \<a name="CreateWPFApp">\</a> To create a WPF application  
  
1.  Start Visual Studio.  
  
2.  On the menu bar, choose **File**, **New**, **Project**.  
  
     The **New Project** dialog box opens.  
  
3.  In the **Installed Templates** pane, choose Visual C#, and then choose **WPF Application** from the list of project types.  
  
4.  In the **Name** text box, enter <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, and then choose the **OK** button.  
  
     The new project appears in **Solution Explorer**.  
  
##  \<a name="BKMK_DesignWPFMainWin">\</a>   
###  \<a name="MainWindow">\</a> To design a simple WPF MainWindow  
  
1.  In the Visual Studio Code Editor, choose the **MainWindow.xaml** tab.  
  
2.  If the **Toolbox** window isn’t visible, open the **View** menu, and then choose **Toolbox**.  
  
3.  Add a **Button** control and a **TextBox** control to the **MainWindow** window.  
  
4.  Highlight the **TextBox** control and, in the **Properties** window, set the following values:  
  
    -   Set the **Name** property to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
    -   Set the **Height** property to 250.  
  
    -   Set the **Width** property to 500.  
  
    -   On the **Text** tab, specify a monospaced font, such as Lucida Console or Global Monospace.  
  
5.  Highlight the **Button** control and, in the **Properties** window, set the following values:  
  
    -   Set the **Name** property to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
    -   Change the value of the **Content** property from **Button** to **Start**.  
  
6.  Position the text box and the button so that both appear in the **MainWindow** window.  
  
     For more information about the WPF XAML Designer, see [Creating a UI by using XAML Designer](../vs140/creating-a-ui-by-using-xaml-designer-in-visual-studio.md).  
  
##  \<a name="BKMK_AddReference">\</a>   
###  \<a name="AddRef">\</a> To add a reference  
  
1.  In **Solution Explorer**, highlight your project's name.  
  
2.  On the menu bar, choose **Project**, **Add Reference**.  
  
     The **Reference Manager** dialog box appears.  
  
3.  At the top of the dialog box, verify that your project is targeting the .NET Framework 4.5 or higher.  
  
4.  In the **Assemblies** area, choose **Framework** if it isn’t already chosen.  
  
5.  In the list of names, select the **System.Net.Http** check box.  
  
6.  Choose the **OK** button to close the dialog box.  
  
##  \<a name="BKMK_AddStatesandDirs">\</a>   
###  \<a name="usingDir">\</a> To add necessary using directives  
  
1.  In **Solution Explorer**, open the shortcut menu for MainWindow.xaml.cs, and then choose **View Code**.  
  
2.  Add the following <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> directives at the top of the code file if they’re not already present.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
##  \<a name="BKMK_CreatSynchApp">\</a>   
###  \<a name="synchronous">\</a> To create a synchronous application  
  
1.  In the design window, MainWindow.xaml, double-click the **Start** button to create the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> event handler in MainWindow.xaml.cs.  
  
2.  In MainWindow.xaml.cs, copy the following code into the body of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     The code calls the method that drives the application, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, and displays a message when control returns to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
3.  The code for the synchronous solution contains the following four methods:  
  
    -   <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, which gets a list of webpage URLs from <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and then calls <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to process each URL.  
  
    -   <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, which makes and returns a list of web addresses.  
  
    -   <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, which downloads the contents of each website and returns the contents as a byte array.  
  
    -   <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, which displays  the number of bytes in the byte array for each URL.  
  
     Copy the following four methods, and then paste them under the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> event handler in MainWindow.xaml.cs:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="BKMK_TestSynchSol">\</a>   
###  \<a name="testSynch">\</a> To test the synchronous solution  
  
1.  Choose the F5 key to run the program, and then choose the **Start** button.  
  
     Output that resembles the following list should appear.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     Notice that it takes a few seconds to display the counts. During that time, the UI thread is blocked while it waits for requested resources to download. As a result, you can't move, maximize, minimize, or even close the display window after you choose the  **Start** button. These efforts fail until the byte counts start to appear. If a website isn’t responding, you have no indication of which site failed. It is difficult even to stop waiting and close the program.  
  
##  \<a name="BKMK_ConvertGtBtArr">\</a>   
###  \<a name="GetURLContents">\</a> To convert GetURLContents to an asynchronous method  
  
1.  To convert the synchronous solution to an asynchronous solution, the best place to start is in <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> because the calls to the \<xref:System.Net.HttpWebRequest*> method \<xref:System.Net.HttpWebRequest.GetResponse*> and to the \<xref:System.IO.Stream*> method \<xref:System.IO.Stream.CopyTo*> are where the application accesses the web. The .NET Framework makes the conversion easy by supplying asynchronous versions of both methods.  
  
     For more information about the methods that are used in <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, see \<xref:System.Net.WebRequest*>.  
  
    > [!NOTE]
    >  As you follow the steps in this walkthrough, several compiler errors appear. You can ignore them and continue with the walkthrough.  
  
     Change the method that's called in the third line of <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> from <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> to the asynchronous, task-based \<xref:System.Net.WebRequest.GetResponseAsync*> method.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
2.  <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> returns a <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>TResult<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>WebResponse<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>WebResponse<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>GetResponseAsync<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>GetURLContents<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>GetURLContents<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>SumPageSizes<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>WebResponse<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>response<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>webReq.GetResponseAsync<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>Task(Of WebResponse)<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>Task<WebResponse><CodeContentPlaceHolder>56\</CodeContentPlaceHolder>WebResponse<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>CopyTo<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>CopyToAsync<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>CopyTo<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>CopyToAsync<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>content<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>CopyTo<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>CopyToAsync<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>Await<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>CopyToAsync<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>GetURLContents<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>1*>, or <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> in C#. Typically, a return type of <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> is used only in an async event handler, where <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> is required. In other cases, you use <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> if the completed method has a [return](../vs140/return--csharp-reference-.md) statement that returns a value of type T, and you use <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> if the completed method doesn’t return a meaningful value. You can think of the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> return type as meaning "Task(void)."  
  
     For more information, see [Async Return Types (C#)](../vs140/async-return-types--csharp-.md).  
  
     Method <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> has a return statement, and the statement returns a byte array. Therefore, the return type of the async version is Task(T), where T is a byte array. Make the following changes in the method signature:  
  
    -   Change the return type to <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.  
  
    -   By convention, asynchronous methods have names that end in "Async," so rename the method <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.  
  
     The following code shows these changes.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
     With those few changes, the conversion of <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> to an asynchronous method is complete.  
  
##  \<a name="BKMK_ConvertSumPagSzs">\</a>   
###  \<a name="SumPageSizes">\</a> To convert SumPageSizes to an asynchronous method  
  
1.  Repeat the steps from the previous procedure for <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>. First, change the call to <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> to an asynchronous call.  
  
    -   Change the name of the method that’s called from <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>, if you haven't already done so.  
  
    -   Apply <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> to the task that <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> returns to obtain the byte array value.  
  
     The following code shows these changes.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
     The previous assignment abbreviates the following two lines of code.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
2.  Make the following changes in the method's signature:  
  
    -   Mark the method with the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> modifier.  
  
    -   Add "Async" to the method name.  
  
    -   There is no task return variable, T, this time because <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> doesn’t return a value for T. (The method has no <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> statement.) However, the method must return a <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> to be awaitable. Therefore, change the return type of the method from <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>.  
  
     The following code shows these changes.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
     The conversion of <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> is complete.  
  
##  \<a name="BKMK_Cnvrtbttn1">\</a>   
###  \<a name="startButton">\</a> To convert startButton_Click to an asynchronous method  
  
1.  In the event handler, change the name of the called method from <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>, if you haven’t already done so.  
  
2.  Because <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> is an async method, change the code in the event handler to await the result.  
  
     The call to <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> mirrors the call to <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>. The call returns a <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>, not a <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.  
  
     As in previous procedures, you can convert the call by using one statement or two statements. The following code shows these changes.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
3.  To prevent accidentally reentering the operation, add the following statement at the top of <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> to disable the **Start** button.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
     You can reenable the button at the end of the event handler.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
     For more information about reentrancy, see [Handling Reentrancy in Async Apps (C#)](../vs140/handling-reentrancy-in-async-apps--csharp-.md).  
  
4.  Finally, add the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> modifier to the declaration so that the event handler can await <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
     Typically, the names of event handlers aren’t changed. The return type isn’t changed to <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> because event handlers must return <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.  
  
     The conversion of the project from synchronous to asynchronous processing is complete.  
  
##  \<a name="BKMK_testAsynchSolution">\</a>   
###  \<a name="testAsynch">\</a> To test the asynchronous solution  
  
1.  Choose the F5 key to run the program, and then choose the **Start** button.  
  
2.  Output that resembles the output of the synchronous solution should appear. However, notice the following differences.  
  
    -   The results don’t all occur at the same time, after the processing is complete. For example, both programs contain a line in <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> that clears the text box. The intent is to clear the text box between runs if you choose the **Start** button for a second time, after one set of results has appeared. In the synchronous version, the text box is cleared just before the counts appear for the second time, when the downloads are completed and the UI thread is free to do other work. In the asynchronous version, the text box clears immediately after you choose the **Start** button.  
  
    -   Most importantly, the UI thread isn’t blocked during the downloads. You can move or resize the window while the web resources are being downloaded, counted, and displayed. If one of the websites is slow or not responding, you can cancel the operation by choosing the **Close** button (the x in the red field in the upper-right corner).  
  
##  \<a name="BKMK_ReplaceGetByteArrayAsync">\</a>   
###  \<a name="GetURLContentsAsync">\</a> To replace method GetURLContentsAsync with a .NET Framework method  
  
1.  The .NET Framework 4.5 provides many async methods that you can use. One of them, the \<xref:System.Net.Http.HttpClient*> method \<xref:System.Net.Http.HttpClient.GetByteArrayAsync(System.String)>, does just what you need for this walkthrough. You can use it instead of the <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> method that you created in an earlier procedure.  
  
     The first step is to create an <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> object in method <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>. Add the following declaration at the start of the method.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
2.  In <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> replace the call to your <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> method with a call to the <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> method.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
3.  Remove or comment out the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> method that you wrote.  
  
4.  Choose the F5 key to run the program, and then choose the **Start** button.  
  
     The behavior of this version of the project should match the behavior that the "To test the asynchronous solution" procedure describes but with even less effort from you.  
  
##  \<a name="BKMK_CompleteCodeExamples">\</a> Example  
 The following code contains the full example of the conversion from a synchronous to an asynchronous solution by using the asynchronous <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> method that you wrote. Notice that it strongly resembles the original, synchronous solution.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The following code contains the full example of the solution that uses the <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> method, <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
## See Also  
 [Async Sample: Accessing the Web Walkthrough (C# and Visual Basic)](http://go.microsoft.com/fwlink/?LinkId=255191)   
 [async (C# Reference)](../vs140/async--csharp-reference-.md)   
 [await (C# Reference)](../vs140/await--csharp-reference-.md)   
 [Asynchronous Programming with async and await (C#)](../vs140/asynchronous-programming-with-async-and-await--csharp-.md)   
 [Async Return Types (C#)](../vs140/async-return-types--csharp-.md)   
 [Task-based Asynchronous Programming (TAP)](http://go.microsoft.com/fwlink/?LinkId=204847)   
 [How to: Extend the async Walkthrough by Using Task.WhenAll (C#)](../vs140/how-to--extend-the-async-walkthrough-by-using-task.whenall--csharp-.md)   
 [How to: Make Multiple Web Requests in Parallel by Using async and await (C#)](../vs140/how-to--make-multiple-web-requests-in-parallel-by-using-async-and-await--csharp-.md)