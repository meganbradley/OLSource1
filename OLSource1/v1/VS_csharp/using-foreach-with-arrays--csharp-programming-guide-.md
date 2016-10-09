---
title: "Using foreach with Arrays (C# Programming Guide)"
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
  - "arrays [C#], foreach"
  - "foreach statement [C#], using with arrays"
ms.assetid: 5f2da2a9-1f56-4de5-94cc-e07f4f7a0244
caps.latest.revision: 14
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
# Using foreach with Arrays (C# Programming Guide)
C# also provides the [foreach](../VS_csharp/foreach--in--csharp-reference-.md) statement. This statement provides a simple, clean way to iterate through the elements of an array or any enumerable collection. The `foreach` statement processes elements in the order returned by the array or collection type’s enumerator, which is usually from the 0th element to the last. For example, the following code creates an array called `numbers` and iterates through it with the `foreach` statement:  
  
 [!code[csProgGuideArrays#28](../VS_csharp/codesnippet/CSharp/using-foreach-with-arrays--csharp-programming-guide-_1.cs)]  
  
 With multidimensional arrays, you can use the same method to iterate through the elements, for example:  
  
 [!code[csProgGuideArrays#29](../VS_csharp/codesnippet/CSharp/using-foreach-with-arrays--csharp-programming-guide-_2.cs)]  
  
 However, with multidimensional arrays, using a nested [for](../VS_csharp/for--csharp-reference-.md) loop gives you more control over the array elements.  
  
## See Also  
 \<xref:System.Array>   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Arrays](../VS_csharp/arrays--csharp-programming-guide-.md)   
 [Single-Dimensional Arrays](../VS_csharp/single-dimensional-arrays--csharp-programming-guide-.md)   
 [Multidimensional Arrays](../VS_csharp/multidimensional-arrays--csharp-programming-guide-.md)   
 [Jagged Arrays](../VS_csharp/jagged-arrays--csharp-programming-guide-.md)