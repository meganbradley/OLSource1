---
title: "Default Values Table (C# Reference)"
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
  - "constructors [C#], return values"
  - "keywords [C#], new"
  - "default constructor [C#]"
  - "defaults [C#]"
  - "value types [C#], initializing"
  - "variables [C#], value types"
  - "constructors [C#], default constructor"
  - "types [C#], default constructor return values"
ms.assetid: 4af2c1df-9e3a-48c1-83ac-b192986fc5bc
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Default Values Table (C# Reference)
The following table shows the default values of value types returned by the default constructors. Default constructors are invoked by using the `new` operator, as follows:  
  
```  
int myInt = new int();  
```  
  
 The preceding statement has the same effect as the following statement:  
  
```  
int myInt = 0;  
```  
  
 Remember that using uninitialized variables in C# is not allowed.  
  
|Value type|Default value|  
|----------------|-------------------|  
|[bool](../VS_csharp/bool--csharp-reference-.md)|`false`|  
|[byte](../VS_csharp/byte--csharp-reference-.md)|0|  
|[char](../VS_csharp/char--csharp-reference-.md)|'\0'|  
|[decimal](../VS_csharp/decimal--csharp-reference-.md)|0.0M|  
|[double](../VS_csharp/double--csharp-reference-.md)|0.0D|  
|[enum](../VS_csharp/enum--csharp-reference-.md)|The value produced by the expression (E)0, where E is the enum identifier.|  
|[float](../VS_csharp/float--csharp-reference-.md)|0.0F|  
|[int](../VS_csharp/int--csharp-reference-.md)|0|  
|[long](../VS_csharp/long--csharp-reference-.md)|0L|  
|[sbyte](../VS_csharp/sbyte--csharp-reference-.md)|0|  
|[short](../VS_csharp/short--csharp-reference-.md)|0|  
|[struct](../VS_csharp/struct--csharp-reference-.md)|The value produced by setting all value-type fields to their default values and all reference-type fields to `null`.|  
|[uint](../VS_csharp/uint--csharp-reference-.md)|0|  
|[ulong](../VS_csharp/ulong--csharp-reference-.md)|0|  
|[ushort](../VS_csharp/ushort--csharp-reference-.md)|0|  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Value Types Table (C# Reference)](../VS_csharp/value-types-table--csharp-reference-.md)   
 [Value Types](../VS_csharp/value-types--csharp-reference-.md)   
 [Built-in Types Table (Visual C#)](../VS_csharp/built-in-types-table--csharp-reference-.md)   
 [Reference Tables for Types](../VS_csharp/reference-tables-for-types--csharp-reference-.md)