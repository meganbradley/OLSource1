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
For generic type parameters, the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> keyword specifies that the type parameter is contravariant. You can use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword in generic interfaces and delegates.  
  
 Contravariance enables you to use a less derived type than that specified by the generic parameter. This allows for implicit conversion of classes that implement variant interfaces and implicit conversion of delegate types. Covariance and contravariance in generic type parameters are supported for reference types, but they are not supported for value types.  
  
 A type can be declared contravariant in a generic interface or delegate if it is used only as a type of method arguments and not used as a method return type. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameters cannot be variant.  
  
 An interface that has a contravariant type parameter allows its methods to accept arguments of less derived types than those specified by the interface type parameter. For example, because in .NET Framework 4, in the <xref:System.Collections.Generic.IComparer<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>IComparer(Of Person)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>IComparer(Of Employee)<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>Employee<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>Person`.  
  
 A contravariant delegate can be assigned another delegate of the same type, but with a less derived generic type parameter.  
  
 For more information, see [Covariance and Contravariance (C# and Visual Basic)](../vs140/covariance-and-contravariance--csharp-and-visual-basic-.md).  
  
## Example  
 The following example shows how to declare, extend, and implement a contravariant generic interface. It also shows how you can use implicit conversion for classes that implement this interface.  
  
 [!code[csVarianceKeywords#1](../vs140/codesnippet/CSharp/in--generic-modifier---csharp-reference-_1.cs)]  
  
## Example  
 The following example shows how to declare, instantiate, and invoke a contravariant generic delegate. It also shows how you can implicitly convert a delegate type.  
  
 [!code[csVarianceKeywords#2](../vs140/codesnippet/CSharp/in--generic-modifier---csharp-reference-_2.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [out (Generic Modifier) (C# Reference)](../vs140/out--generic-modifier---csharp-reference-.md)   
 [Covariance and Contravariance (C# and Visual Basic)](../vs140/covariance-and-contravariance--csharp-and-visual-basic-.md)   
 [Modifiers (C# Reference)](../vs140/modifiers--csharp-reference-.md)