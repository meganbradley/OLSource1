---
title: "goto (C# Reference)"
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
  - "goto_CSharpKeyword"
  - "goto"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "goto keyword [C#]"
ms.assetid: 2c03c9c1-8119-44ef-b740-fb3d287a42fe
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
# goto (C# Reference)
The `goto` statement transfers the program control directly to a labeled statement.  
  
 A common use of `goto` is to transfer control to a specific switch-case label or the default label in a `switch` statement.  
  
 The `goto` statement is also useful to get out of deeply nested loops.  
  
## Example  
 The following example demonstrates using `goto` in a [switch](../VS_csharp/switch--csharp-reference-.md) statement.  
  
 [!code[csrefKeywordsJump#4](../VS_csharp/codesnippet/CSharp/goto--csharp-reference-_1.cs)]  
  
## Example  
 The following example demonstrates using `goto` to break out from nested loops.  
  
 [!code[csrefKeywordsJump#5](../VS_csharp/codesnippet/CSharp/goto--csharp-reference-_2.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [goto Statement](../Topic/goto%20Statement%20\(C++\).md)   
 [Jump Statements](../VS_csharp/jump-statements--csharp-reference-.md)