---
title: "operator (C# Reference)2"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "operator (C# Reference)"
f1_keywords: 
  - "operator_CSharpKeyword"
  - "operator"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "operator keyword [C#]"
ms.assetid: 59218cce-e90e-42f6-a6bb-30300981b86a
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator (C# Reference)2
Use the `operator` keyword to overload a built-in operator or to provide a user-defined conversion in a class or struct declaration.  
  
## Example  
 The following is a very simplified class for fractional numbers. It overloads the + and * operators to perform fractional addition and multiplication, and also provides a conversion operator that converts a Fraction type to a double type.  
  
 [!code[csrefKeywordsConversion#6](../VS_csharp/codesnippet/CSharp/operator--csharp-reference-2_1.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [implicit](../VS_csharp/implicit--csharp-reference-.md)   
 [explicit](../VS_csharp/explicit--csharp-reference-.md)   
 [How to: Implement User-Defined Conversions Between Structs (C#)](../VS_csharp/how-to--implement-user-defined-conversions-between-structs--csharp-programming-guide-.md)