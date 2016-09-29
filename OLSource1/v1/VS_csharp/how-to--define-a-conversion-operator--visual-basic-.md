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
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Define a Conversion Operator (Visual Basic)
If you have defined a class or structure, you can define a type conversion operator between the type of your class or structure and another data type (such as `Integer`, `Double`, or `String`).  
  
 Define the type conversion as a [CType Function](../VS_csharp/ctype-function--visual-basic-.md) procedure within the class or structure. All conversion procedures must be `Public Shared`, and each one must specify either [Widening](../VS_csharp/widening--visual-basic-.md) or [Narrowing](../VS_csharp/narrowing--visual-basic-.md).  
  
 Defining an operator on a class or structure is also called *overloading* the operator.  
  
## Example  
 The following example defines conversion operators between a structure called `digit` and a `Byte`.  
  
 [!code[VbVbcnProcedures#27](../VS_csharp/codesnippet/VisualBasic/how-to--define-a-conversion-operator--visual-basic-_1.vb)]  
  
 You can test the structure `digit` with the following code.  
  
 [!code[VbVbcnProcedures#28](../VS_csharp/codesnippet/VisualBasic/how-to--define-a-conversion-operator--visual-basic-_2.vb)]  
  
## See Also  
 [Operator Procedures](../VS_csharp/operator-procedures--visual-basic-.md)   
 [How to: Define an Operator](../VS_csharp/how-to--define-an-operator--visual-basic-.md)   
 [How to: Call an Operator Procedure](../VS_csharp/how-to--call-an-operator-procedure--visual-basic-.md)   
 [How to: Use a Class that Defines Operators](../VS_csharp/how-to--use-a-class-that-defines-operators--visual-basic-.md)   
 [Operator Statement](../VS_csharp/operator-statement.md)   
 [Structure Statement](../VS_csharp/structure-statement.md)   
 [How to: Declare a Structure](../VS_csharp/how-to--declare-a-structure--visual-basic-.md)   
 [Implicit and Explicit Conversions](../VS_csharp/implicit-and-explicit-conversions--visual-basic-.md)   
 [Widening and Narrowing Conversions](../VS_csharp/widening-and-narrowing-conversions--visual-basic-.md)