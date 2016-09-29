---
title: "while (C# Reference)"
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
  - "while_CSharpKeyword"
  - "while"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "while keyword [C#]"
ms.assetid: 72a0765c-6852-4aca-b327-4a11cb7f5c59
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# while (C# Reference)
The `while` statement executes a statement or a block of statements until a specified expression evaluates to `false`.  
  
## Example  
 [!code[csrefKeywordsIteration#5](../VS_csharp/codesnippet/CSharp/while--csharp-reference-_1.cs)]  
  
## Example  
 [!code[csrefKeywordsIteration#6](../VS_csharp/codesnippet/CSharp/while--csharp-reference-_2.cs)]  
  
## Example  
 Because the test of the `while` expression takes place before each execution of the loop, a `while` loop executes zero or more times. This differs from the [do](../VS_csharp/do--csharp-reference-.md) loop, which executes one or more times.  
  
 A `while` loop can be terminated when a [break](../VS_csharp/break--csharp-reference-.md), [goto](../VS_csharp/goto--csharp-reference-.md), [return](../VS_csharp/return--csharp-reference-.md), or [throw](../VS_csharp/throw--csharp-reference-.md) statement transfers control outside the loop. To pass control to the next iteration without exiting the loop, use the [continue](../VS_csharp/continue--csharp-reference-.md) statement. Notice the difference in output in the three previous examples, depending on where `int n` is incremented. In the example below no output is generated.  
  
 [!code[csrefKeywordsIteration#7](../VS_csharp/codesnippet/CSharp/while--csharp-reference-_3.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [while Statement (C++)](../VS_csharp/while-statement--c---.md)   
 [Iteration Statements](../VS_csharp/iteration-statements--csharp-reference-.md)