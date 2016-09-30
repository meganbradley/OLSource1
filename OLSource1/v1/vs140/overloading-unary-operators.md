---
title: "Overloading Unary Operators"
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
  - "unary operators, plus"
  - "increment operators, overloaded"
  - "unary operators, minus"
  - "operators [C++], unary"
  - "redefinable unary operators"
  - "unary operators"
  - "pointer dereference operator overloading"
  - "plus operator"
ms.assetid: 7683ef08-42a4-4283-928f-d3dd4f3ab4c0
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Overloading Unary Operators
The unary operators that can be overloaded are the following:  
  
1.  <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> ([logical NOT](../vs140/logical-negation-operator--!.md))  
  
2.  <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> ([address-of](../vs140/address-of-operator---.md))  
  
3.  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> ([one's complement](../vs140/one-s-complement-operator--~.md))  
  
4.  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> ([pointer dereference](../vs140/indirection-operator---.md))  
  
5.  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> ([unary plus](../vs140/additive-operators----and--.md))  
  
6.  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> ([unary negation](../vs140/additive-operators----and--.md))  
  
7.  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> ([increment](../vs140/prefix-increment-and-decrement-operators-----and---.md))  
  
8.  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> ([decrement](../vs140/prefix-increment-and-decrement-operators-----and---.md))  
  
9. conversion operators  
  
 The postfix increment and decrement operators (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and **––**) are treated separately in [Increment and Decrement](../vs140/increment-and-decrement-operator-overloading--c---.md).  
  
 Conversion operators are also discussed in a separate topic; see [Conversions](../vs140/user-defined-type-conversions--c---.md).  
  
 The following rules are true of all other unary operators. To declare a unary operator function as a nonstatic member, you must declare it in the form:  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 where <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is the return type and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is one of the operators listed in the preceding table.  
  
 To declare a unary operator function as a global function, you must declare it in the form:  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> )  
  
 where <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> are as described for member operator functions and the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is an argument of class type on which to operate.  
  
> [!NOTE]
>  There is no restriction on the return types of the unary operators. For example, it makes sense for logical NOT (<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>) to return an integral value, but this is not enforced.  
  
## See Also  
 [Operator Overloading](../vs140/operator-overloading.md)