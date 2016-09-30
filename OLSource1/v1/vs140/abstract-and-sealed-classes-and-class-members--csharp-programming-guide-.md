---
title: "Abstract and Sealed Classes and Class Members (C# Programming Guide)"
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
  - "abstract classes [C#]"
  - "sealed classes [C#]"
  - "C# language, abstract classes"
  - "C# language, sealed"
ms.assetid: 99aa52f7-b435-43f9-936e-2470af734c4e
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Abstract and Sealed Classes and Class Members (C# Programming Guide)
The [abstract](../vs140/abstract--csharp-reference-.md) keyword enables you to create classes and [class](../vs140/class--csharp-reference-.md) members that are incomplete and must be implemented in a derived class.  
  
 The [sealed](../vs140/sealed--csharp-reference-.md) keyword enables you to prevent the inheritance of a class or certain class members that were previously marked [virtual](../vs140/virtual--csharp-reference-.md).  
  
## Abstract Classes and Class Members  
 Classes can be declared as abstract by putting the keyword <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> before the class definition. For example:  
  
 [!code[csProgGuideInheritance#13](../vs140/codesnippet/CSharp/abstract-and-sealed-classes-and-class-members--csharp-programming-guide-_1.cs)]  
  
 An abstract class cannot be instantiated. The purpose of an abstract class is to provide a common definition of a base class that multiple derived classes can share. For example, a class library may define an abstract class that is used as a parameter to many of its functions, and require programmers using that library to provide their own implementation of the class by creating a derived class.  
  
 Abstract classes may also define abstract methods. This is accomplished by adding the keyword <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> before the return type of the method. For example:  
  
 [!code[csProgGuideInheritance#14](../vs140/codesnippet/CSharp/abstract-and-sealed-classes-and-class-members--csharp-programming-guide-_2.cs)]  
  
 Abstract methods have no implementation, so the method definition is followed by a semicolon instead of a normal method block. Derived classes of the abstract class must implement all abstract methods. When an abstract class inherits a virtual method from a base class, the abstract class can override the virtual method with an abstract method. For example:  
  
 [!code[csProgGuideInheritance#15](../vs140/codesnippet/CSharp/abstract-and-sealed-classes-and-class-members--csharp-programming-guide-_3.cs)]  
  
 If a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method is declared <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, it is still virtual to any class inheriting from the abstract class. A class inheriting an abstract method cannot access the original implementation of the method—in the previous example, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> on class F cannot call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> on class D. In this way, an abstract class can force derived classes to provide new method implementations for virtual methods.  
  
## Sealed Classes and Class Members  
 Classes can be declared as [sealed](../vs140/sealed--csharp-reference-.md) by putting the keyword <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> before the class definition. For example:  
  
 [!code[csProgGuideInheritance#16](../vs140/codesnippet/CSharp/abstract-and-sealed-classes-and-class-members--csharp-programming-guide-_4.cs)]  
  
 A sealed class cannot be used as a base class. For this reason, it cannot also be an abstract class. Sealed classes prevent derivation. Because they can never be used as a base class, some run-time optimizations can make calling sealed class members slightly faster.  
  
 A method, indexer, property, or event, on a derived class that is overriding a virtual member of the base class can declare that member as sealed. This negates the virtual aspect of the member for any further derived class. This is accomplished by putting the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keyword before the [override](../vs140/override--csharp-reference-.md) keyword in the class member declaration. For example:  
  
 [!code[csProgGuideInheritance#17](../vs140/codesnippet/CSharp/abstract-and-sealed-classes-and-class-members--csharp-programming-guide-_5.cs)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Objects, Classes and Structs (C# Programming Guide)](../vs140/classes-and-structs--csharp-programming-guide-.md)   
 [Inheritance (Visual C#)](../vs140/inheritance--csharp-programming-guide-.md)   
 [Class Methods (Visual C#)](../vs140/methods--csharp-programming-guide-.md)   
 [Properties and Fields (Visual C#)](../vs140/fields--csharp-programming-guide-.md)   
 [How to: Define Abstract Properties (C#)](../vs140/how-to--define-abstract-properties--csharp-programming-guide-.md)