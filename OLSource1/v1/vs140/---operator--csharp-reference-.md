---
title: "&amp;&amp; Operator (C# Reference)"
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
  - "&&_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "&& operator [C#]"
  - "logical AND operator [C#]"
ms.assetid: 2e4f0a1c-92a3-40f8-8e3b-17b607f20c31
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &amp;&amp; Operator (C# Reference)
The conditional-AND operator (`&&`) performs a logical-AND of its `bool` operands, but only evaluates its second operand if necessary.  
  
## Remarks  
 The operation  
  
```  
x && y  
```  
  
 corresponds to the operation  
  
```  
x & y  
```  
  
 except that if `x` is `false`, `y` is not evaluated, because the result of the AND operation is `false` no matter what the value of `y`  is. This is known as "short-circuit" evaluation.  
  
 The conditional-AND operator cannot be overloaded, but overloads of the regular logical operators and operators [true](../vs140/true--csharp-reference-.md) and [false](../vs140/false--csharp-reference-.md) are, with certain restrictions, also considered overloads of the conditional logical operators.  
  
## Example  
 In the following example, the conditional expression in the second `if` statement evaluates only the first operand because the operand returns `false`.  
  
 [!code[csRefOperators#48](../vs140/codesnippet/CSharp/---operator--csharp-reference-_1.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Operators](../vs140/csharp-operators.md)