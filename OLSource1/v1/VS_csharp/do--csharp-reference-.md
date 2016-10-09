---
title: "do (C# Reference)"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "do_CSharpKeyword"
  - "do"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "do keyword [C#]"
ms.assetid: 50725f79-9ba6-4898-aa78-6e331568a1bb
caps.latest.revision: 22
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# do (C# Reference)
The `do` statement executes a statement or a block of statements repeatedly until a specified expression evaluates to `false`. The body of the loop must be enclosed in braces, `{}`, unless it consists of a single statement. In that case, the braces are optional.  
  
## Example  
 In the following example, the `do-while` loop statements execute as long as the variable `x` is less than 5.  
  
 [!code[csrefKeywordsIteration#1](../VS_csharp/codesnippet/CSharp/do--csharp-reference-_1.cs)]  
  
 Unlike the [while](../VS_csharp/while--csharp-reference-.md) statement, a `do-while` loop is executed one time before the conditional expression is evaluated.  
  
 At any point in the `do-while` block, you can break out of the loop using the [break](../VS_csharp/break--csharp-reference-.md) statement. You can step directly to the `while` expression evaluation statement by using the [continue](../VS_csharp/continue--csharp-reference-.md) statement. If the `while` expression evaluates to true, execution continues at the first statement in the loop. If the expression evaluates to false, execution continues at the first statement after the `do-while` loop.  
  
 A `do-while` loop can also be exited by the [goto](../VS_csharp/goto--csharp-reference-.md), [return](../VS_csharp/return--csharp-reference-.md), or [throw](../VS_csharp/throw--csharp-reference-.md) statements.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [do-while Statement (C++)](../Topic/do-while%20Statement%20\(C++\).md)   
 [Iteration Statements](../VS_csharp/iteration-statements--csharp-reference-.md)