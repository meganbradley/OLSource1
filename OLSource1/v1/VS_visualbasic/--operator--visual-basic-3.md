---
title: "- Operator (Visual Basic)3"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 18
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
  
 The [\ Operator (Visual Basic)](../VS_visualbasic/--operator--visual-basic-2.md) returns the integer quotient, which drops the remainder.  
  
## Remarks  
 The data type of the result depends on the types of the operands. The following table shows how the data type of the result is determined.  
  
|Operand data types|Result data type|  
|------------------------|----------------------|  
|Both expressions are integral data types ([SByte](../VS_visualbasic/sbyte-data-type--visual-basic-.md), [Byte](../VS_visualbasic/byte-data-type--visual-basic-.md), [Short](../VS_visualbasic/short-data-type--visual-basic-.md), [UShort](../VS_visualbasic/ushort-data-type--visual-basic-.md), [Integer](../VS_visualbasic/integer-data-type--visual-basic-.md), [UInteger](../VS_visualbasic/uinteger-data-type.md), [Long](../VS_visualbasic/long-data-type--visual-basic-.md), [ULong](../VS_visualbasic/ulong-data-type--visual-basic-.md))|`Double`|  
|One expression is a [Single](../VS_visualbasic/single-data-type--visual-basic-.md) data type and the other is not a [Double](../VS_visualbasic/double-data-type--visual-basic-.md)|`Single`|  
|One expression is a [Decimal](../VS_visualbasic/decimal-data-type--visual-basic-.md) data type and the other is not a [Single](../VS_visualbasic/single-data-type--visual-basic-.md) or a [Double](../VS_visualbasic/double-data-type--visual-basic-.md)|`Decimal`|  
|Either expression is a [Double](../VS_visualbasic/double-data-type--visual-basic-.md) data type|`Double`|  
  
 Before division is performed, any integral numeric expressions are widened to `Double`. If you assign the result to an integral data type, Visual Basic attempts to convert the result from `Double` to that type. This can throw an exception if the result does not fit in that type. In particular, see "Attempted Division by Zero" on this Help page.  
  
 If `expression1` or `expression2` evaluates to [Nothing](../VS_visualbasic/nothing--visual-basic-.md), it is treated as zero.  
  
## Attempted Division by Zero  
 If `expression2` evaluates to zero, the `/` operator behaves differently for different operand data types. The following table shows the possible behaviors.  
  
|Operand data types|Behavior if `expression2` is zero|  
|------------------------|---------------------------------------|  
|Floating-point (`Single` or `Double`)|Returns infinity (\<xref:System.Double.PositiveInfinity> or \<xref:System.Double.NegativeInfinity>), or \<xref:System.Double.NaN> (not a number) if `expression1` is also zero|  
|`Decimal`|Throws \<xref:System.DivideByZeroException>|  
|Integral (signed or unsigned)|Attempted conversion back to integral type throws \<xref:System.OverflowException> because integral types cannot accept \<xref:System.Double.PositiveInfinity>, \<xref:System.Double.NegativeInfinity>, or \<xref:System.Double.NaN>|  
  
> [!NOTE]
>  The `/` operator can be *overloaded*, which means that a class or structure can redefine its behavior when an operand has the type of that class or structure. If your code uses this operator on such a class or structure, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../VS_visualbasic/operator-procedures--visual-basic-.md).  
  
## Example  
 This example uses the `/` operator to perform floating-point division. The result is the quotient of the two operands.  
  
 [!code[VbVbalrOperators#16](../VS_visualbasic/codesnippet/VisualBasic/--operator--visual-basic-3_1.vb)]  
  
 The expressions in the preceding example return values of 2.5 and 3.333333. Note that the result is always floating-point (`Double`), even though both operands are integer constants.  
  
## See Also  
 [/= Operator (Visual Basic)](../VS_visualbasic/-=-operator--visual-basic-1.md)   
 [\ Operator (Visual Basic)](../VS_visualbasic/--operator--visual-basic-2.md)   
 [Data Types of Operator Results](../VS_visualbasic/data-types-of-operator-results--visual-basic-.md)   
 [Arithmetic Operators](../VS_visualbasic/arithmetic-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../VS_visualbasic/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../VS_visualbasic/operators-listed-by-functionality--visual-basic-.md)   
 [Arithmetic Operators in Visual Basic](../VS_visualbasic/arithmetic-operators-in-visual-basic.md)