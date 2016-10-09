---
title: "Single-Dimensional Arrays (C# Programming Guide)"
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
  - "single-dimensional arrays [C#]"
  - "arrays [C#], single-dimensional"
ms.assetid: 2cec1196-1de0-49d2-baf2-c607c33310e8
caps.latest.revision: 18
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
# Single-Dimensional Arrays (C# Programming Guide)
You can declare a single-dimensional array of five integers as shown in the following example:  
  
 [!code[csProgGuideArrays#4](../VS_csharp/codesnippet/CSharp/single-dimensional-arrays--csharp-programming-guide-_1.cs)]  
  
 This array contains the elements from `array[0]` to `array[4]`. The [new](../VS_csharp/new--csharp-reference-.md) operator is used to create the array and initialize the array elements to their default values. In this example, all the array elements are initialized to zero.  
  
 An array that stores string elements can be declared in the same way. For example:  
  
 [!code[csProgGuideArrays#5](../VS_csharp/codesnippet/CSharp/single-dimensional-arrays--csharp-programming-guide-_2.cs)]  
  
## Array Initialization  
 It is possible to initialize an array upon declaration, in which case, the rank specifier is not needed because it is already supplied by the number of elements in the initialization list. For example:  
  
 [!code[csProgGuideArrays#6](../VS_csharp/codesnippet/CSharp/single-dimensional-arrays--csharp-programming-guide-_3.cs)]  
  
 A string array can be initialized in the same way. The following is a declaration of a string array where each array element is initialized by a name of a day:  
  
 [!code[csProgGuideArrays#7](../VS_csharp/codesnippet/CSharp/single-dimensional-arrays--csharp-programming-guide-_4.cs)]  
  
 When you initialize an array upon declaration, you can use the following shortcuts:  
  
 [!code[csProgGuideArrays#8](../VS_csharp/codesnippet/CSharp/single-dimensional-arrays--csharp-programming-guide-_5.cs)]  
  
 It is possible to declare an array variable without initialization, but you must use the `new` operator when you assign an array to this variable. For example:  
  
 [!code[csProgGuideArrays#9](../VS_csharp/codesnippet/CSharp/single-dimensional-arrays--csharp-programming-guide-_6.cs)]  
  
 C# 3.0 introduces implicitly typed arrays. For more information, see [Implicitly Typed Arrays](../VS_csharp/implicitly-typed-arrays--csharp-programming-guide-.md).  
  
## Value Type and Reference Type Arrays  
 Consider the following array declaration:  
  
 [!code[csProgGuideArrays#10](../VS_csharp/codesnippet/CSharp/single-dimensional-arrays--csharp-programming-guide-_7.cs)]  
  
 The result of this statement depends on whether `SomeType` is a value type or a reference type. If it is a value type, the statement creates an array of 10 elements, each of which has the type `SomeType`. If `SomeType` is a reference type, the statement creates an array of 10 elements, each of which is initialized to a null reference.  
  
 For more information about value types and reference types, see [Types](../VS_csharp/types--csharp-reference-.md).  
  
## See Also  
 \<xref:System.Array>   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Arrays](../VS_csharp/arrays--csharp-programming-guide-.md)   
 [Multidimensional Arrays](../VS_csharp/multidimensional-arrays--csharp-programming-guide-.md)   
 [Jagged Arrays](../VS_csharp/jagged-arrays--csharp-programming-guide-.md)