---
title: "Mod Operator (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vb.Mod
dev_langs: 
  - VB
helpviewer_keywords: 
  - remainder (Mod operator)
  - division operator, Mod operator
  - modulus operator, Visual Basic
  - Mod operator [Visual Basic]
  - operators [Visual Basic], division
  - arithmetic operators, Mod
  - math operators
ms.assetid: 6ff7e40e-cec8-4c77-bff6-8ddd2791c25b
caps.latest.revision: 26
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Mod Operator (Visual Basic)
Divides two numbers and returns only the remainder.  
  
## Syntax  
  
```  
  
number1 Mod number2  
```  
  
## Parts  
 `number1`  
 Required. Any numeric expression.  
  
 `number2`  
 Required. Any numeric expression.  
  
## Supported Types  
 All numeric types. This includes the unsigned and floating-point types and `Decimal`.  
  
## Result  
 The result is the remainder after `number1` is divided by `number2`. For example, the expression `14 Mod 4` evaluates to 2.  
  
## Remarks  
 If either `number1` or `number2` is a floating-point value, the floating-point remainder of the division is returned. The data type of the result is the smallest data type that can hold all possible values that result from division with the data types of `number1` and `number2`.  
  
 If `number1` or `number2` evaluates to [Nothing](../vs140/nothing--visual-basic-.md), it is treated as zero.  
  
 Related operators include the following:  
  
-   The [\ Operator](../vs140/--operator--visual-basic-2.md) returns the integer quotient of a division. For example, the expression `14 \ 4` evaluates to 3.  
  
-   The [/ Operator (Visual Basic)](../vs140/--operator--visual-basic-3.md) returns the full quotient, including the remainder, as a floating-point number. For example, the expression `14 / 4` evaluates to 3.5.  
  
## Attempted Division by Zero  
 If `number2` evaluates to zero, the behavior of the `Mod` operator depends on the data type of the operands. An integral division throws a <xref:System.DivideByZeroException?qualifyHint=False> exception. A floating-point division returns <xref:System.Double.NaN?qualifyHint=False>.  
  
## Equivalent Formula  
 The expression `a Mod b` is equivalent to either of the following formulas:  
  
 `a - (b * (a \ b))`  
  
 `a - (b * Fix(a / b))`  
  
## Floating-Point Imprecision  
 When you work with floating-point numbers, remember that they do not always have a precise representation in memory. This could lead to unexpected results from certain operations, such as value comparison and the `Mod` operator. For more information, see [Troubleshooting Data Types](../vs140/troubleshooting-data-types--visual-basic-.md).  
  
## Overloading  
 The `Mod` operator can be *overloaded*, which means that a class or structure can redefine its behavior. If your code applies `Mod` to an instance of a class or structure that includes such an overload, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example uses the `Mod` operator to divide two numbers and return only the remainder. If either number is a floating-point number, the result is a floating-point number that represents the remainder.  
  
 [!code[VbVbalrOperators#31](../vs140/codesnippet/VisualBasic/mod-operator--visual-basic-_1.vb)]
  
  
## Example  
 The following example demonstrates the potential imprecision of floating-point operands. In the first statement, the operands are `Double`, and 0.2 is an infinitely repeating binary fraction with a stored value of 0.20000000000000001. In the second statement, the literal type character `D` forces both operands to `Decimal`, and 0.2 has a precise representation.  
  
 [!code[VbVbalrOperators#32](../vs140/codesnippet/VisualBasic/mod-operator--visual-basic-_2.vb)]
  
  
## See Also  
 <xref:Microsoft.VisualBasic.Conversion.Int?qualifyHint=False>   
 <xref:Microsoft.VisualBasic.Conversion.Fix?qualifyHint=False>   
 [Arithmetic Operators](../vs140/arithmetic-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Troubleshooting Data Types](../vs140/troubleshooting-data-types--visual-basic-.md)   
 [Arithmetic Operators in Visual Basic](../vs140/arithmetic-operators-in-visual-basic.md)   
 [\ Operator](../vs140/--operator--visual-basic-2.md)