---
title: "&amp;= Operator (Visual Basic)"
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
  - "vb.&="
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "operator &="
  - "assignment statements, compound"
  - "statements [Visual Basic], compound assignment"
  - "&= operator [Visual Basic]"
  - "compound assignment statements"
ms.assetid: 0cf262fc-1a05-419a-a503-60013f111c8a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &amp;= Operator (Visual Basic)
Concatenates a `String` expression to a `String` variable or property and assigns the result to the variable or property.  
  
## Syntax  
  
```  
  
variableorproperty &= expression  
```  
  
## Parts  
 `variableorproperty`  
 Required. Any `String` variable or property.  
  
 `expression`  
 Required. Any `String` expression.  
  
## Remarks  
 The element on the left side of the `&=` operator can be a simple scalar variable, a property, or an element of an array. The variable or property cannot be [ReadOnly (Visual Basic)](../vs140/readonly--visual-basic-.md). The `&=` operator concatenates the `String` expression on its right to the `String` variable or property on its left, and assigns the result to the variable or property on its left.  
  
## Overloading  
 The [& Operator](../vs140/--operator--visual-basic-.md) can be *overloaded*, which means that a class or structure can redefine its behavior when an operand has the type of that class or structure. Overloading the `&` operator affects the behavior of the `&=` operator. If your code uses `&=` on a class or structure that overloads `&`, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example uses the `&=` operator to concatenate two `String` variables and assign the result to the first variable.  
  
 [!code[VbVbalrOperators#3](../vs140/codesnippet/VisualBasic/-=-operator--visual-basic-_1.vb)]  
  
## See Also  
 [& Operator](../vs140/--operator--visual-basic-.md)   
 [+= Operator](../vs140/-=-operator--visual-basic-.md)   
 [Assignment Operators](../vs140/assignment-operators--visual-basic-.md)   
 [Concatenation Operators](../vs140/concatenation-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Statements in Visual Basic](../vs140/statements-in-visual-basic.md)