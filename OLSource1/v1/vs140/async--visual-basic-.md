---
title: "Async (Visual Basic)"
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
  - "vb.Async"
helpviewer_keywords: 
  - "Async [Visual Basic]"
  - "Async keyword [Visual Basic]"
ms.assetid: 1be8b4b5-9689-41b5-bd33-b906bfd53bc5
caps.latest.revision: 41
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Async (Visual Basic)
The `Async` modifier indicates that the method or [lambda expression](../vs140/lambda-expressions--visual-basic-.md) that it modifies is asynchronous. Such methods are referred to as *async methods*.  
  
 An async method provides a convenient way to do potentially long-running work without blocking the caller's thread. The caller of an async method can resume its work without waiting for the async method to finish.  
  
> [!NOTE]
>  The `Async` and `Await` keywords were introduced in Visual Studio 2012. For an introduction to async programming, see [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md).  
  
 The following example shows the structure of an async method. By convention, async method names end in "Async."  
  
```vb  
  
Public Async Function ExampleMethodAsync() As Task(Of Integer)  
    ' . . .  
  
    ' At the Await expression, execution in this method is suspended and,  
    ' if AwaitedProcessAsync has not already finished, control returns  
    ' to the caller of ExampleMethodAsync. When the awaited task is   
    ' completed, this method resumes execution.   
    Dim exampleInt As Integer = Await AwaitedProcessAsync()  
  
    ' . . .  
  
    ' The return statement completes the task. Any method that is   
    ' awaiting ExampleMethodAsync can now get the integer result.  
    Return exampleInt  
End Function  
```  
  
 Typically, a method modified by the `Async` keyword contains at least one [Await](../vs140/async--visual-basic-.md) expression or statement. The method runs synchronously until it reaches the first `Await`, at which point it suspends until the awaited task completes. In the meantime, control is returned to the caller of the method. If the method doesn’t contain an `Await` expression or statement, the method isn’t suspended and executes as a synchronous method does. A compiler warning alerts you to any async methods that don't contain `Await` because that situation might indicate an error. For more information, see the [compiler error](../vs140/because-this-call-is-not-awaited--the-current-method-continues-to-run-before-the-call-is-completed.md).  
  
 The `Async` keyword is an unreserved keyword. It is a keyword when it modifies a method or a lambda expression. In all other contexts, it is interpreted as an identifier.  
  
## Return Types  
 An async method is either a [Sub](../vs140/sub-procedures--visual-basic-.md) procedure, or a [Function](../vs140/function-procedures--visual-basic-.md) procedure that has a return type of <xref:System.Threading.Tasks.Task*> or <xref:System.Threading.Tasks.Task`1*>. The method cannot declare any [ByRef](../vs140/byref--visual-basic-.md) parameters.  
  
 You specify `Task(Of TResult)` for the return type of an async method if the [Return](../vs140/return-statement--visual-basic-.md) statement of the method has an operand of type TResult. You use `Task` if no meaningful value is returned when the method is completed. That is, a call to the method returns a `Task`, but when the `Task` is completed, any `Await` statement that's awaiting the `Task` doesn’t produce a result value.  
  
 Async subroutines are used primarily to define event handlers where a `Sub` procedure is required. The caller of an async subroutine can't await it and can't catch exceptions that the method throws.  
  
 For more information and examples, see [Async Return Types (C# and Visual Basic)](../vs140/async-return-types--csharp-and-visual-basic-.md).  
  
## Example  
 The following examples show an async event handler, an async lambda expression, and an async method. For a full example that uses these elements, see [Walkthrough: Writing an Async Program (C# and Visual Basic)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--csharp-and-visual-basic-.md). You can download the walkthrough code from [Developer Code Samples](http://go.microsoft.com/fwlink/?LinkId=255191).  
  
```vb  
  
' An event handler must be a Sub procedure.  
Async Sub button1_Click(sender As Object, e As RoutedEventArgs) Handles button1.Click  
    textBox1.Clear()  
    ' SumPageSizesAsync is a method that returns a Task.  
    Await SumPageSizesAsync()  
    textBox1.Text = vbCrLf & "Control returned to button1_Click."  
End Sub  
  
' The following async lambda expression creates an equivalent anonymous  
' event handler.  
AddHandler button1.Click, Async Sub(sender, e)  
                              textBox1.Clear()  
                              ' SumPageSizesAsync is a method that returns a Task.  
                              Await SumPageSizesAsync()  
                              textBox1.Text = vbCrLf & "Control returned to button1_Click."  
                          End Sub  
  
' The following async method returns a Task(Of T).  
' A typical call awaits the Byte array result:  
'      Dim result As Byte() = Await GetURLContents("http://msdn.com")  
Private Async Function GetURLContentsAsync(url As String) As Task(Of Byte())  
  
    ' The downloaded resource ends up in the variable named content.  
    Dim content = New MemoryStream()  
  
    ' Initialize an HttpWebRequest for the current URL.  
    Dim webReq = CType(WebRequest.Create(url), HttpWebRequest)  
  
    ' Send the request to the Internet resource and wait for  
    ' the response.  
    Using response As WebResponse = Await webReq.GetResponseAsync()  
        ' Get the data stream that is associated with the specified URL.  
        Using responseStream As Stream = response.GetResponseStream()  
            ' Read the bytes in responseStream and copy them to content.    
            ' CopyToAsync returns a Task, not a Task<T>.  
            Await responseStream.CopyToAsync(content)  
        End Using  
    End Using  
  
    ' Return the result as a byte array.  
    Return content.ToArray()  
End Function  
  
```  
  
## See Also  
 <xref:System.Runtime.CompilerServices.AsyncStateMachineAttribute*>   
 [Await Operator (Visual Basic)](../vs140/await-operator--visual-basic-.md)   
 [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md)   
 [Walkthrough: Writing an Async Program (C# and Visual Basic)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--csharp-and-visual-basic-.md)