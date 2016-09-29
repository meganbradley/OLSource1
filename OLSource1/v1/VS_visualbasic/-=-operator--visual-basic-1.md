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
  
```  
  
variableorproperty /= expression  
```  
  
## Parts  
 `variableorproperty`  
 Required. Any numeric variable or property.  
  
 `expression`  
 Required. Any numeric expression.  
  
## Remarks  
 The element on the left side of the `/=` operator can be a simple scalar variable, a property, or an element of an array. The variable or property cannot be [ReadOnly (Visual Basic)](../VS_csharp/readonly--visual-basic-.md).  
  
 The `/=` operator first divides the value of the variable or property (on the left-hand side of the operator) by the value of the expression (on the right-hand side of the operator). The operator then assigns the floating-point result of that operation to the variable or property.  
  
 This statement assigns a `Double` value to the variable or property on the left. If `Option Strict` is `On`, `variableorproperty` must be a `Double`. If `Option Strict` is `Off`, Visual Basic performs an implicit conversion and assigns the resulting value to `variableorproperty`, with a possible error at run time. For more information, see [Widening and Narrowing Conversions](../VS_csharp/widening-and-narrowing-conversions--visual-basic-.md) and [Option Strict Statement](../VS_csharp/option-strict-statement.md).  
  
## Overloading  
 The [/ Operator (Visual Basic)](../VS_csharp/--operator--visual-basic-3.md) can be *overloaded*, which means that a class or structure can redefine its behavior when an operand has the type of that class or structure. Overloading the `/` operator affects the behavior of the `/=` operator. If your code uses `/=` on a class or structure that overloads `/`, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../VS_csharp/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example uses the `/=` operator to divide one `Integer` variable by a second and assign the quotient to the first variable.  
  
 [!code[VbVbalrOperators#17](../VS_csharp/codesnippet/VisualBasic/-=-operator--visual-basic-1_1.vb)]  
  
## See Also  
 [/ Operator (Visual Basic)](../VS_csharp/--operator--visual-basic-3.md)   
 [\\= Operator](../VS_csharp/-=-operator.md)   
 [Assignment Operators](../VS_csharp/assignment-operators--visual-basic-.md)   
 [Arithmetic Operators](../VS_csharp/arithmetic-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../VS_csharp/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../VS_csharp/operators-listed-by-functionality--visual-basic-.md)   
 [Statements in Visual Basic](../VS_csharp/statements-in-visual-basic.md)