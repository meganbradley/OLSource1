---
title: "char (C# Reference)"
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
  - "char"
  - "char_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "char data type [C#]"
ms.assetid: b51cf4fb-124c-4067-af48-afbac122b228
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char (C# Reference)
The `char` keyword is used to declare an instance of the <xref:System.Char*?displayProperty=fullName> structure that the .NET Framework uses to represent a Unicode character. The value of a `Char` object is a 16-bit numeric (ordinal) value.  
  
 Unicode characters are used to represent most of the written languages throughout the world.  
  
|Type|Range|Size|.NET Framework type|  
|----------|-----------|----------|-------------------------|  
|`char`|U+0000 to U+FFFF|Unicode 16-bit character|<xref:System.Char*?displayProperty=fullName>|  
  
## Literals  
 Constants of the `char` type can be written as character literals, hexadecimal escape sequence, or Unicode representation. You can also cast the integral character codes. In the following example four `char` variables are initialized with the same character `X`:  
  
 [!code[csrefKeywordsTypes#19](../VS_csharp/codesnippet/CSharp/char--csharp-reference-_1.cs)]  
  
## Conversions  
 A `char` can be implicitly converted to [ushort](../VS_csharp/ushort--csharp-reference-.md), [int](../VS_csharp/int--csharp-reference-.md), [uint](../VS_csharp/uint--csharp-reference-.md), [long](../VS_csharp/long--csharp-reference-.md), [ulong](../VS_csharp/ulong--csharp-reference-.md), [float](../VS_csharp/float--csharp-reference-.md), [double](../VS_csharp/double--csharp-reference-.md), or [decimal](../VS_csharp/decimal--csharp-reference-.md). However, there are no implicit conversions from other types to the `char` type.  
  
 The <xref:System.Char*?displayProperty=fullName> type provides several static methods for working with `char` values.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 <xref:System.Char*>   
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Integral Types Table](../VS_csharp/integral-types-table--csharp-reference-.md)   
 [Built-in Types Table (Visual C#)](../VS_csharp/built-in-types-table--csharp-reference-.md)   
 [Implicit Numeric Conversions Table](../VS_csharp/implicit-numeric-conversions-table--csharp-reference-.md)   
 [Explicit Numeric Conversions Table (Visual C#)](../VS_csharp/explicit-numeric-conversions-table--csharp-reference-.md)   
 [Nullable Types (C# Programming Guide)](../VS_csharp/nullable-types--csharp-programming-guide-.md)   
 [String Basics (C# Programming Guide)](../VS_csharp/strings--csharp-programming-guide-.md)