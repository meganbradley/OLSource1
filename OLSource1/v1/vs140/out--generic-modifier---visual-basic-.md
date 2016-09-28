---
title: "Out (Generic Modifier) (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.VarianceOut"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Out keyword [Visual Basic]"
  - "covariance, Out keyword [Visual Basic]"
ms.assetid: c4418369-1518-4a46-9a1e-054c61038eca
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Out (Generic Modifier) (Visual Basic)
For generic type parameters, the `Out` keyword specifies that the type is covariant.  
  
## Remarks  
 Covariance enables you to use a more derived type than that specified by the generic parameter. This allows for implicit conversion of classes that implement variant interfaces and implicit conversion of delegate types.  
  
 For more information, see [Covariance and Contravariance (C# and Visual Basic)](../vs140/covariance-and-contravariance--csharp-and-visual-basic-.md).  
  
## Rules  
 You can use the `Out` keyword in generic interfaces and delegates.  
  
 In a generic interface, a type parameter can be declared covariant if it satisfies the following conditions:  
  
-   The type parameter is used only as a return type of interface methods and not used as a type of method arguments.  
  
    > [!NOTE]
    >  There is one exception to this rule. If in a covariant interface you have a contravariant generic delegate as a method parameter, you can use the covariant type as a generic type parameter for this delegate. For more information about covariant and contravariant generic delegates, see [Variance in Generic Delegates](../vs140/variance-in-delegates--csharp-and-visual-basic-.md) and [Using Covariance and Contravariance for Func and Action Generic Delegates](../vs140/using-variance-for-func-and-action-generic-delegates--csharp-and-visual-basic-.md).  
  
-   The type parameter is not used as a generic constraint for the interface methods.  
  
 In a generic delegate, a type parameter can be declared covariant if it is used only as a method return type and not used for method arguments.  
  
 Covariance and contravariance are supported for reference types, but they are not supported for value types.  
  
 In Visual Basic, you cannot declare events in covariant interfaces without specifying the delegate type. Also, covariant interfaces cannot have nested classes, enums, or structures, but they can have nested interfaces.  
  
## Behavior  
 An interface that has a covariant type parameter enables its methods to return more derived types than those specified by the type parameter. For example, because in .NET Framework 4, in <xref:System.Collections.Generic.IEnumerable`1*>, type T is covariant, you can assign an object of the `IEnumerabe(Of String)` type to an object of the `IEnumerable(Of Object)` type without using any special conversion methods.  
  
 A covariant delegate can be assigned another delegate of the same type, but with a more derived generic type parameter.  
  
## Example  
 The following example shows how to declare, extend, and implement a covariant generic interface. It also shows how to use implicit conversion for classes that implement a covariant interface.  
  
 [!code[vbVarianceKeywords#3](../vs140/codesnippet/VisualBasic/out--generic-modifier---visual-basic-_1.vb)]  
  
## Example  
 The following example shows how to declare, instantiate, and invoke a covariant generic delegate. It also shows how you can use implicit conversion for delegate types.  
  
 [!code[vbVarianceKeywords#4](../vs140/codesnippet/VisualBasic/out--generic-modifier---visual-basic-_2.vb)]  
  
## See Also  
 [Covariance and Contravariance in Generic Interfaces (C# and Visual Basic)](../vs140/variance-in-generic-interfaces--csharp-and-visual-basic-.md)   
 [in (Generic Modifier) (Visual Basic)](../vs140/in--generic-modifier---visual-basic-.md)