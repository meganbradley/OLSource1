---
title: "uint (C# Reference)"
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
  - "uint"
  - "uint_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "uint keyword [C#]"
ms.assetid: e93e42c6-ec72-4b0b-89df-2fd8d36f7a7b
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# uint (C# Reference)
The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keyword signifies an integral type that stores values according to the size and range shown in the following table.  
  
|Type|Range|Size|.NET Framework type|  
|----------|-----------|----------|-------------------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|0 to 4,294,967,295|Unsigned 32-bit integer|\<xref:System.UInt32*?displayProperty=fullName>|  
  
 **Note** The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> type is not CLS-compliant. Use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> whenever possible.  
  
## Literals  
 You can declare and initialize a variable of the type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> like this example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 When an integer literal has no suffix, its type is the first of these types in which its value can be represented: [int](../vs140/int--csharp-reference-.md), <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, [long](../vs140/long--csharp-reference-.md), [ulong](../vs140/ulong--csharp-reference-.md). In this example, it is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You can also use the suffix u or U, such as this:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 When you use the suffix <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, the type of the literal is determined to be either <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> according to the numeric value of the literal. For example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This code displays <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, followed by <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> -- the underlying types for <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> respectively -- because the second literal is too large to be stored by the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> type.  
  
## Conversions  
 There is a predefined implicit conversion from <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to [long](../vs140/long--csharp-reference-.md), [ulong](../vs140/ulong--csharp-reference-.md), [float](../vs140/float--csharp-reference-.md), [double](../vs140/double--csharp-reference-.md), or [decimal](../vs140/decimal--csharp-reference-.md). For example:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 There is a predefined implicit conversion from [byte](../vs140/byte--csharp-reference-.md), [ushort](../vs140/ushort--csharp-reference-.md), or [char](../vs140/char--csharp-reference-.md) to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. Otherwise you must use a cast. For example, the following assignment statement will produce a compilation error without a cast:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Notice also that there is no implicit conversion from floating-point types to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. For example, the following statement generates a compiler error unless an explicit cast is used:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 For information about arithmetic expressions with mixed floating-point types and integral types, see [float](../vs140/float--csharp-reference-.md) and [double](../vs140/double--csharp-reference-.md).  
  
 For more information about implicit numeric conversion rules, see the [Implicit Numeric Conversions Table](../vs140/implicit-numeric-conversions-table--csharp-reference-.md).  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 \<xref:System.UInt32*>   
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Integral Types Table](../vs140/integral-types-table--csharp-reference-.md)   
 [Built-in Types Table (Visual C#)](../vs140/built-in-types-table--csharp-reference-.md)   
 [Implicit Numeric Conversions Table](../vs140/implicit-numeric-conversions-table--csharp-reference-.md)   
 [Explicit Numeric Conversions Table (Visual C#)](../vs140/explicit-numeric-conversions-table--csharp-reference-.md)