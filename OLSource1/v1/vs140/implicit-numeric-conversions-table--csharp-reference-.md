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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Implicit Numeric Conversions Table (C# Reference)
The following table shows the predefined implicit numeric conversions. Implicit conversions might occur in many situations, including method invoking and assignment statements.  
  
|From|To|  
|----------|--------|  
|[sbyte](../vs140/sbyte--csharp-reference-.md)|`short`, `int`, `long`, `float`, `double`, or `decimal`|  
|[byte](../vs140/byte--csharp-reference-.md)|`short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`, or `decimal`|  
|[short](../vs140/short--csharp-reference-.md)|`int`, `long`, `float`, `double`, or `decimal`|  
|[ushort](../vs140/ushort--csharp-reference-.md)|`int`, `uint`, `long`, `ulong`, `float`, `double`, or `decimal`|  
|[int](../vs140/int--csharp-reference-.md)|`long`, `float`, `double`, or `decimal`|  
|[uint](../vs140/uint--csharp-reference-.md)|`long`, `ulong`, `float`, `double`, or `decimal`|  
|[long](../vs140/long--csharp-reference-.md)|`float`, `double`, or `decimal`|  
|[char](../vs140/char--csharp-reference-.md)|`ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`, or `decimal`|  
|[float](../vs140/float--csharp-reference-.md)|`double`|  
|[ulong](../vs140/ulong--csharp-reference-.md)|`float`, `double`, or `decimal`|  
  
## Remarks  
  
-   Precision but not magnitude might be lost in the conversions from `int`, `uint`,  `long`, or `ulong` to `float` and from `long` or `ulong` to `double`.  
  
-   There are no implicit conversions to the `char` type.  
  
-   There are no implicit conversions between floating-point types and the `decimal` type.  
  
-   A constant expression of type `int` can be converted to `sbyte`, `byte`, `short`, `ushort`, `uint`, or `ulong`, provided the value of the constant expression is within the range of the destination type.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Integral Types Table](../vs140/integral-types-table--csharp-reference-.md)   
 [Built-in Types Table (Visual C#)](../vs140/built-in-types-table--csharp-reference-.md)   
 [Explicit Numeric Conversions Table (Visual C#)](../vs140/explicit-numeric-conversions-table--csharp-reference-.md)   
 [Casting and Type Conversions (C# Programming Guide)](../vs140/casting-and-type-conversions--csharp-programming-guide-.md)