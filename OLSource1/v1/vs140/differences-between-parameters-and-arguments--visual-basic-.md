---
title: "Differences Between Parameters and Arguments (Visual Basic)"
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
  - "procedures, arguments"
  - "procedures, parameters"
  - "parameters, and arguments"
  - "procedure arguments"
  - "Visual Basic code, procedures"
  - "arguments [Visual Basic], and parameters"
  - "procedure parameters"
  - "parameters, definition"
ms.assetid: c237c056-74f4-4749-9f2c-15864f139a31
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Differences Between Parameters and Arguments (Visual Basic)
In most cases, a procedure must have some information about the circumstances in which it has been called. A procedure that performs repeated or shared tasks uses different information for each call. This information consists of variables, constants, and expressions that you pass to the procedure when you call it.  
  
 To communicate this information to the procedure, the procedure defines a *parameter*, and the calling code passes an *argument* to that parameter. You can think of the parameter as a parking space and the argument as an automobile. Just as different automobiles can park in a parking space at different times, the calling code can pass a different argument to the same parameter every time that it calls the procedure.  
  
## Parameters  
 A *parameter* represents a value that the procedure expects you to pass when you call it. The procedure's declaration defines its parameters.  
  
 When you define a `Function` or `Sub` procedure, you specify a *parameter list* in parentheses immediately following the procedure name. For each parameter, you specify a name, a data type, and a passing mechanism ([ByVal](../vs140/byval--visual-basic-.md) or [ByRef](../vs140/byref--visual-basic-.md)). You can also indicate that a parameter is optional. This means that the calling code does not have to pass a value for it.  
  
 The name of each parameter serves as a *local variable* in the procedure. You use the parameter name the same way you use any other variable.  
  
## Arguments  
 An *argument* represents the value that you pass to a procedure parameter when you call the procedure. The calling code supplies the arguments when it calls the procedure.  
  
 When you call a `Function` or `Sub` procedure, you include an *argument list* in parentheses immediately following the procedure name. Each argument corresponds to the parameter in the same position in the list.  
  
 In contrast to parameter definition, arguments do not have names. Each argument is an expression, which can contain zero or more variables, constants, and literals. The data type of the evaluated expression should typically match the data type defined for the corresponding parameter, and in any case it must be convertible to the parameter type.  
  
## See Also  
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Sub Procedures](../vs140/sub-procedures--visual-basic-.md)   
 [Function Procedures](../vs140/function-procedures--visual-basic-.md)   
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [How to: Define a Parameter for a Procedure](../vs140/how-to--define-a-parameter-for-a-procedure--visual-basic-.md)   
 [How to: Pass Arguments to a Procedure](../vs140/how-to--pass-arguments-to-a-procedure--visual-basic-.md)   
 [Argument Passing By Value and By Reference](../vs140/passing-arguments-by-value-and-by-reference--visual-basic-.md)   
 [Recursive Procedures](../vs140/recursive-procedures--visual-basic-.md)   
 [Procedure Overloading](../vs140/procedure-overloading--visual-basic-.md)