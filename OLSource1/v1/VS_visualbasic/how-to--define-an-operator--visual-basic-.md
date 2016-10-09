---
title: "How to: Define an Operator (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
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
  - "Visual Basic code, procedures"
  - "operators [Visual Basic], defining"
  - "procedures, operator"
  - "Visual Basic code, operators"
  - "syntax, Operator procedures"
  - "operators [Visual Basic], overloading"
  - "operator procedures, about operator procedures"
  - "return values, Operator procedures"
  - "operator overloading"
ms.assetid: d4b0e253-092a-4e6e-9fe2-01f562140a29
caps.latest.revision: 15
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
# How to: Define an Operator (Visual Basic)
If you have defined a class or structure, you can define the behavior of a standard operator (such as `*`, `<>`, or `And`) when one or both of the operands is of the type of your class or structure.  
  
 Define the standard operator as an operator procedure within the class or structure. All operator procedures must be `Public` `Shared`.  
  
 Defining an operator on a class or structure is also called *overloading* the operator.  
  
## Example  
 The following example defines the `+` operator for a structure called `height`. The structure uses heights measured in feet and inches. One *inch* is 2.54 centimeters, and one *foot* is 12 inches. To ensure normalized values (inches < 12.0), the constructor performs *modulo* 12 arithmetic. The `+` operator uses the constructor to generate normalized values.  
  
 [!code[VbVbcnProcedures#25](../VS_visualbasic/codesnippet/VisualBasic/how-to--define-an-operator--visual-basic-_1.vb)]  
  
 You can test the structure `height` with the following code.  
  
 [!code[VbVbcnProcedures#26](../VS_visualbasic/codesnippet/VisualBasic/how-to--define-an-operator--visual-basic-_2.vb)]  
  
 For more information and examples, see [Operator Overloading in Visual Basic 2005](http://go.microsoft.com/fwlink/?LinkId=101703).  
  
## See Also  
 [Operator Procedures](../VS_visualbasic/operator-procedures--visual-basic-.md)   
 [How to: Define a Conversion Operator](../VS_visualbasic/how-to--define-a-conversion-operator--visual-basic-.md)   
 [How to: Call an Operator Procedure](../VS_visualbasic/how-to--call-an-operator-procedure--visual-basic-.md)   
 [How to: Use a Class that Defines Operators](../VS_visualbasic/how-to--use-a-class-that-defines-operators--visual-basic-.md)   
 [Operator Statement](../VS_visualbasic/operator-statement.md)   
 [Structure Statement](../VS_visualbasic/structure-statement.md)   
 [How to: Declare a Structure](../VS_visualbasic/how-to--declare-a-structure--visual-basic-.md)   
 [Mod Operator](../VS_visualbasic/mod-operator--visual-basic-.md)