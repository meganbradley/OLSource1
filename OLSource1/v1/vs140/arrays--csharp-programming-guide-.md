---
title: "Arrays (C# Programming Guide)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - arrays [C#]
  - C# language, arrays
ms.assetid: bb79bdde-e570-4c30-adb0-1dd5759ae041
caps.latest.revision: 37
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Arrays (C# Programming Guide)
You can store multiple variables of the same type in an array data structure. You declare an array by specifying the type of its elements.  
  
 `type[] arrayName;`  
  
 The following examples create single-dimensional, multidimensional, and jagged arrays:  
  
 [!code[csProgGuideArrays#1](../vs140/codesnippet/CSharp/arrays--csharp-programming-guide-_1.cs)]
  
  
## Array Overview  
 An array has the following properties:  
  
-   An array can be [Single-Dimensional](../vs140/single-dimensional-arrays--csharp-programming-guide-.md), [Multidimensional](../vs140/multidimensional-arrays--csharp-programming-guide-.md) or [Jagged](../vs140/jagged-arrays--csharp-programming-guide-.md).  
  
-   The number of dimensions and the length of each dimension are established when the array instance is created. These values can't be changed during the lifetime of the instance.  
  
-   The default values of numeric array elements are set to zero, and reference elements are set to null.  
  
-   A jagged array is an array of arrays, and therefore its elements are reference types and are initialized to `null`.  
  
-   Arrays are zero indexed: an array with `n` elements is indexed from `0` to `n-1`.  
  
-   Array elements can be of any type, including an array type.  
  
-   Array types are [reference types](../vs140/reference-types--csharp-reference-.md) derived from the abstract base type <xref:System.Array?qualifyHint=False>. Since this type implements <xref:System.Collections.IEnumerable?qualifyHint=False> and <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>, you can use [foreach](../vs140/foreach--in--csharp-reference-.md) iteration on all arrays in C#.  
  
## Related Sections  
  
-   [Arrays as Objects](../vs140/arrays-as-objects--csharp-programming-guide-.md)  
  
-   [Using Foreach with Arrays (Visual C#)](../vs140/using-foreach-with-arrays--csharp-programming-guide-.md)  
  
-   [Passing Arrays as Parameters](../vs140/passing-arrays-as-arguments--csharp-programming-guide-.md)  
  
-   [Passing Arrays Using ref and out](../vs140/passing-arrays-using-ref-and-out--csharp-programming-guide-.md)  
  
-   [More About Variables](http://go.microsoft.com/fwlink/?LinkId=221230) in [Beginning Visual C# 2010](http://go.microsoft.com/fwlink/?LinkId=221214)  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Collection Classes (C#)](../vs140/collections--csharp-and-visual-basic-.md)   
 [Array Collection Type](assetId:///8a9964de-8941-47b1-a3cf-a01bc88db9e8)