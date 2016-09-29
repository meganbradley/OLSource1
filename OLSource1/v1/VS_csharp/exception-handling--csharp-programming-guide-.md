---
title: "Exception Handling (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "exception handling [C#], about exception handling"
  - "exceptions [C#], handling"
ms.assetid: b4e4ecf2-b907-4e58-891f-2563762258e9
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exception Handling (C# Programming Guide)
A [try](../VS_csharp/try-catch--csharp-reference-.md) block is used by C# programmers to partition code that might be affected by an exception. Associated [catch](../VS_csharp/try-catch--csharp-reference-.md) blocks are used to handle any resulting exceptions. A [finally](../VS_csharp/try-finally--csharp-reference-.md) block contains code that is run regardless of whether or not an exception is thrown in the `try` block, such as releasing resources that are allocated in the `try` block. A `try` block requires one or more associated `catch` blocks, or a `finally` block, or both.  
  
 The following examples show a `try-catch` statement, a `try-finally` statement, and a `try-catch-finally` statement.  
  
 [!code[csProgGuideExceptions#6](../VS_csharp/codesnippet/CSharp/exception-handling--csharp-programming-guide-_1.cs)]  
  
 [!code[csProgGuideExceptions#7](../VS_csharp/codesnippet/CSharp/exception-handling--csharp-programming-guide-_2.cs)]  
  
 [!code[csProgGuideExceptions#8](../VS_csharp/codesnippet/CSharp/exception-handling--csharp-programming-guide-_3.cs)]  
  
 A `try` block without a `catch` or `finally` block causes a compiler error.  
  
## Catch Blocks  
 A `catch` block can specify the type of exception to catch. The type specification is called an *exception filter*. The exception type should be derived from <xref:System.Exception*>. In general, do not specify <xref:System.Exception*> as the exception filter unless either you know how to handle all exceptions that might be thrown in the `try` block, or you have included a [throw](../VS_csharp/throw--csharp-reference-.md) statement at the end of your `catch` block.  
  
 Multiple `catch` blocks with different exception filters can be chained together. The `catch` blocks are evaluated from top to bottom in your code, but only one `catch` block is executed for each exception that is thrown. The first `catch` block that specifies the exact type or a base class of the thrown exception is executed. If no `catch` block specifies a matching exception filter, a `catch` block that does not have a filter is selected, if one is present in the statement. It is important to position `catch` blocks with the most specific (that is, the most derived) exception types first.  
  
 You should catch exceptions when the following conditions are true:  
  
-   You have a good understanding of why the exception might be thrown, and you can implement a specific recovery, such as prompting the user to enter a new file name when you catch a <xref:System.IO.FileNotFoundException*> object.  
  
-   You can create and throw a new, more specific exception.  
  
     [!code[csProgGuideExceptions#9](../VS_csharp/codesnippet/CSharp/exception-handling--csharp-programming-guide-_4.cs)]  
  
-   You want to partially handle an exception before passing it on for additional handling. In the following example, a `catch` block is used to add an entry to an error log before re-throwing the exception.  
  
     [!code[csProgGuideExceptions#10](../VS_csharp/codesnippet/CSharp/exception-handling--csharp-programming-guide-_5.cs)]  
  
## Finally Blocks  
 A `finally` block enables you to clean up actions that are performed in a `try` block. If present, the `finally` block executes last, after the `try` block and any matched `catch` block. A `finally` block always runs, regardless of whether an exception is thrown or a `catch` block matching the exception type is found.  
  
 The `finally` block can be used to release resources such as file streams, database connections, and graphics handles without waiting for the garbage collector in the runtime to finalize the objects. See [using Statement (C# Reference)](../VS_csharp/using-statement--csharp-reference-.md) for more information.  
  
 In the following example, the `finally` block is used to close a file that is opened in the `try` block. Notice that the state of the file handle is checked before the file is closed. If the `try` block cannot open the file, the file handle still has the value `null` and the `finally` block does not try to close it. Alternatively, if the file is opened successfully in the `try` block, the `finally` block closes the open file.  
  
 [!code[csProgGuideExceptions#11](../VS_csharp/codesnippet/CSharp/exception-handling--csharp-programming-guide-_6.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programmer's Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming](../VS_csharp/csharp-programming-guide.md)   
 [Exceptions and Exception Handling (Visual C#)](../VS_csharp/exceptions-and-exception-handling--csharp-programming-guide-.md)   
 [try-catch (C# Reference)](../VS_csharp/try-catch--csharp-reference-.md)   
 [try-finally (C# Reference)](../VS_csharp/try-finally--csharp-reference-.md)   
 [try-catch-finally (C# Reference)](../VS_csharp/try-catch-finally--csharp-reference-.md)   
 [using Statement (C# Reference)](../VS_csharp/using-statement--csharp-reference-.md)