---
title: "How to: Return a Value from a Procedure (Visual Basic)"
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
  - "Visual Basic code, procedures"
  - "procedures, returning from"
  - "procedures, returning a value"
ms.assetid: 4bcc4724-2b4e-4df8-9b4b-16054607f87d
caps.latest.revision: 12
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
# How to: Return a Value from a Procedure (Visual Basic)
A `Function` procedure returns a value to the calling code either by executing a `Return` statement or by encountering an `Exit Function` or `End Function` statement.  
  
### To return a value using the Return statement  
  
1.  Put a `Return` statement at the point where the procedure's task is completed.  
  
2.  Follow the `Return` keyword with an expression that yields the value you want to return to the calling code.  
  
3.  You can have more than one `Return` statement in the same procedure.  
  
     The following `Function` procedure calculates the longest side, or hypotenuse, of a right triangle, and returns it to the calling code.  
  
     [!code[VbVbcnProcedures#1](../VS_visualbasic/codesnippet/VisualBasic/how-to--return-a-value-from-a-procedure--visual-basic-_1.vb)]  
  
     The following example shows a typical call to `hypotenuse`, which stores the returned value.  
  
     [!code[VbVbcnProcedures#6](../VS_visualbasic/codesnippet/VisualBasic/how-to--return-a-value-from-a-procedure--visual-basic-_2.vb)]  
  
### To return a value using Exit Function or End Function  
  
1.  In at least one place in the `Function` procedure, assign a value to the procedure's name.  
  
2.  When you execute an `Exit Function` or `End Function` statement, [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] returns the value most recently assigned to the procedure's name.  
  
3.  You can have more than one `Exit Function` statement in the same procedure, and you can mix `Return` and `Exit Function` statements in the same procedure.  
  
4.  You can have only one `End Function` statement in a `Function` procedure.  
  
     For more information and an example, see "Return Value" in [Function Statement](../VS_visualbasic/function-statement--visual-basic-.md).  
  
## See Also  
 [Procedures](../VS_visualbasic/procedures-in-visual-basic.md)   
 [Sub Procedures](../VS_visualbasic/sub-procedures--visual-basic-.md)   
 [Property Procedures](../VS_visualbasic/property-procedures--visual-basic-.md)   
 [Operator Procedures](../VS_visualbasic/operator-procedures--visual-basic-.md)   
 [Procedure Parameters and Arguments](../VS_visualbasic/procedure-parameters-and-arguments--visual-basic-.md)   
 [Function Statement](../VS_visualbasic/function-statement--visual-basic-.md)   
 [Return Statement](../VS_visualbasic/return-statement--visual-basic-.md)   
 [How to: Create a Procedure that Returns a Value](../VS_visualbasic/how-to--create-a-procedure-that-returns-a-value--visual-basic-.md)   
 [How to: Call a Procedure That Returns a Value](../VS_visualbasic/how-to--call-a-procedure-that-returns-a-value--visual-basic-.md)