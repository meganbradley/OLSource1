---
title: "continue (C# Reference)"
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
  - "continue_CSharpKeyword"
  - "continue"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "continue keyword [C#]"
ms.assetid: 8a5ac96f-f98a-4519-b32d-345847ed7be0
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# continue (C# Reference)
The `continue` statement passes control to the next iteration of the enclosing [while](../VS_csharp/while--csharp-reference-.md), [do](../VS_csharp/do--csharp-reference-.md), [for](../VS_csharp/for--csharp-reference-.md), or [foreach](../VS_csharp/foreach--in--csharp-reference-.md) statement in which it appears.  
  
## Example  
 In this example, a counter is initialized to count from 1 to 10. By using the `continue` statement in conjunction with the expression `(i < 9)`, the statements between `continue` and the end of the `for` body are skipped.  
  
 [!code[csrefKeywordsJump#3](../VS_csharp/codesnippet/CSharp/continue--csharp-reference-_1.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [break Statement](../VS_csharp/break-statement--c---.md)   
 [Jump Statements](../VS_csharp/jump-statements--csharp-reference-.md)