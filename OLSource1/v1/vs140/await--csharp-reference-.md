---
title: "await (C# Reference)"
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
  - "await_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "await keyword [C#]"
  - "await [C#]"
ms.assetid: 50725c24-ac76-4ca7-bca1-dd57642ffedb
caps.latest.revision: 40
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# await (C# Reference)
The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator is applied to a task in an asynchronous method to suspend the execution of the method until the awaited task completes. The task represents ongoing work.  
  
 The asynchronous method in which <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is used must be modified by the [async](../vs140/async--csharp-reference-.md) keyword. Such a method, defined by using the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> modifier, and usually containing one or more <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> expressions, is referred to as an *async method*.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keywords were introduced in Visual Studio 2012. For an introduction to async programming, see [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md).  
  
 The task to which the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> operator is applied typically is the return value from a call to a method that implements the [Task-Based Asynchronous Pattern](http://go.microsoft.com/fwlink/?LinkId=204847). Examples include values of type \<xref:System.Threading.Tasks.Task*> or <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>Task\<byte[]><CodeContentPlaceHolder>11\</CodeContentPlaceHolder>getContentsTask<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>getContentsTask<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>SumPageSizesAsync<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>getContentsTask<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>SumPageSizesAsync<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>getContentsTask<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>Task<TResult><CodeContentPlaceHolder>21\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>Task<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>async<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>1*>. The properties of the returned task carry information about its status and history, such as whether the task is complete, whether the async method caused an exception or was canceled, and what the final result is. The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> operator accesses those properties.  
  
 If you await a task-returning async method that causes an exception, the  <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> operator rethrows the exception.  
  
 If you await a task-returning async method that's canceled, the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> operator rethrows an \<xref:System.OperationCanceledException*>.  
  
 A single task that is in a faulted state can reflect multiple exceptions. For example, the task might be the result of a call to \<xref:System.Threading.Tasks.Task.WhenAll*?displayProperty=fullName>. When you await such a task, the await operation rethrows only one of the exceptions. However, you can't predict which of the exceptions is rethrown.  
  
 For examples of error handling in async methods, see [try-catch (C# Reference)](../vs140/try-catch--csharp-reference-.md).  
  
## Example  
 The following Windows Forms example illustrates the use of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> in an async method, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. Contrast the behavior of that method with the behavior of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. Without an <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> operator applied to a task, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> runs synchronously despite the use of the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> modifier in its definition and a call to \<xref:System.Threading.Thread.Sleep*?displayProperty=fullName> in its body.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md)   
 [Walkthrough: Writing an Async Program (C# and Visual Basic)](../vs140/walkthrough--accessing-the-web-by-using-async-and-await--csharp-and-visual-basic-.md)   
 [async (C# Reference)](../vs140/async--csharp-reference-.md)