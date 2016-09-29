---
title: "- Operator (Visual Basic)3"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/ Operator (Visual Basic)"
f1_keywords: 
  - "vb./"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "division operator, floating point"
  - "floating-point numbers, division operator"
  - "slash (/) operator"
  - "zero, division by zero"
  - "operators [Visual Basic], arithmetic"
  - "arithmetic operators, division"
  - "division, by zero"
  - "operators [Visual Basic], division"
  - "division operator, syntax"
  - "/ operator [Visual Basic]"
  - "math operators"
ms.assetid: 335e97f2-c434-439e-9064-76973a051101
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# - Operator (Visual Basic)3
Divides two numbers and returns a floating-point result.  
  
## Syntax  
  
```  
  
expression1 / expression2  
```  
  
## Parts  
 `expression1`  
 Required. Any numeric expression.  
  
 `expression2`  
 Required. Any numeric expression.  
  
## Supported Types  
 All numeric types, including the unsigned and floating-point types and `Decimal`.  
  
## Result  
 The result is the full quotient of `expression1` divided by `expression2`, including any remainder.  
  
 The [\ Operator (Visual Basic)](../vs140/--operator--visual-basic-2.md) returns the integer quotient, which drops the remainder.  
  
## Remarks  
 The data type of the result depends on the types of the operands. The following table shows how the data type of the result is determined.  
  
|Operand data types|Result data type|  
|------------------------|----------------------|  
|Both expressions are integral data types ([SByte](../vs140/sbyte-data-type--visual-basic-.md), [Byte](../vs140/byte-data-type--visual-basic-.md), [Short](../vs140/short-data-type--visual-basic-.md), [UShort](../vs140/ushort-data-type--visual-basic-.md), [Integer](../vs140/integer-data-type--visual-basic-.md), [UInteger](../vs140/uinteger-data-type.md), [Long](../vs140/long-data-type--visual-basic-.md), [ULong](../vs140/ulong-data-type--visual-basic-.md))|`Double`|  
|One expression is a [Single](../vs140/single-data-type--visual-basic-.md) data type and the other is not a [Double](../vs140/double-data-type--visual-basic-.md)|`Single`|  
|One expression is a [Decimal](../vs140/decimal-data-type--visual-basic-.md) data type and the other is not a [Single](../vs140/single-data-type--visual-basic-.md) or a [Double](../vs140/double-data-type--visual-basic-.md)|`Decimal`|  
|Either expression is a [Double](../vs140/double-data-type--visual-basic-.md) data type|`Double`|  
  
 Before division is performed, any integral numeric expressions are widened to `Double`. If you assign the result to an integral data type, Visual Basic attempts to convert the result from `Double` to that type. This can throw an exception if the result does not fit in that type. In particular, see "Attempted Division by Zero" on this Help page.  
  
 If `expression1` or `expression2` evaluates to [Nothing](../vs140/nothing--visual-basic-.md), it is treated as zero.  
  
## Attempted Division by Zero  
 If `expression2` evaluates to zero, the `/` operator behaves differently for different operand data types. The following table shows the possible behaviors.  
  
|Operand data types|Behavior if `expression2` is zero|  
|------------------------|---------------------------------------|  
|Floating-point (`Single` or `Double`)|Returns infinity (<xref:System.Double.PositiveInfinity*> or <xref:System.Double.NegativeInfinity*>), or <xref:System.Double.NaN*> (not a number) if `expression1` is also zero|  
|`Decimal`|Throws <xref:System.DivideByZeroException*>|  
|Integral (signed or unsigned)|Attempted conversion back to integral type throws <xref:System.OverflowException*> because integral types cannot accept <xref:System.Double.PositiveInfinity*>, <xref:System.Double.NegativeInfinity*>, or <xref:System.Double.NaN*>|  
  
> [!NOTE]
>  The `/` operator can be *overloaded*, which means that a class or structure can redefine its behavior when an operand has the type of that class or structure. If your code uses this operator on such a class or structure, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 This example uses the `/` operator to perform floating-point division. The result is the quotient of the two operands.  
  
 [!code[VbVbalrOperators#16](../vs140/codesnippet/VisualBasic/--operator--visual-basic-3_1.vb)]  
  
 The expressions in the preceding example return values of 2.5 and 3.333333. Note that the result is always floating-point (`Double`), even though both operands are integer constants.  
  
## See Also  
 [/= Operator (Visual Basic)](../vs140/-=-operator--visual-basic-1.md)   
 [\ Operator (Visual Basic)](../vs140/--operator--visual-basic-2.md)   
 [Data Types of Operator Results](../vs140/data-types-of-operator-results--visual-basic-.md)   
 [Arithmetic Operators](../vs140/arithmetic-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Arithmetic Operators in Visual Basic](../vs140/arithmetic-operators-in-visual-basic.md)