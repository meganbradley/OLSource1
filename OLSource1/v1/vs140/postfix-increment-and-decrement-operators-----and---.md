---
title: "Postfix Increment and Decrement Operators: ++ and --"
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
  - "--"
  - "++"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "increment operators, syntax"
  - "member-selection operators"
  - "-- operator, postfix decrement operators"
  - "postfix operators"
  - "++ operator, postfix increment operators"
  - "decrement operators, syntax"
  - "operators [C++], postfix"
  - "decrement operators"
ms.assetid: 0204d5c8-51b0-4108-b8a1-074c5754d89c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Postfix Increment and Decrement Operators: ++ and --
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 C++ provides prefix and postfix increment and decrement operators; this section describes only the postfix increment and decrement operators. (For more information, see [Prefix Increment and Decrement Operators](../vs140/prefix-increment-and-decrement-operators-----and---.md).) The difference between the two is that in the postfix notation, the operator appears after *postfix-expression*, whereas in the prefix notation, the operator appears before *expression.* The following example shows a postfix-increment operator:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The effect of applying the postfix increment operator (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) is that the operand's value is increased by one unit of the appropriate type. Similarly, the effect of applying the postfix decrement operator (**––**) is that the operand's value is decreased by one unit of the appropriate type.  
  
 It is important to note that a postfix increment or decrement expression evaluates to the value of the expression **prior to** application of the respective operator. The increment or decrement operation occurs **after** the operand is evaluated. This issue arises only when the postfix increment or decrement operation occurs in the context of a larger expression.  
  
 When a postfix operator is applied to a function argument, the value of the argument is not guaranteed to be incremented or decremented before it is passed to the function.  See section 1.9.17 in the C++ standard for more information.  
  
 Applying the postfix increment operator to a pointer to an array of objects of type **long** actually adds four to the internal representation of the pointer. This behavior causes the pointer, which previously referred to the *n*th element of the array, to refer to the (*n*+1)th element.  
  
 The operands to postfix increment and postfix decrement operators must be modifiable (not **const**) l-values of arithmetic or pointer type. The type of the result is the same as that of the *postfix-expression*, but it is no longer an l-value.  
  
 The operand of a postfix increment operator may also be of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, in which case the operand is evaluated and then set to **true**. The operand of a postfix decrement operator cannot be of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 The following code illustrates the postfix increment operator:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Postincrement and postdecrement operations on enumerated types are not supported:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Postfix Expressions](../vs140/postfix-expressions.md)   
 [C++ Operators](../vs140/c---operators.md)   
 [C++ Built-in Operators, Precedence and Associativity](../vs140/c---built-in-operators--precedence-and-associativity.md)   
 [C Postfix Increment and Decrement Operators](../vs140/c-postfix-increment-and-decrement-operators.md)