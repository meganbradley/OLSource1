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
Like all [out](../vs140/out--csharp-reference-.md) parameters, an <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> parameter of an array type must be assigned before it is used; that is, it must be assigned by the callee. For example:  
  
 [!code[csProgGuideArrays#39](../vs140/codesnippet/CSharp/passing-arrays-using-ref-and-out--csharp-programming-guide-_1.cs)]  
  
 Like all [ref](../vs140/ref--csharp-reference-.md) parameters, a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter of an array type must be definitely assigned by the caller. Therefore, there is no need to be definitely assigned by the callee. A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter of an array type may be altered as a result of the call. For example, the array can be assigned the [null](../vs140/null--csharp-reference-.md) value or can be initialized to a different array. For example:  
  
 [!code[csProgGuideArrays#40](../vs140/codesnippet/CSharp/passing-arrays-using-ref-and-out--csharp-programming-guide-_2.cs)]  
  
 The following two examples demonstrate the difference between <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> when used in passing arrays to methods.  
  
## Example  
 In this example, the array <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is declared in the caller (the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method), and initialized in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method. Then, the array elements are returned to the caller and displayed.  
  
 [!code[csProgGuideArrays#37](../vs140/codesnippet/CSharp/passing-arrays-using-ref-and-out--csharp-programming-guide-_3.cs)]  
  
## Example  
 In this example, the array <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is initialized in the caller (the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method), and passed to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> method by using the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter. Some of the array elements are updated in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method. Then, the array elements are returned to the caller and displayed.  
  
 [!code[csProgGuideArrays#38](../vs140/codesnippet/CSharp/passing-arrays-using-ref-and-out--csharp-programming-guide-_4.cs)]  
  
## See Also  
 [C# Programming Guide](../vs140/ref--csharp-reference-.md)   
 [Arrays (Visual C#)](../vs140/out-parameter-modifier--csharp-reference-.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Arrays (Visual C#)](../vs140/arrays--csharp-programming-guide-.md)   
 [Single-Dimensional Arrays](../vs140/single-dimensional-arrays--csharp-programming-guide-.md)   
 [Multidimensional Arrays](../vs140/multidimensional-arrays--csharp-programming-guide-.md)   
 [Jagged Arrays](../vs140/jagged-arrays--csharp-programming-guide-.md)