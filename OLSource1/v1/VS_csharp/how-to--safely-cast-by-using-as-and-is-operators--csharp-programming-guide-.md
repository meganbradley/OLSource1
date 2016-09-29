---
title: "How to: Safely Cast by Using as and is Operators (C# Programming Guide)"
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
  - "cast operators [C#], as and is operators"
  - "as operator [C#]"
  - "is operator [C#]"
ms.assetid: c1176cea-1426-4a44-8570-3eadafa58863
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Safely Cast by Using as and is Operators (C# Programming Guide)
Because objects are polymorphic, it is possible for a variable of a base class type to hold a derived type. To access the derived type's method, it is necessary to cast the value back to the derived type. However, to attempt a simple cast in these cases creates the risk of throwing an <xref:System.InvalidCastException*>. That is why C# provides the [is](../VS_csharp/is--csharp-reference-.md) and [as](../VS_csharp/as--csharp-reference-.md) operators. You can use these operators to test whether a cast will succeed without causing an exception to be thrown. In general, the `as` operator is more efficient because it actually returns the cast value if the cast can be made successfully. The `is` operator returns only a Boolean value. It can therefore be used when you just want to determine an object's type but do not have to actually cast it.  
  
## Example  
 The following examples show how to use the `is` and `as` operators to cast from one reference type to another without the risk of throwing an exception. The example also shows how to use the `as` operator with nullable value types.  
  
 [!code[csProgGuideTypes#40](../VS_csharp/codesnippet/CSharp/how-to--safely-cast-by-using-as-and-is-operators--csharp-programming-guide-_1.cs)]  
  
## See Also  
 [Types (C# Programming Guide)](../VS_csharp/types--csharp-programming-guide-.md)   
 [Casting and Type Conversions (C# Programming Guide)](../VS_csharp/casting-and-type-conversions--csharp-programming-guide-.md)   
 [Nullable Types (C# Programming Guide)](../VS_csharp/nullable-types--csharp-programming-guide-.md)