---
title: "Generics and Attributes (C# Programming Guide)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 13
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Generics and Attributes (C# Programming Guide)
Attributes can be applied to generic types in the same way as non-generic types. For more information on applying attributes, see [Attributes](../Topic/Attributes%20\(C%23%20and%20Visual%20Basic\).md).  
  
 Custom attributes are only permitted to reference open generic types, which are generic types for which no type arguments are supplied, and closed constructed generic types, which supply arguments for all type parameters.  
  
 The following examples use this custom attribute:  
  
 [!code[csProgGuideGenerics#48](../VS_csharp/codesnippet/CSharp/generics-and-attributes--csharp-programming-guide-_1.cs)]  
  
 An attribute can reference an open generic type:  
  
 [!code[csProgGuideGenerics#49](../VS_csharp/codesnippet/CSharp/generics-and-attributes--csharp-programming-guide-_2.cs)]  
  
 Specify multiple type parameters using the appropriate number of commas. In this example, `GenericClass2` has two type parameters:  
  
 [!code[csProgGuideGenerics#50](../VS_csharp/codesnippet/CSharp/generics-and-attributes--csharp-programming-guide-_3.cs)]  
  
 An attribute can reference a closed constructed generic type:  
  
 [!code[csProgGuideGenerics#51](../VS_csharp/codesnippet/CSharp/generics-and-attributes--csharp-programming-guide-_4.cs)]  
  
 An attribute that references a generic type parameter will cause a compile-time error:  
  
 [!code[csProgGuideGenerics#52](../VS_csharp/codesnippet/CSharp/generics-and-attributes--csharp-programming-guide-_5.cs)]  
  
 A generic type cannot inherit from \<xref:System.Attribute>:  
  
 [!code[csProgGuideGenerics#53](../VS_csharp/codesnippet/CSharp/generics-and-attributes--csharp-programming-guide-_6.cs)]  
  
 To obtain information about a generic type or type parameter at run time, you can use the methods of \<xref:System.Reflection>. For more information, see [Generics and Reflection](../VS_csharp/generics-and-reflection--csharp-programming-guide-.md)  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Generics](../VS_csharp/generics--csharp-programming-guide-.md)   
 [Attributes](../Topic/Extending%20Metadata%20Using%20Attributes.md)