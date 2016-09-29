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
|[bool](../vs140/bool--csharp-reference-.md)|`false`|  
|[byte](../vs140/byte--csharp-reference-.md)|0|  
|[char](../vs140/char--csharp-reference-.md)|'\0'|  
|[decimal](../vs140/decimal--csharp-reference-.md)|0.0M|  
|[double](../vs140/double--csharp-reference-.md)|0.0D|  
|[enum](../vs140/enum--csharp-reference-.md)|The value produced by the expression (E)0, where E is the enum identifier.|  
|[float](../vs140/float--csharp-reference-.md)|0.0F|  
|[int](../vs140/int--csharp-reference-.md)|0|  
|[long](../vs140/long--csharp-reference-.md)|0L|  
|[sbyte](../vs140/sbyte--csharp-reference-.md)|0|  
|[short](../vs140/short--csharp-reference-.md)|0|  
|[struct](../vs140/struct--csharp-reference-.md)|The value produced by setting all value-type fields to their default values and all reference-type fields to `null`.|  
|[uint](../vs140/uint--csharp-reference-.md)|0|  
|[ulong](../vs140/ulong--csharp-reference-.md)|0|  
|[ushort](../vs140/ushort--csharp-reference-.md)|0|  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Value Types Table (C# Reference)](../vs140/value-types-table--csharp-reference-.md)   
 [Value Types](../vs140/value-types--csharp-reference-.md)   
 [Built-in Types Table (Visual C#)](../vs140/built-in-types-table--csharp-reference-.md)   
 [Reference Tables for Types](../vs140/reference-tables-for-types--csharp-reference-.md)