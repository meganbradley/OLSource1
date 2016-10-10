---
title: "% Operator (C# Reference)"
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
  - "%_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "modulus operator [C#]"
  - "% operator [C#]"
ms.assetid: 3b74f4f9-fd9c-45e7-84fa-c8d71a0dfad7
caps.latest.revision: 15
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
# % Operator (C# Reference)
The `%` operator computes the remainder after dividing its first operand by its second. All numeric types have predefined remainder operators.  
  
## Remarks  
 User-defined types can overload the `%` operator (see [operator](../VS_csharp/operator--csharp-reference-2.md)). When a binary operator is overloaded, the corresponding assignment operator, if any, is also implicitly overloaded.  
  
## Example  
 [!code[csRefOperators#9](../VS_csharp/codesnippet/CSharp/--operator--csharp-reference-_1.cs)]  
  
## Comments  
 Note the round-off errors associated with the double type.  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Operators](../VS_csharp/csharp-operators.md)