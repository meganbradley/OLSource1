---
title: "How to: Return a Value from a Procedure (Visual Basic)"
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
  - "Visual Basic code, procedures"
  - "procedures, returning from"
  - "procedures, returning a value"
ms.assetid: 4bcc4724-2b4e-4df8-9b4b-16054607f87d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Return a Value from a Procedure (Visual Basic)
A `Function` procedure returns a value to the calling code either by executing a `Return` statement or by encountering an `Exit Function` or `End Function` statement.  
  
### To return a value using the Return statement  
  
1.  Put a `Return` statement at the point where the procedure's task is completed.  
  
2.  Follow the `Return` keyword with an expression that yields the value you want to return to the calling code.  
  
3.  You can have more than one `Return` statement in the same procedure.  
  
     The following `Function` procedure calculates the longest side, or hypotenuse, of a right triangle, and returns it to the calling code.  
  
     [!code[VbVbcnProcedures#1](../VS_csharp/codesnippet/VisualBasic/how-to--return-a-value-from-a-procedure--visual-basic-_1.vb)]  
  
     The following example shows a typical call to `hypotenuse`, which stores the returned value.  
  
     [!code[VbVbcnProcedures#6](../VS_csharp/codesnippet/VisualBasic/how-to--return-a-value-from-a-procedure--visual-basic-_2.vb)]  
  
### To return a value using Exit Function or End Function  
  
1.  In at least one place in the `Function` procedure, assign a value to the procedure's name.  
  
2.  When you execute an `Exit Function` or `End Function` statement, [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] returns the value most recently assigned to the procedure's name.  
  
3.  You can have more than one `Exit Function` statement in the same procedure, and you can mix `Return` and `Exit Function` statements in the same procedure.  
  
4.  You can have only one `End Function` statement in a `Function` procedure.  
  
     For more information and an example, see "Return Value" in [Function Statement (Visual Basic)](../VS_csharp/function-statement--visual-basic-.md).  
  
## See Also  
 [Procedures in Visual Basic](../VS_csharp/procedures-in-visual-basic.md)   
 [Sub Procedures](../VS_csharp/sub-procedures--visual-basic-.md)   
 [Property Procedures](../VS_csharp/property-procedures--visual-basic-.md)   
 [Operator Procedures](../VS_csharp/operator-procedures--visual-basic-.md)   
 [Procedure Parameters and Arguments](../VS_csharp/procedure-parameters-and-arguments--visual-basic-.md)   
 [Function Statement](../VS_csharp/function-statement--visual-basic-.md)   
 [Return Statement (Visual Basic)](../VS_csharp/return-statement--visual-basic-.md)   
 [How to: Create a Procedure that Returns a Value](../VS_csharp/how-to--create-a-procedure-that-returns-a-value--visual-basic-.md)   
 [How to: Call a Procedure that Returns a Value](../VS_csharp/how-to--call-a-procedure-that-returns-a-value--visual-basic-.md)