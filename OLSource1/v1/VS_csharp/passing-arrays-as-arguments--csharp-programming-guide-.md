---
title: "Passing Arrays as Arguments (C# Programming Guide)"
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
  - "arrays [C#], passing as arguments"
ms.assetid: f3a0971e-c87c-4a1f-8262-bc0a3b712772
caps.latest.revision: 21
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
# Passing Arrays as Arguments (C# Programming Guide)
Arrays can be passed as arguments to method parameters. Because arrays are reference types, the method can change the value of the elements.  
  
## Passing Single-Dimensional Arrays As Arguments  
 You can pass an initialized single-dimensional array to a method. For example, the following statement sends an array to a print method.  
  
 [!code[csProgGuideArrays#34](../VS_csharp/codesnippet/CSharp/passing-arrays-as-arguments--csharp-programming-guide-_1.cs)]  
  
 The following code shows a partial implementation of the print method.  
  
 [!code[csProgGuideArrays#33](../VS_csharp/codesnippet/CSharp/passing-arrays-as-arguments--csharp-programming-guide-_2.cs)]  
  
 You can initialize and pass a new array in one step, as is shown in the following example.  
  
 [!code[CsProgGuideArrays#35](../VS_csharp/codesnippet/CSharp/passing-arrays-as-arguments--csharp-programming-guide-_3.cs)]  
  
## Example  
  
### Description  
 In the following example, an array of strings is initialized and passed as an argument to a `PrintArray` method for strings. The method displays the elements of the array. Next, methods `ChangeArray` and `ChangeArrayElement` are called to demonstrate that sending an array argument by value does not prevent changes to the array elements.  
  
### Code  
 [!code[csProgGuideArrays#30](../VS_csharp/codesnippet/CSharp/passing-arrays-as-arguments--csharp-programming-guide-_4.cs)]  
  
## Passing Multidimensional Arrays As Arguments  
 You pass an initialized multidimensional array to a method in the same way that you pass a one-dimensional array.  
  
 [!code[csProgGuideArrays#41](../VS_csharp/codesnippet/CSharp/passing-arrays-as-arguments--csharp-programming-guide-_5.cs)]  
  
 The following code shows a partial declaration of a print method that accepts a two-dimensional array as its argument.  
  
 [!code[csProgGuideArrays#36](../VS_csharp/codesnippet/CSharp/passing-arrays-as-arguments--csharp-programming-guide-_6.cs)]  
  
 You can initialize and pass a new array in one step, as is shown in the following example.  
  
 [!code[csProgGuideArrays#32](../VS_csharp/codesnippet/CSharp/passing-arrays-as-arguments--csharp-programming-guide-_7.cs)]  
  
## Example  
  
### Description  
 In the following example, a two-dimensional array of integers is initialized and passed to the `Print2DArray` method. The method displays the elements of the array.  
  
### Code  
 [!code[csProgGuideArrays#31](../VS_csharp/codesnippet/CSharp/passing-arrays-as-arguments--csharp-programming-guide-_8.cs)]  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Arrays](../VS_csharp/arrays--csharp-programming-guide-.md)   
 [Single-Dimensional Arrays](../VS_csharp/single-dimensional-arrays--csharp-programming-guide-.md)   
 [Multidimensional Arrays](../VS_csharp/multidimensional-arrays--csharp-programming-guide-.md)   
 [Jagged Arrays](../VS_csharp/jagged-arrays--csharp-programming-guide-.md)