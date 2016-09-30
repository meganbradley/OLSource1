---
title: "sbyte (C# Reference)"
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
  - "sbyte_CSharpKeyword"
  - "sbyte"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "sbyte keyword [C#]"
ms.assetid: 1a9c7b48-73d1-4d33-b485-c4faf0a816bc
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sbyte (C# Reference)
The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keyword indicates an integral type that stores values according to the size and range shown in the following table.  
  
|Type|Range|Size|.NET Framework type|  
|----------|-----------|----------|-------------------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|-128 to 127|Signed 8-bit integer|\<xref:System.SByte*?displayProperty=fullName>|  
  
## Literals  
 You can declare and initialize an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> variable in this manner:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the previous declaration, the integer literal 127 is implicitly converted from [int](../vs140/int--csharp-reference-.md) to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. If the integer literal exceeds the range of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, a compilation error will occur.  
  
 A cast must be used when calling overloaded methods. Consider, for example, the following overloaded methods that use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and [int](../vs140/int--csharp-reference-.md) parameters:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Using the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> cast guarantees that the correct type is called, for example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Conversions  
 There is a predefined implicit conversion from <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to [short](../vs140/short--csharp-reference-.md), [int](../vs140/int--csharp-reference-.md), [long](../vs140/long--csharp-reference-.md), [float](../vs140/float--csharp-reference-.md), [double](../vs140/double--csharp-reference-.md), or [decimal](../vs140/decimal--csharp-reference-.md).  
  
 You cannot implicitly convert nonliteral numeric types of larger storage size to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> (see [Integral Types Table](../vs140/integral-types-table--csharp-reference-.md) for the storage sizes of integral types). Consider, for example, the following two <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> variables <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The following assignment statement will produce a compilation error, because the arithmetic expression on the right side of the assignment operator evaluates to [int](../vs140/int--csharp-reference-.md) by default.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 To fix this problem, cast the expression as in the following example:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 It is possible though to use the following statements, where the destination variable has the same storage size or a larger storage size:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Notice also that there is no implicit conversion from floating-point types to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. For example, the following statement generates a compiler error unless an explicit cast is used:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 For information about arithmetic expressions with mixed floating-point types and integral types, see [float](../vs140/float--csharp-reference-.md) and [double](../vs140/double--csharp-reference-.md).  
  
 For more information about implicit numeric conversion rules, see the [Implicit Numeric Conversions Table](../vs140/implicit-numeric-conversions-table--csharp-reference-.md).  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 \<xref:System.SByte*>   
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Integral Types Table](../vs140/integral-types-table--csharp-reference-.md)   
 [Built-in Types Table (Visual C#)](../vs140/built-in-types-table--csharp-reference-.md)   
 [Implicit Numeric Conversions Table](../vs140/implicit-numeric-conversions-table--csharp-reference-.md)   
 [Explicit Numeric Conversions Table (Visual C#)](../vs140/explicit-numeric-conversions-table--csharp-reference-.md)