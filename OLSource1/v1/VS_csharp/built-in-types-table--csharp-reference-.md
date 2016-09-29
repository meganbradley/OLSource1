---
title: "Built-In Types Table (C# Reference)"
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
  - "types [C#], built-in"
  - "built-in C# types"
ms.assetid: 54f901f2-bf2f-472c-ae8d-73e8ecfc57fe
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Built-In Types Table (C# Reference)
The following table shows the keywords for built-in C# types, which are aliases of predefined types in the <xref:System*> namespace.  
  
|C# Type|.NET Framework Type|  
|--------------|-------------------------|  
|[bool](../VS_csharp/bool--csharp-reference-.md)|`System.Boolean`|  
|[byte](../VS_csharp/byte--csharp-reference-.md)|`System.Byte`|  
|[sbyte](../VS_csharp/sbyte--csharp-reference-.md)|`System.SByte`|  
|[char](../VS_csharp/char--csharp-reference-.md)|`System.Char`|  
|[decimal](../VS_csharp/decimal--csharp-reference-.md)|`System.Decimal`|  
|[double](../VS_csharp/double--csharp-reference-.md)|`System.Double`|  
|[float](../VS_csharp/float--csharp-reference-.md)|`System.Single`|  
|[int](../VS_csharp/int--csharp-reference-.md)|`System.Int32`|  
|[uint](../VS_csharp/uint--csharp-reference-.md)|`System.UInt32`|  
|[long](../VS_csharp/long--csharp-reference-.md)|`System.Int64`|  
|[ulong](../VS_csharp/ulong--csharp-reference-.md)|`System.UInt64`|  
|[object](../VS_csharp/object--csharp-reference-.md)|`System.Object`|  
|[short](../VS_csharp/short--csharp-reference-.md)|`System.Int16`|  
|[ushort](../VS_csharp/ushort--csharp-reference-.md)|`System.UInt16`|  
|[string](../VS_csharp/string--csharp-reference-.md)|`System.String`|  
  
## Remarks  
 All of the types in the table, except `object` and `string`, are referred to as simple types.  
  
 The C# type keywords and their aliases are interchangeable. For example, you can declare an integer variable by using either of the following declarations:  
  
```  
int x = 123;  
System.Int32 x = 123;  
```  
  
 To display the actual type for any C# type, use the system method `GetType()`. For example, the following statement displays the system alias that represents the type of `myVariable`:  
  
```  
Console.WriteLine(myVariable.GetType());  
```  
  
 You can also use the [typeof](../VS_csharp/typeof--csharp-reference-.md) operator.  
  
## See Also  
 [C# Programmer's Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Value Types](../VS_csharp/value-types--csharp-reference-.md)   
 [Default Values Table](../VS_csharp/default-values-table--csharp-reference-.md)   
 [Formatting Numeric Results Table](../VS_csharp/formatting-numeric-results-table--csharp-reference-.md)   
 [dynamic](../VS_csharp/dynamic--csharp-reference-.md)   
 [Types Reference Tables](../VS_csharp/reference-tables-for-types--csharp-reference-.md)