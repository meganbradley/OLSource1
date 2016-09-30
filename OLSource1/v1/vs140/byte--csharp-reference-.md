---
title: "byte (C# Reference)"
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
  - "byte"
  - "byte_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "byte keyword [C#]"
ms.assetid: 111f1db9-ca32-4f0e-b497-4783517eda47
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# byte (C# Reference)
The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keyword denotes an integral type that stores values as indicated in the following table.  
  
|Type|Range|Size|.NET Framework type|  
|----------|-----------|----------|-------------------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|0 to 255|Unsigned 8-bit integer|\<xref:System.Byte*?displayProperty=fullName>|  
  
## Literals  
 You can declare and initialize a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> variable like this example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the preceding declaration, the integer literal <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is implicitly converted from [int](../vs140/int--csharp-reference-.md) to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. If the integer literal exceeds the range of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, a compilation error will occur.  
  
## Conversions  
 There is a predefined implicit conversion from <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to [short](../vs140/short--csharp-reference-.md), [ushort](../vs140/ushort--csharp-reference-.md), [int](../vs140/int--csharp-reference-.md), [uint](../vs140/uint--csharp-reference-.md), [long](../vs140/long--csharp-reference-.md), [ulong](../vs140/ulong--csharp-reference-.md), [float](../vs140/float--csharp-reference-.md), [double](../vs140/double--csharp-reference-.md), or [decimal](../vs140/decimal--csharp-reference-.md).  
  
 You cannot implicitly convert non-literal numeric types of larger storage size to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. For more information on the storage sizes of integral types, see [Integral Types Table](../vs140/integral-types-table--csharp-reference-.md). Consider, for example, the following two <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> variables <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following assignment statement will produce a compilation error, because the arithmetic expression on the right-hand side of the assignment operator evaluates to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> by default.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 To fix this problem, use a cast:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 It is possible though, to use the following statements where the destination variable has the same storage size or a larger storage size:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Also, there is no implicit conversion from floating-point types to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. For example, the following statement generates a compiler error unless an explicit cast is used:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 When calling overloaded methods, a cast must be used. Consider, for example, the following overloaded methods that use <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and [int](../vs140/int--csharp-reference-.md) parameters:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Using the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> cast guarantees that the correct type is called, for example:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 For information on arithmetic expressions with mixed floating-point types and integral types, see [float](../vs140/float--csharp-reference-.md) and [double](../vs140/double--csharp-reference-.md).  
  
 For more information on implicit numeric conversion rules, see the [Implicit Numeric Conversions Table](../vs140/implicit-numeric-conversions-table--csharp-reference-.md).  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 \<xref:System.Byte*>   
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Integral Types Table](../vs140/integral-types-table--csharp-reference-.md)   
 [Built-in Types Table (Visual C#)](../vs140/built-in-types-table--csharp-reference-.md)   
 [Implicit Numeric Conversions Table](../vs140/implicit-numeric-conversions-table--csharp-reference-.md)   
 [Explicit Numeric Conversions Table (Visual C#)](../vs140/explicit-numeric-conversions-table--csharp-reference-.md)