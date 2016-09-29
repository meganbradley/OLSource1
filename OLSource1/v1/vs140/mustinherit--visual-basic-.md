---
title: "MustInherit (Visual Basic)"
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
  - "MustInherit"
  - "vb.MustInherit"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "classes [Visual Basic], abstract"
  - "MustInherit classes, MustInherit keyword"
  - "abstract classes, MustInherit class"
  - "MustInherit keyword"
ms.assetid: b8f05185-90e3-4dd7-adc2-90d852fab5b4
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MustInherit (Visual Basic)
Specifies that a class can be used only as a base class and that you cannot create an object directly from it.  
  
## Remarks  
 The purpose of a *base class* (also known as an *abstract class*) is to define functionality that is common to all the classes derived from it. This saves the derived classes from having to redefine the common elements. In some cases, this common functionality is not complete enough to make a usable object, and each derived class defines the missing functionality. In such a case, you want the consuming code to create objects only from the derived classes. You use `MustInherit` on the base class to enforce this.  
  
 Another use of a `MustInherit` class is to restrict a variable to a set of related classes. You can define a base class and derive all these related classes from it. The base class does not need to provide any functionality common to all the derived classes, but it can serve as a filter for assigning values to variables. If your consuming code declares a variable as the base class, Visual Basic allows you to assign only an object from one of the derived classes to that variable.  
  
 The .NET Framework defines several `MustInherit` classes, among them <xref:System.Array*>, <xref:System.Enum*>, and <xref:System.ValueType*>. <xref:System.ValueType*> is an example of a base class that restricts a variable. All value types derive from <xref:System.ValueType*>. If you declare a variable as <xref:System.ValueType*>, you can assign only value types to that variable.  
  
## Rules  
  
-   **Declaration Context.** You can use `MustInherit` only in a `Class` statement.  
  
-   **Combined Modifiers.** You cannot specify `MustInherit` together with `NotInheritable` in the same declaration.  
  
## Example  
 The following example illustrates both forced inheritance and forced overriding. The base class `shape` defines a variable `acrossLine`. The classes `circle` and `square` derive from `shape`. They inherit the definition of `acrossLine`, but they must define the function `area` because that calculation is different for each kind of shape.  
  
 [!code[VbVbalrKeywords#2](../vs140/codesnippet/VisualBasic/mustinherit--visual-basic-_1.vb)]  
  
 You can declare `shape1` and `shape2` to be of type `shape`. However, you cannot create an object from `shape` because it lacks the functionality of the function `area` and is marked `MustInherit`.  
  
 Because they are declared as `shape`, the variables `shape1` and `shape2` are restricted to objects from the derived classes `circle` and `square`. Visual Basic does not allow you to assign any other object to these variables, which gives you a high level of type safety.  
  
## Usage  
 The `MustInherit` modifier can be used in this context:  
  
 [Class Statement](../vs140/class-statement--visual-basic-.md)  
  
## See Also  
 [Inherits Statement](../vs140/inherits-statement.md)   
 [NotInheritable](../vs140/notinheritable--visual-basic-.md)   
 [Keywords (Visual Basic)](../vs140/keywords--visual-basic-.md)   
 [Inheritance Basics](../vs140/inheritance-basics--visual-basic-.md)