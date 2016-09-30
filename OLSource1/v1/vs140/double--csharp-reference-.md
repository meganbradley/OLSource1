---
title: "double (C# Reference)"
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
  - "double"
  - "double_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "double data type [C#]"
ms.assetid: 0980e11b-6004-4102-abcf-cfc280fc6991
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# double (C# Reference)
The `double` keyword signifies a simple type that stores 64-bit floating-point values. The following table shows the precision and approximate range for the `double` type.  
  
|Type|Approximate range|Precision|.NET Framework type|  
|----------|-----------------------|---------------|-------------------------|  
|`double`|±5.0 × 10<sup>−324</sup> to ±1.7 × 10<sup>308</sup>|15-16 digits|\<xref:System.Double?displayProperty=fullName>|  
  
## Literals  
 By default, a real numeric literal on the right side of the assignment operator is treated as `double`. However, if you want an integer number to be treated as `double`, use the suffix d or D, for example:  
  
```  
  
double x = 3D;  
```  
  
## Conversions  
 You can mix numeric integral types and floating-point types in an expression. In this case, the integral types are converted to floating-point types. The evaluation of the expression is performed according to the following rules:  
  
-   If one of the floating-point types is `double`, the expression evaluates to `double`, or [bool](../vs140/bool--csharp-reference-.md) in relational or Boolean expressions.  
  
-   If there is no `double` type in the expression, it evaluates to [float](../vs140/float--csharp-reference-.md), or [bool](../vs140/bool--csharp-reference-.md) in relational or Boolean expressions.  
  
 A floating-point expression can contain the following sets of values:  
  
-   Positive and negative zero.  
  
-   Positive and negative infinity.  
  
-   Not-a-Number value (NaN).  
  
-   The finite set of nonzero values.  
  
 For more information about these values, see IEEE Standard for Binary Floating-Point Arithmetic, available on the [IEEE](http://go.microsoft.com/fwlink/?LinkId=26269) Web site.  
  
## Example  
 In the following example, an [int](../vs140/int--csharp-reference-.md), a [short](../vs140/short--csharp-reference-.md), a [float](../vs140/float--csharp-reference-.md), and a `double` are added together giving a `double` result.  
  
 [!code[csrefKeywordsTypes#9](../vs140/codesnippet/CSharp/double--csharp-reference-_1.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Default Values Table](../vs140/default-values-table--csharp-reference-.md)   
 [Built-in Types Table (Visual C#)](../vs140/built-in-types-table--csharp-reference-.md)   
 [Floating-Point Types Table](../vs140/floating-point-types-table--csharp-reference-.md)   
 [Implicit Numeric Conversions Table](../vs140/implicit-numeric-conversions-table--csharp-reference-.md)   
 [Explicit Numeric Conversions Table (Visual C#)](../vs140/explicit-numeric-conversions-table--csharp-reference-.md)