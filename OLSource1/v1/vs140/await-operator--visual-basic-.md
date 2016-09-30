---
title: "Await Operator (Visual Basic)"
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
  - "vb.Await"
helpviewer_keywords: 
  - "Await operator [Visual Basic]"
  - "Await [Visual Basic]"
ms.assetid: 6b1ce283-e92b-4ba7-b081-7be7b3d37af9
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Await Operator (Visual Basic)
You apply the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator to an operand in an asynchronous method or lambda expression to suspend execution of the method until the awaited task completes. The task represents ongoing work.  
  
 The method in which <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is used must have an [Async](../vs140/async--visual-basic-.md) modifier. Such a method, defined by using the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> modifier, and usually containing one or more <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> expressions, is referred to as an *async method*.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keywords were introduced in Visual Studio 2012. For an introduction to async programming, see [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md).  
  
 Typically, the task to which you apply the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> operator is the return value from a call to a method that implements the [Task-Based Asynchronous Pattern](http://go.microsoft.com/fwlink/?LinkId=204847), that is, a \<xref:System.Threading.Tasks.Task*> or a <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>getContentsTask<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>Task(Of Byte())<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>Await<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>getContentsTask<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>SumPageSizesAsync<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>getContentsTask<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>SumPageSizesAsync<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>getContentsTask<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>Await<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>Await<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>Task(Of TResult)<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>Await<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>Await<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>Task<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>Await<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>Await<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>Await<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>Await<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>Async<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>Await<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>catch<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>finally<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>For<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>For Each<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>1*>. The properties of the returned task carry information about its status and history, such as whether the task is complete, whether the async method caused an exception or was canceled, and what the final result is. The <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> operator accesses those properties.  
  
 If you await a task-returning async method that causes an exception, the  <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> operator rethrows the exception.  
  
 If you await a task-returning async method that is canceled, the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> operator rethrows an \<xref:System.OperationCanceledException*>.  
  
 A single task that is in a faulted state can reflect multiple exceptions.  For example, the task might be the result of a call to \<xref:System.Threading.Tasks.Task.WhenAll*?displayProperty=fullName>. When you await such a task, the await operation rethrows only one of the exceptions. However, you can't predict which of the exceptions is rethrown.  
  
 For examples of error handling in async methods, see [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md).  
  
## Example  
 The following Windows Forms example illustrates the use of <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> in an async method, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. Contrast the behavior of that method with the behavior of <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. Without an <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> operator, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> runs synchronously despite the use of the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> modifier in its definition and a call to \<xref:System.Threading.Thread.Sleep*?displayProperty=fullName> in its body.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md)   
 [Walkthrough: Writing an Async Program (C# and Visual Basic)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--csharp-and-visual-basic-.md)   
 [Async (Visual Basic)](../vs140/async--visual-basic-.md)