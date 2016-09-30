---
title: "-= Operator"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "\= Operator"
f1_keywords: 
  - "\="
  - "vb.\="
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "\= operator [Visual Basic]"
  - "assignment statements, compound"
  - "statements [Visual Basic], compound assignment"
  - "operator \= [Visual Basic]"
  - "compound assignment statements"
ms.assetid: 6f39915d-e398-4045-afcc-da6885e57b9c
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -= Operator
Divides the value of a variable or property by the value of an expression and assigns the integer result to the variable or property.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required. Any numeric variable or property.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. Any numeric expression.  
  
## Remarks  
 The element on the left side of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator can be a simple scalar variable, a property, or an element of an array. The variable or property cannot be [ReadOnly (Visual Basic)](../vs140/readonly--visual-basic-.md).  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operator divides the value of a variable or property on its left by the value on its right, and assigns the integer result to the variable or property on its left  
  
 For further information on integer division, see [\ Operator (Visual Basic)](../vs140/--operator--visual-basic-2.md).  
  
## Overloading  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> operator can be *overloaded*, which means that a class or structure can redefine its behavior when an operand has the type of that class or structure. Overloading the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> operator affects the behavior of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> operator. If your code uses <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> on a class or structure that overloads <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> operator to divide one <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> variable by a second and assign the integer result to the first variable.  
  
 [!code[VbVbalrOperators#19](../vs140/codesnippet/VisualBasic/-=-operator_1.vb)]  
  
## See Also  
 [\ Operator (Visual Basic)](../vs140/--operator--visual-basic-2.md)   
 [/= Operator (Visual Basic)](../vs140/-=-operator--visual-basic-1.md)   
 [Assignment Operators](../vs140/assignment-operators--visual-basic-.md)   
 [Arithmetic Operators](../vs140/arithmetic-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Statements in Visual Basic](../vs140/statements-in-visual-basic.md)