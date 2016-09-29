---
title: "volatile (C# Reference)"
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
  - "volatile_CSharpKeyword"
  - "volatile"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "volatile keyword [C#]"
ms.assetid: 78089bc7-7b38-4cfd-9e49-87ac036af009
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# volatile (C# Reference)
The `volatile` keyword indicates that a field might be modified by multiple threads that are executing at the same time. Fields that are declared `volatile` are not subject to compiler optimizations that assume access by a single thread. This ensures that the most up-to-date value is present in the field at all times.  
  
 The `volatile` modifier is usually used for a field that is accessed by multiple threads without using the [lock](../vs140/lock-statement--csharp-reference-.md) statement to serialize access.  
  
 The `volatile` keyword can be applied to fields of these types:  
  
-   Reference types.  
  
-   Pointer types (in an unsafe context). Note that although the pointer itself can be volatile, the object that it points to cannot. In other words, you cannot declare a "pointer to volatile."  
  
-   Types such as sbyte, byte, short, ushort, int, uint, char, float, and bool.  
  
-   An enum type with one of the following base types: byte, sbyte, short, ushort, int, or uint.  
  
-   Generic type parameters known to be reference types.  
  
-   <xref:System.IntPtr*> and <xref:System.UIntPtr*>.  
  
 The volatile keyword can only be applied to fields of a class or struct. Local variables cannot be declared `volatile`.  
  
## Example  
 The following example shows how to declare a public field variable as `volatile`.  
  
 [!code[csrefKeywordsModifiers#24](../vs140/codesnippet/CSharp/volatile--csharp-reference-_1.cs)]  
  
## Example  
 The following example demonstrates how an auxiliary or worker thread can be created and used to perform processing in parallel with that of the primary thread. For background information about multithreading, see [Managed Threading](assetId:///7b46a7d9-c6f1-46d1-a947-ae97471bba87) and [Threading (C# and Visual Basic)](../vs140/threading--csharp-and-visual-basic-.md).  
  
 [!code[csProgGuideThreading#1](../vs140/codesnippet/CSharp/volatile--csharp-reference-_2.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Modifiers](../vs140/modifiers--csharp-reference-.md)