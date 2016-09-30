---
title: "Multidimensional Arrays (C# Programming Guide)"
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
  - "arrays [C#], multidimensional"
  - "multidimensional arrays [C#]"
ms.assetid: 020ce02e-7dff-4273-8e53-bf0b33747232
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Multidimensional Arrays (C# Programming Guide)
Arrays can have more than one dimension. For example, the following declaration creates a two-dimensional array of four rows and two columns.  
  
 [!code[csProgGuideArrays#11](../vs140/codesnippet/CSharp/multidimensional-arrays--csharp-programming-guide-_1.cs)]  
  
 The following declaration creates an array of three dimensions, 4, 2, and 3.  
  
 [!code[csProgGuideArrays#12](../vs140/codesnippet/CSharp/multidimensional-arrays--csharp-programming-guide-_2.cs)]  
  
## Array Initialization  
 You can initialize the array upon declaration, as is shown in the following example.  
  
 [!code[csProgGuideArrays#13](../vs140/codesnippet/CSharp/multidimensional-arrays--csharp-programming-guide-_3.cs)]  
  
 You also can initialize the array without specifying the rank.  
  
 [!code[csProgGuideArrays#14](../vs140/codesnippet/CSharp/multidimensional-arrays--csharp-programming-guide-_4.cs)]  
  
 If you choose to declare an array variable without initialization, you must use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> operator to assign an array to the variable. The use of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is shown in the following example.  
  
 [!code[csProgGuideArrays#15](../vs140/codesnippet/CSharp/multidimensional-arrays--csharp-programming-guide-_5.cs)]  
  
 The following example assigns a value to a particular array element.  
  
 [!code[csProgGuideArrays#16](../vs140/codesnippet/CSharp/multidimensional-arrays--csharp-programming-guide-_6.cs)]  
  
 Similarly, the following example gets the value of a particular array element and assigns it to variable <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 [!code[csProgGuideArrays#42](../vs140/codesnippet/CSharp/multidimensional-arrays--csharp-programming-guide-_7.cs)]  
  
 The following code example initializes the array elements to default values (except for jagged arrays).  
  
 [!code[csProgGuideArrays#17](../vs140/codesnippet/CSharp/multidimensional-arrays--csharp-programming-guide-_8.cs)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Arrays (Visual C#)](../vs140/arrays--csharp-programming-guide-.md)   
 [Single-Dimensional Arrays](../vs140/single-dimensional-arrays--csharp-programming-guide-.md)   
 [Jagged Arrays](../vs140/jagged-arrays--csharp-programming-guide-.md)