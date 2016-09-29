---
title: "- Operator (Visual Basic)2"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "\ Operator (Visual Basic)"
f1_keywords: 
  - "vb.\"
  - "\"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "division operator, integer"
  - "integer division operator"
  - "zero, division by zero"
  - "arithmetic operators, division"
  - "division, by zero"
  - "backslash (\) [Visual Basic]"
  - "\ operator [Visual Basic]"
  - "integer quotient"
  - "math operators"
  - "quotients, integer"
  - "truncation, integer division"
ms.assetid: 4b0ee347-950c-45c9-8e23-54bc85df208e
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# - Operator (Visual Basic)2
Divides two numbers and returns an integer result.  
  
## Syntax  
  
```  
  
expression1 \ expression2  
```  
  
## Parts  
 `expression1`  
 Required. Any numeric expression.  
  
 `expression2`  
 Required. Any numeric expression.  
  
## Supported Types  
 All numeric types, including the unsigned and floating-point types and `Decimal`.  
  
## Result  
 The result is the integer quotient of `expression1` divided by `expression2`, which discards any remainder and retains only the integer portion. This is known as *truncation*.  
  
 The result data type is a numeric type appropriate for the data types of `expression1` and `expression2`. See the "Integer Arithmetic" tables in [Data Types of Operator Results](../vs140/data-types-of-operator-results--visual-basic-.md).  
  
 The [/ Operator (Visual Basic)](../vs140/--operator--visual-basic-3.md) returns the full quotient, which retains the remainder in the fractional portion.  
  
## Remarks  
 Before performing the division, Visual Basic attempts to convert any floating-point numeric expression to `Long`. If `Option Strict` is `On`, a compiler error occurs. If `Option Strict` is `Off`, an <xref:System.OverflowException*> is possible if the value is outside the range of the [Long Data Type (Visual Basic)](../vs140/long-data-type--visual-basic-.md). The conversion to `Long` is also subject to *banker's rounding*. For more information, see "Fractional Parts" in [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md).  
  
 If `expression1` or `expression2` evaluates to [Nothing](../vs140/nothing--visual-basic-.md), it is treated as zero.  
  
## Attempted Division by Zero  
 If `expression2` evaluates to zero, the `\` operator throws a <xref:System.DivideByZeroException*> exception. This is true for all numeric data types of the operands.  
  
> [!NOTE]
>  The `\` operator can be *overloaded*, which means that a class or structure can redefine its behavior when an operand has the type of that class or structure. If your code uses this operator on such a class or structure, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example uses the `\` operator to perform integer division. The result is an integer that represents the integer quotient of the two operands, with the remainder discarded.  
  
 [!code[VbVbalrOperators#18](../vs140/codesnippet/VisualBasic/--operator--visual-basic-2_1.vb)]  
  
 The expressions in the preceding example return values of 2, 3, 33, and -22, respectively.  
  
## See Also  
 [\\= Operator](../vs140/-=-operator.md)   
 [/ Operator (Visual Basic)](../vs140/--operator--visual-basic-3.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)   
 [Arithmetic Operators](../vs140/arithmetic-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Arithmetic Operators in Visual Basic](../vs140/arithmetic-operators-in-visual-basic.md)