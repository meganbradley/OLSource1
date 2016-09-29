---
title: "Implicit Numeric Conversions Table (C# Reference)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "conversions [C#], implicit numeric"
  - "implicit numeric conversions [C#]"
  - "numeric conversions [C#], implicit"
  - "types [C#], implicit numeric conversions"
ms.assetid: 72eb5a94-0491-48bf-8032-d7ebfdfeb8d8
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Implicit Numeric Conversions Table (C# Reference)
The following table shows the predefined implicit numeric conversions. Implicit conversions might occur in many situations, including method invoking and assignment statements.  
  
|From|To|  
|----------|--------|  
|[sbyte](../VS_csharp/sbyte--csharp-reference-.md)|`short`, `int`, `long`, `float`, `double`, or `decimal`|  
|[byte](../VS_csharp/byte--csharp-reference-.md)|`short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`, or `decimal`|  
|[short](../VS_csharp/short--csharp-reference-.md)|`int`, `long`, `float`, `double`, or `decimal`|  
|[ushort](../VS_csharp/ushort--csharp-reference-.md)|`int`, `uint`, `long`, `ulong`, `float`, `double`, or `decimal`|  
|[int](../VS_csharp/int--csharp-reference-.md)|`long`, `float`, `double`, or `decimal`|  
|[uint](../VS_csharp/uint--csharp-reference-.md)|`long`, `ulong`, `float`, `double`, or `decimal`|  
|[long](../VS_csharp/long--csharp-reference-.md)|`float`, `double`, or `decimal`|  
|[char](../VS_csharp/char--csharp-reference-.md)|`ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`, or `decimal`|  
|[float](../VS_csharp/float--csharp-reference-.md)|`double`|  
|[ulong](../VS_csharp/ulong--csharp-reference-.md)|`float`, `double`, or `decimal`|  
  
## Remarks  
  
-   Precision but not magnitude might be lost in the conversions from `int`, `uint`,  `long`, or `ulong` to `float` and from `long` or `ulong` to `double`.  
  
-   There are no implicit conversions to the `char` type.  
  
-   There are no implicit conversions between floating-point types and the `decimal` type.  
  
-   A constant expression of type `int` can be converted to `sbyte`, `byte`, `short`, `ushort`, `uint`, or `ulong`, provided the value of the constant expression is within the range of the destination type.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Integral Types Table](../VS_csharp/integral-types-table--csharp-reference-.md)   
 [Built-in Types Table (Visual C#)](../VS_csharp/built-in-types-table--csharp-reference-.md)   
 [Explicit Numeric Conversions Table (Visual C#)](../VS_csharp/explicit-numeric-conversions-table--csharp-reference-.md)   
 [Casting and Type Conversions (C# Programming Guide)](../VS_csharp/casting-and-type-conversions--csharp-programming-guide-.md)