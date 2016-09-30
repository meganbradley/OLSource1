---
title: "^ Operator (C# Reference)"
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
  - "^_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "^ operator [C#]"
  - "bitwise exclusive OR operator [C#]"
ms.assetid: b09bc815-570f-4db6-a637-5b4ed99d014a
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ^ Operator (C# Reference)
Binary <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> operators are predefined for the integral types and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. For integral types, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> computes the bitwise exclusive-OR of its operands. For <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operands, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> computes the logical exclusive-or of its operands; that is, the result is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if and only if exactly one of its operands is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 User-defined types can overload the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> operator (see [operator](../vs140/operator--csharp-reference-2.md)). Operations on integral types are generally allowed on enumeration.  
  
## Example  
 [!code[csRefOperators#30](../vs140/codesnippet/CSharp/^-operator--csharp-reference-_1.cs)]  
  
 The computation of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in the previous example performs a bitwise exclusive-OR of the following two binary values, which correspond to the hexadecimal values F8 and 3F:  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 The result of the exclusive-OR is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, which is C7 in hexadecimal.  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Operators](../vs140/csharp-operators.md)