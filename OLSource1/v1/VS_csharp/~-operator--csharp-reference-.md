---
title: "~ Operator (C# Reference)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 18
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# ~ Operator (C# Reference)
The `~` operator performs a bitwise complement operation on its operand, which has the effect of reversing each bit. Bitwise complement operators are predefined for [int](../VS_csharp/int--csharp-reference-.md), [uint](../VS_csharp/uint--csharp-reference-.md), [long](../VS_csharp/long--csharp-reference-.md), and [ulong](../VS_csharp/ulong--csharp-reference-.md).  
  
> [!NOTE]
>  The `~` symbol also is used to declare destructors. For more information, see [Destructors](../VS_csharp/destructors--csharp-programming-guide-.md).  
  
## Remarks  
 User-defined types can overload the `~` operator. For more information, see [operator](../VS_csharp/operator--csharp-reference-2.md). Operations on integral types are generally allowed on enumeration.  
  
## Example  
 [!code[csRefOperators#25](../VS_csharp/codesnippet/CSharp/~-operator--csharp-reference-_1.cs)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Operators](../VS_csharp/csharp-operators.md)   
 [Destructors](../VS_csharp/destructors--csharp-programming-guide-.md)