---
title: "How to: Initialize an Array Variable in Visual Basic"
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
  - "variables [Visual Basic], initializing"
  - "arrays [Visual Basic], variables"
  - "arrays [Visual Basic], initializing"
  - "arrays [Visual Basic], declaring"
ms.assetid: aadd7a60-7ca4-4608-b986-091f19e7fc10
caps.latest.revision: 46
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Initialize an Array Variable in Visual Basic
You initialize an array variable by including an array literal in a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> clause and specifying the initial values of the array. You can either specify the type or allow it to be inferred from the values in the array literal. For more information about how the type is inferred, see "Populating an Array with Initial Values" in [Arrays in Visual Basic](../vs140/arrays-in-visual-basic.md).  
  
### To initialize an array variable by using an array literal  
  
-   Either in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> clause, or when you assign the array value, supply the element values inside braces (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>). The following example shows several ways to declare, create, and initialize a variable to contain an array that has elements of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
     [!code[VbVbalrArrays#16](../vs140/codesnippet/VisualBasic/how-to--initialize-an-array-variable-in-visual-basic_1.vb)]  
  
     After each statement executes, the array that's created has a length of 3, with elements at index 0 through index 2 containing the initial values. If you supply both the upper bound and the values, you must include a value for every element from index 0 through the upper bound.  
  
     Notice that you do not have to specify the index upper bound if you supply element values in an array literal. If no upper bound is specified, the size of the array is inferred based on the number of values in the array literal.  
  
### To initialize a multidimensional array variable by using array literals  
  
-   Nest values inside braces (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) within braces. Ensure that the nested array literals all infer as arrays of the same type and length. The following code example shows several examples of multidimensional array initialization.  
  
     [!code[VbVbalrArrays#17](../vs140/codesnippet/VisualBasic/how-to--initialize-an-array-variable-in-visual-basic_2.vb)]  
  
-   You can explicitly specify the array bounds, or leave them out and have the compiler infer the array bounds based on the values in the array literal. If you supply both the upper bounds and the values, you must include a value for every element from index 0 through the upper bound in every dimension. The following example shows several ways to declare, create, and initialize a variable to contain a two-dimensional array that has elements of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
     [!code[VbVbalrArrays#18](../vs140/codesnippet/VisualBasic/how-to--initialize-an-array-variable-in-visual-basic_3.vb)]  
  
     After each statement executes, the created array contains six initialized elements that have indexes <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Each array location contains the value <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
-   The following example iterates through a multidimensional array. In a Windows console application that is written in Visual Basic, paste the code inside the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method. The last comments show the output.  
  
     [!code[VbVbalrArrays#31](../vs140/codesnippet/VisualBasic/how-to--initialize-an-array-variable-in-visual-basic_4.vb)]  
  
### To initialize a jagged array variable by using array literals  
  
-   Nest object values inside braces (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>). Although you can also nest array literals that specify arrays of different lengths, in the case of a jagged array, make sure that that the nested array literals are enclosed in parentheses (<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>). The parentheses force the evaluation of the nested array literals, and the resulting arrays are used as the initial values of the jagged array. The following code example shows two examples of jagged array initialization.  
  
     [!code[VbVbalrArrays#19](../vs140/codesnippet/VisualBasic/how-to--initialize-an-array-variable-in-visual-basic_5.vb)]  
  
-   The following example iterates through a jagged array. In a Windows console application that is written in Visual Basic, paste the code inside the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> method.  The last comments in the code show the output.  
  
     [!code[VbVbalrArrays#32](../vs140/codesnippet/VisualBasic/how-to--initialize-an-array-variable-in-visual-basic_6.vb)]  
  
## See Also  
 [Arrays](../vs140/arrays-in-visual-basic.md)   
 [Troubleshooting Arrays](../vs140/troubleshooting-arrays--visual-basic-.md)