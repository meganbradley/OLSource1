---
title: "Because this call is not awaited, the current method continues to run before the call is completed"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc42358"
  - "vbc42358"
helpviewer_keywords: 
  - "BC42358"
ms.assetid: 43342515-c3c8-4155-9263-c302afabcbc2
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Because this call is not awaited, the current method continues to run before the call is completed
Because this call is not awaited, execution of the current method continues before the call is completed. Consider applying the 'Await' operator to the result of the call.  
  
 The current method calls an async method that returns a \<xref:System.Threading.Tasks.Task*> or a <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>Await<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>1*> is stored in the returned task. If you don't await the task or explicitly check for exceptions, the exception is lost. If you await the task, its exception is rethrown.  
  
 As a best practice, you should always await the call.  
  
 By default, this message is a warning. For more information about hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC42358  
  
### To address this warning  
  
-   You should consider suppressing the warning only if you're sure that you don't want to wait for the asynchronous call to complete and that the called method won't raise any exceptions. In that case, you can suppress the warning by assigning the task result of the call to a variable.  
  
     The following example shows how to cause the warning, how to suppress it, and how to await the call.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     In the example, if you choose Call #1 or Call #2, the unawaited async method (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) finishes after both its caller (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) and the caller's caller (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) are complete. The last line in the following output shows you when the called method finishes. Entry to and exit from the event handler that calls <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in the full example are marked in the output.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following Windows Presentation Foundation (WPF) application contains the methods from the previous example. The following steps set up the application.  
  
1.  Create a WPF application, and name it <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
2.  In the Visual Studio Code Editor, choose the **MainWindow.xaml** tab.  
  
     If the tab isn't visible, open the shortcut menu for MainWindow.xaml in **Solution Explorer**, and then choose **View Code**.  
  
3.  Replace the code in the **XAML** view of MainWindow.xaml with the following code.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     A simple window that contains a button and a text box appears in the **Design** view of MainWindow.xaml.  
  
     For more information about the XAML Designer, see [Creating a UI by using XAML Designer](../vs140/creating-a-ui-by-using-xaml-designer-in-visual-studio.md). For information about how to build your own simple UI, see the "To create a WPF application" and "To design a simple WPF MainWindow" sections of [Walkthrough: Writing an Async Program (C# and Visual Basic)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--csharp-and-visual-basic-.md).  
  
4.  Replace the code in MainWindow.xaml.vb with the following code.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
5.  Choose the F5 key to run the program, and then choose the **Start** button.  
  
     The expected output appears at the end of the code.  
  
## See Also  
 [Await Operator (Visual Basic)](../vs140/await-operator--visual-basic-.md)   
 [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md)