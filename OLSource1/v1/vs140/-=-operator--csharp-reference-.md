---
title: "&gt;= Operator (C# Reference)"
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
  - ">=_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "greater than or equal to operator (>=) [C#]"
  - ">= operator [C#]"
ms.assetid: 0db4dcaf-56a3-4884-a7ad-35f64978a58d
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &gt;= Operator (C# Reference)
All numeric and enumeration types define a "greater than or equal" relational operator, <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> that returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the first operand is greater than or equal to the second, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> otherwise.  
  
## Remarks  
 User-defined types can overload the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator. For more information, see [operator](../vs140/operator--csharp-reference-2.md). If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is overloaded, [<=](../vs140/-=-operator--csharp-reference-.md) must also be overloaded. Operations on integral types are generally allowed on enumeration.  
  
## Example  
 [!code[csRefOperators#39](../vs140/codesnippet/CSharp/-=-operator--csharp-reference-_1.cs)]  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming](../vs140/csharp-programming-guide.md)   
 [C# Operators](../vs140/csharp-operators.md)