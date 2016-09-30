---
title: "Multiplicative Operators and the Modulus Operator"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "%"
  - "/"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operators [C++], multiplicative"
  - "arithmetic operators [C++], multiplicative operators"
  - "modulus operator, C+"
  - "* operator"
  - "division operator, multiplicative operators"
  - "% operator"
  - "multiplication operator [C++], multiplicative operators"
  - "multiplicative operators [C++]"
  - "division operator"
ms.assetid: b53ea5da-d0b4-40dc-98f3-0aa52d548293
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Multiplicative Operators and the Modulus Operator
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The multiplicative operators are:  
  
-   Multiplication (**\***)  
  
-   Division (**/**)  
  
-   Modulus (remainder from division) (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>)  
  
 These binary operators have left-to-right associativity.  
  
 The multiplicative operators take operands of arithmetic types. The modulus operator (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) has a stricter requirement in that its operands must be of integral type. (To get the remainder of a floating-point division, use the run-time function, [fmod](../vs140/fmod--fmodf.md).) The conversions covered in [Arithmetic Conversions](../vs140/arithmetic-conversions.md) are applied to the operands, and the result is of the converted type.  
  
 The multiplication operator yields the result of multiplying the first operand by the second.  
  
 The division operator yields the result of dividing the first operand by the second.  
  
 The modulus operator yields the remainder given by the following expression, where *e1* is the first operand and *e2* is the second: *e1* – (*e1* / *e2*) \* *e2*, where both operands are of integral types.  
  
 Division by 0 in either a division or a modulus expression is undefined and causes a run-time error. Therefore, the following expressions generate undefined, erroneous results:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If both operands to a multiplication, division, or modulus expression have the same sign, the result is positive. Otherwise, the result is negative. The result of a modulus operation's sign is implementation-defined.  
  
> [!NOTE]
>  Since the conversions performed by the multiplicative operators do not provide for overflow or underflow conditions, information may be lost if the result of a multiplicative operation cannot be represented in the type of the operands after conversion.  
  
## Microsoft Specific  
 In Microsoft C++, the result of a modulus expression is always the same as the sign of the first operand.  
  
## END Microsoft Specific  
 If the computed division of two integers is inexact and only one operand is negative, the result is the largest integer (in magnitude, disregarding the sign) that is less than the exact value the division operation would yield. For example, the computed value of –11 / 3 is –3.666666666. The result of that integral division is –3.  
  
 The relationship between the multiplicative operators is given by the identity (*e1* / *e2*) \* *e2* + *e1* % *e2* == *e1*.  
  
## Example  
 The following program demonstrates the multiplicative operators. Note that either operand of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> must be explicitly cast to type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to avoid truncation so that both operands are of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> before division.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Expressions with Binary Operators](../vs140/expressions-with-binary-operators.md)   
 [C++ Operators](../vs140/c---operators.md)   
 [C++ Built-in Operators, Precedence and Associativity](../vs140/c---built-in-operators--precedence-and-associativity.md)   
 [C Multiplicative Operators](../vs140/c-multiplicative-operators.md)