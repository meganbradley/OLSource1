---
title: "Generic Classes (C# Programming Guide)"
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
  - "C# language, generic classes"
  - "generics [C#], classes"
ms.assetid: 27d6f256-cd61-41e3-bc6e-b990a53b0224
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Generic Classes (C# Programming Guide)
Generic classes encapsulate operations that are not specific to a particular data type. The most common use for generic classes is with collections like linked lists, hash tables, stacks, queues, trees, and so on. Operations such as adding and removing items from the collection are performed in basically the same way regardless of the type of data being stored.  
  
 For most scenarios that require collection classes, the recommended approach is to use the ones provided in the .NET Framework class library. For more information about using these classes, see [Generics in the Base Class Library](../vs140/generics-in-the-.net-framework-class-library--csharp-programming-guide-.md).  
  
 Typically, you create generic classes by starting with an existing concrete class, and changing types into type parameters one at a time until you reach the optimal balance of generalization and usability. When creating your own generic classes, important considerations include the following:  
  
-   Which types to generalize into type parameters.  
  
     As a rule, the more types you can parameterize, the more flexible and reusable your code becomes. However, too much generalization can create code that is difficult for other developers to read or understand.  
  
-   What constraints, if any, to apply to the type parameters (See [Constraints on Type Parameters (C# Programmers Reference)](../vs140/constraints-on-type-parameters--csharp-programming-guide-.md)).  
  
     A good rule is to apply the maximum constraints possible that will still let you handle the types you must handle. For example, if you know that your generic class is intended for use only with reference types, apply the class constraint. That will prevent unintended use of your class with value types, and will enable you to use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> operator on <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, and check for null values.  
  
-   Whether to factor generic behavior into base classes and subclasses.  
  
     Because generic classes can serve as base classes, the same design considerations apply here as with non-generic classes. See the rules about inheriting from generic base classes later in this topic.  
  
-   Whether to implement one or more generic interfaces.  
  
     For example, if you are designing a class that will be used to create items in a generics-based collection, you may have to implement an interface such as <xref:System.IComparable<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>T<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>Node<T>,<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>Node<int><CodeContentPlaceHolder>5\</CodeContentPlaceHolder>Node<T><CodeContentPlaceHolder>6\</CodeContentPlaceHolder>List<BaseClass><CodeContentPlaceHolder>7\</CodeContentPlaceHolder>List<DerivedClass>`.  
  
## See Also  
 \<xref:System.Collections.Generic*>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Generics (C#)](../vs140/generics--csharp-programming-guide-.md)   
 [Saving the State of Enumerators](http://go.microsoft.com/fwlink/?LinkId=112390)   
 [An Inheritance Puzzle, Part One](http://go.microsoft.com/fwlink/?LinkId=112380)