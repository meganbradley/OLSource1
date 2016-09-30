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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Part  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Provides information about the exception to be thrown. Optional when residing in a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement, otherwise required.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement throws an exception that you can handle with structured exception-handling code (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) or unstructured exception-handling code (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>). You can use the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement to trap errors within your code because Visual Basic moves up the call stack until it finds the appropriate exception-handling code.  
  
 A <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement with no expression can only be used in a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement, in which case the statement rethrows the exception currently being handled by the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement.  
  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statement resets the call stack for the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> exception. If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is not provided, the call stack is left unchanged. You can access the call stack for the exception through the \<xref:System.Exception.StackTrace*> property.  
  
## Example  
 The following code uses the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> statement to throw an exception:  
  
 [!code[VbVbalrStatements#84](../vs140/codesnippet/VisualBasic/throw-statement--visual-basic-_1.vb)]  
  
## Requirements  
 **Namespace:** [Microsoft.VisualBasic](../vs140/visual-basic-runtime-library-members.md)  
  
 **Module:** <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
 **Assembly:** Visual Basic Runtime Library (in Microsoft.VisualBasic.dll)  
  
## See Also  
 [Try...Catch...Finally Statement](../vs140/try...catch...finally-statement--visual-basic-.md)   
 [On Error Statement](../vs140/on-error-statement--visual-basic-.md)