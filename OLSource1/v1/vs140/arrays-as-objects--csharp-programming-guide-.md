---
title: "Arrays as Objects (C# Programming Guide)"
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
  - "arrays [C#], as objects"
ms.assetid: f76d4403-bd0a-42a0-9bc8-694c55b2c926
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Arrays as Objects (C# Programming Guide)
In C#, arrays are actually objects, and not just addressable regions of contiguous memory as in C and C++. \<xref:System.Array*> is the abstract base type of all array types. You can use the properties, and other class members, that \<xref:System.Array*> has. An example of this would be using the \<xref:System.Array.Length*> property to get the length of an array. The following code assigns the length of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> array, which is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, to a variable called <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>:  
  
 [!code[csProgGuideArrays#3](../vs140/codesnippet/CSharp/arrays-as-objects--csharp-programming-guide-_1.cs)]  
  
 The \<xref:System.Array*> class provides many other useful methods and properties for sorting, searching, and copying arrays.  
  
## Example  
 This example uses the \<xref:System.Array.Rank*> property to display the number of dimensions of an array.  
  
 [!code[csProgGuideArrays#2](../vs140/codesnippet/CSharp/arrays-as-objects--csharp-programming-guide-_2.cs)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Arrays (Visual C#)](../vs140/arrays--csharp-programming-guide-.md)   
 [Single-Dimensional Arrays](../vs140/single-dimensional-arrays--csharp-programming-guide-.md)   
 [Multidimensional Arrays](../vs140/multidimensional-arrays--csharp-programming-guide-.md)   
 [Jagged Arrays](../vs140/jagged-arrays--csharp-programming-guide-.md)