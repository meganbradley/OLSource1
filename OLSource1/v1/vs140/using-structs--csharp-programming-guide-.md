---
title: "Using Structs (C# Programming Guide)"
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
  - structs [C#], using
ms.assetid: cea4a459-9eb9-442b-8d08-490e0797ba38
caps.latest.revision: 32
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Using Structs (C# Programming Guide)
The `struct` type is suitable for representing lightweight objects such as `Point`, `Rectangle`, and `Color`. Although it is just as convenient to represent a point as a [class](../vs140/class--csharp-reference-.md) with [Auto-Implemented Properties](../vs140/auto-implemented-properties--csharp-programming-guide-.md), a [struct](../vs140/struct--csharp-reference-.md) might be more efficient in some scenarios. For example, if you declare an array of 1000 `Point` objects, you will allocate additional memory for referencing each object; in this case, a struct would be less expensive. Because the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] contains an object called <xref:System.Drawing.Point?qualifyHint=False>, the struct in this example is named "CoOrds" instead.  
  
 [!code[csProgGuideObjects#1](../vs140/codesnippet/CSharp/using-structs--csharp-programming-guide-_1.cs)]
  
  
 It is an error to define a default (parameterless) constructor for a struct. It is also an error to initialize an instance field in a struct body. You can initialize struct members only by using a parameterized constructor or by accessing the members individually after the struct is declared. Any private or otherwise inaccessible members can be initialized only in a constructor.  
  
 When you create a struct object using the [new](../vs140/new--csharp-reference-.md) operator, it gets created and the appropriate constructor is called. Unlike classes, structs can be instantiated without using the `new` operator. In such a case, there is no constructor call, which makes the allocation more efficient. However, the fields will remain unassigned and the object cannot be used until all of the fields are initialized.  
  
 When a struct contains a reference type as a member, the default constructor of the member must be invoked explicitly, otherwise the member remains unassigned and the struct cannot be used. (This results in compiler error CS0171.)  
  
 There is no inheritance for structs as there is for classes. A struct cannot inherit from another struct or class, and it cannot be the base of a class. Structs, however, inherit from the base class <xref:System.Object?qualifyHint=False>. A struct can implement interfaces, and it does that exactly as classes do.  
  
 You cannot declare a class using the keyword `struct`. In C#, classes and structs are semantically different. A struct is a value type, while a class is a reference type. For more information, see [Value Types](../vs140/value-types--csharp-reference-.md).  
  
 Unless you need reference-type semantics, a small class may be more efficiently handled by the system if you declare it as a struct instead.  
  
## Example 1  
  
### Description  
 This example demonstrates `struct` initialization using both default and parameterized constructors.  
  
### Code  
 [!code[csProgGuideObjects#1](../vs140/codesnippet/CSharp/using-structs--csharp-programming-guide-_1.cs)]
  
  
 [!code[csProgGuideObjects#2](../vs140/codesnippet/CSharp/using-structs--csharp-programming-guide-_2.cs)]
  
  
## Example 2  
  
### Description  
 This example demonstrates a feature that is unique to structs. It creates a CoOrds object without using the `new` operator. If you replace the word `struct` with the word `class`, the program will not compile.  
  
### Code  
 [!code[csProgGuideObjects#1](../vs140/codesnippet/CSharp/using-structs--csharp-programming-guide-_1.cs)]
  
  
 [!code[csProgGuideObjects#3](../vs140/codesnippet/CSharp/using-structs--csharp-programming-guide-_3.cs)]
  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Objects, Classes and Structs (C# Programming Guide)](../vs140/classes-and-structs--csharp-programming-guide-.md)   
 [Structs (C#)](../vs140/structs--csharp-programming-guide-.md)