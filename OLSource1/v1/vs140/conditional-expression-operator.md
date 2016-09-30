---
title: "Conditional-Expression Operator"
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
  - "conditional operators"
  - "operators [C++], conditional"
  - "expressions [C++], conditional"
ms.assetid: c4f1a5ca-0844-44a7-a384-eca584d4e3dd
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Conditional-Expression Operator
C has one ternary operator: the conditional-expression operator (**? :**).  
  
## Syntax  
 *conditional-expression*:  
 *logical-OR-expression*  
  
 *logical-OR expression*  **?**  *expression*  **:**  *conditional-expression*  
  
 The *logical-OR-expression* must have integral, floating, or pointer type. It is evaluated in terms of its equivalence to 0. A sequence point follows *logical-OR-expression*. Evaluation of the operands proceeds as follows:  
  
-   If *logical-OR-expression* is not equal to 0, *expression* is evaluated. The result of evaluating the expression is given by the nonterminal *expression*. (This means *expression* is evaluated only if *logical-OR-expression* is true.)  
  
-   If *logical-OR-expression* equals 0, *conditional-expression* is evaluated. The result of the expression is the value of *conditional-expression*. (This means *conditional-expression* is evaluated only if *logical-OR-expression* is false.)  
  
 Note that either *expression* or *conditional-expression* is evaluated, but not both.  
  
 The type of the result of a conditional operation depends on the type of the *expression* or *conditional-expression* operand, as follows:  
  
-   If *expression* or *conditional-expression* has integral or floating type (their types can be different), the operator performs the usual arithmetic conversions. The type of the result is the type of the operands after conversion.  
  
-   If both *expression* and *conditional-expression* have the same structure, union, or pointer type, the type of the result is the same structure, union, or pointer type.  
  
-   If both operands have type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the result has type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
-   If either operand is a pointer to an object of any type, and the other operand is a pointer to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the pointer to the object is converted to a pointer to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and the result is a pointer to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
-   If either *expression* or *conditional-expression* is a pointer and the other operand is a constant expression with the value 0, the type of the result is the pointer type.  
  
 In the type comparison for pointers, any type qualifiers (**const** or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) in the type to which the pointer points are insignificant, but the result type inherits the qualifiers from both components of the conditional.  
  
## Examples  
 The following examples show uses of the conditional operator:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example assigns the absolute value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is less than 0, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is assigned to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is greater than or equal to 0, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is assigned to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In this example, two functions, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, and two variables, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, are declared. Later in the program, if the two variables have the same value, the function <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is called. Otherwise, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is called.  
  
## See Also  
 [Conditional Operator: ? :](../vs140/conditional-operator-----.md)