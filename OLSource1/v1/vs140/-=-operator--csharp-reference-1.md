---
title: "-= Operator (C# Reference)1"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/= Operator (C# Reference)"
f1_keywords: 
  - "/=_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "division assignment operator (/=) [C#]"
  - "/= (division assignment operator) [C#]"
ms.assetid: 50fc02b0-ee9c-4c3e-b58d-d591282caf1c
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -= Operator (C# Reference)1
The division assignment operator.  
  
## Remarks  
 An expression using the `/=` assignment operator, such as  
  
```  
x /= y  
```  
  
 is equivalent to  
  
```  
x = x / y  
```  
  
 except that `x` is only evaluated once. The [/ operator](../vs140/--operator--csharp-reference-1.md) is predefined for numeric types to perform division.  
  
 The `/=` operator cannot be overloaded directly, but user-defined types can overload the [/ operator](../vs140/--operator--csharp-reference-1.md) (see [operator](../vs140/operator--csharp-reference-2.md)). On all compound assignment operators, overloading the binary operator implicitly overloads the equivalent compound assignment.  
  
## Example  
 [!code[csRefOperators#5](../vs140/codesnippet/CSharp/-=-operator--csharp-reference-1_1.cs)]  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Operators](../vs140/csharp-operators.md)