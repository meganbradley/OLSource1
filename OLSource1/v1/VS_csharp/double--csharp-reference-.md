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
|`double`|±5.0 × 10<sup>−324</sup> to ±1.7 × 10<sup>308</sup>|15-16 digits|<xref:System.Double?displayProperty=fullName>|  
  
## Literals  
 By default, a real numeric literal on the right side of the assignment operator is treated as `double`. However, if you want an integer number to be treated as `double`, use the suffix d or D, for example:  
  
```  
  
double x = 3D;  
```  
  
## Conversions  
 You can mix numeric integral types and floating-point types in an expression. In this case, the integral types are converted to floating-point types. The evaluation of the expression is performed according to the following rules:  
  
-   If one of the floating-point types is `double`, the expression evaluates to `double`, or [bool](../VS_csharp/bool--csharp-reference-.md) in relational or Boolean expressions.  
  
-   If there is no `double` type in the expression, it evaluates to [float](../VS_csharp/float--csharp-reference-.md), or [bool](../VS_csharp/bool--csharp-reference-.md) in relational or Boolean expressions.  
  
 A floating-point expression can contain the following sets of values:  
  
-   Positive and negative zero.  
  
-   Positive and negative infinity.  
  
-   Not-a-Number value (NaN).  
  
-   The finite set of nonzero values.  
  
 For more information about these values, see IEEE Standard for Binary Floating-Point Arithmetic, available on the [IEEE](http://go.microsoft.com/fwlink/?LinkId=26269) Web site.  
  
## Example  
 In the following example, an [int](../VS_csharp/int--csharp-reference-.md), a [short](../VS_csharp/short--csharp-reference-.md), a [float](../VS_csharp/float--csharp-reference-.md), and a `double` are added together giving a `double` result.  
  
 [!code[csrefKeywordsTypes#9](../VS_csharp/codesnippet/CSharp/double--csharp-reference-_1.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Default Values Table](../VS_csharp/default-values-table--csharp-reference-.md)   
 [Built-in Types Table (Visual C#)](../VS_csharp/built-in-types-table--csharp-reference-.md)   
 [Floating-Point Types Table](../VS_csharp/floating-point-types-table--csharp-reference-.md)   
 [Implicit Numeric Conversions Table](../VS_csharp/implicit-numeric-conversions-table--csharp-reference-.md)   
 [Explicit Numeric Conversions Table (Visual C#)](../VS_csharp/explicit-numeric-conversions-table--csharp-reference-.md)