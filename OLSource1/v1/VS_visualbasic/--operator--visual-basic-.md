---
title: "* Operator (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 19
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
|Both expressions are integral data types ([SByte](../VS_visualbasic/sbyte-data-type--visual-basic-.md), [Byte](../VS_visualbasic/byte-data-type--visual-basic-.md), [Short](../VS_visualbasic/short-data-type--visual-basic-.md), [UShort](../VS_visualbasic/ushort-data-type--visual-basic-.md), [Integer](../VS_visualbasic/integer-data-type--visual-basic-.md), [UInteger](../VS_visualbasic/uinteger-data-type.md), [Long](../VS_visualbasic/long-data-type--visual-basic-.md), [ULong](../VS_visualbasic/ulong-data-type--visual-basic-.md))|A numeric data type appropriate for the data types of `number1` and `number2`. See the "Integer Arithmetic" tables in [Data Types of Operator Results](../VS_visualbasic/data-types-of-operator-results--visual-basic-.md).|  
|Both expressions are [Decimal](../VS_visualbasic/decimal-data-type--visual-basic-.md)|`Decimal`|  
|Both expressions are [Single](../VS_visualbasic/single-data-type--visual-basic-.md)|`Single`|  
|Either expression is a floating-point data type (`Single` or [Double](../VS_visualbasic/double-data-type--visual-basic-.md)) but not both `Single` (note `Decimal` is not a floating-point data type)|`Double`|  
  
 If an expression evaluates to [Nothing](../VS_visualbasic/nothing--visual-basic-.md), it is treated as zero.  
  
## Overloading  
 The `*` operator can be *overloaded*, which means that a class or structure can redefine its behavior when an operand has the type of that class or structure. If your code uses this operator on such a class or structure, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../VS_visualbasic/operator-procedures--visual-basic-.md).  
  
## Example  
 This example uses the `*` operator to multiply two numbers. The result is the product of the two operands.  
  
 [!code[VbVbalrOperators#4](../VS_visualbasic/codesnippet/VisualBasic/--operator--visual-basic-_1.vb)]  
  
## See Also  
 [*= Operator](../VS_visualbasic/-=-operator--visual-basic-.md)   
 [Arithmetic Operators](../VS_visualbasic/arithmetic-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../VS_visualbasic/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../VS_visualbasic/operators-listed-by-functionality--visual-basic-.md)   
 [Arithmetic Operators in Visual Basic](../VS_visualbasic/arithmetic-operators-in-visual-basic.md)