---
title: "Compiler Warning (level 1) CS4014"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS4014"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS4014"
ms.assetid: b9e7c029-eaa9-48d7-8b3c-9823772c9acb
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS4014
Because this call is not awaited, execution of the current method continues before the call is completed. Consider applying the 'await' operator to the result of the call.  
  
 The current method calls an async method that returns a \<xref:System.Threading.Tasks.Task*> or a <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>1*> is stored in the returned task. If you don't await the task or explicitly check for exceptions, the exception is lost. If you await the task, its exception is rethrown.  
  
 As a best practice, you should always await the call.  
  
 You should consider suppressing the warning only if you're sure that you don't want to wait for the asynchronous call to complete and that the called method won't raise any exceptions. In that case, you can suppress the warning by assigning the task result of the call to a variable.  
  
 The following example shows how to cause the warning, how to suppress it, and how to await the call.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the example, if you choose Call #1 or Call #2, the unawaited async method (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) finishes after both its caller (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) and the caller's caller (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) are complete. The last line in the following output shows you when the called method finishes. Entry to and exit from the event handler that calls <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in the full example are marked in the output.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You can also suppress compiler warnings by using [#pragma warning (C# Reference)](../vs140/sharppragma-warning--csharp-reference-.md) directives.  
  
## Example  
 The following Windows Presentation Foundation (WPF) application contains the methods from the previous example. The following steps set up the application.  
  
1.  Create a WPF application, and name it <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
2.  In the Visual Studio Code Editor, choose the **MainWindow.xaml** tab.  
  
     If the tab isn't visible, open the shortcut menu for MainWindow.xaml in **Solution Explorer**, and then choose **View Code**.  
  
3.  Replace the code in the **XAML** view of MainWindow.xaml with the following code.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     A simple window that contains a button and a text box appears in the **Design** view of MainWindow.xaml.  
  
     For more information about the XAML Designer, see [Creating a UI by using XAML Designer](../vs140/creating-a-ui-by-using-xaml-designer-in-visual-studio.md). For information about how to build your own simple UI, see the "To create a WPF application" and "To design a simple WPF MainWindow" sections of [Walkthrough: Writing an Async Program (C# and Visual Basic)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--csharp-and-visual-basic-.md).  
  
4.  Replace the code in MainWindow.xaml.cs with the following code.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
5.  Choose the F5 key to run the program, and then choose the **Start** button.  
  
     The expected output appears at the end of the code.  
  
## See Also  
 [await (C# Reference)](../vs140/await--csharp-reference-.md)   
 [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md)