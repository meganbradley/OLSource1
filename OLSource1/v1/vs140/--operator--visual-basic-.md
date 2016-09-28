---
title: "* Operator (Visual Basic)"
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
  - "vb.*"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "arithmetic operators, multiplication"
  - "operators [Visual Basic], multiplication"
  - "* operator [Visual Basic]"
  - "multiplication operator, syntax"
  - "math operators"
ms.assetid: 2b210382-99da-4195-89ba-b1d06f5e89ad
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# * Operator (Visual Basic)
Multiplies two numbers.  
  
## Syntax  
  
```  
  
number1 * number2  
```  
  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|`number1`|Required. Any numeric expression.|  
|`number2`|Required. Any numeric expression.|  
  
## Result  
 The result is the product of `number1` and `number2`.  
  
## Supported Types  
 All numeric types, including the unsigned and floating-point types and `Decimal`.  
  
## Remarks  
 The data type of the result depends on the types of the operands. The following table shows how the data type of the result is determined.  
  
|||  
|-|-|  
|Operand data types|Result data type|  
|Both expressions are integral data types ([SByte](../vs140/sbyte-data-type--visual-basic-.md), [Byte](../vs140/byte-data-type--visual-basic-.md), [Short](../vs140/short-data-type--visual-basic-.md), [UShort](../vs140/ushort-data-type--visual-basic-.md), [Integer](../vs140/integer-data-type--visual-basic-.md), [UInteger](../vs140/uinteger-data-type.md), [Long](../vs140/long-data-type--visual-basic-.md), [ULong](../vs140/ulong-data-type--visual-basic-.md))|A numeric data type appropriate for the data types of `number1` and `number2`. See the "Integer Arithmetic" tables in [Data Types of Operator Results](../vs140/data-types-of-operator-results--visual-basic-.md).|  
|Both expressions are [Decimal](../vs140/decimal-data-type--visual-basic-.md)|`Decimal`|  
|Both expressions are [Single](../vs140/single-data-type--visual-basic-.md)|`Single`|  
|Either expression is a floating-point data type (`Single` or [Double](../vs140/double-data-type--visual-basic-.md)) but not both `Single` (note `Decimal` is not a floating-point data type)|`Double`|  
  
 If an expression evaluates to [Nothing](../vs140/nothing--visual-basic-.md), it is treated as zero.  
  
## Overloading  
 The `*` operator can be *overloaded*, which means that a class or structure can redefine its behavior when an operand has the type of that class or structure. If your code uses this operator on such a class or structure, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 This example uses the `*` operator to multiply two numbers. The result is the product of the two operands.  
  
 [!code[VbVbalrOperators#4](../vs140/codesnippet/VisualBasic/--operator--visual-basic-_1.vb)]  
  
## See Also  
 [*= Operator](../vs140/-=-operator--visual-basic-.md)   
 [Arithmetic Operators](../vs140/arithmetic-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Arithmetic Operators in Visual Basic](../vs140/arithmetic-operators-in-visual-basic.md)