---
title: "How to: Create Inheritance Between Types (Class Designer)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.classdesigner.inheritanceline"
helpviewer_keywords: 
  - "inheritance, relationship defining"
  - "relationships, defining inheritance"
ms.assetid: 3786a21c-8022-4bf5-9d13-740fd354e93c
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create Inheritance Between Types (Class Designer)
To create an inheritance relationship between two types on a class diagram using Class Designer, connect the base type with its derived type or types. You can have an inheritance relationship between two classes, between a class and an interface, or between two interfaces.  
  
### To create an inheritance between types  
  
1.  From your project in Solution Explorer, open a class diagram (.cd) file.  
  
     If you don't have a class diagram, create it. See [How to: Add Class Diagrams to Projects](../vs140/how-to--add-class-diagrams-to-projects--class-designer-.md).  
  
2.  In the **Toolbox**, under **Class Designer**, click **Inheritance**.  
  
3.  On the class diagram, draw an inheritance line between the types that you want, starting from:  
  
    -   A derived class to the base class  
  
    -   An implementing class to the implemented interface  
  
    -   An extending interface to the extended interface  
  
4.  Optionally, when you have a derived type from a generic type, click the inheritance line. In the **Properties** window, set the **Type Arguments** property to match the type that you want for the generic type.  
  
    > [!NOTE]
    >  If a parent abstract class contains at least one abstract member, then all abstract members are implemented as non-abstract inheriting classes. See [Implementing Abstract Base Classes](../vs140/refactoring-classes-and-types--class-designer-.md#ImplementingAbstractBaseClasses).  
    >   
    >  Although you can visualize existing generic types, you can't create new generic types. You also can't change the type parameters for existing generic types.  
  
## See Also  
 [Inheritance (C# Programming Guide)](../vs140/inheritance--csharp-programming-guide-.md)   
 [Inheritance Basics (Visual Basic)](../vs140/inheritance-basics--visual-basic-.md)   
 [How to: View Inheritance Between Types on Class Diagrams](../vs140/how-to--view-inheritance-between-types--class-designer-.md)   
 [Visual C++ Classes in Class Designer](../vs140/visual-c---classes-in-class-designer.md)