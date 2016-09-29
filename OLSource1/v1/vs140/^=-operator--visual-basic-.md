---
title: "^= Operator (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.^="
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "assignment statements, compound"
  - "statements [Visual Basic], compound assignment"
  - "^= operator [Visual Basic]"
  - "compound assignment statements"
ms.assetid: 397da132-2d96-4a85-a7bc-f7c730a608c9
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ^= Operator (Visual Basic)
Raises the value of a variable or property to the power of an expression and assigns the result back to the variable or property.  
  
## Syntax  
  
```  
  
variableorproperty ^= expression  
```  
  
## Parts  
 `variableorproperty`  
 Required. Any numeric variable or property.  
  
 `expression`  
 Required. Any numeric expression.  
  
## Remarks  
 The element on the left side of the `^=` operator can be a simple scalar variable, a property, or an element of an array. The variable or property cannot be [ReadOnly (Visual Basic)](../vs140/readonly--visual-basic-.md).  
  
 The `^=` operator first raises the value of the variable or property (on the left-hand side of the operator) to the power of the value of the expression (on the right-hand side of the operator). The operator then assigns the result of that operation back to the variable or property.  
  
 Visual Basic always performs exponentiation in the [Double Data Type (Visual Basic)](../vs140/double-data-type--visual-basic-.md). Operands of any different type are converted to `Double`, and the result is always `Double`.  
  
 The value of `expression` can be fractional, negative, or both.  
  
## Overloading  
 The [^ Operator](../vs140/^-operator--visual-basic-.md) can be *overloaded*, which means that a class or structure can redefine its behavior when an operand has the type of that class or structure. Overloading the `^` operator affects the behavior of the `^=` operator. If your code uses `^=` on a class or structure that overloads `^`, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example uses the `^=` operator to raise the value of one `Integer` variable to the power of a second variable and assign the result to the first variable.  
  
 [!code[VbVbalrOperators#21](../vs140/codesnippet/VisualBasic/^=-operator--visual-basic-_1.vb)]  
  
## See Also  
 [^ Operator](../vs140/^-operator--visual-basic-.md)   
 [Assignment Operators](../vs140/assignment-operators--visual-basic-.md)   
 [Arithmetic Operators](../vs140/arithmetic-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Statements in Visual Basic](../vs140/statements-in-visual-basic.md)