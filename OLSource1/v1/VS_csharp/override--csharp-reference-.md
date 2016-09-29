---
title: "override (C# Reference)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "override"
  - "override_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "override keyword [C#]"
ms.assetid: dd1907a8-acf8-46d3-80b9-c2ca4febada8
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# override (C# Reference)
The `override` modifier is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.  
  
## Example  
 In this example, the `Square` class must provide an overridden implementation of `Area` because `Area` is inherited from the abstract `ShapesClass`:  
  
 [!code[csrefKeywordsModifiers#1](../VS_csharp/codesnippet/CSharp/override--csharp-reference-_1.cs)]  
  
 An `override` method provides a new implementation of a member that is inherited from a base class. The method that is overridden by an `override` declaration is known as the overridden base method. The overridden base method must have the same signature as the `override` method. For information about inheritance, see [Inheritance](../VS_csharp/inheritance--csharp-programming-guide-.md).  
  
 You cannot override a non-virtual or static method. The overridden base method must be `virtual`, `abstract`, or `override`.  
  
 An `override` declaration cannot change the accessibility of the `virtual` method. Both the `override` method and the `virtual` method must have the same [access level modifier](../VS_csharp/access-modifiers--csharp-reference-.md).  
  
 You cannot use the `new`, `static`, or `virtual` modifiers to modify an `override` method.  
  
 An overriding property declaration must specify exactly the same access modifier, type, and name as the inherited property, and the overridden property must be `virtual`, `abstract`, or `override`.  
  
 For more information about how to use the `override` keyword, see [Versioning with the Override and New Keywords](../VS_csharp/versioning-with-the-override-and-new-keywords--csharp-programming-guide-.md) and [Knowing when to use Override and New Keywords](../VS_csharp/knowing-when-to-use-override-and-new-keywords--csharp-programming-guide-.md).  
  
## Example  
 This example defines a base class named `Employee`, and a derived class named `SalesEmployee`. The `SalesEmployee` class includes an extra property, `salesbonus`, and overrides the method `CalculatePay` in order to take it into account.  
  
 [!code[csrefKeywordsModifiers#9](../VS_csharp/codesnippet/CSharp/override--csharp-reference-_2.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Inheritance (Visual C#)](../VS_csharp/inheritance--csharp-programming-guide-.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Modifiers](../VS_csharp/modifiers--csharp-reference-.md)   
 [abstract](../VS_csharp/abstract--csharp-reference-.md)   
 [virtual](../VS_csharp/virtual--csharp-reference-.md)   
 [new (C# Programmer's Reference)](../VS_csharp/new--csharp-reference-.md)   
 [Polymorphism (Visual C#)](../VS_csharp/polymorphism--csharp-programming-guide-.md)