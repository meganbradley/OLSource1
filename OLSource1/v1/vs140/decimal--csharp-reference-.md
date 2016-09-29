---
title: "decimal (C# Reference)"
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
  - "decimal_CSharpKeyword"
  - "decimal"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "decimal keyword [C#]"
ms.assetid: b6522132-b5ee-4be3-ad13-3adfdb7de7a1
caps.latest.revision: 36
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# decimal (C# Reference)
The `decimal` keyword indicates a 128-bit data type. Compared to floating-point types, the `decimal` type has more precision and a smaller range, which makes it appropriate for financial and monetary calculations. The approximate range and precision for the `decimal` type are shown in the following table.  
  
|Type|Approximate Range|Precision|.NET Framework type|  
|----------|-----------------------|---------------|-------------------------|  
|`decimal`|(-7.9 x 10<sup>28</sup> to 7.9 x 10<sup>28</sup>) / (10<sup>0 to 28</sup>)|28-29 significant digits|<xref:System.Decimal*?displayProperty=fullName>|  
  
## Literals  
 If you want a numeric real literal to be treated as `decimal`, use the suffix m or M, for example:  
  
```  
  
decimal myMoney = 300.5m;  
```  
  
 Without the suffix m, the number is treated as a [double](../vs140/double--csharp-reference-.md) and generates a compiler error.  
  
## Conversions  
 The integral types are implicitly converted to `decimal` and the result evaluates to `decimal`. Therefore you can initialize a decimal variable using an integer literal, without the suffix, as follows:  
  
```  
  
decimal myMoney = 300;  
```  
  
 There is no implicit conversion between floating-point types and the `decimal` type; therefore, a cast must be used to convert between these two types. For example:  
  
```  
  
      decimal myMoney = 99.9m;  
double x = (double)myMoney;  
myMoney = (decimal)x;  
```  
  
 You can also mix `decimal` and numeric integral types in the same expression. However, mixing `decimal` and floating-point types without a cast causes a compilation error.  
  
 For more information about implicit numeric conversions, see [Implicit Numeric Conversions Table](../vs140/implicit-numeric-conversions-table--csharp-reference-.md).  
  
 For more information about explicit numeric conversions, see [Explicit Numeric Conversions Table (Visual C#)](../vs140/explicit-numeric-conversions-table--csharp-reference-.md).  
  
## Formatting Decimal Output  
 You can format the results by using the `String.Format` method, or through the <xref:System.Console.Write*?displayProperty=fullName> method, which calls `String.Format()`. The currency format is specified by using the standard currency format string "C" or "c," as shown in the second example later in this article. For more information about the `String.Format` method, see <xref:System.String.Format*?displayProperty=fullName>.  
  
## Example  
 The following example causes a compiler error by trying to add [double](../vs140/double--csharp-reference-.md) and `decimal` variables.  
  
```c#  
double dub = 9;  
// The following line causes an error that reads "Operator '+' cannot be applied to   
// operands of type 'double' and 'decimal'"  
Console.WriteLine(dec + dub);   
  
// You can fix the error by using explicit casting of either operand.  
Console.WriteLine(dec + (decimal)dub);  
Console.WriteLine((double)dec + dub);  
  
```  
  
 The result is the following error:  
  
 `Operator '+' cannot be applied to operands of type 'double' and 'decimal'`  
  
 In this example, a `decimal` and an [int](../vs140/int--csharp-reference-.md) are mixed in the same expression. The result evaluates to the `decimal` type.  
  
 [!code[csrefKeywordsTypes#6](../vs140/codesnippet/CSharp/decimal--csharp-reference-_1.cs)]  
  
## Example  
 In this example, the output is formatted by using the currency format string. Notice that `x` is rounded because the decimal places exceed $0.99. The variable `y`, which represents the maximum exact digits, is displayed exactly in the correct format.  
  
 [!code[csrefKeywordsTypes#7](../vs140/codesnippet/CSharp/decimal--csharp-reference-_2.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 <xref:System.Decimal*>   
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Integral Types Table](../vs140/integral-types-table--csharp-reference-.md)   
 [Built-in Types Table (Visual C#)](../vs140/built-in-types-table--csharp-reference-.md)   
 [Implicit Numeric Conversions Table](../vs140/implicit-numeric-conversions-table--csharp-reference-.md)   
 [Explicit Numeric Conversions Table (Visual C#)](../vs140/explicit-numeric-conversions-table--csharp-reference-.md)   
 [Standard Numeric Format Strings](assetId:///580e57eb-ac47-4ffd-bccd-3a1637c2f467)