---
title: "How to: Calculate Numeric Values (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "operator precedence"
  - "operators [Visual Basic]"
  - "expressions [Visual Basic], numeric"
  - "calculations, numeric expressions"
  - "precedence, of operators"
  - "Visual Basic code, operators"
  - "Visual Basic code, expressions"
  - "numeric expressions"
ms.assetid: ba6bf43d-bd96-49b8-b1de-4a7797551372
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Calculate Numeric Values (Visual Basic)
You can calculate numeric values through the use of numeric expressions. A *numeric expression* is an expression that contains literals, constants, and variables representing numeric values, and operators that act on those values.  
  
## Calculating Numeric Values  
  
#### To calculate a numeric value  
  
-   Combine one or more numeric literals, constants, and variables into a numeric expression. The following example shows some valid numeric expressions.  
  
     `93.217`  
  
     `System.Math.PI`  
  
     `counter`  
  
     `4 * (67 + i)`  
  
     The first three lines show a literal, a constant, and a variable. Each one forms a valid numeric expression by itself. The final line shows a combination of a variable with two literals.  
  
     Note that a numeric expression does not form a complete [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] statement by itself. You must use the expression as part of a complete statement.  
  
#### To store a numeric value  
  
-   You can use an assignment statement to assign the value represented by a numeric expression to a variable, as the following example demonstrates.  
  
     [!code[VbVbalrOperators#82](../VS_csharp/codesnippet/VisualBasic/how-to--calculate-numeric-values--visual-basic-_1.vb)]  
  
     In the preceding example, the value of the expression on the right side of the equal operator (`=`) is assigned to the variable `j` on the left side of the operator, so `j` evaluates to 276.  
  
     For more information, see [Statements (Visual Basic)](../VS_csharp/statements--visual-basic-.md).  
  
## Multiple Operators  
 If the numeric expression contains more than one operator, the order in which they are evaluated is determined by the rules of operator precedence. To override the rules of operator precedence, you enclose expressions in parentheses, as in the above example; the enclosed expressions are evaluated first.  
  
#### To override normal operator precedence  
  
-   Use parentheses to enclose the operations you want to be performed first. The following example shows two different results with the same operands and operators.  
  
     [!code[VbVbalrOperators#83](../VS_csharp/codesnippet/VisualBasic/how-to--calculate-numeric-values--visual-basic-_2.vb)]  
  
     In the preceding example, the calculation for `j` performs the addition operator (`+`) first because the parentheses around `(67 + i)` override normal precedence, and the value assigned to `j` is 276 (4 times 69). The calculation for `k` performs the operators in their normal precedence (`*` before `+`), and the value assigned to `k` is 270 (268 plus 2).  
  
     For more information, see [Operator Precedence in Visual Basic](../VS_csharp/operator-precedence-in-visual-basic.md).  
  
## See Also  
 [Operators and Expressions in Visual Basic](../VS_csharp/operators-and-expressions-in-visual-basic.md)   
 [Value Comparisons](../VS_csharp/value-comparisons--visual-basic-.md)   
 [Statements (Visual Basic)](../VS_csharp/statements--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../VS_csharp/operator-precedence-in-visual-basic.md)   
 [Arithmetic Operators](../VS_csharp/arithmetic-operators--visual-basic-.md)   
 [Efficient Combination of Operators](../VS_csharp/efficient-combination-of-operators--visual-basic-.md)