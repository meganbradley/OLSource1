---
title: "Arithmetic Operations on Pointers (C# Programming Guide)"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "pointers [C#], arithmetic operations"
ms.assetid: d4f0b623-827e-45ce-8649-cfcebc8692aa
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
# Arithmetic Operations on Pointers (C# Programming Guide)
This topic discusses using the arithmetic operators `+` and **-** to manipulate pointers.  
  
> [!NOTE]
>  You cannot perform any arithmetic operations on void pointers.  
  
## Adding and Subtracting Numeric Values to or From Pointers  
 You can add a value `n` of type [int](../VS_csharp/int--csharp-reference-.md), [uint](../VS_csharp/uint--csharp-reference-.md), [long](../VS_csharp/long--csharp-reference-.md), or [ulong](../VS_csharp/ulong--csharp-reference-.md) to a pointer, `p`,of any type except `void*`. The result `p+n` is the pointer resulting from adding `n * sizeof(p) to the address of p`. Similarly, `p-n` is the pointer resulting from subtracting `n * sizeof(p)` from the address of `p`.  
  
## Subtracting Pointers  
 You can also subtract pointers of the same type. The result is always of the type `long`. For example, if `p1` and `p2` are pointers of the type `pointer-type*`, then the expression `p1-p2` results in:  
  
 `((long)p1 - (long)p2)/sizeof(pointer_type)`  
  
 No exceptions are generated when the arithmetic operation overflows the domain of the pointer, and the result depends on the implementation.  
  
## Example  
 [!code[csProgGuidePointers#14](../VS_csharp/codesnippet/CSharp/arithmetic-operations-on-pointers--csharp-programming-guide-_1.cs)]  
  
 [!code[csProgGuidePointers#15](../VS_csharp/codesnippet/CSharp/arithmetic-operations-on-pointers--csharp-programming-guide-_2.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Unsafe Code and Pointers](../VS_csharp/unsafe-code-and-pointers--csharp-programming-guide-.md)   
 [Pointer Expressions](../VS_csharp/pointer-expressions--csharp-programming-guide-.md)   
 [C# Operators](../VS_csharp/csharp-operators.md)   
 [Manipulating Pointers](../VS_csharp/manipulating-pointers--csharp-programming-guide-.md)   
 [Pointer types](../VS_csharp/pointer-types--csharp-programming-guide-.md)   
 [Types](../VS_csharp/types--csharp-reference-.md)   
 [unsafe](../VS_csharp/unsafe--csharp-reference-.md)   
 [fixed Statement](../VS_csharp/fixed-statement--csharp-reference-.md)   
 [stackalloc](../VS_csharp/stackalloc--csharp-reference-.md)