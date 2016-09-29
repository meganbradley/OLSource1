---
title: "Operator (C# Reference)1"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Operator (C# Reference)"
f1_keywords: 
  - "[]_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "subscript operator [C#]"
  - "square brackets [ ] operator [C#]"
  - "[] operator [C#]"
  - "indexing operator [C#]"
ms.assetid: 5c16bb45-88f7-45ff-b42c-1af1972b042c
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operator (C# Reference)1
Square brackets (`[]`) are used for arrays, indexers, and attributes. They can also be used with pointers.  
  
## Remarks  
 An array type is a type followed by `[]`:  
  
 [!code[csRefOperators#43](../VS_csharp/codesnippet/CSharp/operator--csharp-reference-1_1.cs)]  
  
 To access an element of an array, the index of the desired element is enclosed in brackets:  
  
 [!code[csRefOperators#44](../VS_csharp/codesnippet/CSharp/operator--csharp-reference-1_2.cs)]  
  
 An exception is thrown if an array index is out of range.  
  
 The array indexing operator cannot be overloaded; however, types can define indexers, and properties that take one or more parameters. Indexer parameters are enclosed in square brackets, just like array indexes, but indexer parameters can be declared to be of any type, unlike array indexes, which must be integral.  
  
 For example, the .NET Framework defines a `Hashtable` type that associates keys and values of arbitrary type:  
  
 [!code[csRefOperators#45](../VS_csharp/codesnippet/CSharp/operator--csharp-reference-1_3.cs)]  
  
 Square brackets are also used to specify [Attributes (C#)](../VS_csharp/attributes--csharp-and-visual-basic-.md):  
  
 [!code[csRefOperators#46](../VS_csharp/codesnippet/CSharp/operator--csharp-reference-1_4.cs)]  
  
 You can use square brackets to index off a pointer:  
  
 [!code[csRefOperators#47](../VS_csharp/codesnippet/CSharp/operator--csharp-reference-1_5.cs)]  
  
 No bounds checking is performed.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programmer's Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Operators](../VS_csharp/csharp-operators.md)   
 [Arrays (Visual C#)](../VS_csharp/arrays--csharp-programming-guide-.md)   
 [Indexers](../VS_csharp/indexers--csharp-programming-guide-.md)   
 [unsafe](../VS_csharp/unsafe--csharp-reference-.md)   
 [fixed Statement](../VS_csharp/fixed-statement--csharp-reference-.md)