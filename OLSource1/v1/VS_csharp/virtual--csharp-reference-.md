---
title: "virtual (C# Reference)"
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
  - "virtual_CSharpKeyword"
  - "virtual"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "virtual keyword [C#]"
ms.assetid: 5da9abae-bc1e-434f-8bea-3601b8dcb3b2
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# virtual (C# Reference)
The `virtual` keyword is used to modify a method, property, indexer, or event declaration and allow for it to be overridden in a derived class. For example, this method can be overridden by any class that inherits it:  
  
```  
public virtual double Area()   
{  
    return x * y;  
}  
```  
  
 The implementation of a virtual member can be changed by an [overriding member](../VS_csharp/override--csharp-reference-.md) in a derived class. For more information about how to use the `virtual` keyword, see [Versioning with the Override and New Keywords (C#)](../VS_csharp/versioning-with-the-override-and-new-keywords--csharp-programming-guide-.md) and [Knowing when to use Override and New Keywords](../VS_csharp/knowing-when-to-use-override-and-new-keywords--csharp-programming-guide-.md).  
  
## Remarks  
 When a virtual method is invoked, the run-time type of the object is checked for an overriding member. The overriding member in the most derived class is called, which might be the original member, if no derived class has overridden the member.  
  
 By default, methods are non-virtual. You cannot override a non-virtual method.  
  
 You cannot use the `virtual` modifier with the `static`, `abstract, private`, or `override` modifiers. The following example shows a virtual property:  
  
 [!code[csrefKeywordsModifiers#26](../VS_csharp/codesnippet/CSharp/virtual--csharp-reference-_1.cs)]  
  
 Virtual properties behave like abstract methods, except for the differences in declaration and invocation syntax.  
  
-   It is an error to use the `virtual` modifier on a static property.  
  
-   A virtual inherited property can be overridden in a derived class by including a property declaration that uses the `override` modifier.  
  
## Example  
 In this example, the `Shape` class contains the two coordinates `x`, `y`, and the `Area()` virtual method. Different shape classes such as `Circle`, `Cylinder`, and `Sphere` inherit the `Shape` class, and the surface area is calculated for each figure. Each derived class has it own override implementation of `Area()`.  
  
 Notice that the inherited classes `Circle`, `Sphere`, and `Cylinder` all use constructors that initialize the base class, as shown in the following declaration.  
  
```  
public Cylinder(double r, double h): base(r, h) {}  
```  
  
 The following program calculates and displays the appropriate area for each figure by invoking the appropriate implementation of the `Area()` method, according to the object that is associated with the method.  
  
 [!code[csrefKeywordsModifiers#23](../VS_csharp/codesnippet/CSharp/virtual--csharp-reference-_2.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Modifiers](../VS_csharp/modifiers--csharp-reference-.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Polymorphism (Visual C#)](../VS_csharp/polymorphism--csharp-programming-guide-.md)   
 [abstract](../VS_csharp/abstract--csharp-reference-.md)   
 [override (C# Programmer's Reference)](../VS_csharp/override--csharp-reference-.md)   
 [new (C# Programmer's Reference)](../VS_csharp/new--csharp-reference-.md)