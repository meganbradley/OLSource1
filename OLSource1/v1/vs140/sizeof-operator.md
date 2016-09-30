---
title: "sizeof Operator"
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
  - "sizeof_cpp"
  - "sizeof"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sizeof operator"
ms.assetid: 8bc3b6fb-54a1-4eb7-ada0-05f8c5efc532
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sizeof Operator
Yields the size of its operand with respect to the size of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  For information about the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> operator, see [Ellipses and Variadic Templates](../vs140/ellipses-and-variadic-templates.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The result of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> operator is of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, an integral type defined in the include file STDDEF.H. This operator allows you to avoid specifying machine-dependent data sizes in your programs.  
  
 The operand to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> can be one of the following:  
  
-   A type name. To use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> with a type name, the name must be enclosed in parentheses.  
  
-   An expression. When used with an expression, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> can be specified with or without the parentheses. The expression is not evaluated.  
  
 When the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> operator is applied to an object of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, it yields 1. When the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> operator is applied to an array, it yields the total number of bytes in that array, not the size of the pointer represented by the array identifier. To obtain the size of the pointer represented by the array identifier, pass it as a parameter to a function that uses <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. For example:  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 When the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> operator is applied to a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> type, the result is the number of bytes in an object of that type, plus any padding added to align members on word boundaries. The result does not necessarily correspond to the size calculated by adding the storage requirements of the individual members. The [/Zp](../vs140/-zp--struct-member-alignment-.md) compiler option and the [pack](../vs140/pack.md) pragma affect alignment boundaries for members.  
  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> operator never yields 0, even for an empty class.  
  
 The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> operator cannot be used with the following operands:  
  
-   Functions. (However, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> can be applied to pointers to functions.)  
  
-   Bit fields.  
  
-   Undefined classes.  
  
-   The type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
-   Dynamically allocated arrays.  
  
-   External arrays.  
  
-   Incomplete types.  
  
-   Parenthesized names of incomplete types.  
  
 When the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> operator is applied to a reference, the result is the same as if <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> had been applied to the object itself.  
  
 If an unsized array is the last element of a structure, the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> operator returns the size of the structure without the array.  
  
 The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> operator is often used to calculate the number of elements in an array using an expression of the form:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Expressions with Unary Operators](../vs140/expressions-with-unary-operators.md)   
 [Keywords](../vs140/keywords--c---.md)