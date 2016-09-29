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
The `short` keyword denotes an integral data type that stores values according to the size and range shown in the following table.  
  
|Type|Range|Size|.NET Framework type|  
|----------|-----------|----------|-------------------------|  
|`short`|-32,768 to 32,767|Signed 16-bit integer|<xref:System.Int16*?displayProperty=fullName>|  
  
## Literals  
 You can declare and initialize a `short` variable like this example:  
  
```  
  
short x = 32767;  
```  
  
 In the preceding declaration, the integer literal `32767` is implicitly converted from [int](../VS_csharp/int--csharp-reference-.md) to `short`. If the integer literal does not fit into a `short` storage location, a compilation error will occur.  
  
 A cast must be used when calling overloaded methods. Consider, for example, the following overloaded methods that use `short` and [int](../VS_csharp/int--csharp-reference-.md) parameters:  
  
```  
public static void SampleMethod(int i) {}  
public static void SampleMethod(short s) {}  
```  
  
 Using the `short` cast guarantees that the correct type is called, for example:  
  
```  
SampleMethod(5);         // Calling the method with the int parameter  
SampleMethod((short)5);  // Calling the method with the short parameter  
```  
  
## Conversions  
 There is a predefined implicit conversion from `short` to [int](../VS_csharp/int--csharp-reference-.md), [long](../VS_csharp/long--csharp-reference-.md), [float](../VS_csharp/float--csharp-reference-.md), [double](../VS_csharp/double--csharp-reference-.md), or [decimal](../VS_csharp/decimal--csharp-reference-.md).  
  
 You cannot implicitly convert nonliteral numeric types of larger storage size to `short` (see [Integral Types Table](../VS_csharp/integral-types-table--csharp-reference-.md) for the storage sizes of integral types). Consider, for example, the following two `short` variables `x` and `y`:  
  
```  
  
short x = 5, y = 12;  
```  
  
 The following assignment statement will produce a compilation error, because the arithmetic expression on the right-hand side of the assignment operator evaluates to [int](../VS_csharp/int--csharp-reference-.md) by default.  
  
 `short`   `z = x + y;   // Error: no conversion from int to short`  
  
 To fix this problem, use a cast:  
  
 `short`   `z = (`  `short`  `)(x + y);   // OK: explicit conversion`  
  
 It is possible though to use the following statements, where the destination variable has the same storage size or a larger storage size:  
  
```  
int m = x + y;  
long n = x + y;  
```  
  
 There is no implicit conversion from floating-point types to `short`. For example, the following statement generates a compiler error unless an explicit cast is used:  
  
```  
  
      short x = 3.0;          // Error: no implicit conversion from double  
short y = (short)3.0;   // OK: explicit conversion  
```  
  
 For information on arithmetic expressions with mixed floating-point types and integral types, see [float](../VS_csharp/float--csharp-reference-.md) and [double](../VS_csharp/double--csharp-reference-.md).  
  
 For more information on implicit numeric conversion rules, see the [Implicit Numeric Conversions Table](../VS_csharp/implicit-numeric-conversions-table--csharp-reference-.md).  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 <xref:System.Int16*>   
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Integral Types Table](../VS_csharp/integral-types-table--csharp-reference-.md)   
 [Built-in Types Table (Visual C#)](../VS_csharp/built-in-types-table--csharp-reference-.md)   
 [Implicit Numeric Conversions Table](../VS_csharp/implicit-numeric-conversions-table--csharp-reference-.md)   
 [Explicit Numeric Conversions Table (Visual C#)](../VS_csharp/explicit-numeric-conversions-table--csharp-reference-.md)