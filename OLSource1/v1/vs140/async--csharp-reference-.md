---
title: "async (C# Reference)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - async_CSharpKeyword
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - async keyword [C#]
  - async method [C#]
  - async [C#]
ms.assetid: 16f14f09-b2ce-42c7-a875-e4eca5d50674
caps.latest.revision: 56
translation.priority.ht: 
  - de-de
  - ja-jp
---
# async (C# Reference)
Use the `async` modifier to specify that a method, [lambda expression](../vs140/lambda-expressions--csharp-programming-guide-.md), or [anonymous method](../vs140/anonymous-methods--csharp-programming-guide-.md) is asynchronous. If you use this modifier on a method or expression, it's referred to as an async method.  
  
```c#  
public async Task<int> ExampleMethodAsync()  
{  
    // . . . .  
}  
  
```  
  
 If you're new to asynchronous programming or do not understand how an async method uses the `await` keyword to do potentially long-running work without blocking the caller’s thread, you should read the introduction in [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md).  
  
```  
string contents = await contentsTask;  
```  
  
 The method runs synchronously until it reaches its first `await` expression, at which point the method is suspended until the awaited task is complete. In the meantime, control returns to the caller of the method, as the example in the next section shows.  
  
 If the method that the `async` keyword modifies doesn't contain an `await` expression or statement, the method executes synchronously. A compiler warning alerts you to any async methods that don't contain `await`, because that situation might indicate an error. See [Compiler Warning CS4014](../vs140/compiler-warning--level-1--cs4014.md).  
  
 The `async` keyword is contextual in that it's a keyword only when it modifies a method, a lambda expression, or an anonymous method. In all other contexts, it's interpreted as an identifier.  
  
## Example  
 The following example shows the structure and flow of control between an async event handler, `StartButton_Click`, and an async method, `ExampleMethodAsync`. The result from the async method is the length of a downloaded website. The code is suitable for a Windows Presentation Foundation (WPF) app or Windows Store app that you create in [!INCLUDE[vs_dev12](../vs140/includes/vs_dev12_md.md)]; see the code comments for setting up the app.  
  
```c#  
// You can run this code in Visual Studio 2013 as a WPF app or a Windows Store app.  
// You need a button (StartButton) and a textbox (ResultsTextBox).  
// Remember to set the names and handler so that you have something like this:  
// <Button Content="Button" HorizontalAlignment="Left" Margin="88,77,0,0" VerticalAlignment="Top" Width="75"  
//         Click="StartButton_Click" Name="StartButton"/>  
// <TextBox HorizontalAlignment="Left" Height="137" Margin="88,140,0,0" TextWrapping="Wrap"   
//          Text="TextBox" VerticalAlignment="Top" Width="310" Name="ResultsTextBox"/>  
  
// To run the code as a WPF app:  
//    paste this code into the MainWindow class in MainWindow.xaml.cs,  
//    add a reference to System.Net.Http, and  
//    add a using directive for System.Net.Http.  
  
// To run the code as a Windows Store app:  
//    paste this code into the MainPage class in MainPage.xaml.cs, and  
//    add using directives for System.Net.Http and System.Threading.Tasks.  
  
private async void StartButton_Click(object sender, RoutedEventArgs e)  
{  
    // ExampleMethodAsync returns a Task<int>, which means that the method  
    // eventually produces an int result. However, ExampleMethodAsync returns  
    // the Task<int> value as soon as it reaches an await.  
    ResultsTextBox.Text += "\n";  
    try  
    {  
        int length = await ExampleMethodAsync();  
        // Note that you could put "await ExampleMethodAsync()" in the next line where  
        // "length" is, but due to when '+=' fetches the value of ResultsTextBox, you  
        // would not see the global side effect of ExampleMethodAsync setting the text.  
        ResultsTextBox.Text += String.Format("Length: {0}\n", length);  
    }  
    catch (Exception)  
    {  
        // Process the exception if one occurs.  
    }  
}  
  
public async Task<int> ExampleMethodAsync()  
{  
    var httpClient = new HttpClient();  
    int exampleInt = (await httpClient.GetStringAsync("http://msdn.microsoft.com")).Length;  
    ResultsTextBox.Text += "Preparing to finish ExampleMethodAsync.\n";  
    // After the following return statement, any method that's awaiting  
    // ExampleMethodAsync (in this case, StartButton_Click) can get the   
    // integer result.  
    return exampleInt;  
}  
// Output:  
// Preparing to finish ExampleMethodAsync.  
// Length: 53292  
  
```  
  
> [!IMPORTANT]
>  For more information about tasks and the code that executes while waiting for a task, see [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md).  For a full WPF example that uses similar elements, see [Walkthrough: Writing an Async Program (C# and Visual Basic)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--csharp-and-visual-basic-.md). You can download the walkthrough code from [Developer Code Samples](http://go.microsoft.com/fwlink/?LinkId=255191).  
  
## Return Types  
 An async method can have a return type of <xref:System.Threading.Tasks.Task?qualifyHint=False>, <xref:System.Threading.Tasks.Task`1?qualifyHint=False>, or [void](../vs140/void--csharp-reference-.md). The method can't declare any [ref](../vs140/ref--csharp-reference-.md) or [out](../vs140/out--csharp-reference-.md) parameters, but it can call methods that have such parameters.  
  
 You specify `Task<TResult>` as the return type of an async method if the [return](../vs140/return--csharp-reference-.md) statement of the method specifies an operand of type `TResult`. You use `Task` if no meaningful value is returned when the method is completed. That is, a call to the method returns a `Task`, but when the `Task` is completed, any `await` expression that's awaiting the `Task` evaluates to `void`.  
  
 You use the `void` return type primarily to define event handlers, which require that return type. The caller of a `void`-returning async method can't await it and can't catch exceptions that the method throws.  
  
 For more information and examples, see [Async Return Types (C# and Visual Basic)](../vs140/async-return-types--csharp-and-visual-basic-.md).  
  
## See Also  
 <xref:System.Runtime.CompilerServices.AsyncStateMachineAttribute?qualifyHint=False>   
 [await (C# Reference)](../vs140/await--csharp-reference-.md)   
 [Walkthrough: Writing an Async Program (C# and Visual Basic)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--csharp-and-visual-basic-.md)   
 [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md)