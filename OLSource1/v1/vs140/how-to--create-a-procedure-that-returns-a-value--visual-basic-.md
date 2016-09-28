---
title: "How to: Create a Procedure that Returns a Value (Visual Basic)"
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
  - "Visual Basic code, procedures"
  - "procedures, returning a value"
ms.assetid: 8ee19f95-a9ef-4033-963b-d224dca207c4
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create a Procedure that Returns a Value (Visual Basic)
You use a `Function` procedure to return a value to the calling code.  
  
### To create a procedure that returns a value  
  
1.  Outside any other procedure, use a `Function` statement, followed by an `End Function` statement.  
  
2.  In the `Function` statement, follow the `Function` keyword with the name of the procedure, and then the parameter list in parentheses.  
  
3.  Follow the parentheses with an `As` clause to specify the data type of the returned value.  
  
4.  Place the procedure's code statements between the `Function` and `End Function` statements.  
  
5.  Use a `Return` statement to return the value to the calling code.  
  
     The following `Function` procedure calculates the longest side, or hypotenuse, of a right triangle, given the values for the other two sides.  
  
     [!code[VbVbcnProcedures#1](../vs140/codesnippet/VisualBasic/how-to--create-a-procedure-that-returns-a-value--visual-basic-_1.vb)]  
  
     The following example shows a typical call to `hypotenuse`.  
  
     [!code[VbVbcnProcedures#6](../vs140/codesnippet/VisualBasic/how-to--create-a-procedure-that-returns-a-value--visual-basic-_2.vb)]  
  
## See Also  
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Sub Procedures](../vs140/sub-procedures--visual-basic-.md)   
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [Function Statement](../vs140/function-statement--visual-basic-.md)   
 [How to: Return a Value from a Procedure](../vs140/how-to--return-a-value-from-a-procedure--visual-basic-.md)   
 [How to: Call a Procedure that Returns a Value](../vs140/how-to--call-a-procedure-that-returns-a-value--visual-basic-.md)