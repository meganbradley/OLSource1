---
title: "long (C# Reference)"
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
  - "long_CSharpKeyword"
  - "long"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "long keyword [C#]"
ms.assetid: f9b24319-1f39-48be-a42b-d528ee28a7fd
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# long (C# Reference)
The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keyword denotes an integral type that stores values according to the size and range shown in the following table.  
  
|Type|Range|Size|.NET Framework type|  
|----------|-----------|----------|-------------------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|–9,223,372,036,854,775,808 to 9,223,372,036,854,775,807|Signed 64-bit integer|\<xref:System.Int64*?displayProperty=fullName>|  
  
## Literals  
 You can declare and initialize a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> variable like this example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 When an integer literal has no suffix, its type is the first of these types in which its value can be represented: [int](../vs140/int--csharp-reference-.md), [uint](../vs140/uint--csharp-reference-.md), <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, [ulong](../vs140/ulong--csharp-reference-.md). In the preceding example, it is of the type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> because it exceeds the range of [uint](../vs140/uint--csharp-reference-.md) (see [Integral Types Table](../vs140/integral-types-table--csharp-reference-.md) for the storage sizes of integral types).  
  
 You can also use the suffix L with the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> type like this:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 When you use the suffix L, the type of the literal integer is determined to be either <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or [ulong](../vs140/ulong--csharp-reference-.md) according to its size. In the case it is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> because it less than the range of [ulong](../vs140/ulong--csharp-reference-.md).  
  
 A common use of the suffix is with calling overloaded methods. Consider, for example, the following overloaded methods that use <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and [int](../vs140/int--csharp-reference-.md) parameters:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Using the suffix L guarantees that the correct type is called, for example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 You can use the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> type with other numeric integral types in the same expression, in which case the expression is evaluated as <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> (or [bool](../vs140/bool--csharp-reference-.md) in the case of relational or Boolean expressions). For example, the following expression evaluates as <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
> [!NOTE]
>  You can also use the lowercase letter "l" as a suffix. However, this generates a compiler warning because the letter "l" is easily confused with the digit "1." Use "L" for clarity.  
  
 For information on arithmetic expressions with mixed floating-point types and integral types, see [float](../vs140/float--csharp-reference-.md) and [double](../vs140/double--csharp-reference-.md).  
  
## Conversions  
 There is a predefined implicit conversion from <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to [float](../vs140/float--csharp-reference-.md), [double](../vs140/double--csharp-reference-.md), or [decimal](../vs140/decimal--csharp-reference-.md). Otherwise a cast must be used. For example, the following statement will produce a compilation error without an explicit cast:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 There is a predefined implicit conversion from [sbyte](../vs140/sbyte--csharp-reference-.md), [byte](../vs140/byte--csharp-reference-.md), [short](../vs140/short--csharp-reference-.md), [ushort](../vs140/ushort--csharp-reference-.md), [int](../vs140/int--csharp-reference-.md), [uint](../vs140/uint--csharp-reference-.md), or [char](../vs140/char--csharp-reference-.md) to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 Notice also that there is no implicit conversion from floating-point types to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. For example, the following statement generates a compiler error unless an explicit cast is used:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 \<xref:System.Int64*>   
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Integral Types Table](../vs140/integral-types-table--csharp-reference-.md)   
 [Built-in Types Table](../vs140/built-in-types-table--csharp-reference-.md)   
 [Implicit Numeric Conversions Table](../vs140/implicit-numeric-conversions-table--csharp-reference-.md)   
 [Explicit Numeric Conversions Table](../vs140/explicit-numeric-conversions-table--csharp-reference-.md)