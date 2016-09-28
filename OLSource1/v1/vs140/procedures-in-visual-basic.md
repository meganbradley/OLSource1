---
title: "Procedures in Visual Basic"
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
  - "procedures, structured code"
  - "Visual Basic code, procedures"
  - "procedures, types of"
  - "structured code, procedures"
  - "procedures"
ms.assetid: 9effbcf0-80a0-4d1a-98f4-2c6920592766
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Procedures in Visual Basic
A *procedure* is a block of [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] statements enclosed by a declaration statement (`Function`, `Sub`, `Operator`, `Get`, `Set`) and a matching `End` declaration. All executable statements in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] must be within some procedure.  
  
## Calling a Procedure  
 You invoke a procedure from some other place in the code. This is known as a *procedure call*. When the procedure is finished running, it returns control to the code that invoked it, which is known as the *calling code*. The calling code is a statement, or an expression within a statement, that specifies the procedure by name and transfers control to it.  
  
## Returning from a Procedure  
 A procedure returns control to the calling code when it has finished running. To do this, it can use a [Return Statement (Visual Basic)](../vs140/return-statement--visual-basic-.md), the appropriate [Exit Statement (Visual Basic)](../vs140/exit-statement--visual-basic-.md) statement for the procedure, or the procedure's [End (Visual Basic)](../vs140/end--keyword--statement--visual-basic-.md) statement. Control then passes to the calling code following the point of the procedure call.  
  
-   With a `Return` statement, control returns immediately to the calling code. Statements following the `Return` statement do not run. You can have more than one `Return` statement in the same procedure.  
  
-   With an `Exit Sub` or `Exit Function` statement, control returns immediately to the calling code. Statements following the `Exit` statement do not run. You can have more than one `Exit` statement in the same procedure, and you can mix `Return` and `Exit` statements in the same procedure.  
  
-   If a procedure has no `Return` or `Exit` statements, it concludes with an `End Sub` or `End Function`, `End Get`, or `End Set` statement following the last statement of the procedure body. The `End` statement returns control immediately to the calling code. You can have only one `End` statement in a procedure.  
  
## Parameters and Arguments  
 In most cases, a procedure needs to operate on different data each time you call it. You can pass this information to the procedure as part of the procedure call. The procedure defines zero or more *parameters*, each of which represents a value it expects you to pass to it. Corresponding to each parameter in the procedure definition is an *argument* in the procedure call. An argument represents the value you pass to the corresponding parameter in a given procedure call.  
  
## Types of Procedures  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] uses several types of procedures:  
  
-   [Sub Procedures](../vs140/sub-procedures--visual-basic-.md) perform actions but do not return a value to the calling code.  
  
-   Event-handling procedures are `Sub` procedures that execute in response to an event raised by user action or by an occurrence in a program.  
  
-   [Function Procedures](../vs140/function-procedures--visual-basic-.md) return a value to the calling code. They can perform other actions before returning.  
  
-   [Property Procedures](../vs140/property-procedures--visual-basic-.md) return and assign values of properties on objects or modules.  
  
-   [Operator Procedures](../vs140/operator-procedures--visual-basic-.md) define the behavior of a standard operator when one or both of the operands is a newly-defined class or structure.  
  
-   [Generic Procedures in Visual Basic](../vs140/generic-procedures-in-visual-basic.md) define one or more *type parameters* in addition to their normal parameters, so the calling code can pass specific data types each time it makes a call.  
  
## Procedures and Structured Code  
 Every line of executable code in your application must be inside some procedure, such as `Main`, `calculate`, or `Button1_Click`. If you subdivide large procedures into smaller ones, your application is more readable.  
  
 Procedures are useful for performing repeated or shared tasks, such as frequently used calculations, text and control manipulation, and database operations. You can call a procedure from many different places in your code, so you can use procedures as building blocks for your application.  
  
 Structuring your code with procedures gives you the following benefits:  
  
-   Procedures allow you to break your programs into discrete logical units. You can debug separate units more easily than you can debug an entire program without procedures.  
  
-   After you develop procedures for use in one program, you can use them in other programs, often with little or no modification. This helps you avoid code duplication.  
  
## See Also  
 [How to: Create a Procedure](../vs140/how-to--create-a-procedure--visual-basic-.md)   
 [Sub Procedures](../vs140/sub-procedures--visual-basic-.md)   
 [Function Procedures](../vs140/function-procedures--visual-basic-.md)   
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [Recursive Procedures](../vs140/recursive-procedures--visual-basic-.md)   
 [Procedure Overloading](../vs140/procedure-overloading--visual-basic-.md)   
 [Generic Procedures in Visual Basic](../vs140/generic-procedures-in-visual-basic.md)   
 [Objects and Classes in Visual Basic](../vs140/objects-and-classes-in-visual-basic.md)