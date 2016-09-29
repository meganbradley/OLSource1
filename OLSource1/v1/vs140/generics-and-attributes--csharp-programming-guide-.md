---
title: "Generics and Attributes (C# Programming Guide)"
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
  - "generics [C#], attributes"
  - "attributes [C#], with generics"
ms.assetid: da9fc326-4648-454a-8e13-3911a2edefd7
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Generics and Attributes (C# Programming Guide)
Attributes can be applied to generic types in the same way as non-generic types. For more information on applying attributes, see [Attributes (C# Programmer's Reference)](../vs140/attributes--csharp-and-visual-basic-.md).  
  
 Custom attributes are only permitted to reference open generic types, which are generic types for which no type arguments are supplied, and closed constructed generic types, which supply arguments for all type parameters.  
  
 The following examples use this custom attribute:  
  
 [!code[csProgGuideGenerics#48](../vs140/codesnippet/CSharp/generics-and-attributes--csharp-programming-guide-_1.cs)]  
  
 An attribute can reference an open generic type:  
  
 [!code[csProgGuideGenerics#49](../vs140/codesnippet/CSharp/generics-and-attributes--csharp-programming-guide-_2.cs)]  
  
 Specify multiple type parameters using the appropriate number of commas. In this example, `GenericClass2` has two type parameters:  
  
 [!code[csProgGuideGenerics#50](../vs140/codesnippet/CSharp/generics-and-attributes--csharp-programming-guide-_3.cs)]  
  
 An attribute can reference a closed constructed generic type:  
  
 [!code[csProgGuideGenerics#51](../vs140/codesnippet/CSharp/generics-and-attributes--csharp-programming-guide-_4.cs)]  
  
 An attribute that references a generic type parameter will cause a compile-time error:  
  
 [!code[csProgGuideGenerics#52](../vs140/codesnippet/CSharp/generics-and-attributes--csharp-programming-guide-_5.cs)]  
  
 A generic type cannot inherit from <xref:System.Attribute*>:  
  
 [!code[csProgGuideGenerics#53](../vs140/codesnippet/CSharp/generics-and-attributes--csharp-programming-guide-_6.cs)]  
  
 To obtain information about a generic type or type parameter at run time, you can use the methods of <xref:System.Reflection*>. For more information, see [Generics and Reflection (C# Programmers Reference)](../vs140/generics-and-reflection--csharp-programming-guide-.md)  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Generics (C# Programmers Reference)](../vs140/generics--csharp-programming-guide-.md)   
 [Attributes](assetId:///30386922-1e00-4602-9ebf-526b271a8b87)