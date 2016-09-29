---
title: "- Operator (C# Reference)1"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/ Operator (C# Reference)"
f1_keywords: 
  - "/_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "/ operator [C#]"
  - "division operator [C#]"
ms.assetid: d155e496-678f-4efa-bebe-2bd08da2c5af
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# - Operator (C# Reference)1
The division operator (`/`) divides its first operand by its second operand. All numeric types have predefined division operators.  
  
## Remarks  
 User-defined types can overload the `/` operator (see [operator](../vs140/operator--csharp-reference-2.md)). An overload of the `/` operator implicitly overloads the [/= operator](../vs140/-=-operator--csharp-reference-1.md).  
  
 When you divide two integers, the result is always an integer. For example, the result of 7 / 3 is 2. To determine the remainder of 7 / 3, use the remainder operator ([%](../vs140/--operator--csharp-reference-.md)). To obtain a quotient as a rational number or fraction, give the dividend or divisor type `float` or type `double`. You can assign the type implicitly if you express the dividend or divisor as a decimal by putting a digit to the right side of the decimal point, as the following example shows.  
  
## Example  
 [!code[csRefOperators#42](../vs140/codesnippet/CSharp/--operator--csharp-reference-1_1.cs)]  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Operators](../vs140/csharp-operators.md)