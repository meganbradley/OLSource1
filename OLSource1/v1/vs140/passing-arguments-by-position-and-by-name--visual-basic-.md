---
title: "Passing Arguments by Position and by Name (Visual Basic)"
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
  - "arguments [Visual Basic], passing by name"
  - "procedures, arguments"
  - ":= passing arguments"
  - "procedure arguments"
  - "Visual Basic code, procedures"
  - "named arguments, passing arguments"
  - "arguments [Visual Basic], passing by position"
  - "Function procedures, passing arguments"
  - "named parameters, passing arguments"
  - "named arguments"
  - "passing parameters, named parameter arguments"
  - "passing parameters, by position"
  - "procedures, calling"
  - "named parameters"
  - "Sub procedures, passing arguments"
  - "argument passing"
  - "passing parameters, by name"
  - "argument passing, by position"
  - "arguments [Visual Basic], listing by name"
ms.assetid: 1ad7358f-1da9-48da-a95b-f3c7ed41eff3
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Passing Arguments by Position and by Name (Visual Basic)
When you call a `Sub` or `Function` procedure, you can pass arguments *by position* — in the order in which they appear in the procedure's definition — or you can pass them *by name*, without regard to position.  
  
 When you pass an argument by name, you specify the argument's declared name followed by a colon and an equal sign (`:=`), followed by the argument value. You can supply named arguments in any order.  
  
 For example, the following `Sub` procedure takes three arguments:  
  
 [!code[VbVbcnProcedures#41](../vs140/codesnippet/VisualBasic/passing-arguments-by-position-and-by-name--visual-basic-_1.vb)]  
  
 When you call this procedure, you can supply the arguments by position, by name, or by using a mixture of both.  
  
## Passing Arguments by Position  
 You can call the procedure `studentInfo` with its arguments passed by position and delimited by commas, as shown in the following example:  
  
 [!code[VbVbcnProcedures#42](../vs140/codesnippet/VisualBasic/passing-arguments-by-position-and-by-name--visual-basic-_2.vb)]  
  
 If you omit an optional argument in a positional argument list, you must hold its place with a comma. The following example calls `studentInfo` without the `age` argument:  
  
 [!code[VbVbcnProcedures#43](../vs140/codesnippet/VisualBasic/passing-arguments-by-position-and-by-name--visual-basic-_3.vb)]  
  
## Passing Arguments by Name  
 Alternatively, you can call `studentInfo` with the arguments passed by name, also delimited by commas, as shown in the following example:  
  
 [!code[VbVbcnProcedures#44](../vs140/codesnippet/VisualBasic/passing-arguments-by-position-and-by-name--visual-basic-_4.vb)]  
  
## Mixing Arguments by Position and by Name  
 You can supply arguments both by position and by name in a single procedure call, as shown in the following example:  
  
 [!code[VbVbcnProcedures#45](../vs140/codesnippet/VisualBasic/passing-arguments-by-position-and-by-name--visual-basic-_5.vb)]  
  
 In the preceding example, no extra comma is necessary to hold the place of the omitted `age` argument, since `birth` is passed by name.  
  
 When you supply arguments by a mixture of position and name, the positional arguments must all come first. Once you supply an argument by name, the remaining arguments must all be by name.  
  
## Supplying Optional Arguments by Name  
 Passing arguments by name is especially useful when you call a procedure that has more than one optional argument. If you supply arguments by name, you do not have to use consecutive commas to denote missing positional arguments. Passing arguments by name also makes it easier to keep track of which arguments you are passing and which ones you are omitting.  
  
## Restrictions on Supplying Arguments by Name  
 You cannot pass arguments by name to avoid entering required arguments. You can omit only the optional arguments.  
  
 You cannot pass a parameter array by name. This is because when you call the procedure, you supply an indefinite number of comma-separated arguments for the parameter array, and the compiler cannot associate more than one argument with a single name.  
  
## See Also  
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [How to: Pass Arguments to a Procedure](../vs140/how-to--pass-arguments-to-a-procedure--visual-basic-.md)   
 [Argument Passing By Value and By Reference](../vs140/passing-arguments-by-value-and-by-reference--visual-basic-.md)   
 [Optional Parameters](../vs140/optional-parameters--visual-basic-.md)   
 [Parameter Arrays](../vs140/parameter-arrays--visual-basic-.md)   
 [Optional](../vs140/optional--visual-basic-.md)   
 [ParamArray](../vs140/paramarray--visual-basic-.md)