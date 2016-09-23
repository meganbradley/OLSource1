---
title: "Generics (C# Programming Guide)"
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
  - C# language, generics
  - generics [C#]
ms.assetid: 75ea8509-a4ea-4e7a-a2b3-cf72482e9282
caps.latest.revision: 27
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Generics (C# Programming Guide)
Generics were added to version 2.0 of the C# language and the common language runtime (CLR). Generics introduce to the .NET Framework the concept of type parameters, which make it possible to design classes and methods that defer the specification of one or more types until the class or method is declared and instantiated by client code. For example, by using a generic type parameter T you can write a single class that other client code can use without incurring the cost or risk of runtime casts or boxing operations, as shown here:  
  
 [!code[csProgGuideGenerics#1](../vs140/codesnippet/CSharp/generics--csharp-programming-guide-_1.cs)]
  
  
## Generics Overview  
  
-   Use generic types to maximize code reuse, type safety, and performance.  
  
-   The most common use of generics is to create collection classes.  
  
-   The .NET Framework class library contains several new generic collection classes in the <xref:System.Collections.Generic?qualifyHint=False> namespace. These should be used whenever possible instead of classes such as <xref:System.Collections.ArrayList?qualifyHint=False> in the <xref:System.Collections?qualifyHint=False> namespace.  
  
-   You can create your own generic interfaces, classes, methods, events and delegates.  
  
-   Generic classes may be constrained to enable access to methods on particular data types.  
  
-   Information on the types that are used in a generic data type may be obtained at run-time by using reflection.  
  
## Related Sections  
 For more information:  
  
-   [Generics Overview (C# Programmer's Reference)](../vs140/introduction-to-generics--csharp-programming-guide-.md)  
  
-   [Benefits of Generics (C# Programmer's Reference)](../vs140/benefits-of-generics--csharp-programming-guide-.md)  
  
-   [Generic Type Parameters (C# Programmer's Reference)](../vs140/generic-type-parameters--csharp-programming-guide-.md)  
  
-   [Constraints on Type Parameters (C# Programmer's Reference)](../vs140/constraints-on-type-parameters--csharp-programming-guide-.md)  
  
-   [Generic Classes (C# Programmer's Reference)](../vs140/generic-classes--csharp-programming-guide-.md)  
  
-   [Generic Interfaces (C# Programmer's Reference)](../vs140/generic-interfaces--csharp-programming-guide-.md)  
  
-   [Generic Methods (C# Programmer's Reference)](../vs140/generic-methods--csharp-programming-guide-.md)  
  
-   [Generic Delegates (C# Programmer's Reference)](../vs140/generic-delegates--csharp-programming-guide-.md)  
  
-   [default Keyword in Generic Code (C# Programmer's Reference)](../vs140/default-keyword-in-generic-code--csharp-programming-guide-.md)  
  
-   [Differences Between C++ Templates and C# Generics](../vs140/differences-between-c---templates-and-csharp-generics--csharp-programming-guide-.md)  
  
-   [Generics and Reflection  (C# Programmer's Reference)](../vs140/generics-and-reflection--csharp-programming-guide-.md)  
  
-   [Generics in the Runtime(C# Programmer's Reference)](../vs140/generics-in-the-run-time--csharp-programming-guide-.md)  
  
-   [Generics in the Base Class Library(C# Programmer's Reference)](../vs140/generics-in-the-.net-framework-class-library--csharp-programming-guide-.md)  
  
## C# Language Specification  
 For more information, see the [C# Language Specification](../vs140/csharp-language-specification.md).  
  
## See Also  
 <xref:System.Collections.Generic?qualifyHint=False>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Data Types](../vs140/types--csharp-programming-guide-.md)   
 [<typeparam\> (C# Programming Guide)](../vs140/-typeparam---csharp-programming-guide-.md)   
 [<typeparamref\> (C# Programming Guide)](../vs140/-typeparamref---csharp-programming-guide-.md)