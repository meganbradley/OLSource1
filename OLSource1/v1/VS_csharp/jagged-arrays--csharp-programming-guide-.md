---
title: "Jagged Arrays (C# Programming Guide)"
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
  - "jagged arrays [C#]"
  - "arrays [C#], jagged"
ms.assetid: 537c65a6-0e0a-4a00-a2b8-086f38519c70
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Jagged Arrays (C# Programming Guide)
A jagged array is an array whose elements are arrays. The elements of a jagged array can be of different dimensions and sizes. A jagged array is sometimes called an "array of arrays." The following examples show how to declare, initialize, and access jagged arrays.  
  
 The following is a declaration of a single-dimensional array that has three elements, each of which is a single-dimensional array of integers:  
  
 [!code[csProgGuideArrays#19](../VS_csharp/codesnippet/CSharp/jagged-arrays--csharp-programming-guide-_1.cs)]  
  
 Before you can use `jaggedArray`, its elements must be initialized. You can initialize the elements like this:  
  
 [!code[csProgGuideArrays#20](../VS_csharp/codesnippet/CSharp/jagged-arrays--csharp-programming-guide-_2.cs)]  
  
 Each of the elements is a single-dimensional array of integers. The first element is an array of 5 integers, the second is an array of 4 integers, and the third is an array of 2 integers.  
  
 It is also possible to use initializers to fill the array elements with values, in which case you do not need the array size. For example:  
  
 [!code[csProgGuideArrays#21](../VS_csharp/codesnippet/CSharp/jagged-arrays--csharp-programming-guide-_3.cs)]  
  
 You can also initialize the array upon declaration like this:  
  
 [!code[csProgGuideArrays#22](../VS_csharp/codesnippet/CSharp/jagged-arrays--csharp-programming-guide-_4.cs)]  
  
 You can use the following shorthand form. Notice that you cannot omit the `new` operator from the elements initialization because there is no default initialization for the elements:  
  
 [!code[csProgGuideArrays#23](../VS_csharp/codesnippet/CSharp/jagged-arrays--csharp-programming-guide-_5.cs)]  
  
 A jagged array is an array of arrays, and therefore its elements are reference types and are initialized to `null`.  
  
 You can access individual array elements like these examples:  
  
 [!code[csProgGuideArrays#24](../VS_csharp/codesnippet/CSharp/jagged-arrays--csharp-programming-guide-_6.cs)]  
  
 It is possible to mix jagged and multidimensional arrays. The following is a declaration and initialization of a single-dimensional jagged array that contains three two-dimensional array elements of different sizes. For more information about two-dimensional arrays, see [Multidimensional Arrays (C# Programming Guide)](../VS_csharp/multidimensional-arrays--csharp-programming-guide-.md).  
  
 [!code[csProgGuideArrays#25](../VS_csharp/codesnippet/CSharp/jagged-arrays--csharp-programming-guide-_7.cs)]  
  
 You can access individual elements as shown in this example, which displays the value of the element `[1,0]` of the first array (value `5`):  
  
 [!code[csProgGuideArrays#26](../VS_csharp/codesnippet/CSharp/jagged-arrays--csharp-programming-guide-_8.cs)]  
  
 The method `Length` returns the number of arrays contained in the jagged array. For example, assuming you have declared the previous array, this line:  
  
 [!code[csProgGuideArrays#27](../VS_csharp/codesnippet/CSharp/jagged-arrays--csharp-programming-guide-_9.cs)]  
  
 returns a value of 3.  
  
## Example  
 This example builds an array whose elements are themselves arrays. Each one of the array elements has a different size.  
  
 [!code[csProgGuideArrays#18](../VS_csharp/codesnippet/CSharp/jagged-arrays--csharp-programming-guide-_10.cs)]  
  
## See Also  
 <xref:System.Array*>   
 [C# Programming](../VS_csharp/csharp-programming-guide.md)   
 [Arrays (Visual C#)](../VS_csharp/arrays--csharp-programming-guide-.md)   
 [Single-Dimensional Arrays](../VS_csharp/single-dimensional-arrays--csharp-programming-guide-.md)   
 [Multidimensional Arrays](../VS_csharp/multidimensional-arrays--csharp-programming-guide-.md)