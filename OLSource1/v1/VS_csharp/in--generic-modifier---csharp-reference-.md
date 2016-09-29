---
title: "in (Generic Modifier) (C# Reference)"
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
  - "contravariance, in keyword [C#]"
  - "in keyword [C#]"
ms.assetid: 3a778c36-8aed-4ebe-aa8b-39f4057215b1
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# in (Generic Modifier) (C# Reference)
For generic type parameters, the `in` keyword specifies that the type parameter is contravariant. You can use the `in` keyword in generic interfaces and delegates.  
  
 Contravariance enables you to use a less derived type than that specified by the generic parameter. This allows for implicit conversion of classes that implement variant interfaces and implicit conversion of delegate types. Covariance and contravariance in generic type parameters are supported for reference types, but they are not supported for value types.  
  
 A type can be declared contravariant in a generic interface or delegate if it is used only as a type of method arguments and not used as a method return type. `Ref` and `out` parameters cannot be variant.  
  
 An interface that has a contravariant type parameter allows its methods to accept arguments of less derived types than those specified by the interface type parameter. For example, because in .NET Framework 4, in the <xref:System.Collections.Generic.IComparer`1*> interface, type T is contravariant, you can assign an object of the `IComparer(Of Person)` type to an object of the `IComparer(Of Employee)` type without using any special conversion methods if `Employee` inherits `Person`.  
  
 A contravariant delegate can be assigned another delegate of the same type, but with a less derived generic type parameter.  
  
 For more information, see [Covariance and Contravariance (C# and Visual Basic)](../VS_csharp/covariance-and-contravariance--csharp-and-visual-basic-.md).  
  
## Example  
 The following example shows how to declare, extend, and implement a contravariant generic interface. It also shows how you can use implicit conversion for classes that implement this interface.  
  
 [!code[csVarianceKeywords#1](../VS_csharp/codesnippet/CSharp/in--generic-modifier---csharp-reference-_1.cs)]  
  
## Example  
 The following example shows how to declare, instantiate, and invoke a contravariant generic delegate. It also shows how you can implicitly convert a delegate type.  
  
 [!code[csVarianceKeywords#2](../VS_csharp/codesnippet/CSharp/in--generic-modifier---csharp-reference-_2.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [out (Generic Modifier) (C# Reference)](../VS_csharp/out--generic-modifier---csharp-reference-.md)   
 [Covariance and Contravariance (C# and Visual Basic)](../VS_csharp/covariance-and-contravariance--csharp-and-visual-basic-.md)   
 [Modifiers (C# Reference)](../VS_csharp/modifiers--csharp-reference-.md)