---
title: "Using Arrays (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "arrays [C++]"
ms.assetid: 7818a7fe-7e82-4881-a3d1-7d25162b7fc7
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Arrays (C++)
You can access individual elements of an array by using the array subscript operator (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>). If a one-dimensional array is used in an expression that has no subscript, the array name evaluates to a pointer to the first element in the array.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 When you use multidimensional arrays, you can use various combinations in expressions.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In the preceding code, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a three-dimensional array of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> pointer points to an array of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> of size three. In this example, the array is used with one, two, and three subscripts. Although it is more common to specify all subscripts, as in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement, it is sometimes useful to select a specific subset of array elements, as shown in the statements that follow <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## See Also  
 [Arrays](../vs140/arrays--c---.md)