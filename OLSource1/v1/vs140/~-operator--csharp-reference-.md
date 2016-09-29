---
title: "~ Operator (C# Reference)"
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
  - "~_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "tilde (~) one's complement operator [C#]"
  - "~ operator [C#]"
  - "~ [C#], bitwise complement operator"
  - "bitwise complement operator [C#]"
ms.assetid: 11bc078a-50e2-4d7e-9896-67ef669dc602
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ~ Operator (C# Reference)
The `~` operator performs a bitwise complement operation on its operand, which has the effect of reversing each bit. Bitwise complement operators are predefined for [int](../vs140/int--csharp-reference-.md), [uint](../vs140/uint--csharp-reference-.md), [long](../vs140/long--csharp-reference-.md), and [ulong](../vs140/ulong--csharp-reference-.md).  
  
> [!NOTE]
>  The `~` symbol also is used to declare destructors. For more information, see [Destructors (C# Programming Guide)](../vs140/destructors--csharp-programming-guide-.md).  
  
## Remarks  
 User-defined types can overload the `~` operator. For more information, see [operator](../vs140/operator--csharp-reference-2.md). Operations on integral types are generally allowed on enumeration.  
  
## Example  
 [!code[csRefOperators#25](../vs140/codesnippet/CSharp/~-operator--csharp-reference-_1.cs)]  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Operators](../vs140/csharp-operators.md)   
 [Destructors (C# Programming Guide)](../vs140/destructors--csharp-programming-guide-.md)