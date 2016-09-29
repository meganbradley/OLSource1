---
title: "out (Generic Modifier) (C# Reference)"
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
  - "covariance, out keyword [C#]"
  - "out keyword [C#]"
ms.assetid: f8c20dec-a8bc-426a-9882-4076b1db1e00
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# out (Generic Modifier) (C# Reference)
For generic type parameters, the `out` keyword specifies that the type parameter is covariant. You can use the `out` keyword in generic interfaces and delegates.  
  
 Covariance enables you to use a more derived type than that specified by the generic parameter. This allows for implicit conversion of classes that implement variant interfaces and implicit conversion of delegate types. Covariance and contravariance are supported for reference types, but they are not supported for value types.  
  
 An interface that has a covariant type parameter enables its methods to return more derived types than those specified by the type parameter. For example, because in .NET Framework 4, in <xref:System.Collections.Generic.IEnumerable`1*>, type T is covariant, you can assign an object of the `IEnumerabe(Of String)` type to an object of the `IEnumerable(Of Object)` type without using any special conversion methods.  
  
 A covariant delegate can be assigned another delegate of the same type, but with a more derived generic type parameter.  
  
 For more information, see [Covariance and Contravariance (C# and Visual Basic)](../VS_csharp/covariance-and-contravariance--csharp-and-visual-basic-.md).  
  
## Example  
 The following example shows how to declare, extend, and implement a covariant generic interface. It also shows how to use implicit conversion for classes that implement a covariant interface.  
  
 [!code[csVarianceKeywords#3](../VS_csharp/codesnippet/CSharp/out--generic-modifier---csharp-reference-_1.cs)]  
  
 In a generic interface, a type parameter can be declared covariant if it satisfies the following conditions:  
  
-   The type parameter is used only as a return type of interface methods and not used as a type of method arguments.  
  
    > [!NOTE]
    >  There is one exception to this rule. If in a covariant interface you have a contravariant generic delegate as a method parameter, you can use the covariant type as a generic type parameter for this delegate. For more information about covariant and contravariant generic delegates, see [Variance in Generic Delegates](../VS_csharp/variance-in-delegates--csharp-and-visual-basic-.md) and [Using Covariance and Contravariance for Func and Action Generic Delegates](../VS_csharp/using-variance-for-func-and-action-generic-delegates--csharp-and-visual-basic-.md).  
  
-   The type parameter is not used as a generic constraint for the interface methods.  
  
## Example  
 The following example shows how to declare, instantiate, and invoke a covariant generic delegate. It also shows how to implicitly convert delegate types.  
  
 [!code[csVarianceKeywords#4](../VS_csharp/codesnippet/CSharp/out--generic-modifier---csharp-reference-_2.cs)]  
  
 In a generic delegate, a type can be declared covariant if it is used only as a method return type and not used for method arguments.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [Covariance and Contravariance in Generic Interfaces (C# and Visual Basic)](../VS_csharp/variance-in-generic-interfaces--csharp-and-visual-basic-.md)   
 [in (Generic Modifier) (C# Reference)](../VS_csharp/in--generic-modifier---csharp-reference-.md)   
 [Modifiers (C# Reference)](../VS_csharp/modifiers--csharp-reference-.md)