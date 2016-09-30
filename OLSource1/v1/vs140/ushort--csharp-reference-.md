---
title: "ushort (C# Reference)"
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
  - "ushort"
  - "ushort_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "ushort keyword [C#]"
ms.assetid: 1a7dbaae-b7a0-4111-872a-c88a6d3981ac
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ushort (C# Reference)
The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keyword indicates an integral data type that stores values according to the size and range shown in the following table.  
  
|Type|Range|Size|.NET Framework type|  
|----------|-----------|----------|-------------------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|0 to 65,535|Unsigned 16-bit integer|\<xref:System.UInt16*?displayProperty=fullName>|  
  
## Literals  
 You can declare and initialize a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> variable such as this example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the previous declaration, the integer literal <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is implicitly converted from [int](../vs140/int--csharp-reference-.md) to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. If the integer literal exceeds the range of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, a compilation error will occur.  
  
 A cast must be used when you call overloaded methods. Consider, for example, the following overloaded methods that use <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and [int](../vs140/int--csharp-reference-.md) parameters:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Using the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> cast guarantees that the correct type is called, for example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Conversions  
 There is a predefined implicit conversion from <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to [int](../vs140/int--csharp-reference-.md), [uint](../vs140/uint--csharp-reference-.md), [long](../vs140/long--csharp-reference-.md), [ulong](../vs140/ulong--csharp-reference-.md), [float](../vs140/float--csharp-reference-.md), [double](../vs140/double--csharp-reference-.md), or [decimal](../vs140/decimal--csharp-reference-.md).  
  
 There is a predefined implicit conversion from [byte](../vs140/byte--csharp-reference-.md) or [char](../vs140/char--csharp-reference-.md) to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. Otherwise a cast must be used to perform an explicit conversion. Consider, for example, the following two <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> variables <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The following assignment statement will produce a compilation error, because the arithmetic expression on the right side of the assignment operator evaluates to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> by default.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 To fix this problem, use a cast:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 It is possible though to use the following statements, where the destination variable has the same storage size or a larger storage size:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Notice also that there is no implicit conversion from floating-point types to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. For example, the following statement generates a compiler error unless an explicit cast is used:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 For information about arithmetic expressions with mixed floating-point types and integral types, see [float](../vs140/float--csharp-reference-.md) and [double](../vs140/double--csharp-reference-.md).  
  
 For more information about implicit numeric conversion rules, see the [Implicit Numeric Conversions Table](../vs140/implicit-numeric-conversions-table--csharp-reference-.md).  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 \<xref:System.UInt16*>   
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Integral Types Table](../vs140/integral-types-table--csharp-reference-.md)   
 [Built-in Types Table (Visual C#)](../vs140/built-in-types-table--csharp-reference-.md)   
 [Implicit Numeric Conversions Table](../vs140/implicit-numeric-conversions-table--csharp-reference-.md)   
 [Explicit Numeric Conversions Table (Visual C#)](../vs140/explicit-numeric-conversions-table--csharp-reference-.md)