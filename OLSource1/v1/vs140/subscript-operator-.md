---
title: "Subscript Operator:"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operators [C++], subscript"
  - "postfix operators"
  - "[] operator"
  - "subscript operator, syntax"
ms.assetid: 69c31494-52da-4dd0-8bbe-6ccbfd50f197
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Subscript Operator:
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 A postfix expression (which can also be a primary expression) followed by the subscript operator, **[ ]**, specifies array indexing.  
  
 For information about managed arrays, see [array](../vs140/arrays--c---component-extensions-.md).  
  
 Usually, the value represented by *postfix-expression* is a pointer value, such as an array identifier, and *expression* is an integral value (including enumerated types). However, all that is required syntactically is that one of the expressions be of pointer type and the other be of integral type. Thus the integral value could be in the *postfix-expression* position and the pointer value could be in the brackets in the *expression* or subscript position. Consider the following code fragment:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In the preceding example, the expression <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is identical to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The reason is that the result of a subscript expression *e1***[** *e2* **]** is given by:  
  
 **\*( (** *e2* **)** *+* **(***e1***) )**  
  
 The address yielded by the expression is not *e2* bytes from the address *e1*. Rather, the address is scaled to yield the next object in the array *e2*. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The addresses of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> are 8 bytes apart — the size of an object of type **double**. This scaling according to object type is done automatically by the C++ language and is defined in [Additive Operators](../vs140/additive-operators----and--.md) where addition and subtraction of operands of pointer type is discussed.  
  
 A subscript expression can also have multiple subscripts, as follows:  
  
 *expression1* **[***expression2***] [***expression3***]**...  
  
 Subscript expressions associate from left to right. The leftmost subscript expression, *expression1***[***expression2***]**, is evaluated first. The address that results from adding *expression1* and *expression2* forms a pointer expression; then *expression3* is added to this pointer expression to form a new pointer expression, and so on until the last subscript expression has been added. The indirection operator (**\***) is applied after the last subscripted expression is evaluated, unless the final pointer value addresses an array type.  
  
 Expressions with multiple subscripts refer to elements of multidimensional arrays. A multidimensional array is an array whose elements are arrays. For example, the first element of a three-dimensional array is an array with two dimensions. The following example declares and initializes a simple two-dimensional array of characters:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Positive and negative subscripts  
 The first element of an array is element 0. The range of a C++ array is from *array*[0] to *array*[*size* – 1]. However, C++ supports positive and negative subscripts. Negative subscripts must fall within array boundaries; if they do not, the results are unpredictable. The following code shows positive and negative array subscripts:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The negative subscript in the lasta line can produce a run-time error because it points an address 256 bytes lower in memory than the origin of the array. The pointer <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is initialized to the middle of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>; it is therefore possible to use both positive and negative array indices on it. Array subscript errors do not generate compile-time errors, but they yield unpredictable results.  
  
 The subscript operator is commutative. Therefore, the expressions *array*[*index*] and *array*[*array*] are guaranteed to be equivalent as long as the subscript operator is not overloaded (see [Overloaded Operators](../vs140/operator-overloading.md)). The first form is the most common coding practice, but either works.  
  
## See Also  
 [Postfix Expressions](../vs140/postfix-expressions.md)   
 [C++ Operators](../vs140/c---operators.md)   
 [C++ Built-in Operators, Precedence and Associativity](../vs140/c---built-in-operators--precedence-and-associativity.md)   
 [Arrays](../vs140/arrays--c---.md)   
 [One-Dimensional Arrays](../vs140/one-dimensional-arrays.md)   
 [Multidimensional Arrays](../vs140/multidimensional-arrays--c-.md)