---
title: "Static Constructors (C# Programming Guide)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - static constructors [C#]
  - constructors [C#], static
ms.assetid: 151ec95e-3c4d-4ed7-885d-95b7a3be2e7d
caps.latest.revision: 27
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Static Constructors (C# Programming Guide)
A static constructor is used to initialize any [static](../vs140/static--csharp-reference-.md) data, or to perform a particular action that needs to be performed once only. It is called automatically before the first instance is created or any static members are referenced.  
  
 [!code[csProgGuideObjects#14](../vs140/codesnippet/CSharp/static-constructors--csharp-programming-guide-_1.cs)]
  
  
 Static constructors have the following properties:  
  
-   A static constructor does not take access modifiers or have parameters.  
  
-   A static constructor is called automatically to initialize the [class](../vs140/class--csharp-reference-.md) before the first instance is created or any static members are referenced.  
  
-   A static constructor cannot be called directly.  
  
-   The user has no control on when the static constructor is executed in the program.  
  
-   A typical use of static constructors is when the class is using a log file and the constructor is used to write entries to this file.  
  
-   Static constructors are also useful when creating wrapper classes for unmanaged code, when the constructor can call the `LoadLibrary` method.  
  
-   If a static constructor throws an exception, the runtime will not invoke it a second time, and the type will remain uninitialized for the lifetime of the application domain in which your program is running.  
  
## Example  
 In this example, class `Bus` has a static constructor. When the first instance of `Bus` is created (`bus1`), the static constructor is invoked to initialize the class. The sample output verifies that the static constructor runs only one time, even though two instances of `Bus` are created, and that it runs before the instance constructor runs.  
  
 [!code[csProgGuideObjects#15](../vs140/codesnippet/CSharp/static-constructors--csharp-programming-guide-_2.cs)]
  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Objects, Classes, and Structs (Visual C#)](../vs140/classes-and-structs--csharp-programming-guide-.md)   
 [Constructors](../vs140/constructors--csharp-programming-guide-.md)   
 [Static Classes and Static Class Members (C# Programming Guide)](../vs140/static-classes-and-static-class-members--csharp-programming-guide-.md)   
 [Destructors (C# Programmer's Reference)](../vs140/destructors--csharp-programming-guide-.md)