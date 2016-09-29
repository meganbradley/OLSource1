---
title: "try-finally (C# Reference)"
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
  - "finally"
  - "finally_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "finally keyword [C#]"
  - "try-finally statement [C#]"
ms.assetid: c27623fb-7261-4464-862c-7a369d3c8f0a
caps.latest.revision: 29
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# try-finally (C# Reference)
By using a `finally` block, you can clean up any resources that are allocated in a [try](../vs140/try-catch--csharp-reference-.md) block, and you can run code even if an exception occurs in the `try` block. Typically, the statements of a `finally` block run when control leaves a `try` statement. The transfer of control can occur as a result of normal execution, of execution of a `break`, `continue`, `goto`, or `return` statement, or of propagation of an exception out of the `try` statement.  
  
 Within a handled exception, the associated `finally` block is guaranteed to be run. However, if the exception is unhandled, execution of the `finally` block is dependent on how the exception unwind operation is triggered. That, in turn, is dependent on how your computer is set up. For more information, see [Unhandled Exception Processing in the CLR](http://go.microsoft.com/fwlink/?LinkId=128371).  
  
 Usually, when an unhandled exception ends an application, whether or not the `finally` block is run is not important. However, if you have statements in a `finally` block that must be run even in that situation, one solution is to add a `catch` block to the `try`-`finally` statement. Alternatively, you can catch the exception that might be thrown in the `try` block of a `try`-`finally` statement higher up the call stack. That is, you can catch the exception in the method that calls the method that contains the `try`-`finally` statement, or in the method that calls that method, or in any method in the call stack. If the exception is not caught, execution of the `finally` block depends on whether the operating system chooses to trigger an exception unwind operation.  
  
## Example  
 In the following example, an invalid conversion statement causes a `System.InvalidCastException` exception. The exception is unhandled.  
  
 [!code[csrefKeywordsExceptions#4](../vs140/codesnippet/CSharp/try-finally--csharp-reference-_1.cs)]  
  
 In the following example, an exception from the `TryCast` method is caught in a method farther up the call stack.  
  
 [!code[csrefKeywordsExceptions#6](../vs140/codesnippet/CSharp/try-finally--csharp-reference-_2.cs)]  
  
 For more information about `finally`, see [try-catch-finally](../vs140/try-catch-finally--csharp-reference-.md).  
  
 C# also contains the [using statement](../vs140/using-statement--csharp-reference-.md), which provides similar functionality for <xref:System.IDisposable*> objects in a convenient syntax.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [try, throw, and catch Statements (C++)](../vs140/try--throw--and-catch-statements--c---.md)   
 [Exception Handling Statements](../vs140/exception-handling-statements--csharp-reference-.md)   
 [throw](../vs140/throw--csharp-reference-.md)   
 [try-catch](../vs140/try-catch--csharp-reference-.md)   
 [Throwing Exceptions](assetId:///72bdd157-caa9-4478-9ee3-cb4500b84528)