---
title: "== Operator (C# Reference)"
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
  - "==_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "== operator [C#]"
  - "equality operator [C#]"
ms.assetid: 34c6b597-caa2-4855-a7cd-38ecdd11bd07
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# == Operator (C# Reference)
For predefined value types, the equality operator (`==`) returns true if the values of its operands are equal, `false` otherwise. For reference types other than [string](../vs140/string--csharp-reference-.md), `==` returns `true` if its two operands refer to the same object. For the `string` type, `==` compares the values of the strings.  
  
## Remarks  
 User-defined value types can overload the `==` operator (see [operator](../vs140/operator--csharp-reference-2.md)). So can user-defined reference types, although by default `==` behaves as described above for both predefined and user-defined reference types. If `==` is overloaded, [!=](../vs140/!=-operator--csharp-reference-.md) must also be overloaded. Operations on integral types are generally allowed on enumeration.  
  
## Example  
 [!code[csRefOperators#36](../vs140/codesnippet/CSharp/==-operator--csharp-reference-_1.cs)]  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Operators](../vs140/csharp-operators.md)