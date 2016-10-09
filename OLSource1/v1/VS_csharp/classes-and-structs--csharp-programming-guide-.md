---
title: "Classes and Structs (C# Programming Guide)"
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
  - "structs [C#], about structs"
  - "classes [C#], overview"
  - "C# language, structs"
  - "C# language, objects"
  - "objects [C#]"
  - "C# language, classes"
ms.assetid: cc39dbda-8754-423e-b5b1-16a1db0734c0
caps.latest.revision: 48
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Classes and Structs (C# Programming Guide)
Classes and structs are two of the basic constructs of the common type system in the .NET Framework. Each is essentially a data structure that encapsulates a set of data and behaviors that belong together as a logical unit. The data and behaviors are the *members* of the class or struct, and they include its methods, properties, and events, and so on, as listed later in this topic.  
  
 A class or struct declaration is like a blueprint that is used to create instances or objects at run time. If you define a class or struct called `Person`, `Person` is the name of the type. If you declare and initialize a variable `p` of type `Person`, `p` is said to be an object or instance of `Person`. Multiple instances of the same `Person` type can be created, and each instance can have different values in its properties and fields.  
  
 A class is a reference type. When an object of the class is created, the variable to which the object is assigned holds only a reference to that memory. When the object reference is assigned to a new variable, the new variable refers to the original object. Changes made through one variable are reflected in the other variable because they both refer to the same data.  
  
 A struct is a value type. When a struct is created, the variable to which the struct is assigned holds the struct's actual data. When the struct is assigned to a new variable, it is copied. The new variable and the original variable therefore contain two separate copies of the same data. Changes made to one copy do not affect the other copy.  
  
 In general, classes are used to model more complex behavior, or data that is intended to be modified after a class object is created. Structs are best suited for small data structures that contain primarily data that is not intended to be modified after the struct is created.  
  
 For more information, see [Classes](../VS_csharp/classes--csharp-programming-guide-.md), [Objects](../VS_csharp/objects--csharp-programming-guide-.md), and [Structs](../VS_csharp/structs--csharp-programming-guide-.md).  
  
## Example  
 In the following example, `MyCustomClass` is defined with three members at the top level of the `ProgrammingGuide` namespace. An instance (object) of `MyCustomClass` is created in the `Main` method in the `Program` class, and the object’s methods and properties are accessed by using dot notation.  
  
 [!code[csProgGuideObjects#88](../VS_csharp/codesnippet/CSharp/classes-and-structs--csharp-programming-guide-_1.cs)]  
  
## Encapsulation  
 *Encapsulation* is sometimes referred to as the first pillar or principle of object-oriented programming. According to the principle of encapsulation, a class or struct can specify how accessible each of its members is to code outside of the class or struct. Methods and variables that are not intended to be used from outside of the class or assembly can be hidden to limit the potential for coding errors or malicious exploits.  
  
 For more information about classes, see [Classes](../VS_csharp/classes--csharp-programming-guide-.md) and [Objects](../VS_csharp/objects--csharp-programming-guide-.md).  
  
### Members  
 All methods, fields, constants, properties, and events must be declared within a type; these are called the *members* of the type. In C#, there are no global variables or methods as there are in some other languages. Even a program's entry point, the `Main` method, must be declared within a class or struct. The following list includes all the various kinds of members that may be declared in a class or struct.  
  
-   [Fields](../VS_csharp/fields--csharp-programming-guide-.md)  
  
-   [Constants](../VS_csharp/constants--csharp-programming-guide-.md)  
  
-   [Properties](../VS_csharp/properties--csharp-programming-guide-.md)  
  
-   [Methods](../VS_csharp/methods--csharp-programming-guide-.md)  
  
-   [Constructors](../VS_csharp/constructors--csharp-programming-guide-.md)  
  
-   [Destructors](../VS_csharp/destructors--csharp-programming-guide-.md)  
  
-   [Events](../VS_csharp/events--csharp-programming-guide-.md)  
  
-   [Indexers](../VS_csharp/indexers--csharp-programming-guide-.md)  
  
-   [Operators](../VS_csharp/operators--csharp-programming-guide-.md)  
  
-   [Nested Types](../VS_csharp/nested-types--csharp-programming-guide-.md)  
  
### Accessibility  
 Some methods and properties are meant to be called or accessed from code outside your class or struct, known as *client code*. Other methods and properties might be only for use in the class or struct itself. It is important to limit the accessibility of your code so that only the intended client code can reach it. You specify how accessible your types and their members are to client code by using the access modifiers [public](../VS_csharp/public--csharp-reference-.md), [protected](../VS_csharp/protected--csharp-reference-.md), [internal](../VS_csharp/internal--csharp-reference-.md), `protected internal`, and [private](../VS_csharp/private--csharp-reference-.md). The default accessibility is `private`. For more information, see [Access Modifiers](../VS_csharp/access-modifiers--csharp-programming-guide-.md).  
  
### Inheritance  
 Classes (but not structs) support the concept of inheritance. A class that derives from another class (the *base class*) automatically contains all the public, protected, and internal members of the base class except its constructors and destructors. For more information, see [Inheritance](../VS_csharp/inheritance--csharp-programming-guide-.md) and [Polymorphism](../VS_csharp/polymorphism--csharp-programming-guide-.md).  
  
 Classes may be declared as [abstract](../VS_csharp/abstract--csharp-reference-.md), which means that one or more of their methods have no implementation. Although abstract classes cannot be instantiated directly, they can serve as base classes for other classes that provide the missing implementation. Classes can also be declared as [sealed](../VS_csharp/sealed--csharp-reference-.md) to prevent other classes from inheriting from them. For more information, see [Abstract and Sealed Classes and Class Members](../VS_csharp/abstract-and-sealed-classes-and-class-members--csharp-programming-guide-.md).  
  
### Interfaces  
 Classes and structs can inherit multiple interfaces. To inherit from an interface means that the type implements all the methods defined in the interface. For more information, see [Interfaces](../VS_csharp/interfaces--csharp-programming-guide-.md).  
  
### Generic Types  
 Classes and structs can be defined with one or more type parameters. Client code supplies the type when it creates an instance of the type. For example The <xref:System.Collections.Generic.List`1> class in the <xref:System.Collections.Generic> namespace is defined with one type parameter. Client code creates an instance of a `List<string>` or `List<int>` to specify the type that the list will hold. For more information, see [Generics](../VS_csharp/generics--csharp-programming-guide-.md).  
  
### Static Types  
 Classes (but not structs) can be declared as [static](../VS_csharp/static--csharp-reference-.md). A static class can contain only static members and cannot be instantiated with the new keyword. One copy of the class is loaded into memory when the program loads, and its members are accessed through the class name. Both classes and structs can contain static members. For more information, see [Static Classes and Static Class Members](../VS_csharp/static-classes-and-static-class-members--csharp-programming-guide-.md).  
  
### Nested Types  
 A class or struct can be nested within another class or struct. For more information, see [Nested Types](../VS_csharp/nested-types--csharp-programming-guide-.md).  
  
### Partial Types  
 You can define part of a class, struct or method in one code file and another part in a separate code file. For more information, see [Partial Classes and Methods](../VS_csharp/partial-classes-and-methods--csharp-programming-guide-.md).  
  
### Object Initializers  
 You can instantiate and initialize class or struct objects, and collections of objects, without explicitly calling their constructor. For more information, see [Object and Collection Initializers](../VS_csharp/object-and-collection-initializers--csharp-programming-guide-.md).  
  
### Anonymous Types  
 In situations where it is not convenient or necessary to create a named class, for example when you are populating a list with data structures that you do not have to persist or pass to another method, you use anonymous types. For more information, see [Anonymous Types](../VS_csharp/anonymous-types--csharp-programming-guide-.md).  
  
### Extension Methods  
 You can "extend" a class without creating a derived class by creating a separate type whose methods can be called as if they belonged to the original type. For more information, see [Extension Methods](../VS_csharp/extension-methods--csharp-programming-guide-.md).  
  
### Implicitly Typed Local Variables  
 Within a class or struct method, you can use implicit typing to instruct the compiler to determine the correct type at compile time. For more information, see [Implicitly Typed Local Variables](../VS_csharp/implicitly-typed-local-variables--csharp-programming-guide-.md).  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)