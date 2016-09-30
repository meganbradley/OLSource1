---
title: "Using foreach with Arrays (C# Programming Guide)"
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
  - "arrays [C#], foreach"
  - "foreach statement [C#], using with arrays"
ms.assetid: 5f2da2a9-1f56-4de5-94cc-e07f4f7a0244
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using foreach with Arrays (C# Programming Guide)
C# also provides the [foreach](../vs140/foreach--in--csharp-reference-.md) statement. This statement provides a simple, clean way to iterate through the elements of an array or any enumerable collection. The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement processes elements in the order returned by the array or collection type’s enumerator, which is usually from the 0th element to the last. For example, the following code creates an array called <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and iterates through it with the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement:  
  
 [!code[csProgGuideArrays#28](../vs140/codesnippet/CSharp/using-foreach-with-arrays--csharp-programming-guide-_1.cs)]  
  
 With multidimensional arrays, you can use the same method to iterate through the elements, for example:  
  
 [!code[csProgGuideArrays#29](../vs140/codesnippet/CSharp/using-foreach-with-arrays--csharp-programming-guide-_2.cs)]  
  
 However, with multidimensional arrays, using a nested [for](../vs140/for--csharp-reference-.md) loop gives you more control over the array elements.  
  
## See Also  
 \<xref:System.Array*>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Arrays (Visual C#)](../vs140/arrays--csharp-programming-guide-.md)   
 [Single-Dimensional Arrays](../vs140/single-dimensional-arrays--csharp-programming-guide-.md)   
 [Multidimensional Arrays](../vs140/multidimensional-arrays--csharp-programming-guide-.md)   
 [Jagged Arrays](../vs140/jagged-arrays--csharp-programming-guide-.md)