---
title: "OrElse Operator (Visual Basic)"
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
  - "OrElse"
  - "vb.OrElse"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "short-circuiting"
  - "operators [Visual Basic], short-circuiting"
  - "operators [Visual Basic], disjunction"
  - "short-circuit evaluation"
  - "OrElse operator [Visual Basic]"
ms.assetid: 253803d8-05b0-47d7-b213-abd222847779
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OrElse Operator (Visual Basic)
Performs short-circuiting inclusive logical disjunction on two expressions.  
  
## Syntax  
  
```  
  
result = expression1 OrElse expression2  
```  
  
## Parts  
 `result`  
 Required. Any `Boolean` expression.  
  
 `expression1`  
 Required. Any `Boolean` expression.  
  
 `expression2`  
 Required. Any `Boolean` expression.  
  
## Remarks  
 A logical operation is said to be *short-circuiting* if the compiled code can bypass the evaluation of one expression depending on the result of another expression. If the result of the first expression evaluated determines the final result of the operation, there is no need to evaluate the second expression, because it cannot change the final result. Short-circuiting can improve performance if the bypassed expression is complex, or if it involves procedure calls.  
  
 If either or both expressions evaluate to `True`, `result` is `True`. The following table illustrates how `result` is determined.  
  
|If `expression1` is|And `expression2` is|The value of `result` is|  
|-------------------------|--------------------------|------------------------------|  
|`True`|(not evaluated)|`True`|  
|`False`|`True`|`True`|  
|`False`|`False`|`False`|  
  
## Data Types  
 The `OrElse` operator is defined only for the [Boolean Data Type (Visual Basic)](../VS_csharp/boolean-data-type--visual-basic-.md). Visual Basic converts each operand as necessary to `Boolean` and performs the operation entirely in `Boolean`. If you assign the result to a numeric type, Visual Basic converts it from `Boolean` to that type. This could produce unexpected behavior. For example, `5 OrElse 12` results in `–1` when converted to `Integer`.  
  
## Overloading  
 The [Or Operator (Visual Basic)](../VS_csharp/or-operator--visual-basic-.md) and the [IsTrue Operator](../VS_csharp/istrue-operator--visual-basic-.md) can be *overloaded*, which means that a class or structure can redefine their behavior when an operand has the type of that class or structure. Overloading the `Or` and `IsTrue` operators affects the behavior of the `OrElse` operator. If your code uses `OrElse` on a class or structure that overloads `Or` and `IsTrue`, be sure you understand their redefined behavior. For more information, see [Operator Procedures](../VS_csharp/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example uses the `OrElse` operator to perform logical disjunction on two expressions. The result is a `Boolean` value that represents whether either of the two expressions is true. If the first expression is `True`, the second is not evaluated.  
  
 [!code[VbVbalrOperators#37](../VS_csharp/codesnippet/VisualBasic/orelse-operator--visual-basic-_1.vb)]  
  
 The preceding example produces results of `True`, `True`, and `False` respectively. In the calculation of `firstCheck`, the second expression is not evaluated because the first is already `True`. However, the second expression is evaluated in the calculation of `secondCheck`.  
  
## Example  
 The following example shows an `If`...`Then` statement containing two procedure calls. If the first call returns `True`, the second procedure is not called. This could produce unexpected results if the second procedure performs important tasks that should always be performed when this section of the code runs.  
  
 [!code[VbVbalrOperators#38](../VS_csharp/codesnippet/VisualBasic/orelse-operator--visual-basic-_2.vb)]  
  
## See Also  
 [Logical/Bitwise Operators (Visual Basic)](../VS_csharp/logical-bitwise-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../VS_csharp/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../VS_csharp/operators-listed-by-functionality--visual-basic-.md)   
 [Or Operator](../VS_csharp/or-operator--visual-basic-.md)   
 [IsTrue Operator](../VS_csharp/istrue-operator--visual-basic-.md)   
 [Logical and Bitwise Operators in Visual Basic](../VS_csharp/logical-and-bitwise-operators-in-visual-basic.md)