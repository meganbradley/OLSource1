---
title: "= Operator (C# Reference)"
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
  - "=_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "= operator [C#]"
ms.assetid: d802a6d5-32f0-42b8-b180-12f5a081bfc1
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# = Operator (C# Reference)
The assignment operator (<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>) stores the value of its right-hand operand in the storage location, property, or indexer denoted by its left-hand operand and returns the value as its result. The operands must be of the same type (or the right-hand operand must be implicitly convertible to the type of the left-hand operand).  
  
## Remarks  
 The assignment operator cannot be overloaded. However, you can define implicit conversion operators for a type, which enable you to use the assignment operator with those types. For more information, see [Using Conversion Operators (C# Programming Guide)](../vs140/using-conversion-operators--csharp-programming-guide-.md).  
  
## Example  
 [!code[csRefOperators#49](../vs140/codesnippet/CSharp/=-operator--csharp-reference-_1.cs)]  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Operators](../vs140/csharp-operators.md)