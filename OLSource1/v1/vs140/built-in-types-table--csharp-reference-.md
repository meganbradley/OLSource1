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
|[bool](../vs140/bool--csharp-reference-.md)|`System.Boolean`|  
|[byte](../vs140/byte--csharp-reference-.md)|`System.Byte`|  
|[sbyte](../vs140/sbyte--csharp-reference-.md)|`System.SByte`|  
|[char](../vs140/char--csharp-reference-.md)|`System.Char`|  
|[decimal](../vs140/decimal--csharp-reference-.md)|`System.Decimal`|  
|[double](../vs140/double--csharp-reference-.md)|`System.Double`|  
|[float](../vs140/float--csharp-reference-.md)|`System.Single`|  
|[int](../vs140/int--csharp-reference-.md)|`System.Int32`|  
|[uint](../vs140/uint--csharp-reference-.md)|`System.UInt32`|  
|[long](../vs140/long--csharp-reference-.md)|`System.Int64`|  
|[ulong](../vs140/ulong--csharp-reference-.md)|`System.UInt64`|  
|[object](../vs140/object--csharp-reference-.md)|`System.Object`|  
|[short](../vs140/short--csharp-reference-.md)|`System.Int16`|  
|[ushort](../vs140/ushort--csharp-reference-.md)|`System.UInt16`|  
|[string](../vs140/string--csharp-reference-.md)|`System.String`|  
  
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
  
 You can also use the [typeof](../vs140/typeof--csharp-reference-.md) operator.  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Value Types](../vs140/value-types--csharp-reference-.md)   
 [Default Values Table](../vs140/default-values-table--csharp-reference-.md)   
 [Formatting Numeric Results Table](../vs140/formatting-numeric-results-table--csharp-reference-.md)   
 [dynamic](../vs140/dynamic--csharp-reference-.md)   
 [Types Reference Tables](../vs140/reference-tables-for-types--csharp-reference-.md)