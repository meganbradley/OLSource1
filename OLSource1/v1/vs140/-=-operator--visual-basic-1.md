---
title: "-= Operator (Visual Basic)1"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/= Operator (Visual Basic)"
f1_keywords: 
  - "vb./="
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "assignment statements, compound"
  - "statements [Visual Basic], compound assignment"
  - "/= operator [Visual Basic]"
  - "operator /="
  - "compound assignment statements"
ms.assetid: a1e22d0e-8380-4761-9da1-84fb51c34821
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -= Operator (Visual Basic)1
Divides the value of a variable or property by the value of an expression and assigns the floating-point result to the variable or property.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required. Any numeric variable or property.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. Any numeric expression.  
  
## Remarks  
 The element on the left side of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator can be a simple scalar variable, a property, or an element of an array. The variable or property cannot be [ReadOnly (Visual Basic)](../vs140/readonly--visual-basic-.md).  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operator first divides the value of the variable or property (on the left-hand side of the operator) by the value of the expression (on the right-hand side of the operator). The operator then assigns the floating-point result of that operation to the variable or property.  
  
 This statement assigns a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> value to the variable or property on the left. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> must be a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, Visual Basic performs an implicit conversion and assigns the resulting value to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, with a possible error at run time. For more information, see [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md) and [Option Strict Statement](../vs140/option-strict-statement.md).  
  
## Overloading  
 The [/ Operator (Visual Basic)](../vs140/--operator--visual-basic-3.md) can be *overloaded*, which means that a class or structure can redefine its behavior when an operand has the type of that class or structure. Overloading the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> operator affects the behavior of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> operator. If your code uses <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> on a class or structure that overloads <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> operator to divide one <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> variable by a second and assign the quotient to the first variable.  
  
 [!code[VbVbalrOperators#17](../vs140/codesnippet/VisualBasic/-=-operator--visual-basic-1_1.vb)]  
  
## See Also  
 [/ Operator (Visual Basic)](../vs140/--operator--visual-basic-3.md)   
 [\\= Operator](../vs140/-=-operator.md)   
 [Assignment Operators](../vs140/assignment-operators--visual-basic-.md)   
 [Arithmetic Operators](../vs140/arithmetic-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Statements in Visual Basic](../vs140/statements-in-visual-basic.md)