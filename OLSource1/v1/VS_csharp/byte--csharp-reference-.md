---
title: "byte (C# Reference)"
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
  - "byte"
  - "byte_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "byte keyword [C#]"
ms.assetid: 111f1db9-ca32-4f0e-b497-4783517eda47
caps.latest.revision: 19
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
# byte (C# Reference)
The `byte` keyword denotes an integral type that stores values as indicated in the following table.  
  
|Type|Range|Size|.NET Framework type|  
|----------|-----------|----------|-------------------------|  
|`byte`|0 to 255|Unsigned 8-bit integer|\<xref:System.Byte?displayProperty=fullName>|  
  
## Literals  
 You can declare and initialize a `byte` variable like this example:  
  
```  
byte myByte = 255;  
```  
  
 In the preceding declaration, the integer literal `255` is implicitly converted from [int](../VS_csharp/int--csharp-reference-.md) to `byte`. If the integer literal exceeds the range of `byte`, a compilation error will occur.  
  
## Conversions  
 There is a predefined implicit conversion from `byte` to [short](../VS_csharp/short--csharp-reference-.md), [ushort](../VS_csharp/ushort--csharp-reference-.md), [int](../VS_csharp/int--csharp-reference-.md), [uint](../VS_csharp/uint--csharp-reference-.md), [long](../VS_csharp/long--csharp-reference-.md), [ulong](../VS_csharp/ulong--csharp-reference-.md), [float](../VS_csharp/float--csharp-reference-.md), [double](../VS_csharp/double--csharp-reference-.md), or [decimal](../VS_csharp/decimal--csharp-reference-.md).  
  
 You cannot implicitly convert non-literal numeric types of larger storage size to `byte`. For more information on the storage sizes of integral types, see [Integral Types Table](../VS_csharp/integral-types-table--csharp-reference-.md). Consider, for example, the following two `byte` variables `x` and `y`:  
  
```  
  
byte x = 10, y = 20;  
```  
  
 The following assignment statement will produce a compilation error, because the arithmetic expression on the right-hand side of the assignment operator evaluates to `int` by default.  
  
```  
// Error: conversion from int to byte:  
byte z = x + y;  
```  
  
 To fix this problem, use a cast:  
  
```  
// OK: explicit conversion:  
byte z = (byte)(x + y);  
```  
  
 It is possible though, to use the following statements where the destination variable has the same storage size or a larger storage size:  
  
```  
int x = 10, y = 20;  
int m = x + y;  
long n = x + y;  
```  
  
 Also, there is no implicit conversion from floating-point types to `byte`. For example, the following statement generates a compiler error unless an explicit cast is used:  
  
```  
// Error: no implicit conversion from double:  
byte x = 3.0;   
// OK: explicit conversion:  
byte y = (byte)3.0;  
```  
  
 When calling overloaded methods, a cast must be used. Consider, for example, the following overloaded methods that use `byte` and [int](../VS_csharp/int--csharp-reference-.md) parameters:  
  
```  
public static void SampleMethod(int i) {}  
public static void SampleMethod(byte b) {}  
```  
  
 Using the `byte` cast guarantees that the correct type is called, for example:  
  
```  
// Calling the method with the int parameter:  
SampleMethod(5);  
// Calling the method with the byte parameter:  
SampleMethod((byte)5);  
```  
  
 For information on arithmetic expressions with mixed floating-point types and integral types, see [float](../VS_csharp/float--csharp-reference-.md) and [double](../VS_csharp/double--csharp-reference-.md).  
  
 For more information on implicit numeric conversion rules, see the [Implicit Numeric Conversions Table](../VS_csharp/implicit-numeric-conversions-table--csharp-reference-.md).  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 \<xref:System.Byte>   
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Integral Types Table](../VS_csharp/integral-types-table--csharp-reference-.md)   
 [Built-In Types Table](../VS_csharp/built-in-types-table--csharp-reference-.md)   
 [Implicit Numeric Conversions Table](../VS_csharp/implicit-numeric-conversions-table--csharp-reference-.md)   
 [Explicit Numeric Conversions Table](../VS_csharp/explicit-numeric-conversions-table--csharp-reference-.md)