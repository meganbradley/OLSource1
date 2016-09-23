---
title: "static (C# Reference)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - static
  - static_CSharpKeyword
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - static keyword [C#]
ms.assetid: 5509e215-2183-4da3-bab4-6b7e607a4fdf
caps.latest.revision: 30
translation.priority.ht: 
  - de-de
  - ja-jp
---
# static (C# Reference)
Use the `static` modifier to declare a static member, which belongs to the type itself rather than to a specific object. The `static` modifier can be used with classes, fields, methods, properties, operators, events, and constructors, but it cannot be used with indexers, destructors, or types other than classes. For more information, see [Static Classes and Static Class Members](../vs140/static-classes-and-static-class-members--csharp-programming-guide-.md).  
  
## Example  
 The following class is declared as `static` and contains only `static` methods:  
  
 [!code[csrefKeywordsModifiers#18](../vs140/codesnippet/CSharp/static--csharp-reference-_1.cs)]
  
  
 A constant or type declaration is implicitly a static member.  
  
 A static member cannot be referenced through an instance. Instead, it is referenced through the type name. For example, consider the following class:  
  
 [!code[csrefKeywordsModifiers#19](../vs140/codesnippet/CSharp/static--csharp-reference-_2.cs)]
  
  
 To refer to the static member `x`, use the fully qualified name, `MyBaseC.MyStruct.x`, unless the member is accessible from the same scope:  
  
```c#  
Console.WriteLine(MyBaseC.MyStruct.x);  
```  
  
 While an instance of a class contains a separate copy of all instance fields of the class, there is only one copy of each static field.  
  
 It is not possible to use [this](../vs140/this--csharp-reference-.md) to reference static methods or property accessors.  
  
 If the `static` keyword is applied to a class, all the members of the class must be static.  
  
 Classes and static classes may have static constructors. Static constructors are called at some point between when the program starts and the class is instantiated.  
  
> [!NOTE]
>  The `static` keyword has more limited uses than in C++. To compare with the C++ keyword, see [Static](../vs140/static--c---.md).  
  
 To demonstrate static members, consider a class that represents a company employee. Assume that the class contains a method to count employees and a field to store the number of employees. Both the method and the field do not belong to any instance employee. Instead they belong to the company class. Therefore, they should be declared as static members of the class.  
  
## Example  
 This example reads the name and ID of a new employee, increments the employee counter by one, and displays the information for the new employee and the new number of employees. For simplicity, this program reads the current number of employees from the keyboard. In a real application, this information should be read from a file.  
  
 [!code[csrefKeywordsModifiers#20](../vs140/codesnippet/CSharp/static--csharp-reference-_3.cs)]
  
  
## Example  
 This example shows that although you can initialize a static field by using another static field not yet declared, the results will be undefined until you explicitly assign a value to the static field.  
  
 [!code[csrefKeywordsModifiers#21](../vs140/codesnippet/CSharp/static--csharp-reference-_4.cs)]
  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Modifiers](../vs140/modifiers--csharp-reference-.md)   
 [Static Classes and Static Class Members](../vs140/static-classes-and-static-class-members--csharp-programming-guide-.md)