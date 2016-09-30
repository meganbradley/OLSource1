---
title: "Single-Dimensional Arrays (C# Programming Guide)"
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
  - "single-dimensional arrays [C#]"
  - "arrays [C#], single-dimensional"
ms.assetid: 2cec1196-1de0-49d2-baf2-c607c33310e8
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Single-Dimensional Arrays (C# Programming Guide)
You can declare a single-dimensional array of five integers as shown in the following example:  
  
 [!code[csProgGuideArrays#4](../vs140/codesnippet/CSharp/single-dimensional-arrays--csharp-programming-guide-_1.cs)]  
  
 This array contains the elements from <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. The [new](../vs140/new--csharp-reference-.md) operator is used to create the array and initialize the array elements to their default values. In this example, all the array elements are initialized to zero.  
  
 An array that stores string elements can be declared in the same way. For example:  
  
 [!code[csProgGuideArrays#5](../vs140/codesnippet/CSharp/single-dimensional-arrays--csharp-programming-guide-_2.cs)]  
  
## Array Initialization  
 It is possible to initialize an array upon declaration, in which case, the rank specifier is not needed because it is already supplied by the number of elements in the initialization list. For example:  
  
 [!code[csProgGuideArrays#6](../vs140/codesnippet/CSharp/single-dimensional-arrays--csharp-programming-guide-_3.cs)]  
  
 A string array can be initialized in the same way. The following is a declaration of a string array where each array element is initialized by a name of a day:  
  
 [!code[csProgGuideArrays#7](../vs140/codesnippet/CSharp/single-dimensional-arrays--csharp-programming-guide-_4.cs)]  
  
 When you initialize an array upon declaration, you can use the following shortcuts:  
  
 [!code[csProgGuideArrays#8](../vs140/codesnippet/CSharp/single-dimensional-arrays--csharp-programming-guide-_5.cs)]  
  
 It is possible to declare an array variable without initialization, but you must use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> operator when you assign an array to this variable. For example:  
  
 [!code[csProgGuideArrays#9](../vs140/codesnippet/CSharp/single-dimensional-arrays--csharp-programming-guide-_6.cs)]  
  
 C# 3.0 introduces implicitly typed arrays. For more information, see [Implicitly Typed Arrays (C# Programming Guide)](../vs140/implicitly-typed-arrays--csharp-programming-guide-.md).  
  
## Value Type and Reference Type Arrays  
 Consider the following array declaration:  
  
 [!code[csProgGuideArrays#10](../vs140/codesnippet/CSharp/single-dimensional-arrays--csharp-programming-guide-_7.cs)]  
  
 The result of this statement depends on whether <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a value type or a reference type. If it is a value type, the statement creates an array of 10 elements, each of which has the type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is a reference type, the statement creates an array of 10 elements, each of which is initialized to a null reference.  
  
 For more information about value types and reference types, see [Types](../vs140/types--csharp-reference-.md).  
  
## See Also  
 \<xref:System.Array*>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Arrays (C# Programming Guide)](../vs140/arrays--csharp-programming-guide-.md)   
 [Multidimensional Arrays](../vs140/multidimensional-arrays--csharp-programming-guide-.md)   
 [Jagged Arrays](../vs140/jagged-arrays--csharp-programming-guide-.md)