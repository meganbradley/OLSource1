---
title: "Passing Arrays Using ref and out (C# Programming Guide)"
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
  - "arrays [C#], passing using ref and out"
ms.assetid: 6a2b261e-a1cc-49a6-b4f0-6cacae385a1e
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Passing Arrays Using ref and out (C# Programming Guide)
Like all [out](../VS_csharp/out--csharp-reference-.md) parameters, an `out` parameter of an array type must be assigned before it is used; that is, it must be assigned by the callee. For example:  
  
 [!code[csProgGuideArrays#39](../VS_csharp/codesnippet/CSharp/passing-arrays-using-ref-and-out--csharp-programming-guide-_1.cs)]  
  
 Like all [ref](../VS_csharp/ref--csharp-reference-.md) parameters, a `ref` parameter of an array type must be definitely assigned by the caller. Therefore, there is no need to be definitely assigned by the callee. A `ref` parameter of an array type may be altered as a result of the call. For example, the array can be assigned the [null](../VS_csharp/null--csharp-reference-.md) value or can be initialized to a different array. For example:  
  
 [!code[csProgGuideArrays#40](../VS_csharp/codesnippet/CSharp/passing-arrays-using-ref-and-out--csharp-programming-guide-_2.cs)]  
  
 The following two examples demonstrate the difference between `out` and `ref` when used in passing arrays to methods.  
  
## Example  
 In this example, the array `theArray` is declared in the caller (the `Main` method), and initialized in the `FillArray` method. Then, the array elements are returned to the caller and displayed.  
  
 [!code[csProgGuideArrays#37](../VS_csharp/codesnippet/CSharp/passing-arrays-using-ref-and-out--csharp-programming-guide-_3.cs)]  
  
## Example  
 In this example, the array `theArray` is initialized in the caller (the `Main` method), and passed to the `FillArray` method by using the `ref` parameter. Some of the array elements are updated in the `FillArray` method. Then, the array elements are returned to the caller and displayed.  
  
 [!code[csProgGuideArrays#38](../VS_csharp/codesnippet/CSharp/passing-arrays-using-ref-and-out--csharp-programming-guide-_4.cs)]  
  
## See Also  
 [C# Programming Guide](../VS_csharp/ref--csharp-reference-.md)   
 [Arrays (Visual C#)](../VS_csharp/out-parameter-modifier--csharp-reference-.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Arrays (Visual C#)](../VS_csharp/arrays--csharp-programming-guide-.md)   
 [Single-Dimensional Arrays](../VS_csharp/single-dimensional-arrays--csharp-programming-guide-.md)   
 [Multidimensional Arrays](../VS_csharp/multidimensional-arrays--csharp-programming-guide-.md)   
 [Jagged Arrays](../VS_csharp/jagged-arrays--csharp-programming-guide-.md)