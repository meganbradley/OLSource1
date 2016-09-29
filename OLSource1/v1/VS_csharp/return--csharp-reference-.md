---
title: "return (C# Reference)"
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
  - "return_CSharpKeyword"
  - "return"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "return statement [C#]"
  - "return keyword [C#]"
ms.assetid: 6da6e152-5b58-4448-8f3f-470dd0617ecd
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# return (C# Reference)
The `return` statement terminates execution of the method in which it appears and returns control to the calling method. It can also return an optional value. If the method is a `void` type, the `return` statement can be omitted.  
  
 If the return statement is inside a `try` block, the `finally` block, if one exists, will be executed before control returns to the calling method.  
  
## Example  
 In the following example, the method `A()` returns the variable `Area` as a [double](../VS_csharp/double--csharp-reference-.md) value.  
  
 [!code[csrefKeywordsJump#6](../VS_csharp/codesnippet/CSharp/return--csharp-reference-_1.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [return Statement](../VS_csharp/return-statement--c---.md)   
 [Jump Statements](../VS_csharp/jump-statements--csharp-reference-.md)