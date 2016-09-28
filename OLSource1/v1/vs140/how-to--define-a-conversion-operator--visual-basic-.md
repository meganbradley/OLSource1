---
title: "How to: Define a Conversion Operator (Visual Basic)"
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
  - "procedures, defining"
  - "operators [Visual Basic], defining"
  - "procedures, operator"
  - "operators [Visual Basic], overloading"
  - "return values, Operator procedures"
  - "operator overloading"
ms.assetid: 54203dfa-c24b-463f-9942-d5153e89e762
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Define a Conversion Operator (Visual Basic)
If you have defined a class or structure, you can define a type conversion operator between the type of your class or structure and another data type (such as `Integer`, `Double`, or `String`).  
  
 Define the type conversion as a [CType Function](../vs140/ctype-function--visual-basic-.md) procedure within the class or structure. All conversion procedures must be `Public Shared`, and each one must specify either [Widening](../vs140/widening--visual-basic-.md) or [Narrowing](../vs140/narrowing--visual-basic-.md).  
  
 Defining an operator on a class or structure is also called *overloading* the operator.  
  
## Example  
 The following example defines conversion operators between a structure called `digit` and a `Byte`.  
  
 [!code[VbVbcnProcedures#27](../vs140/codesnippet/VisualBasic/how-to--define-a-conversion-operator--visual-basic-_1.vb)]  
  
 You can test the structure `digit` with the following code.  
  
 [!code[VbVbcnProcedures#28](../vs140/codesnippet/VisualBasic/how-to--define-a-conversion-operator--visual-basic-_2.vb)]  
  
## See Also  
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Call an Operator Procedure](../vs140/how-to--call-an-operator-procedure--visual-basic-.md)   
 [How to: Use a Class that Defines Operators](../vs140/how-to--use-a-class-that-defines-operators--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)   
 [Structure Statement](../vs140/structure-statement.md)   
 [How to: Declare a Structure](../vs140/how-to--declare-a-structure--visual-basic-.md)   
 [Implicit and Explicit Conversions](../vs140/implicit-and-explicit-conversions--visual-basic-.md)   
 [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md)