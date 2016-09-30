---
title: "Arithmetic Operations on Pointers (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
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
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Arithmetic Operations on Pointers (C# Programming Guide)
This topic discusses using the arithmetic operators `+` and **-** to manipulate pointers.  
  
> [!NOTE]
>  You cannot perform any arithmetic operations on void pointers.  
  
## Adding and Subtracting Numeric Values to or From Pointers  
 You can add a value `n` of type [int](../vs140/int--csharp-reference-.md), [uint](../vs140/uint--csharp-reference-.md), [long](../vs140/long--csharp-reference-.md), or [ulong](../vs140/ulong--csharp-reference-.md) to a pointer, `p`,of any type except `void*`. The result `p+n` is the pointer resulting from adding `n * sizeof(p) to the address of p`. Similarly, `p-n` is the pointer resulting from subtracting `n * sizeof(p)` from the address of `p`.  
  
## Subtracting Pointers  
 You can also subtract pointers of the same type. The result is always of the type `long`. For example, if `p1` and `p2` are pointers of the type `pointer-type*`, then the expression `p1-p2` results in:  
  
 `((long)p1 - (long)p2)/sizeof(pointer_type)`  
  
 No exceptions are generated when the arithmetic operation overflows the domain of the pointer, and the result depends on the implementation.  
  
## Example  
 [!code[csProgGuidePointers#14](../vs140/codesnippet/CSharp/arithmetic-operations-on-pointers--csharp-programming-guide-_1.cs)]  
  
 [!code[csProgGuidePointers#15](../vs140/codesnippet/CSharp/arithmetic-operations-on-pointers--csharp-programming-guide-_2.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Unsafe Code and Pointers (C# Programming Guide)](../vs140/unsafe-code-and-pointers--csharp-programming-guide-.md)   
 [Pointer Expressions](../vs140/pointer-expressions--csharp-programming-guide-.md)   
 [C# Operators](../vs140/csharp-operators.md)   
 [Manipulating Pointers](../vs140/manipulating-pointers--csharp-programming-guide-.md)   
 [Pointer types](../vs140/pointer-types--csharp-programming-guide-.md)   
 [Types](../vs140/types--csharp-reference-.md)   
 [unsafe](../vs140/unsafe--csharp-reference-.md)   
 [fixed Statement](../vs140/fixed-statement--csharp-reference-.md)   
 [stackalloc](../vs140/stackalloc--csharp-reference-.md)