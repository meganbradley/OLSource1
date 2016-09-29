---
title: "Throw Statement (Visual Basic)"
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
  - "vb.Throw"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "structured exception handling, throw statements"
  - "try-catch exception handling, throw statements"
  - "throw statement, about throw statements"
  - "throwing exceptions, throw statement"
  - "exception handling, throw statement"
  - "On Error statement, throwing exceptions"
  - "throwing exceptions"
  - "exception handling, unstructured"
  - "throw statement"
ms.assetid: a6e07406-5c8a-4498-87a2-8339f3651d62
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Throw Statement (Visual Basic)
Throws an exception within a procedure.  
  
## Syntax  
  
```  
Throw [ expression ]  
```  
  
## Part  
 `expression`  
 Provides information about the exception to be thrown. Optional when residing in a `Catch` statement, otherwise required.  
  
## Remarks  
 The `Throw` statement throws an exception that you can handle with structured exception-handling code (`Try`...`Catch`...`Finally`) or unstructured exception-handling code (`On Error GoTo`). You can use the `Throw` statement to trap errors within your code because Visual Basic moves up the call stack until it finds the appropriate exception-handling code.  
  
 A `Throw` statement with no expression can only be used in a `Catch` statement, in which case the statement rethrows the exception currently being handled by the `Catch` statement.  
  
 The `Throw` statement resets the call stack for the `expression` exception. If `expression` is not provided, the call stack is left unchanged. You can access the call stack for the exception through the <xref:System.Exception.StackTrace*> property.  
  
## Example  
 The following code uses the `Throw` statement to throw an exception:  
  
 [!code[VbVbalrStatements#84](../VS_csharp/codesnippet/VisualBasic/throw-statement--visual-basic-_1.vb)]  
  
## Requirements  
 **Namespace:** [Microsoft.VisualBasic](../VS_csharp/visual-basic-runtime-library-members.md)  
  
 **Module:** `Interaction`  
  
 **Assembly:** Visual Basic Runtime Library (in Microsoft.VisualBasic.dll)  
  
## See Also  
 [Try...Catch...Finally Statement](../VS_csharp/try...catch...finally-statement--visual-basic-.md)   
 [On Error Statement](../VS_csharp/on-error-statement--visual-basic-.md)