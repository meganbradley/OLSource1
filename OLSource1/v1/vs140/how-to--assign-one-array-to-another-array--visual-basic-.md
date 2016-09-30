---
title: "How to: Assign One Array to Another Array (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "covariance, arrays"
  - "arrays [Visual Basic], assigning"
  - "arrays [Visual Basic], covariance"
ms.assetid: 1ae89ea5-f292-4282-bcfc-e9b06b37fbd5
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Assign One Array to Another Array (Visual Basic)
Because arrays are objects, you can use them in assignment statements like other object types. An array variable holds a pointer to the data constituting the array elements and the rank and length information, and an assignment copies only this pointer.  
  
### To assign one array to another array  
  
1.  Ensure that the two arrays have the same rank (number of dimensions) and compatible element data types.  
  
2.  Use a standard assignment statement to assign the source array to the destination array. Do not follow either array name with parentheses.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 When you assign one array to another, the following rules apply:  
  
-   **Equal Ranks.** The rank (number of dimensions) of the destination array must be the same as that of the source array.  
  
     Provided the ranks of the two arrays are equal, the dimensions do not need to be equal. The number of elements in a given dimension can change during assignment.  
  
-   **Element Types.** Either both arrays must have *reference type* elements or both arrays must have *value type* elements. For more information, see [Value Types and Reference Types](../vs140/value-types-and-reference-types.md).  
  
    -   If both arrays have value type elements, the element data types must be exactly the same. The only exception to this is that you can assign an array of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> elements to an array of the base type of that <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
    -   If both arrays have reference type elements, the source element type must derive from the destination element type. When this is the case, the two arrays have the same inheritance relationship as their elements. This is called *array covariance*.  
  
 The compiler reports an error if the above rules are violated, for example if the data types are not compatible or the ranks are unequal. You can add error handling to your code to make sure that the arrays are compatible before attempting an assignment. You can also use the [TryCast](../vs140/trycast-operator--visual-basic-.md) keyword if you want to avoid throwing an exception.  
  
## See Also  
 [Arrays](../vs140/arrays-in-visual-basic.md)   
 [Troubleshooting Arrays](../vs140/troubleshooting-arrays--visual-basic-.md)   
 [Enum Statement (Visual Basic)](../vs140/enum-statement--visual-basic-.md)   
 [Array Conversions](../vs140/array-conversions--visual-basic-.md)