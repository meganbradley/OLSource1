---
title: "bool (C# Reference)"
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
  - "bool_CSharpKeyword"
  - "bool"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "bool keyword [C#]"
ms.assetid: 551cfe35-2632-4343-af49-33ad12da08e2
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bool (C# Reference)
The `bool` keyword is an alias of <xref:System.Boolean*?displayProperty=fullName>. It is used to declare variables to store the Boolean values, [true](../VS_csharp/true--csharp-reference-.md) and [false](../VS_csharp/false--csharp-reference-.md).  
  
> [!NOTE]
>  If you require a Boolean variable that can also have a value of `null`, use `bool?`. For more information, see [Nullable Types (C# Programmer's Reference)](../VS_csharp/nullable-types--csharp-programming-guide-.md).  
  
## Literals  
 You can assign a Boolean value to a `bool` variable. You can also assign an expression that evaluates to `bool` to a `bool` variable.  
  
 [!code[csrefKeywordsTypes#1](../VS_csharp/codesnippet/CSharp/bool--csharp-reference-_1.cs)]  
  
 The default value of a `bool` variable is `false`. The default value of a `bool?` variable is `null`.  
  
## Conversions  
 In C++, a value of type `bool` can be converted to a value of type `int`; in other words, `false` is equivalent to zero and `true` is equivalent to nonzero values. In C#, there is no conversion between the `bool` type and other types. For example, the following `if` statement is invalid in C#:  
  
 [!code[csrefKeywordsTypes#2](../VS_csharp/codesnippet/CSharp/bool--csharp-reference-_2.cs)]  
  
 To test a variable of the type `int`, you have to explicitly compare it to a value, such as zero, as follows:  
  
 [!code[csrefKeywordsTypes#3](../VS_csharp/codesnippet/CSharp/bool--csharp-reference-_3.cs)]  
  
## Example  
 In this example, you enter a character from the keyboard and the program checks if the input character is a letter. If it is a letter, it checks if it is lowercase or uppercase. These checks are performed with the <xref:System.Char.IsLetter*>, and <xref:System.Char.IsLower*>, both of which return the `bool` type:  
  
 [!code[csrefKeywordsTypes#4](../VS_csharp/codesnippet/CSharp/bool--csharp-reference-_4.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Integral Types Table](../VS_csharp/integral-types-table--csharp-reference-.md)   
 [Built-in Types Table (C#)](../VS_csharp/built-in-types-table--csharp-reference-.md)   
 [Implicit Numeric Conversions Table](../VS_csharp/implicit-numeric-conversions-table--csharp-reference-.md)   
 [Explicit Numeric Conversions Table (C#)](../VS_csharp/explicit-numeric-conversions-table--csharp-reference-.md)