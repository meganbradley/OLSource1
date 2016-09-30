---
title: "float (C# Reference)"
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
  - "float"
  - "float_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "float keyword [C#]"
  - "floating-point numbers [C#], float keyword"
ms.assetid: 1e77db7b-dedb-48b7-8dd1-b055e96a9258
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# float (C# Reference)
The `float` keyword signifies a simple type that stores 32-bit floating-point values. The following table shows the precision and approximate range for the `float` type.  
  
|Type|Approximate range|Precision|.NET Framework type|  
|----------|-----------------------|---------------|-------------------------|  
|`float`|-3.4 × 10<sup>38</sup>to +3.4 × 10<sup>38</sup>|7 digits|\<xref:System.Single*?displayProperty=fullName>|  
  
## Literals  
 By default, a real numeric literal on the right side of the assignment operator is treated as [double](../vs140/double--csharp-reference-.md). Therefore, to initialize a float variable, use the suffix `f` or `F`, as in the following example:  
  
```  
  
float x = 3.5F;  
```  
  
 If you do not use the suffix in the previous declaration, you will get a compilation error because you are trying to store a [double](../vs140/double--csharp-reference-.md) value into a `float` variable.  
  
## Conversions  
 You can mix numeric integral types and floating-point types in an expression. In this case, the integral types are converted to floating-point types. The evaluation of the expression is performed according to the following rules:  
  
-   If one of the floating-point types is [double](../vs140/double--csharp-reference-.md), the expression evaluates to [double](../vs140/double--csharp-reference-.md) or [bool](../vs140/bool--csharp-reference-.md) in relational or Boolean expressions.  
  
-   If there is no [double](../vs140/double--csharp-reference-.md) type in the expression, the expression evaluates to `float` or [bool](../vs140/bool--csharp-reference-.md) in relational or Boolean expressions.  
  
 A floating-point expression can contain the following sets of values:  
  
-   Positive and negative zero  
  
-   Positive and negative infinity  
  
-   Not-a-Number value (NaN)  
  
-   The finite set of nonzero values  
  
 For more information about these values, see IEEE Standard for Binary Floating-Point Arithmetic, available on the [IEEE](http://go.microsoft.com/fwlink/?LinkId=26269) Web site.  
  
## Example  
 In the following example, an [int](../vs140/int--csharp-reference-.md), a [short](../vs140/short--csharp-reference-.md), and a `float` are included in a mathematical expression giving a `float` result. (Remember that `float` is an alias for the \<xref:System.Single*?displayProperty=fullName> type.) Notice that there is no [double](../vs140/double--csharp-reference-.md) in the expression.  
  
 [!code[csrefKeywordsTypes#13](../vs140/codesnippet/CSharp/float--csharp-reference-_1.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 \<xref:System.Single*>   
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Casting and Type Conversions (C# Programming Guide)](../vs140/casting-and-type-conversions--csharp-programming-guide-.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Integral Types Table](../vs140/integral-types-table--csharp-reference-.md)   
 [Built-in Types Table (Visual C#)](../vs140/built-in-types-table--csharp-reference-.md)   
 [Implicit Numeric Conversions Table](../vs140/implicit-numeric-conversions-table--csharp-reference-.md)   
 [Explicit Numeric Conversions Table (Visual C#)](../vs140/explicit-numeric-conversions-table--csharp-reference-.md)