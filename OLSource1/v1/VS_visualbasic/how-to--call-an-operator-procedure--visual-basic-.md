---
title: "How to: Call an Operator Procedure (Visual Basic)"
ms.custom: na
ms.date: "10/10/2016"
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
  - "operator procedures, calling"
  - "procedures, operator"
  - "procedure calls, operator overloading"
  - "syntax, Operator procedures"
  - "operators [Visual Basic], overloading"
  - "return values, Operator procedures"
  - "overloaded operators, calling"
  - "operator overloading"
ms.assetid: 0dce42cc-f0b0-4c14-9f62-018b21f33497
caps.latest.revision: 16
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
# How to: Call an Operator Procedure (Visual Basic)
You call an operator procedure by using the operator symbol in an expression. In the case of a conversion operator, you call the [CType Function](../VS_visualbasic/ctype-function--visual-basic-.md) to convert a value from one data type to another.  
  
 You do not call operator procedures explicitly. You just use the operator, or the `CType` function, in an assignment statement or an expression, the same way you ordinarily use an operator. [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] makes the call to the operator procedure.  
  
 Defining an operator on a class or structure is also called *overloading* the operator.  
  
### To call an operator procedure  
  
1.  Use the operator symbol in an expression in the ordinary way.  
  
2.  Be sure the data types of the operands are appropriate for the operator, and in the correct order.  
  
3.  The operator contributes to the value of the expression as expected.  
  
### To call a conversion operator procedure  
  
1.  Use `CType` inside an expression.  
  
2.  Be sure the data types of the operands are appropriate for the conversion, and in the correct order.  
  
3.  `CType` calls the conversion operator procedure and returns the converted value.  
  
## Example  
 The following example creates two \<xref:System.TimeSpan> structures, adds them together, and stores the result in a third \<xref:System.TimeSpan> structure. The \<xref:System.TimeSpan> structure defines operator procedures to overload several standard operators.  
  
 [!code[VbVbcnProcedures#29](../VS_visualbasic/codesnippet/VisualBasic/how-to--call-an-operator-procedure--visual-basic-_1.vb)]  
  
 Because \<xref:System.TimeSpan> overloads the standard `+` operator, the previous example calls an operator procedure when it calculates the value of `combinedSpan`.  
  
 For an example of calling a conversation operator procedure, see [How to: Use a Class that Defines Operators](../VS_visualbasic/how-to--use-a-class-that-defines-operators--visual-basic-.md).  
  
## Compiling the Code  
 Be sure the class or structure you are using defines the operator you want to use.  
  
## See Also  
 [Operator Procedures](../VS_visualbasic/operator-procedures--visual-basic-.md)   
 [How to: Define an Operator](../VS_visualbasic/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../VS_visualbasic/how-to--define-a-conversion-operator--visual-basic-.md)   
 [Operator Statement](../VS_visualbasic/operator-statement.md)   
 [Widening](../VS_visualbasic/widening--visual-basic-.md)   
 [Narrowing](../VS_visualbasic/narrowing--visual-basic-.md)   
 [Structure Statement](../VS_visualbasic/structure-statement.md)   
 [How to: Declare a Structure](../VS_visualbasic/how-to--declare-a-structure--visual-basic-.md)   
 [Implicit and Explicit Conversions](../VS_visualbasic/implicit-and-explicit-conversions--visual-basic-.md)   
 [Widening and Narrowing Conversions](../VS_visualbasic/widening-and-narrowing-conversions--visual-basic-.md)