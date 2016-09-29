---
title: "Generic Interfaces (C# Programming Guide)"
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
  - "C# language, generic interfaces"
  - "generics [C#], interfaces"
ms.assetid: a8fa49a1-6e78-4a09-87e5-84a0b9f5ffbe
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Generic Interfaces (C# Programming Guide)
It is often useful to define interfaces either for generic collection classes, or for the generic classes that represent items in the collection. The preference for generic classes is to use generic interfaces, such as <xref:System.IComparable`1*> rather than <xref:System.IComparable*>, in order to avoid boxing and unboxing operations on value types. The .NET Framework class library defines several generic interfaces for use with the collection classes in the <xref:System.Collections.Generic*> namespace.  
  
 When an interface is specified as a constraint on a type parameter, only types that implement the interface can be used. The following code example shows a `SortedList<T>` class that derives from the `GenericList<T>` class. For more information, see [Generics Overview (C#)](../vs140/introduction-to-generics--csharp-programming-guide-.md). `SortedList<T>` adds the constraint `where T : IComparable<T>`. This enables the `BubbleSort` method in `SortedList<T>` to use the generic <xref:System.IComparable`1.CompareTo*> method on list elements. In this example, list elements are a simple class, `Person`, that implements `IComparable<Person>`.  
  
 [!code[csProgGuideGenerics#29](../vs140/codesnippet/CSharp/generic-interfaces--csharp-programming-guide-_1.cs)]  
  
 Multiple interfaces can be specified as constraints on a single type, as follows:  
  
 [!code[csProgGuideGenerics#30](../vs140/codesnippet/CSharp/generic-interfaces--csharp-programming-guide-_2.cs)]  
  
 An interface can define more than one type parameter, as follows:  
  
 [!code[csProgGuideGenerics#31](../vs140/codesnippet/CSharp/generic-interfaces--csharp-programming-guide-_3.cs)]  
  
 The rules of inheritance that apply to classes also apply to interfaces:  
  
 [!code[csProgGuideGenerics#32](../vs140/codesnippet/CSharp/generic-interfaces--csharp-programming-guide-_4.cs)]  
  
 Generic interfaces can inherit from non-generic interfaces if the generic interface is contra-variant, which means it only uses its type parameter as a return value. In the .NET Framework class library, <xref:System.Collections.Generic.IEnumerable`1*> inherits from <xref:System.Collections.IEnumerable*> because <xref:System.Collections.Generic.IEnumerable`1*> only uses `T` in the return value of <xref:System.Collections.Generic.IEnumerable`1.GetEnumerator*> and in the <xref:System.Collections.Generic.IEnumerator`1.Current*> property getter.  
  
 Concrete classes can implement closed constructed interfaces, as follows:  
  
 [!code[csProgGuideGenerics#33](../vs140/codesnippet/CSharp/generic-interfaces--csharp-programming-guide-_5.cs)]  
  
 Generic classes can implement generic interfaces or closed constructed interfaces as long as the class parameter list supplies all arguments required by the interface, as follows:  
  
 [!code[csProgGuideGenerics#34](../vs140/codesnippet/CSharp/generic-interfaces--csharp-programming-guide-_6.cs)]  
  
 The rules that control method overloading are the same for methods within generic classes, generic structs, or generic interfaces. For more information, see [Generic Methods (C#)](../vs140/generic-methods--csharp-programming-guide-.md).  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Generics (C#)](../vs140/introduction-to-generics--csharp-programming-guide-.md)   
 [interface](../vs140/interface--csharp-reference-.md)   
 [Generics in the .NET Framework](assetId:///2994d786-c5c7-4666-ab23-4c83129fe39c)