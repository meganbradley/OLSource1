---
title: "C Multiplicative Operators"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "arithmetic operators [C++], multiplicative operators"
  - "/ operator"
  - "/ operator, multiplicative operators"
  - "remainder operator (%)"
  - "operators [C], multiplication"
  - "% operator"
  - "slash (/) operator"
  - "multiplication operator [C++], multiplicative operators"
ms.assetid: 495471c9-319b-4eb4-bd97-039a025fd3a9
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C Multiplicative Operators
The multiplicative operators perform multiplication (**\***), division (**/**), and remainder (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) operations.  
  
 **Syntax**  
  
 *multiplicative-expression*:  
 *cast-expression*  
  
 *multiplicative-expression*  **\***  *cast-expression*  
  
 *multiplicative-expression*  **/**  *cast-expression*  
  
 *multiplicative-expression*  **%**  *cast-expression*  
  
 The operands of the remainder operator (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) must be integral. The multiplication (**\***) and division (**/**) operators can take integral- or floating-type operands; the types of the operands can be different.  
  
 The multiplicative operators perform the usual arithmetic conversions on the operands. The type of the result is the type of the operands after conversion.  
  
> [!NOTE]
>  Since the conversions performed by the multiplicative operators do not provide for overflow or underflow conditions, information may be lost if the result of a multiplicative operation cannot be represented in the type of the operands after conversion.  
  
 The C multiplicative operators are described below:  
  
|Operator|Description|  
|--------------|-----------------|  
|**\***|The multiplication operator causes its two operands to be multiplied.|  
|**/**|The division operator causes the first operand to be divided by the second. If two integer operands are divided and the result is not an integer, it is truncated according to the following rules:|  
||-   The result of division by 0 is undefined according to the ANSI C standard. The Microsoft C compiler generates an error at compile time or run time.|  
||-   If both operands are positive or unsigned, the result is truncated toward 0.|  
||-   If either operand is negative, whether the result of the operation is the largest integer less than or equal to the algebraic quotient or is the smallest integer greater than or equal to the algebraic quotient is implementation defined. (See the Microsoft Specific section below.)|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The result of the remainder operator is the remainder when the first operand is divided by the second. When the division is inexact, the result is determined by the following rules:|  
||-   If the right operand is zero, the result is undefined.|  
||-   If both operands are positive or unsigned, the result is positive.|  
||-   If either operand is negative and the result is inexact, the result is implementation defined. (See the Microsoft Specific section below.)|  
  
 **Microsoft Specific**  
  
 In division where either operand is negative, the direction of truncation is toward 0.  
  
 If either operation is negative in division with the remainder operator, the result has the same sign as the dividend (the first operand in the expression).  
  
 **END Microsoft Specific**  
  
## Examples  
 The declarations shown below are used for the following examples:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This statement uses the multiplication operator:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In this case, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is multiplied by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to give the value 20.0. The result has **double** type.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In this example, 10 is divided by 3. The result is truncated toward 0, yielding the integer value 3.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This statement assigns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> the integer remainder, 1, when 10 is divided by 3.  
  
 **Microsoft Specific**  
  
 The sign of the remainder is the same as the sign of the dividend. For example:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 In each case, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> have the same sign.  
  
 **END Microsoft Specific**  
  
## See Also  
 [Multiplicative Operators and the Modulus Operator](../vs140/multiplicative-operators-and-the-modulus-operator.md)