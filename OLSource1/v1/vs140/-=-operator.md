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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -= Operator
Divides the value of a variable or property by the value of an expression and assigns the integer result to the variable or property.  
  
## Syntax  
  
```  
  
variableorproperty \= expression  
```  
  
## Parts  
 `variableorproperty`  
 Required. Any numeric variable or property.  
  
 `expression`  
 Required. Any numeric expression.  
  
## Remarks  
 The element on the left side of the `\=` operator can be a simple scalar variable, a property, or an element of an array. The variable or property cannot be [ReadOnly (Visual Basic)](../vs140/readonly--visual-basic-.md).  
  
 The `\=` operator divides the value of a variable or property on its left by the value on its right, and assigns the integer result to the variable or property on its left  
  
 For further information on integer division, see [\ Operator (Visual Basic)](../vs140/--operator--visual-basic-2.md).  
  
## Overloading  
 The `\` operator can be *overloaded*, which means that a class or structure can redefine its behavior when an operand has the type of that class or structure. Overloading the `\` operator affects the behavior of the `\=` operator. If your code uses `\=` on a class or structure that overloads `\`, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example uses the `\=` operator to divide one `Integer` variable by a second and assign the integer result to the first variable.  
  
 [!code[VbVbalrOperators#19](../vs140/codesnippet/VisualBasic/-=-operator_1.vb)]  
  
## See Also  
 [\ Operator (Visual Basic)](../vs140/--operator--visual-basic-2.md)   
 [/= Operator (Visual Basic)](../vs140/-=-operator--visual-basic-1.md)   
 [Assignment Operators](../vs140/assignment-operators--visual-basic-.md)   
 [Arithmetic Operators](../vs140/arithmetic-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Statements in Visual Basic](../vs140/statements-in-visual-basic.md)