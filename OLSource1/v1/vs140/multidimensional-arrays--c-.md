---
title: "Multidimensional Arrays (C)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "arrays [C], multidimensional"
  - "multidimensional arrays"
  - "subscript expressions"
ms.assetid: 4ba5c360-1f17-4575-b370-45f62e1f2bc2
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Multidimensional Arrays (C)
A subscript expression can also have multiple subscripts, as follows:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Subscript expressions associate from left to right. The leftmost subscript expression, *expression1***[***expression2***]**, is evaluated first. The address that results from adding *expression1* and *expression2* forms a pointer expression; then *expression3* is added to this pointer expression to form a new pointer expression, and so on until the last subscript expression has been added. The indirection operator (**\***) is applied after the last subscripted expression is evaluated, unless the final pointer value addresses an array type (see examples below).  
  
 Expressions with multiple subscripts refer to elements of "multidimensional arrays." A multidimensional array is an array whose elements are arrays. For example, the first element of a three-dimensional array is an array with two dimensions.  
  
## Examples  
 For the following examples, an array named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is declared with three elements, each of which is a 4-by-6 array of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> values.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> array looks like this:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The example above shows how to refer to the second individual <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. Arrays are stored by row, so the last subscript varies most quickly; the expression <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> refers to the next (third) element of the array, and so on.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This statement is a more complex reference to an individual element of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The expression is evaluated as follows:  
  
1.  The first subscript, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, is multiplied by the size of a 4-by-6 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> array and added to the pointer value <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. The result points to the third 4-by-6 array of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
2.  The second subscript, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, is multiplied by the size of the 6-element <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> array and added to the address represented by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
3.  Each element of the 6-element array is an <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> value, so the final subscript, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, is multiplied by the size of an <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> before it is added to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. The resulting pointer addresses the fourth element of the 6-element array.  
  
4.  The indirection operator is applied to the pointer value. The result is the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> element at that address.  
  
 These next two examples show cases where the indirection operator is not applied.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 In the first of these statements, the expression <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a valid reference to the three-dimensional array <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>; it refers to a 6-element array (declared above). Since the pointer value addresses an array, the indirection operator is not applied.  
  
 Similarly, the result of the expression <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> in the second statement <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is a pointer value addressing a two-dimensional array.  
  
## See Also  
 [Subscript Operator:](../vs140/subscript-operator-.md)