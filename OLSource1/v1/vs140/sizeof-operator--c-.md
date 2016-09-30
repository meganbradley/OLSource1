---
title: "sizeof Operator (C)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "sizeof"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "sizeof operator"
ms.assetid: 70826d03-3451-41e4-bebb-a820ae66d53f
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sizeof Operator (C)
The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator gives the amount of storage, in bytes, required to store an object of the type of the operand. This operator allows you to avoid specifying machine-dependent data sizes in your programs.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The operand is either an identifier that is a *unary-expression*, or a type-cast expression (that is, a type specifier enclosed in parentheses). The *unary-expression* cannot represent a bit-field object, an incomplete type, or a function designator. The result is an unsigned integral constant. The standard header STDDEF.H defines this type as **size_t**.  
  
 When you apply the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operator to an array identifier, the result is the size of the entire array rather than the size of the pointer represented by the array identifier.  
  
 When you apply the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> operator to a structure or union type name, or to an identifier of structure or union type, the result is the number of bytes in the structure or union, including internal and trailing padding. This size may include internal and trailing padding used to align the members of the structure or union on memory boundaries. Thus, the result may not correspond to the size calculated by adding up the storage requirements of the individual members.  
  
 If an unsized array is the last element of a structure, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> operator returns the size of the structure without the array.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This example uses the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> operator to pass the size of an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, which varies among machines, as an argument to a run-time function named <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The value returned by the function is stored in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In this example, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is an array of pointers to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The number of pointers is the number of elements in the array, but is not specified. It is easy to determine the number of pointers by using the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> operator to calculate the number of elements in the array. The **const** integer value <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is initialized to this number. Because it is a **const** value, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> cannot be modified.  
  
## See Also  
 [C++ Operators](../vs140/c---operators.md)