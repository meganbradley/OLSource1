---
title: "How to: Call a Procedure That Returns a Value (Visual Basic)"
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
  - "procedure calls, returning values"
  - "Visual Basic code, procedures"
  - "procedures, calling"
  - "procedures, returning a value"
ms.assetid: a445127b-0f5f-465a-98fb-3e514b93d115
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
# How to: Call a Procedure That Returns a Value (Visual Basic)
A `Function` procedure returns a value to the calling code. You call it by including its name and arguments either on the right side of an assignment statement or in an expression.  
  
### To call a Function procedure within an expression  
  
1.  Use the `Function` procedure name the same way you would use a variable. You can use a `Function` procedure call anywhere you can use a variable or constant in an expression.  
  
2.  Follow the procedure name with parentheses to enclose the argument list. If there are no arguments, you can optionally omit the parentheses. However, using the parentheses makes your code easier to read.  
  
3.  Place the arguments in the argument list within the parentheses, separated by commas. Be sure you supply the arguments in the same order that the `Function` procedure defines the corresponding parameters.  
  
     Alternatively, you can pass one or more arguments by name. For more information, see [Passing Arguments by Position and by Name](../VS_visualbasic/passing-arguments-by-position-and-by-name--visual-basic-.md).  
  
4.  The value returned from the procedure participates in the expression just as the value of a variable or constant would.  
  
### To call a Function procedure in an assignment statement  
  
1.  Use the `Function` procedure name following the equal (`=`) sign in the assignment statement.  
  
2.  Follow the procedure name with parentheses to enclose the argument list. If there are no arguments, you can optionally omit the parentheses. However, using the parentheses makes your code easier to read.  
  
3.  Place the arguments in the argument list within the parentheses, separated by commas. Be sure you supply the arguments in the same order that the `Function` procedure defines the corresponding parameters, unless you are passing them by name.  
  
4.  The value returned from the procedure is stored in the variable or property on the left side of the assignment statement.  
  
## Example  
 The following example calls the [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] \<xref:Microsoft.VisualBasic.Interaction.Environ*> to retrieve the value of an operating system environment variable. The first line calls `Environ` within an expression, and the second line calls it in an assignment statement. `Environ` takes the variable name as its sole argument. It returns the variable's value to the calling code.  
  
 [!code[VbVbcnProcedures#7](../VS_visualbasic/codesnippet/VisualBasic/how-to--call-a-procedure-that-returns-a-value--visual-basic-_1.vb)]  
  
## See Also  
 [Function Procedures](../VS_visualbasic/function-procedures--visual-basic-.md)   
 [Procedure Parameters and Arguments](../VS_visualbasic/procedure-parameters-and-arguments--visual-basic-.md)   
 [Function Statement](../VS_visualbasic/function-statement--visual-basic-.md)   
 [How to: Create a Procedure that Returns a Value](../VS_visualbasic/how-to--create-a-procedure-that-returns-a-value--visual-basic-.md)   
 [How to: Return a Value from a Procedure](../VS_visualbasic/how-to--return-a-value-from-a-procedure--visual-basic-.md)   
 [How to: Call a Procedure that Does Not Return a Value](../VS_visualbasic/how-to--call-a-procedure-that-does-not-return-a-value--visual-basic-.md)