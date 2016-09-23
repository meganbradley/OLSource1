---
title: "- Operator (C# Reference)2"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
H1: - Operator (C# Reference)
f1_keywords: 
  - -_CSharpKeyword
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - - operator [C#]
  - subtraction operator (-) [C#]
ms.assetid: 4de7a4fa-c69d-48e6-aff1-3130af970b2d
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# - Operator (C# Reference)2
The `-` operator can function as either a unary or a binary operator.  
  
## Remarks  
 Unary `-` operators are predefined for all numeric types. The result of a unary `-` operation on a numeric type is the numeric negation of the operand.  
  
 Binary `-` operators are predefined for all numeric and enumeration types to subtract the second operand from the first.  
  
 Delegate types also provide a binary `-` operator, which performs delegate removal.  
  
 User-defined types can overload the unary `-` and binary `-` operators. For more information, see [operator (C# Reference)](../vs140/operator--csharp-reference-2.md).  
  
## Example  
 [!code[csRefOperators#40](../vs140/codesnippet/CSharp/--operator--csharp-reference-2_1.cs)]
  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming](../vs140/csharp-programming-guide.md)   
 [C# Operators](../vs140/csharp-operators.md)