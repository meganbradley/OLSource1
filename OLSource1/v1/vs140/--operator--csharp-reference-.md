---
title: "&gt; Operator (C# Reference)"
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
  - ">_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "> operator [C#]"
  - "greater than operator (>) [C#]"
ms.assetid: 26d3cb69-9c0b-4cc5-858b-5be1abd6659d
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &gt; Operator (C# Reference)
All numeric and enumeration types define a "greater than" relational operator (<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>) that returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the first operand is greater than the second, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> otherwise.  
  
## Remarks  
 User-defined types can overload the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator (see [operator](../vs140/operator--csharp-reference-2.md)). If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is overloaded, [<](../vs140/--operator--csharp-reference-.md) must also be overloaded. When a binary operator is overloaded, the corresponding assignment operator, if any, is also implicitly overloaded.  
  
## Example  
 [!code[csRefOperators#29](../vs140/codesnippet/CSharp/--operator--csharp-reference-_1.cs)]  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Operators](../vs140/csharp-operators.md)   
 [explicit](../vs140/explicit--csharp-reference-.md)