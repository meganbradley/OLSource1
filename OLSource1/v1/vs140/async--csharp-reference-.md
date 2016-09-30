---
title: "async (C# Reference)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "async_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "async keyword [C#]"
  - "async method [C#]"
  - "async [C#]"
ms.assetid: 16f14f09-b2ce-42c7-a875-e4eca5d50674
caps.latest.revision: 56
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# async (C# Reference)
Use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> modifier to specify that a method, [lambda expression](../vs140/lambda-expressions--csharp-programming-guide-.md), or [anonymous method](../vs140/anonymous-methods--csharp-programming-guide-.md) is asynchronous. If you use this modifier on a method or expression, it's referred to as an async method.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If you're new to asynchronous programming or do not understand how an async method uses the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword to do potentially long-running work without blocking the caller’s thread, you should read the introduction in [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The method runs synchronously until it reaches its first <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> expression, at which point the method is suspended until the awaited task is complete. In the meantime, control returns to the caller of the method, as the example in the next section shows.  
  
 If the method that the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword modifies doesn't contain an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> expression or statement, the method executes synchronously. A compiler warning alerts you to any async methods that don't contain <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, because that situation might indicate an error. See [Compiler Warning CS4014](../vs140/compiler-warning--level-1--cs4014.md).  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword is contextual in that it's a keyword only when it modifies a method, a lambda expression, or an anonymous method. In all other contexts, it's interpreted as an identifier.  
  
## Example  
 The following example shows the structure and flow of control between an async event handler, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and an async method, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The result from the async method is the length of a downloaded website. The code is suitable for a Windows Presentation Foundation (WPF) app or Windows Store app that you create in [!INCLUDE[vs_dev12](../vs140/includes/vs_dev12_md.md)]; see the code comments for setting up the app.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
> [!IMPORTANT]
>  For more information about tasks and the code that executes while waiting for a task, see [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md).  For a full WPF example that uses similar elements, see [Walkthrough: Writing an Async Program (C# and Visual Basic)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--csharp-and-visual-basic-.md). You can download the walkthrough code from [Developer Code Samples](http://go.microsoft.com/fwlink/?LinkId=255191).  
  
## Return Types  
 An async method can have a return type of \<xref:System.Threading.Tasks.Task*>, <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>Task<TResult><CodeContentPlaceHolder>13\</CodeContentPlaceHolder>TResult<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>Task<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>Task<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>Task<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>Task<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>void<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>void<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>void`-returning async method can't await it and can't catch exceptions that the method throws.  
  
 For more information and examples, see [Async Return Types (C# and Visual Basic)](../vs140/async-return-types--csharp-and-visual-basic-.md).  
  
## See Also  
 \<xref:System.Runtime.CompilerServices.AsyncStateMachineAttribute*>   
 [await (C# Reference)](../vs140/await--csharp-reference-.md)   
 [Walkthrough: Writing an Async Program (C# and Visual Basic)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--csharp-and-visual-basic-.md)   
 [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md)