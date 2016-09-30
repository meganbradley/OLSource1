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
The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> keyword is used to declare an instance of the \<xref:System.Char*?displayProperty=fullName> structure that the .NET Framework uses to represent a Unicode character. The value of a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object is a 16-bit numeric (ordinal) value.  
  
 Unicode characters are used to represent most of the written languages throughout the world.  
  
|Type|Range|Size|.NET Framework type|  
|----------|-----------|----------|-------------------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|U+0000 to U+FFFF|Unicode 16-bit character|\<xref:System.Char*?displayProperty=fullName>|  
  
## Literals  
 Constants of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> type can be written as character literals, hexadecimal escape sequence, or Unicode representation. You can also cast the integral character codes. In the following example four <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> variables are initialized with the same character <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>:  
  
 [!code[csrefKeywordsTypes#19](../vs140/codesnippet/CSharp/char--csharp-reference-_1.cs)]  
  
## Conversions  
 A <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> can be implicitly converted to [ushort](../vs140/ushort--csharp-reference-.md), [int](../vs140/int--csharp-reference-.md), [uint](../vs140/uint--csharp-reference-.md), [long](../vs140/long--csharp-reference-.md), [ulong](../vs140/ulong--csharp-reference-.md), [float](../vs140/float--csharp-reference-.md), [double](../vs140/double--csharp-reference-.md), or [decimal](../vs140/decimal--csharp-reference-.md). However, there are no implicit conversions from other types to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> type.  
  
 The \<xref:System.Char*?displayProperty=fullName> type provides several static methods for working with <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> values.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 \<xref:System.Char*>   
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Integral Types Table](../vs140/integral-types-table--csharp-reference-.md)   
 [Built-in Types Table (Visual C#)](../vs140/built-in-types-table--csharp-reference-.md)   
 [Implicit Numeric Conversions Table](../vs140/implicit-numeric-conversions-table--csharp-reference-.md)   
 [Explicit Numeric Conversions Table (Visual C#)](../vs140/explicit-numeric-conversions-table--csharp-reference-.md)   
 [Nullable Types (C# Programming Guide)](../vs140/nullable-types--csharp-programming-guide-.md)   
 [String Basics (C# Programming Guide)](../vs140/strings--csharp-programming-guide-.md)