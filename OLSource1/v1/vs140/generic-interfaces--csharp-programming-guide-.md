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
It is often useful to define interfaces either for generic collection classes, or for the generic classes that represent items in the collection. The preference for generic classes is to use generic interfaces, such as <xref:System.IComparable<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>SortedList<T><CodeContentPlaceHolder>1\</CodeContentPlaceHolder>GenericList<T><CodeContentPlaceHolder>2\</CodeContentPlaceHolder>SortedList<T><CodeContentPlaceHolder>3\</CodeContentPlaceHolder>where T : IComparable<T><CodeContentPlaceHolder>4\</CodeContentPlaceHolder>BubbleSort<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>SortedList<T><CodeContentPlaceHolder>6\</CodeContentPlaceHolder>1.CompareTo*> method on list elements. In this example, list elements are a simple class, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, that implements <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 [!code[csProgGuideGenerics#29](../vs140/codesnippet/CSharp/generic-interfaces--csharp-programming-guide-_1.cs)]  
  
 Multiple interfaces can be specified as constraints on a single type, as follows:  
  
 [!code[csProgGuideGenerics#30](../vs140/codesnippet/CSharp/generic-interfaces--csharp-programming-guide-_2.cs)]  
  
 An interface can define more than one type parameter, as follows:  
  
 [!code[csProgGuideGenerics#31](../vs140/codesnippet/CSharp/generic-interfaces--csharp-programming-guide-_3.cs)]  
  
 The rules of inheritance that apply to classes also apply to interfaces:  
  
 [!code[csProgGuideGenerics#32](../vs140/codesnippet/CSharp/generic-interfaces--csharp-programming-guide-_4.cs)]  
  
 Generic interfaces can inherit from non-generic interfaces if the generic interface is contra-variant, which means it only uses its type parameter as a return value. In the .NET Framework class library, <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>1*> only uses <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in the return value of <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>1.Current*> property getter.  
  
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