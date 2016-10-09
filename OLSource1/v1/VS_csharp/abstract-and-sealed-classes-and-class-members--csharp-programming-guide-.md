---
title: "Abstract and Sealed Classes and Class Members (C# Programming Guide)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 14
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Abstract and Sealed Classes and Class Members (C# Programming Guide)
The [abstract](../VS_csharp/abstract--csharp-reference-.md) keyword enables you to create classes and [class](../VS_csharp/class--csharp-reference-.md) members that are incomplete and must be implemented in a derived class.  
  
 The [sealed](../VS_csharp/sealed--csharp-reference-.md) keyword enables you to prevent the inheritance of a class or certain class members that were previously marked [virtual](../VS_csharp/virtual--csharp-reference-.md).  
  
## Abstract Classes and Class Members  
 Classes can be declared as abstract by putting the keyword `abstract` before the class definition. For example:  
  
 [!code[csProgGuideInheritance#13](../VS_csharp/codesnippet/CSharp/abstract-and-sealed-classes-and-class-members--csharp-programming-guide-_1.cs)]  
  
 An abstract class cannot be instantiated. The purpose of an abstract class is to provide a common definition of a base class that multiple derived classes can share. For example, a class library may define an abstract class that is used as a parameter to many of its functions, and require programmers using that library to provide their own implementation of the class by creating a derived class.  
  
 Abstract classes may also define abstract methods. This is accomplished by adding the keyword `abstract` before the return type of the method. For example:  
  
 [!code[csProgGuideInheritance#14](../VS_csharp/codesnippet/CSharp/abstract-and-sealed-classes-and-class-members--csharp-programming-guide-_2.cs)]  
  
 Abstract methods have no implementation, so the method definition is followed by a semicolon instead of a normal method block. Derived classes of the abstract class must implement all abstract methods. When an abstract class inherits a virtual method from a base class, the abstract class can override the virtual method with an abstract method. For example:  
  
 [!code[csProgGuideInheritance#15](../VS_csharp/codesnippet/CSharp/abstract-and-sealed-classes-and-class-members--csharp-programming-guide-_3.cs)]  
  
 If a `virtual` method is declared `abstract`, it is still virtual to any class inheriting from the abstract class. A class inheriting an abstract method cannot access the original implementation of the method—in the previous example, `DoWork` on class F cannot call `DoWork` on class D. In this way, an abstract class can force derived classes to provide new method implementations for virtual methods.  
  
## Sealed Classes and Class Members  
 Classes can be declared as [sealed](../VS_csharp/sealed--csharp-reference-.md) by putting the keyword `sealed` before the class definition. For example:  
  
 [!code[csProgGuideInheritance#16](../VS_csharp/codesnippet/CSharp/abstract-and-sealed-classes-and-class-members--csharp-programming-guide-_4.cs)]  
  
 A sealed class cannot be used as a base class. For this reason, it cannot also be an abstract class. Sealed classes prevent derivation. Because they can never be used as a base class, some run-time optimizations can make calling sealed class members slightly faster.  
  
 A method, indexer, property, or event, on a derived class that is overriding a virtual member of the base class can declare that member as sealed. This negates the virtual aspect of the member for any further derived class. This is accomplished by putting the `sealed` keyword before the [override](../VS_csharp/override--csharp-reference-.md) keyword in the class member declaration. For example:  
  
 [!code[csProgGuideInheritance#17](../VS_csharp/codesnippet/CSharp/abstract-and-sealed-classes-and-class-members--csharp-programming-guide-_5.cs)]  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Classes and Structs](../VS_csharp/classes-and-structs--csharp-programming-guide-.md)   
 [Inheritance](../VS_csharp/inheritance--csharp-programming-guide-.md)   
 [Methods](../VS_csharp/methods--csharp-programming-guide-.md)   
 [Fields](../VS_csharp/fields--csharp-programming-guide-.md)   
 [How to: Define Abstract Properties](../VS_csharp/how-to--define-abstract-properties--csharp-programming-guide-.md)