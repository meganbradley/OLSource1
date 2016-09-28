---
title: "Resume Statement"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.Resume"
  - "vb.ResumeNext"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Next statement, Resume"
  - "Resume Next statement"
  - "execution, resuming"
  - "run-time errors, resuming after"
  - "Resume statement, syntax"
  - "errors [Visual Basic], resuming after"
  - "Error statement, and Resume statement"
  - "execution"
  - "Resume statement"
ms.assetid: e24d058b-1a5c-4274-acb9-7d295d3ea537
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Resume Statement
Resumes execution after an error-handling routine is finished.  
  
 We suggest that you use structured exception handling in your code whenever possible, rather than using unstructured exception handling and the `On Error` and `Resume` statements. For more information, see [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md).  
  
## Syntax  
  
```  
Resume [ Next | line ]  
```  
  
## Parts  
 `Resume`  
 Required. If the error occurred in the same procedure as the error handler, execution resumes with the statement that caused the error. If the error occurred in a called procedure, execution resumes at the statement that last called out of the procedure containing the error-handling routine.  
  
 `Next`  
 Optional. If the error occurred in the same procedure as the error handler, execution resumes with the statement immediately following the statement that caused the error. If the error occurred in a called procedure, execution resumes with the statement immediately following the statement that last called out of the procedure containing the error-handling routine (or `On Error Resume Next` statement).  
  
 `line`  
 Optional. Execution resumes at the line specified in the required `line` argument. The `line` argument is a line label or line number and must be in the same procedure as the error handler.  
  
## Remarks  
  
> [!NOTE]
>  We recommend that you use structured exception handling in your code whenever possible, rather than using unstructured exception handling and the `On Error` and `Resume` statements. For more information, see [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md).  
  
 If you use a `Resume` statement anywhere other than in an error-handling routine, an error occurs.  
  
 The `Resume` statement cannot be used in any procedure that contains a `Try...Catch...Finally` statement.  
  
## Example  
 This example uses the `Resume` statement to end error handling in a procedure and then resume execution with the statement that caused the error. Error number 55 is generated to illustrate use of the `Resume` statement.  
  
 [!code[VbVbalrErrorHandling#16](../vs140/codesnippet/VisualBasic/resume-statement_1.vb)]  
  
## Requirements  
 **Namespace:** [Microsoft.VisualBasic](../vs140/visual-basic-runtime-library-members.md)  
  
 **Assembly:** Visual Basic Runtime Library (in Microsoft.VisualBasic.dll)  
  
## See Also  
 [Try...Catch...Finally Statement](../vs140/try...catch...finally-statement--visual-basic-.md)   
 [Error Statement](../vs140/error-statement.md)   
 [On Error Statement](../vs140/on-error-statement--visual-basic-.md)