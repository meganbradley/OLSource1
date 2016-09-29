---
title: "Using Constructors (C# Programming Guide)"
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
  - "constructors [C#], about constructors"
ms.assetid: 464253b2-fd5d-469a-836d-df0fdf2a43f7
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Constructors (C# Programming Guide)
When a [class](../VS_csharp/class--csharp-reference-.md) or [struct](../VS_csharp/struct--csharp-reference-.md) is created, its constructor is called. Constructors have the same name as the class or struct, and they usually initialize the data members of the new object.  
  
 In the following example, a class named `Taxi` is defined by using a simple constructor. This class is then instantiated with the [new](../VS_csharp/new--csharp-reference-.md) operator. The `Taxi` constructor is invoked by the `new` operator immediately after memory is allocated for the new object.  
  
 [!code[csProgGuideObjects#53](../VS_csharp/codesnippet/CSharp/using-constructors--csharp-programming-guide-_1.cs)]  
  
 A constructor that takes no parameters is called a *default constructor*. Default constructors are invoked whenever an object is instantiated by using the `new` operator and no arguments are provided to `new`. For more information, see [Instance Constructors](../VS_csharp/instance-constructors--csharp-programming-guide-.md).  
  
 Unless the class is [static](../VS_csharp/static--csharp-reference-.md), classes without constructors are given a public default constructor by the C# compiler in order to enable class instantiation. For more information, see [Static Classes and Static Class Members](../VS_csharp/static-classes-and-static-class-members--csharp-programming-guide-.md).  
  
 You can prevent a class from being instantiated by making the constructor private, as follows:  
  
 [!code[csProgGuideObjects#11](../VS_csharp/codesnippet/CSharp/using-constructors--csharp-programming-guide-_2.cs)]  
  
 For more information, see [Private Constructors](../VS_csharp/private-constructors--csharp-programming-guide-.md).  
  
 Constructors for [struct](../VS_csharp/struct--csharp-reference-.md) types resemble class constructors, but `structs` cannot contain an explicit default constructor because one is provided automatically by the compiler. This constructor initializes each field in the `struct` to the default values. For more information, see [Default Values Table](../VS_csharp/default-values-table--csharp-reference-.md). However, this default constructor is only invoked if the `struct` is instantiated with `new`. For example, this code uses the default constructor for <xref:System.Int32*>, so that you are assured that the integer is initialized:  
  
```  
int i = new int();  
Console.WriteLine(i);  
```  
  
 The following code, however, causes a compiler error because it does not use `new`, and because it tries to use an object that has not been initialized:  
  
```  
int i;  
Console.WriteLine(i);  
```  
  
 Alternatively, objects based on `structs` (including all built-in numeric types) can be initialized or assigned and then used as in the following example:  
  
```  
int a = 44;  // Initialize the value type...  
int b;  
b = 33;      // Or assign it before using it.  
Console.WriteLine("{0}, {1}", a, b);  
```  
  
 So calling the default constructor for a value type is not required.  
  
 Both classes and `structs` can define constructors that take parameters. Constructors that take parameters must be called through a `new` statement or a [base](../VS_csharp/base--csharp-reference-.md) statement. Classes and `structs` can also define multiple constructors, and neither is required to define a default constructor. For example:  
  
 [!code[csProgGuideObjects#54](../VS_csharp/codesnippet/CSharp/using-constructors--csharp-programming-guide-_3.cs)]  
  
 This class can be created by using either of the following statements:  
  
 [!code[csProgGuideObjects#55](../VS_csharp/codesnippet/CSharp/using-constructors--csharp-programming-guide-_4.cs)]  
  
 A constructor can use the `base` keyword to call the constructor of a base class. For example:  
  
 [!code[csProgGuideObjects#56](../VS_csharp/codesnippet/CSharp/using-constructors--csharp-programming-guide-_5.cs)]  
  
 In this example, the constructor for the base class is called before the block for the constructor is executed. The `base` keyword can be used with or without parameters. Any parameters to the constructor can be used as parameters to `base`, or as part of an expression. For more information, see [base](../VS_csharp/base--csharp-reference-.md).  
  
 In a derived class, if a base-class constructor is not called explicitly by using the `base` keyword, the default constructor, if there is one, is called implicitly. This means that the following constructor declarations are effectively the same:  
  
 [!code[csProgGuideObjects#58](../VS_csharp/codesnippet/CSharp/using-constructors--csharp-programming-guide-_6.cs)]  
  
 [!code[csProgGuideObjects#57](../VS_csharp/codesnippet/CSharp/using-constructors--csharp-programming-guide-_7.cs)]  
  
 If a base class does not offer a default constructor, the derived class must make an explicit call to a base constructor by using `base`.  
  
 A constructor can invoke another constructor in the same object by using the [this](../VS_csharp/this--csharp-reference-.md) keyword. Like `base`, `this` can be used with or without parameters, and any parameters in the constructor are available as parameters to `this`, or as part of an expression. For example, the second constructor in the previous example can be rewritten using `this`:  
  
 [!code[csProgGuideObjects#59](../VS_csharp/codesnippet/CSharp/using-constructors--csharp-programming-guide-_8.cs)]  
  
 The use of the `this` keyword in the previous example causes this constructor to be called:  
  
 [!code[csProgGuideObjects#60](../VS_csharp/codesnippet/CSharp/using-constructors--csharp-programming-guide-_9.cs)]  
  
 Constructors can be marked as [public](../VS_csharp/public--csharp-reference-.md), [private](../VS_csharp/private--csharp-reference-.md), [protected](../VS_csharp/protected--csharp-reference-.md), [internal](../VS_csharp/internal--csharp-reference-.md), or `protected``internal`. These access modifiers define how users of the class can construct the class. For more information, see [Access Modifiers](../VS_csharp/access-modifiers--csharp-programming-guide-.md).  
  
 A constructor can be declared static by using the [static](../VS_csharp/static--csharp-reference-.md) keyword. Static constructors are called automatically, immediately before any static fields are accessed, and are generally used to initialize static class members. For more information, see [Static Constructors](../VS_csharp/static-constructors--csharp-programming-guide-.md).  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Objects, Classes and Structs (Visual C#)](../VS_csharp/classes-and-structs--csharp-programming-guide-.md)   
 [Constructors](../VS_csharp/constructors--csharp-programming-guide-.md)   
 [Destructors (C# Programmer's Reference)](../VS_csharp/destructors--csharp-programming-guide-.md)