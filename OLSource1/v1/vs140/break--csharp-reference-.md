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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# break (C# Reference)
The `break` statement terminates the closest enclosing loop or [switch](../vs140/switch--csharp-reference-.md) statement in which it appears. Control is passed to the statement that follows the terminated statement, if any.  
  
## Example  
 In this example, the conditional statement contains a counter that is supposed to count from 1 to 100; however, the `break` statement terminates the loop after 4 counts.  
  
 [!code[csrefKeywordsJump#1](../vs140/codesnippet/CSharp/break--csharp-reference-_1.cs)]  
  
## Example  
 In this example, the `break` statement is used to break out of an inner nested loop, and return control to the outer loop.  
  
 [!code[csrefKeywordsJump#7](../vs140/codesnippet/CSharp/break--csharp-reference-_2.cs)]  
  
## Example  
 This example demonstrates the use of `break` in a [switch](../vs140/switch--csharp-reference-.md) statement.  
  
 [!code[csrefKeywordsJump#2](../vs140/codesnippet/CSharp/break--csharp-reference-_3.cs)]  
  
 If you entered `4`, the output would be:  
  
```  
Enter your selection (1, 2, or 3): 4  
Sorry, invalid selection.  
```  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [switch](../vs140/switch--csharp-reference-.md)   
 [Jump Statements](../vs140/jump-statements--csharp-reference-.md)   
 [Iteration Statements (C# Reference)](../vs140/iteration-statements--csharp-reference-.md)