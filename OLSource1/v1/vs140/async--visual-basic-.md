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
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> modifier indicates that the method or [lambda expression](../vs140/lambda-expressions--visual-basic-.md) that it modifies is asynchronous. Such methods are referred to as *async methods*.  
  
 An async method provides a convenient way to do potentially long-running work without blocking the caller's thread. The caller of an async method can resume its work without waiting for the async method to finish.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keywords were introduced in Visual Studio 2012. For an introduction to async programming, see [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md).  
  
 The following example shows the structure of an async method. By convention, async method names end in "Async."  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Typically, a method modified by the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> keyword contains at least one [Await](../vs140/async--visual-basic-.md) expression or statement. The method runs synchronously until it reaches the first <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, at which point it suspends until the awaited task completes. In the meantime, control is returned to the caller of the method. If the method doesn’t contain an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> expression or statement, the method isn’t suspended and executes as a synchronous method does. A compiler warning alerts you to any async methods that don't contain <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> because that situation might indicate an error. For more information, see the [compiler error](../vs140/because-this-call-is-not-awaited--the-current-method-continues-to-run-before-the-call-is-completed.md).  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword is an unreserved keyword. It is a keyword when it modifies a method or a lambda expression. In all other contexts, it is interpreted as an identifier.  
  
## Return Types  
 An async method is either a [Sub](../vs140/sub-procedures--visual-basic-.md) procedure, or a [Function](../vs140/function-procedures--visual-basic-.md) procedure that has a return type of \<xref:System.Threading.Tasks.Task*> or <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>Task(Of TResult)<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>Task<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>Task<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>Task<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>Await<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>Task<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>Sub` procedure is required. The caller of an async subroutine can't await it and can't catch exceptions that the method throws.  
  
 For more information and examples, see [Async Return Types (C# and Visual Basic)](../vs140/async-return-types--csharp-and-visual-basic-.md).  
  
## Example  
 The following examples show an async event handler, an async lambda expression, and an async method. For a full example that uses these elements, see [Walkthrough: Writing an Async Program (C# and Visual Basic)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--csharp-and-visual-basic-.md). You can download the walkthrough code from [Developer Code Samples](http://go.microsoft.com/fwlink/?LinkId=255191).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Runtime.CompilerServices.AsyncStateMachineAttribute*>   
 [Await Operator (Visual Basic)](../vs140/await-operator--visual-basic-.md)   
 [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md)   
 [Walkthrough: Writing an Async Program (C# and Visual Basic)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--csharp-and-visual-basic-.md)