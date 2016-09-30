---
title: "Statements (C# Programming Guide)"
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
  - "statements [C#], about statements"
  - "C# language, statements"
ms.assetid: 901bcde7-87de-4e15-833c-f9cfd40c8ce3
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Statements (C# Programming Guide)
The actions that a program takes are expressed in statements. Common actions include declaring variables, assigning values, calling methods, looping through collections, and branching to one or another block of code, depending on a given condition. The order in which statements are executed in a program is called the flow of control or flow of execution. The flow of control may vary every time that a program is run, depending on how the program reacts to input that it receives at run time.  
  
 A statement can consist of a single line of code that ends in a semicolon, or a series of single-line statements in a block. A statement block is enclosed in {} brackets and can contain nested blocks. The following code shows two examples of single-line statements, and a multi-line statement block:  
  
 [!code[csProgGuideStatements#1](../vs140/codesnippet/CSharp/statements--csharp-programming-guide-_1.cs)]  
  
## Types of Statements  
 The following table lists the various types of statements in C# and their associated keywords, with links to topics that include more information:  
  
|Category|C# keywords / notes|  
|--------------|---------------------------|  
|Declaration statements|A declaration statement introduces a new variable or constant. A variable declaration can optionally assign a value to the variable. In a constant declaration, the assignment is required.\<br />\<br /> [!code[csProgGuideStatements#23](../vs140/codesnippet/CSharp/statements--csharp-programming-guide-_2.cs)]|  
|Expression statements|Expression statements that calculate a value must store the value in a variable.\<br />\<br /> [!code[csProgGuideStatements#24](../vs140/codesnippet/CSharp/statements--csharp-programming-guide-_3.cs)]|  
|[Selection statements](../vs140/selection-statements--csharp-reference-.md)|Selection statements enable you to branch to different sections of code, depending on one or more specified conditions. For more information, see the following topics:\<br />\<br /> [if](../vs140/if-else--csharp-reference-.md), [else](../vs140/if-else--csharp-reference-.md), [switch](../vs140/switch--csharp-reference-.md), [case](../vs140/switch--csharp-reference-.md)|  
|[Iteration statements](../vs140/iteration-statements--csharp-reference-.md)|Iteration statements enable you to loop through collections like arrays, or perform the same set of statements repeatedly until a specified condition is met. For more information, see the following topics:\<br />\<br /> [do](../vs140/do--csharp-reference-.md), [for](../vs140/for--csharp-reference-.md), [foreach](../vs140/foreach--in--csharp-reference-.md), [in](../vs140/foreach--in--csharp-reference-.md), [while](../vs140/while--csharp-reference-.md)|  
|[Jump statements](../vs140/jump-statements--csharp-reference-.md)|Jump statements transfer control to another section of code. For more information, see the following topics:\<br />\<br /> [break](../vs140/break--csharp-reference-.md), [continue](../vs140/continue--csharp-reference-.md), [default](../vs140/switch--csharp-reference-.md), [goto](../vs140/goto--csharp-reference-.md), [return](../vs140/return--csharp-reference-.md), [yield](../vs140/yield--csharp-reference-.md)|  
|[Exception handling statements](../vs140/exception-handling-statements--csharp-reference-.md)|Exception handling statements enable you to gracefully recover from exceptional conditions that occur at run time. For more information, see the following topics:\<br />\<br /> [throw](../vs140/throw--csharp-reference-.md), [try-catch](../vs140/try-catch--csharp-reference-.md), [try-finally](../vs140/try-finally--csharp-reference-.md), [try-catch-finally](../vs140/try-catch-finally--csharp-reference-.md)|  
|[Checked and unchecked](../vs140/checked-and-unchecked--csharp-reference-.md)|Checked and unchecked statements enable you to specify whether numerical operations are allowed to cause an overflow when the result is stored in a variable that is too small to hold the resulting value. For more information, see [checked](../vs140/checked--csharp-reference-.md) and [unchecked](../vs140/unchecked--csharp-reference-.md).|  
he `await` statement|If you mark a method with the [async](../vs140/async--csharp-reference-.md) modifier, you can use the [await](../vs140/await--csharp-reference-.md) operator in the method. When control reaches an `await` expression in the async method, control returns to the caller, and progress in the method is suspended until the awaited task completes. When the task is complete, execution can resume in the method.\<br />\<br /> For a simple example, see the "Async Methods" section of [Methods (C# Programming Guide)](../vs140/methods--csharp-programming-guide-.md). For more information, see [Asynchronous Programming with Async and Await (C# and Visual Basic)](../vs140/asynchronous-programming-with-async-and-await--csharp-and-visual-basic-.md).|  
|The `yield return` statement|An iterator performs a custom iteration over a collection, such as a list or an array. An iterator uses the [yield return](../vs140/yield--csharp-reference-.md) statement to return each element one at a time. When a `yield return` statement is reached, the current location in code is remembered. Execution is restarted from that location when the iterator is called the next time.\<br />\<br /> For more information, see [Iterators (C# and Visual Basic)](../vs140/iterators--csharp-and-visual-basic-.md).|  
|The `fixed` statement|The fixed statement prevents the garbage collector from relocating a movable variable. For more information, see [fixed](../vs140/fixed-statement--csharp-reference-.md).|  
|The `lock` statement|The lock statement enables you to limit access to blocks of code to only one thread at a time. For more information, see [lock](../vs140/lock-statement--csharp-reference-.md).|  
|Labeled statements|You can give a statement a label and then use the [goto](../vs140/goto--csharp-reference-.md) keyword to jump to the labeled statement. (See the example in the following row.)|  
|The empty statement|The empty statement consists of a single semicolon. It does nothing and can be used in places where a statement is required but no action needs to be performed. The following examples show two uses for an empty statement:\<br />\<br /> [!code[csProgGuideStatements#25](../vs140/codesnippet/CSharp/statements--csharp-programming-guide-_4.cs)]|  
  
## Embedded Statements  
 Some statements, including [do](../vs140/do--csharp-reference-.md), [while](../vs140/while--csharp-reference-.md), [for](../vs140/for--csharp-reference-.md), and [foreach](../vs140/foreach--in--csharp-reference-.md), always have an embedded statement that follows them. This embedded statement may be either a single statement or multiple statements enclosed by {} brackets in a statement block. Even single-line embedded statements can be enclosed in {} brackets, as shown in the following example:  
  
 [!code[csProgGuideStatements#26](../vs140/codesnippet/CSharp/statements--csharp-programming-guide-_5.cs)]  
  
 An embedded statement that is not enclosed in {} brackets cannot be a declaration statement or a labeled statement. This is shown in the following example:  
  
 [!code[csProgGuideStatements#27](../vs140/codesnippet/CSharp/statements--csharp-programming-guide-_6.cs)]  
  
 Put the embedded statement in a block to fix the error:  
  
 [!code[csProgGuideStatements#28](../vs140/codesnippet/CSharp/statements--csharp-programming-guide-_7.cs)]  
  
## Nested Statement Blocks  
 Statement blocks can be nested, as shown in the following code:  
  
 [!code[csProgGuideStatements#29](../vs140/codesnippet/CSharp/statements--csharp-programming-guide-_8.cs)]  
  
## Unreachable Statements  
 If the compiler determines that the flow of control can never reach a particular statement under any circumstances, it will produce warning CS0162, as shown in the following example:  
  
 [!code[csProgGuideStatements#22](../vs140/codesnippet/CSharp/statements--csharp-programming-guide-_9.cs)]  
  
## Related Sections  
  
-   [Statement Keywords (C# Reference)](../vs140/statement-keywords--csharp-reference-.md)  
  
-   [Expressions (Visual C#)](../vs140/expressions--csharp-programming-guide-.md)  
  
-   [Operators (Visual C#)](../vs140/operators--csharp-programming-guide-.md)  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)