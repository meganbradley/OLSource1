---
title: "short (C# Reference)"
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
  - "short"
  - "short_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "short keyword [C#]"
ms.assetid: 04c10688-e51a-4a87-bfec-83f7fb42ff11
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# short (C# Reference)
The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword denotes an integral data type that stores values according to the size and range shown in the following table.  
  
|Type|Range|Size|.NET Framework type|  
|----------|-----------|----------|-------------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|-32,768 to 32,767|Signed 16-bit integer|\<xref:System.Int16*?displayProperty=fullName>|  
  
## Literals  
 You can declare and initialize a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> variable like this example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the preceding declaration, the integer literal <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is implicitly converted from [int](../vs140/int--csharp-reference-.md) to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. If the integer literal does not fit into a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> storage location, a compilation error will occur.  
  
 A cast must be used when calling overloaded methods. Consider, for example, the following overloaded methods that use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and [int](../vs140/int--csharp-reference-.md) parameters:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Using the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> cast guarantees that the correct type is called, for example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Conversions  
 There is a predefined implicit conversion from <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to [int](../vs140/int--csharp-reference-.md), [long](../vs140/long--csharp-reference-.md), [float](../vs140/float--csharp-reference-.md), [double](../vs140/double--csharp-reference-.md), or [decimal](../vs140/decimal--csharp-reference-.md).  
  
 You cannot implicitly convert nonliteral numeric types of larger storage size to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> (see [Integral Types Table](../vs140/integral-types-table--csharp-reference-.md) for the storage sizes of integral types). Consider, for example, the following two <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> variables <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The following assignment statement will produce a compilation error, because the arithmetic expression on the right-hand side of the assignment operator evaluates to [int](../vs140/int--csharp-reference-.md) by default.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
 To fix this problem, use a cast:  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 It is possible though to use the following statements, where the destination variable has the same storage size or a larger storage size:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 There is no implicit conversion from floating-point types to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. For example, the following statement generates a compiler error unless an explicit cast is used:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 For information on arithmetic expressions with mixed floating-point types and integral types, see [float](../vs140/float--csharp-reference-.md) and [double](../vs140/double--csharp-reference-.md).  
  
 For more information on implicit numeric conversion rules, see the [Implicit Numeric Conversions Table](../vs140/implicit-numeric-conversions-table--csharp-reference-.md).  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 \<xref:System.Int16*>   
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Integral Types Table](../vs140/integral-types-table--csharp-reference-.md)   
 [Built-in Types Table (Visual C#)](../vs140/built-in-types-table--csharp-reference-.md)   
 [Implicit Numeric Conversions Table](../vs140/implicit-numeric-conversions-table--csharp-reference-.md)   
 [Explicit Numeric Conversions Table (Visual C#)](../vs140/explicit-numeric-conversions-table--csharp-reference-.md)