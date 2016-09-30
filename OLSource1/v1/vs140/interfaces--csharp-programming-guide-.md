---
title: "Interfaces (C# Programming Guide)"
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
  - "interfaces [C#]"
  - "C# language, interfaces"
ms.assetid: 2feda177-ce11-432d-81b4-d50f5f35fd37
caps.latest.revision: 49
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Interfaces (C# Programming Guide)
An interface contains definitions for a group of related functionalities that a [class](../vs140/class--csharp-reference-.md) or a [struct](../vs140/struct--csharp-reference-.md) can implement.  
  
 By using interfaces, you can, for example, include behavior from multiple sources in a class. That capability is important in C# because the language doesn't support multiple inheritance of classes. In addition, you must use an interface if you want to simulate inheritance for structs, because they can't actually inherit from another struct or class.  
  
 You define an interface by using the [interface](../vs140/interface--csharp-reference-.md) keyword, as the following example shows.  
  
 [!code[csProgGuideInheritance#47](../vs140/codesnippet/CSharp/interfaces--csharp-programming-guide-_1.cs)]  
  
 Any class or struct that implements the <xref:System.IEquatable`1*> interface must contain a definition for an <xref:System.IEquatable`1.Equals*> method that matches the signature that the interface specifies. As a result, you can count on a class that implements `IEquatable<T>` to contain an `Equals` method with which an instance of the class can determine whether it's equal to another instance of the same class.  
  
 The definition of `IEquatable<T>` doesn’t provide an implementation for `Equals`. The interface defines only the signature. In that way, an interface in C# is similar to an abstract class in which all the methods are abstract. However, a class or struct can implement multiple interfaces, but a class can inherit only a single class, abstract or not. Therefore, by using interfaces, you can include behavior from multiple sources in a class.  
  
 For more information about abstract classes, see [Abstract and Sealed Classes and Class Members](../vs140/abstract-and-sealed-classes-and-class-members--csharp-programming-guide-.md).  
  
 Interfaces can contain methods, properties, events, indexers, or any combination of those four member types. For links to examples, see [Related Sections](../vs140/interfaces--csharp-programming-guide-.md#BKMK_RelatedSections). An interface can't contain constants, fields, operators, instance constructors, destructors, or types. Interface members are automatically public, and they can't include any access modifiers. Members also can't be [static](../vs140/static--csharp-reference-.md).  
  
 To implement an interface member, the corresponding member of the implementing class must be public, non-static, and have the same name and signature as the interface member.  
  
 When a class or struct implements an interface, the class or struct must provide an implementation for all of the members that the interface defines. The interface itself provides no functionality that a class or struct can inherit in the way that it can inherit base class functionality. However, if a base class implements an interface, any class that's derived from the base class inherits that implementation.  
  
 The following example shows an implementation of the IEquatable\<T> interface. The implementing class, `Car`, must provide an implementation of the <xref:System.IEquatable`1.Equals*> method.  
  
 [!code[csProgGuideInheritance#48](../vs140/codesnippet/CSharp/interfaces--csharp-programming-guide-_2.cs)]  
  
 Properties and indexers of a class can define extra accessors for a property or indexer that's defined in an interface. For example, an interface might declare a property that has a [get](../vs140/get--csharp-reference-.md) accessor. The class that implements the interface can declare the same property with both a `get` and [set](../vs140/set--csharp-reference-.md) accessor. However, if the property or indexer uses explicit implementation, the accessors must match. For more information about explicit implementation, see [Explicit Interface Implementation](../vs140/explicit-interface-implementation--csharp-programming-guide-.md) and [Interface Properties (C# Programming Guide)](../vs140/interface-properties--csharp-programming-guide-.md).  
  
 Interfaces can implement other interfaces. A class might include an interface multiple times through base classes that it inherits or through interfaces that other interfaces implement. However, the class can provide an implementation of an interface only one time and only if the class declares the interface as part of the definition of the class (`class ClassName : InterfaceName`). If the interface is inherited because you inherited a base class that implements the interface, the base class provides the implementation of the members of the interface. However, the derived class can reimplement the interface members instead of using the inherited implementation.  
  
 A base class can also implement interface members by using virtual members. In that case, a derived class can change the interface behavior by overriding the virtual members. For more information about virtual members, see [Polymorphism](../vs140/polymorphism--csharp-programming-guide-.md).  
  
## Interfaces Summary  
 An interface has the following properties:  
  
-   An interface is like an abstract base class. Any class or struct that implements the interface must implement all its members.  
  
-   An interface can't be instantiated directly. Its members are implemented by any class or struct that implements the interface.  
  
-   Interfaces can contain events, indexers, methods, and properties.  
  
-   Interfaces contain no implementation of methods.  
  
-   A class or struct can implement multiple interfaces. A class can inherit a base class and also implement one or more interfaces.  
  
## In This Section  
 [Explicit Interface Implementation (Visual C#)](../vs140/explicit-interface-implementation--csharp-programming-guide-.md)  
 Explains how to create a class member that’s specific to an interface.  
  
 [How to: Explicitly Implement Interface Members (C#)](../vs140/how-to--explicitly-implement-interface-members--csharp-programming-guide-.md)  
 Provides an example of how to explicitly implement members of interfaces.  
  
 [How to: Explicitly Implement Interface Members with Inheritance (C#)](../vs140/how-to--explicitly-implement-members-of-two-interfaces--csharp-programming-guide-.md)  
 Provides an example of how to explicitly implement members of interfaces with inheritance.  
  
##  <a name="BKMK_RelatedSections"></a> Related Sections  
  
-   [Interface Properties](../vs140/interface-properties--csharp-programming-guide-.md)  
  
-   [Interface Indexers](../vs140/indexers-in-interfaces--csharp-programming-guide-.md)  
  
-   [How to: Declare an Event in an Interface and Implement it in a Class (C#)](../vs140/how-to--implement-interface-events--csharp-programming-guide-.md)  
  
-   [Objects, Classes and Structs (C# Programming Guide)](../vs140/classes-and-structs--csharp-programming-guide-.md)  
  
-   [Inheritance (Visual C#)](../vs140/inheritance--csharp-programming-guide-.md)  
  
-   [Class Methods (Visual C#)](../vs140/methods--csharp-programming-guide-.md)  
  
-   [Polymorphism (Visual C#)](../vs140/polymorphism--csharp-programming-guide-.md)  
  
-   [Abstract and Sealed Classes and Class Members (Visual C#)](../vs140/abstract-and-sealed-classes-and-class-members--csharp-programming-guide-.md)  
  
-   [Properties (C# Programming Guide)](../vs140/properties--csharp-programming-guide-.md)  
  
-   [Events (C# Programming Guide)](../vs140/events--csharp-programming-guide-.md)  
  
-   [Indexers (C# Programming Guide)](../vs140/indexers--csharp-programming-guide-.md)  
  
## Featured Book Chapter  
 [Interfaces](http://msdn.microsoft.com/library/orm-9780596521066-01-13.aspx) in [Learning C# 3.0: Master the Fundamentals of C# 3.0](http://msdn.microsoft.com/library/orm-9780596521066-01.aspx)  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Inheritance (C# Programming Guide)](../vs140/inheritance--csharp-programming-guide-.md)