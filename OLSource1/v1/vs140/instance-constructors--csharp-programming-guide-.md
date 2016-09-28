---
title: "Instance Constructors (C# Programming Guide)"
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
  - "constructors [C#], instance constructors"
  - "instance constructors [C#]"
ms.assetid: 24663779-c1e5-4af4-a942-ca554e4c542d
caps.latest.revision: 30
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Instance Constructors (C# Programming Guide)
Instance constructors are used to create and initialize any instance member variables when you use the [new](../vs140/new--csharp-reference-.md) expression to create an object of a [class](../vs140/class--csharp-reference-.md). To initialize a [static](../vs140/static--csharp-reference-.md) class, or static variables in a non-static class, you must define a static constructor. For more information, see [Static Constructors (C# Programming Guide)](../vs140/static-constructors--csharp-programming-guide-.md).  
  
 The following example shows an instance constructor:  
  
 [!code[csProgGuideObjects#5](../vs140/codesnippet/CSharp/instance-constructors--csharp-programming-guide-_1.cs)]  
  
> [!NOTE]
>  For clarity, this class contains public fields. The use of public fields is not a recommended programming practice because it allows any method anywhere in a program unrestricted and unverified access to an object's inner workings. Data members should generally be private, and should be accessed only through class methods and properties.  
  
 This instance constructor is called whenever an object based on the `CoOrds` class is created. A constructor like this one, which takes no arguments, is called a *default constructor*. However, it is often useful to provide additional constructors. For example, we can add a constructor to the `CoOrds` class that allows us to specify the initial values for the data members:  
  
 [!code[csProgGuideObjects#76](../vs140/codesnippet/CSharp/instance-constructors--csharp-programming-guide-_2.cs)]  
  
 This allows `CoOrd` objects to be created with default or specific initial values, like this:  
  
 [!code[csProgGuideObjects#77](../vs140/codesnippet/CSharp/instance-constructors--csharp-programming-guide-_3.cs)]  
  
 If a class does not have a constructor, a default constructor is automatically generated and default values are used to initialize the object fields. For example, an [int](../vs140/int--csharp-reference-.md) is initialized to 0. For more information on default values, see [Default Values Table](../vs140/default-values-table--csharp-reference-.md). Therefore, because the `CoOrds` class default constructor initializes all data members to zero, it can be removed altogether without changing how the class works. A complete example using multiple constructors is provided in Example 1 later in this topic, and an example of an automatically generated constructor is provided in Example 2.  
  
 Instance constructors can also be used to call the instance constructors of base classes. The class constructor can invoke the constructor of the base class through the initializer, as follows:  
  
 [!code[csProgGuideObjects#78](../vs140/codesnippet/CSharp/instance-constructors--csharp-programming-guide-_4.cs)]  
  
 In this example, the `Circle` class passes values representing radius and height to the constructor provided by `Shape` from which `Circle` is derived. A complete example using `Shape` and `Circle` appears in this topic as Example 3.  
  
## Example 1  
 The following example demonstrates a class with two class constructors, one without arguments and one with two arguments.  
  
 [!code[csProgGuideObjects#4](../vs140/codesnippet/CSharp/instance-constructors--csharp-programming-guide-_5.cs)]  
  
## Example 2  
 In this example, the class `Person` does not have any constructors, in which case, a default constructor is automatically provided and the fields are initialized to their default values.  
  
 [!code[csProgGuideObjects#8](../vs140/codesnippet/CSharp/instance-constructors--csharp-programming-guide-_6.cs)]  
  
 Notice that the default value of `age` is `0` and the default value of `name` is `null`. For more information on default values, see [Default Values Table](../vs140/default-values-table--csharp-reference-.md).  
  
## Example 3  
 The following example demonstrates using the base class initializer. The `Circle` class is derived from the general class `Shape`, and the `Cylinder` class is derived from the `Circle` class. The constructor on each derived class is using its base class initializer.  
  
 [!code[csProgGuideObjects#9](../vs140/codesnippet/CSharp/instance-constructors--csharp-programming-guide-_7.cs)]  
  
 For more examples on invoking the base class constructors, see [virtual](../vs140/virtual--csharp-reference-.md), [override](../vs140/override--csharp-reference-.md), and [base](../vs140/base--csharp-reference-.md).  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Objects, Classes, and Structs (Visual C#)](../vs140/classes-and-structs--csharp-programming-guide-.md)   
 [Constructors](../vs140/constructors--csharp-programming-guide-.md)   
 [Destructors (C# Programmer's Reference)](../vs140/destructors--csharp-programming-guide-.md)   
 [static (C# Reference)](../vs140/static--csharp-reference-.md)