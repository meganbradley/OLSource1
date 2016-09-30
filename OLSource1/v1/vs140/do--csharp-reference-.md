---
title: "do (C# Reference)"
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
  - "do_CSharpKeyword"
  - "do"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "do keyword [C#]"
ms.assetid: 50725f79-9ba6-4898-aa78-6e331568a1bb
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# do (C# Reference)
The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement executes a statement or a block of statements repeatedly until a specified expression evaluates to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. The body of the loop must be enclosed in braces, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, unless it consists of a single statement. In that case, the braces are optional.  
  
## Example  
 In the following example, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> loop statements execute as long as the variable <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is less than 5.  
  
 [!code[csrefKeywordsIteration#1](../vs140/codesnippet/CSharp/do--csharp-reference-_1.cs)]  
  
 Unlike the [while](../vs140/while--csharp-reference-.md) statement, a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> loop is executed one time before the conditional expression is evaluated.  
  
 At any point in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> block, you can break out of the loop using the [break](../vs140/break--csharp-reference-.md) statement. You can step directly to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> expression evaluation statement by using the [continue](../vs140/continue--csharp-reference-.md) statement. If the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> expression evaluates to true, execution continues at the first statement in the loop. If the expression evaluates to false, execution continues at the first statement after the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> loop.  
  
 A <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> loop can also be exited by the [goto](../vs140/goto--csharp-reference-.md), [return](../vs140/return--csharp-reference-.md), or [throw](../vs140/throw--csharp-reference-.md) statements.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [do-while Statement (C++)](../vs140/do-while-statement--c---.md)   
 [Iteration Statements](../vs140/iteration-statements--csharp-reference-.md)