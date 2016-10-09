---
title: "Generics and Arrays (C# Programming Guide)"
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
  - "generics [C#], arrays"
  - "arrays [C#], generics"
ms.assetid: 7d956536-3851-41b5-94ad-3e7c0a5fe485
caps.latest.revision: 17
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
# Generics and Arrays (C# Programming Guide)
In C# 2.0 and later, single-dimensional arrays that have a lower bound of zero automatically implement <xref:System.Collections.Generic.IList`1>. This enables you to create generic methods that can use the same code to iterate through arrays and other collection types. This technique is primarily useful for reading data in collections. The <xref:System.Collections.Generic.IList`1> interface cannot be used to add or remove elements from an array. An exception will be thrown if you try to call an <xref:System.Collections.Generic.IList`1> method such as <xref:System.Collections.Generic.IList`1.RemoveAt*> on an array in this context.  
  
 The following code example demonstrates how a single generic method that takes an \<xref:System.Collections.Generic.IList`1> input parameter can iterate through both a list and an array, in this case an array of integers.  
  
 [!code[csProgGuideGenerics#35](../VS_csharp/codesnippet/CSharp/generics-and-arrays--csharp-programming-guide-_1.cs)]  
  
## See Also  
 \<xref:System.Collections.Generic>   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Generics](../VS_csharp/generics--csharp-programming-guide-.md)   
 [Arrays](../VS_csharp/arrays--csharp-programming-guide-.md)   
 [Generics](../Topic/Generics%20in%20the%20.NET%20Framework.md)