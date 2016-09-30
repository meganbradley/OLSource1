---
title: "!= Operator (C# Reference)"
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
  - "!=_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "inequality operator (!=) [C#]"
  - "not equals operator (!=) [C#]"
  - "!= operator [C#]"
ms.assetid: eeff7a4e-ad6f-462d-9f8d-49e9b91c6c97
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# != Operator (C# Reference)
The inequality operator (`!=`) returns false if its operands are equal, true otherwise. Inequality operators are predefined for all types, including string and object. User-defined types can overload the `!=` operator.  
  
## Remarks  
 For predefined value types, the inequality operator (`!=`) returns true if the values of its operands are different, false otherwise. For reference types other than `string`, `!=` returns true if its two operands refer to different objects. For the `string` type, `!=` compares the values of the strings.  
  
 User-defined value types can overload the `!=` operator (see [operator](../vs140/operator--csharp-reference-2.md)). So can user-defined reference types, although by default `!=` behaves as described above for both predefined and user-defined reference types. If `!=` is overloaded, [==](../vs140/==-operator--csharp-reference-.md) must also be overloaded. Operations on integral types are generally allowed on enumeration.  
  
## Example  
 [!code[csRefOperators#33](../vs140/codesnippet/CSharp/!=-operator--csharp-reference-_1.cs)]  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Operators](../vs140/csharp-operators.md)