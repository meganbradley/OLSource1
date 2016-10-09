---
title: "sbyte (C# Reference)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 17
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# sbyte (C# Reference)
The `sbyte` keyword indicates an integral type that stores values according to the size and range shown in the following table.  
  
|Type|Range|Size|.NET Framework type|  
|----------|-----------|----------|-------------------------|  
|`sbyte`|-128 to 127|Signed 8-bit integer|\<xref:System.SByte?displayProperty=fullName>|  
  
## Literals  
 You can declare and initialize an `sbyte` variable in this manner:  
  
```  
  
sbyte sByte1 = 127;  
```  
  
 In the previous declaration, the integer literal 127 is implicitly converted from [int](../VS_csharp/int--csharp-reference-.md) to `sbyte`. If the integer literal exceeds the range of `sbyte`, a compilation error will occur.  
  
 A cast must be used when calling overloaded methods. Consider, for example, the following overloaded methods that use `sbyte` and [int](../VS_csharp/int--csharp-reference-.md) parameters:  
  
```  
public static void SampleMethod(int i) {}  
public static void SampleMethod(sbyte b) {}  
```  
  
 Using the `sbyte` cast guarantees that the correct type is called, for example:  
  
```  
// Calling the method with the int parameter:  
SampleMethod(5);  
// Calling the method with the sbyte parameter:  
SampleMethod((sbyte)5);  
```  
  
## Conversions  
 There is a predefined implicit conversion from `sbyte` to [short](../VS_csharp/short--csharp-reference-.md), [int](../VS_csharp/int--csharp-reference-.md), [long](../VS_csharp/long--csharp-reference-.md), [float](../VS_csharp/float--csharp-reference-.md), [double](../VS_csharp/double--csharp-reference-.md), or [decimal](../VS_csharp/decimal--csharp-reference-.md).  
  
 You cannot implicitly convert nonliteral numeric types of larger storage size to `sbyte` (see [Integral Types Table](../VS_csharp/integral-types-table--csharp-reference-.md) for the storage sizes of integral types). Consider, for example, the following two `sbyte` variables `x` and `y`:  
  
```  
  
sbyte x = 10, y = 20;  
```  
  
 The following assignment statement will produce a compilation error, because the arithmetic expression on the right side of the assignment operator evaluates to [int](../VS_csharp/int--csharp-reference-.md) by default.  
  
```  
  
sbyte z = x + y;   // Error: conversion from int to sbyte  
```  
  
 To fix this problem, cast the expression as in the following example:  
  
```  
  
sbyte z = (sbyte)(x + y);   // OK: explicit conversion  
```  
  
 It is possible though to use the following statements, where the destination variable has the same storage size or a larger storage size:  
  
```  
  
      sbyte x = 10, y = 20;  
int m = x + y;  
long n = x + y;  
```  
  
 Notice also that there is no implicit conversion from floating-point types to `sbyte`. For example, the following statement generates a compiler error unless an explicit cast is used:  
  
```  
  
      sbyte x = 3.0;         // Error: no implicit conversion from double  
sbyte y = (sbyte)3.0;  // OK: explicit conversion  
```  
  
 For information about arithmetic expressions with mixed floating-point types and integral types, see [float](../VS_csharp/float--csharp-reference-.md) and [double](../VS_csharp/double--csharp-reference-.md).  
  
 For more information about implicit numeric conversion rules, see the [Implicit Numeric Conversions Table](../VS_csharp/implicit-numeric-conversions-table--csharp-reference-.md).  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 \<xref:System.SByte>   
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Integral Types Table](../VS_csharp/integral-types-table--csharp-reference-.md)   
 [Built-In Types Table](../VS_csharp/built-in-types-table--csharp-reference-.md)   
 [Implicit Numeric Conversions Table](../VS_csharp/implicit-numeric-conversions-table--csharp-reference-.md)   
 [Explicit Numeric Conversions Table](../VS_csharp/explicit-numeric-conversions-table--csharp-reference-.md)