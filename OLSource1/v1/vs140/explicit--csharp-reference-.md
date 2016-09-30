---
title: "explicit (C# Reference)"
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
  - "explicit_CSharpKeyword"
  - "explicit"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "explicit keyword [C#]"
ms.assetid: cfb8f42a-e411-4db2-af9b-796b05644846
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# explicit (C# Reference)
The `explicit` keyword declares a user-defined type conversion operator that must be invoked with a cast. For example, this operator converts from a class called Fahrenheit to a class called Celsius:  
  
 [!code[csrefKeywordsConversion#2](../vs140/codesnippet/CSharp/explicit--csharp-reference-_1.cs)]  
  
 This conversion operator can be invoked like this:  
  
 [!code[csrefKeywordsConversion#3](../vs140/codesnippet/CSharp/explicit--csharp-reference-_2.cs)]  
  
 The conversion operator converts from a source type to a target type. The source type provides the conversion operator. Unlike implicit conversion, explicit conversion operators must be invoked by means of a cast. If a conversion operation can cause exceptions or lose information, you should mark it `explicit`. This prevents the compiler from silently invoking the conversion operation with possibly unforeseen consequences.  
  
 Omitting the cast results in compile-time error CS0266.  
  
 For more information, see [Using Conversion Operators (C#)](../vs140/using-conversion-operators--csharp-programming-guide-.md).  
  
## Example  
 The following example provides a `Fahrenheit` and a `Celsius` class, each of which provides an explicit conversion operator to the other class.  
  
 [!code[csrefKeywordsConversion#1](../vs140/codesnippet/CSharp/explicit--csharp-reference-_3.cs)]  
  
## Example  
 The following example defines a struct, `Digit`, that represents a single decimal digit. An operator is defined for conversions from `byte` to `Digit`, but because not all bytes can be converted to a `Digit`, the conversion is explicit.  
  
 [!code[csrefKeywordsConversion#4](../vs140/codesnippet/CSharp/explicit--csharp-reference-_4.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [implicit](../vs140/implicit--csharp-reference-.md)   
 [operator (C# Reference)](../vs140/operator--csharp-reference-2.md)   
 [How to: Implement User-Defined Conversions Between Structs (C#)](../vs140/how-to--implement-user-defined-conversions-between-structs--csharp-programming-guide-.md)   
 [Chained user-defined explicit conversions in C#](http://go.microsoft.com/fwlink/?LinkId=112384)