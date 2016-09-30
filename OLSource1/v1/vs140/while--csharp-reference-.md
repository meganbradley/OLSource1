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
The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement executes a statement or a block of statements until a specified expression evaluates to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[csrefKeywordsIteration#5](../vs140/codesnippet/CSharp/while--csharp-reference-_1.cs)]  
  
## Example  
 [!code[csrefKeywordsIteration#6](../vs140/codesnippet/CSharp/while--csharp-reference-_2.cs)]  
  
## Example  
 Because the test of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> expression takes place before each execution of the loop, a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> loop executes zero or more times. This differs from the [do](../vs140/do--csharp-reference-.md) loop, which executes one or more times.  
  
 A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> loop can be terminated when a [break](../vs140/break--csharp-reference-.md), [goto](../vs140/goto--csharp-reference-.md), [return](../vs140/return--csharp-reference-.md), or [throw](../vs140/throw--csharp-reference-.md) statement transfers control outside the loop. To pass control to the next iteration without exiting the loop, use the [continue](../vs140/continue--csharp-reference-.md) statement. Notice the difference in output in the three previous examples, depending on where <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is incremented. In the example below no output is generated.  
  
 [!code[csrefKeywordsIteration#7](../vs140/codesnippet/CSharp/while--csharp-reference-_3.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [while Statement (C++)](../vs140/while-statement--c---.md)   
 [Iteration Statements](../vs140/iteration-statements--csharp-reference-.md)