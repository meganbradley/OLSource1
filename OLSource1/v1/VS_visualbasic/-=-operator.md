---
title: "-= Operator"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 13
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
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
 The element on the left side of the `\=` operator can be a simple scalar variable, a property, or an element of an array. The variable or property cannot be [ReadOnly](../VS_visualbasic/readonly--visual-basic-.md).  
  
 The `\=` operator divides the value of a variable or property on its left by the value on its right, and assigns the integer result to the variable or property on its left  
  
 For further information on integer division, see [\ Operator (Visual Basic)](../VS_visualbasic/--operator--visual-basic-2.md).  
  
## Overloading  
 The `\` operator can be *overloaded*, which means that a class or structure can redefine its behavior when an operand has the type of that class or structure. Overloading the `\` operator affects the behavior of the `\=` operator. If your code uses `\=` on a class or structure that overloads `\`, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../VS_visualbasic/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example uses the `\=` operator to divide one `Integer` variable by a second and assign the integer result to the first variable.  
  
 [!code[VbVbalrOperators#19](../VS_visualbasic/codesnippet/VisualBasic/-=-operator_1.vb)]  
  
## See Also  
 [\ Operator (Visual Basic)](../VS_visualbasic/--operator--visual-basic-2.md)   
 [/= Operator (Visual Basic)](../VS_visualbasic/-=-operator--visual-basic-1.md)   
 [Assignment Operators](../VS_visualbasic/assignment-operators--visual-basic-.md)   
 [Arithmetic Operators](../VS_visualbasic/arithmetic-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../VS_visualbasic/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../VS_visualbasic/operators-listed-by-functionality--visual-basic-.md)   
 [Statements](../VS_visualbasic/statements-in-visual-basic.md)