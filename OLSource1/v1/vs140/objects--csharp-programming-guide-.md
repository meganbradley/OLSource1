---
title: "Objects (C# Programming Guide)"
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
  - "objects [C#], about objects"
  - "variables [C#]"
ms.assetid: af4a5230-fbf3-4eea-95e1-8b883c2f845c
caps.latest.revision: 30
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Objects (C# Programming Guide)
A class or struct definition is like a blueprint that specifies what the type can do. An object is basically a block of memory that has been allocated and configured according to the blueprint. A program may create many objects of the same class. Objects are also called instances, and they can be stored in either a named variable or in an array or collection. Client code is the code that uses these variables to call the methods and access the public properties of the object. In an object-oriented language such as C#, a typical program consists of multiple objects interacting dynamically.  
  
> [!NOTE]
>  Static types behave differently than what is described here. For more information, see [Static Classes and Static Class Members (C# Programming Guide)](../vs140/static-classes-and-static-class-members--csharp-programming-guide-.md).  
  
## Struct Instances vs. Class Instances  
 Because classes are reference types, a variable of a class object holds a reference to the address of the object on the managed heap. If a second object of the same type is assigned to the first object, then both variables refer to the object at that address. This point is discussed in more detail later in this topic.  
  
 Instances of classes are created by using the [new operator](../vs140/new-operator--csharp-reference-.md). In the following example, `Person` is the type and `person1` and `person 2` are instances, or objects, of that type.  
  
 [!code[csProgGuideStatements#30](../vs140/codesnippet/CSharp/objects--csharp-programming-guide-_1.cs)]  
  
 Because structs are value types, a variable of a struct object holds a copy of the entire object. Instances of structs can also be created by using the `new` operator, but this is not required, as shown in the following example:  
  
 [!code[csProgGuideStatements#31](../vs140/codesnippet/CSharp/objects--csharp-programming-guide-_2.cs)]  
  
 The memory for both `p1` and `p2` is allocated on the thread stack. That memory is reclaimed along with the type or method in which it is declared. This is one reason why structs are copied on assignment. By contrast, the memory that is allocated for a class instance is automatically reclaimed (garbage collected) by the common language runtime when all references to the object have gone out of scope. It is not possible to deterministically destroy a class object like you can in C++. For more information about garbage collection in the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)], see [Garbage Collection](assetId:///22b6cb97-0c80-4eeb-a2cf-5ed7655e37f9).  
  
> [!NOTE]
>  The allocation and deallocation of memory on the managed heap is highly optimized in the common language runtime. In most cases there is no significant difference in the performance cost of allocating a class instance on the heap versus allocating a struct instance on the stack.  
  
## Object Identity vs. Value Equality  
 When you compare two objects for equality, you must first distinguish whether you want to know whether the two variables represent the same object in memory, or whether the values of one or more of their fields are equivalent. If you are intending to compare values, you must consider whether the objects are instances of value types (structs) or reference types (classes, delegates, arrays).  
  
-   To determine whether two class instances refer to the same location in memory (which means that they have the same *identity*), use the static [Equals](assetId:///M:System.Object.Equals(System.Object)?qualifyHint=False&autoUpgrade=True) method. (<xref:System.Object*?displayProperty=fullName> is the implicit base class for all value types and reference types, including user-defined structs and classes.)  
  
-   To determine whether the instance fields in two struct instances have the same values, use the [ValueType.Equals](assetId:///M:System.ValueType.Equals(System.Object)?qualifyHint=True&autoUpgrade=True) method. Because all structs implicitly inherit from <xref:System.ValueType*?displayProperty=fullName>, you call the method directly on your object as shown in the following example:  
  
 [!code[csProgGuideStatements#32](../vs140/codesnippet/CSharp/objects--csharp-programming-guide-_3.cs)]  
  
 The <xref:System.ValueType*?displayProperty=fullName> implementation of `Equals` uses reflection because it must be able to determine what the fields are in any struct. When creating your own structs, override the `Equals` method to provide an efficient equality algorithm that is specific to your type.  
  
-   To determine whether the values of the fields in two class instances are equal, you might be able to use the assetId:///M:System.Object.Equals(System.Object)?qualifyHint=False&autoUpgrade=True method or the [== operator](../vs140/==-operator--csharp-reference-.md). However, only use them if the class has overridden or overloaded them to provide a custom definition of what "equality" means for objects of that type. The class might also implement the <xref:System.IEquatable`1*> interface or the <xref:System.Collections.Generic.IEqualityComparer`1*> interface. Both interfaces provide methods that can be used to test value equality. When designing your own classes that override `Equals`, make sure to follow the guidelines stated in [How to: Define Value Equality for a Type (C# Programming Guide)](../vs140/how-to--define-value-equality-for-a-type--csharp-programming-guide-.md) and <xref:System.Object.Equals(System.Object)?displayProperty=fullName>.  
  
## Related Sections  
 For more information:  
  
-   [Classes (C# Programming Guide)](../vs140/classes--csharp-programming-guide-.md)  
  
-   [Structs (C# Programming Guide)](../vs140/structs--csharp-programming-guide-.md)  
  
-   [Constructors (C# Programming Guide)](../vs140/constructors--csharp-programming-guide-.md)  
  
-   [Destructors (C# Programmer's Reference)](../vs140/destructors--csharp-programming-guide-.md)  
  
-   [Events (C# Programming Guide)](../vs140/events--csharp-programming-guide-.md)  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [object (C# Programmer's Reference)](../vs140/object--csharp-reference-.md)   
 [Inheritance (Visual C#)](../vs140/inheritance--csharp-programming-guide-.md)   
 [class (C# Reference)](../vs140/class--csharp-reference-.md)   
 [struct (C# Reference)](../vs140/struct--csharp-reference-.md)   
 [new Operator](../vs140/new-operator--csharp-reference-.md)   
 [Common Type System](assetId:///53c57c96-83e1-4ee3-9543-9ac832671a89)