---
title: "break (C# Reference)"
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
  - "break"
  - "break_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "break keyword [C#]"
ms.assetid: be2571ed-efb0-4965-b122-81e5b09db0b9
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# break (C# Reference)
The `break` statement terminates the closest enclosing loop or [switch](../VS_csharp/switch--csharp-reference-.md) statement in which it appears. Control is passed to the statement that follows the terminated statement, if any.  
  
## Example  
 In this example, the conditional statement contains a counter that is supposed to count from 1 to 100; however, the `break` statement terminates the loop after 4 counts.  
  
 [!code[csrefKeywordsJump#1](../VS_csharp/codesnippet/CSharp/break--csharp-reference-_1.cs)]  
  
## Example  
 In this example, the `break` statement is used to break out of an inner nested loop, and return control to the outer loop.  
  
 [!code[csrefKeywordsJump#7](../VS_csharp/codesnippet/CSharp/break--csharp-reference-_2.cs)]  
  
## Example  
 This example demonstrates the use of `break` in a [switch](../VS_csharp/switch--csharp-reference-.md) statement.  
  
 [!code[csrefKeywordsJump#2](../VS_csharp/codesnippet/CSharp/break--csharp-reference-_3.cs)]  
  
 If you entered `4`, the output would be:  
  
```  
Enter your selection (1, 2, or 3): 4  
Sorry, invalid selection.  
```  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [switch](../VS_csharp/switch--csharp-reference-.md)   
 [Jump Statements](../VS_csharp/jump-statements--csharp-reference-.md)   
 [Iteration Statements (C# Reference)](../VS_csharp/iteration-statements--csharp-reference-.md)