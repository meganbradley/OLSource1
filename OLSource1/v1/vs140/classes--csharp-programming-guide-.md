---
title: "Classes (C# Programming Guide)"
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
  - "classes [C#]"
  - "C# language, classes"
ms.assetid: e8848524-7273-429f-8aba-c658d5eff5ad
caps.latest.revision: 44
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Classes (C# Programming Guide)
A *class* is a construct that enables you to create your own custom types by grouping together variables of other types, methods and events. A class is like a blueprint. It defines the data and behavior of a type. If the class is not declared as static, client code can use it by creating *objects* or *instances* which are assigned to a variable. The variable remains in memory until all references to it go out of scope. At that time, the CLR marks it as eligible for garbage collection. If the class is declared as [static](../vs140/static--csharp-reference-.md), then only one copy exists in memory and client code can only access it through the class itself, not an *instance variable*. For more information, see [Static Classes and Static Class Members](../vs140/static-classes-and-static-class-members--csharp-programming-guide-.md).  
  
 Unlike structs, classes support *inheritance*, a fundamental characteristic of object-oriented programming. For more information, see [Inheritance](../vs140/inheritance--csharp-programming-guide-.md).  
  
## Declaring Classes  
 Classes are declared by using the [class](../vs140/class--csharp-reference-.md) keyword, as shown in the following example:  
  
 [!code[csProgGuideObjects#79](../vs140/codesnippet/CSharp/classes--csharp-programming-guide-_1.cs)]  
  
 The `class` keyword is preceded by the access level. Because [public](../vs140/public--csharp-reference-.md) is used in this case, anyone can create objects from this class. The name of the class follows the `class` keyword. The remainder of the definition is the class body, where the behavior and data are defined. Fields, properties, methods, and events on a class are collectively referred to as *class members*.  
  
## Creating Objects  
 Although they are sometimes used interchangeably, a class and an object are different things. A class defines a type of object, but it is not an object itself. An object is a concrete entity based on a class, and is sometimes referred to as an instance of a class.  
  
 Objects can be created by using the [new](../vs140/new--csharp-reference-.md) keyword followed by the name of the class that the object will be based on, like this:  
  
 [!code[csProgGuideObjects#80](../vs140/codesnippet/CSharp/classes--csharp-programming-guide-_2.cs)]  
  
 When an instance of a class is created, a reference to the object is passed back to the programmer. In the previous example, `object1` is a reference to an object that is based on `Customer`. This reference refers to the new object but does not contain the object data itself. In fact, you can create an object reference without creating an object at all:  
  
 [!code[csProgGuideObjects#81](../vs140/codesnippet/CSharp/classes--csharp-programming-guide-_3.cs)]  
  
 We do not recommend creating object references such as this one that does not refer to an object because trying to access an object through such a reference will fail at run time. However, such a reference can be made to refer to an object, either by creating a new object, or by assigning it to an existing object, such as this:  
  
 [!code[csProgGuideObjects#82](../vs140/codesnippet/CSharp/classes--csharp-programming-guide-_4.cs)]  
  
 This code creates two object references that both refer to the same object. Therefore, any changes to the object made through `object3` will be reflected in subsequent uses of `object4`. Because objects that are based on classes are referred to by reference, classes are known as reference types.  
  
## Class Inheritance  
 Inheritance is accomplished by using a *derivation*, which means a class is declared by using a *base class* from which it inherits data and behavior. A base class is specified by appending a colon and the name of the base class following the derived class name, like this:  
  
 [!code[csProgGuideObjects#83](../vs140/codesnippet/CSharp/classes--csharp-programming-guide-_5.cs)]  
  
 When a class declares a base class, it inherits all the members of the base class except the constructors.  
  
 Unlike C++, a class in C# can only directly inherit from one base class. However, because a base class may itself inherit from another class, a class may indirectly inherit multiple base classes. Furthermore, a class can directly implement more than one interface. For more information, see [Interfaces](../vs140/interfaces--csharp-programming-guide-.md).  
  
 A class can be declared [abstract](../vs140/abstract--csharp-reference-.md). An abstract class contains abstract methods that have a signature definition but no implementation. Abstract classes cannot be instantiated. They can only be used through derived classes that implement the abstract methods. By constrast, a [sealed](../vs140/sealed--csharp-reference-.md) class does not allow other classes to derive from it. For more information, see [Abstract and Sealed Classes and Class Members (C# Programming Guide)](../vs140/abstract-and-sealed-classes-and-class-members--csharp-programming-guide-.md).  
  
 Class definitions can be split between different source files. For more information, see [Partial Class Definitions](../vs140/partial-classes-and-methods--csharp-programming-guide-.md).  
  
## Description  
 In the following example, a public class that contains a single field, a method, and a special method called a constructor is defined. For more information, see [Constructors](../vs140/constructors--csharp-programming-guide-.md). The class is then instantiated with the `new` keyword.  
  
## Example  
 [!code[csProgGuideObjects#84](../vs140/codesnippet/CSharp/classes--csharp-programming-guide-_6.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Object-Oriented Programming (C# and Visual Basic)](../vs140/object-oriented-programming--csharp-and-visual-basic-.md)   
 [Polymorphism (C# Programming Guide)](../vs140/polymorphism--csharp-programming-guide-.md)   
 [Class and Struct Members](../vs140/members--csharp-programming-guide-.md)   
 [Class and Struct Methods (C#)](../vs140/methods--csharp-programming-guide-.md)   
 [Constructors](../vs140/constructors--csharp-programming-guide-.md)   
 [Destructors (C# Programmer's Reference)](../vs140/destructors--csharp-programming-guide-.md)   
 [Objects (C#)](../vs140/objects--csharp-programming-guide-.md)