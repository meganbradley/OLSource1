---
title: "Return Statement (Visual Basic)"
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
  - "vb.Return"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Return statement, syntax"
  - "control flow, returning control to expressions"
  - "Return statement"
  - "expressions [Visual Basic], returning control to"
ms.assetid: ac86e7f0-5a67-42c3-9834-0e0381efa3ec
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Return Statement (Visual Basic)
Returns control to the code that called a `Function`, `Sub`, `Get`, `Set`, or `Operator` procedure.  
  
## Syntax  
  
```  
Return  
-or-  
Return expression  
```  
  
## Part  
 `expression`  
 Required in a `Function`, `Get`, or `Operator` procedure. Expression that represents the value to be returned to the calling code.  
  
## Remarks  
 In a `Sub` or `Set` procedure, the `Return` statement is equivalent to an `Exit Sub` or `Exit Property` statement, and `expression` must not be supplied.  
  
 In a `Function`, `Get`, or `Operator` procedure, the `Return` statement must include `expression`, and `expression` must evaluate to a data type that is convertible to the return type of the procedure. In a `Function` or `Get` procedure, you also have the alternative of assigning an expression to the procedure name to serve as the return value, and then executing an `Exit Function` or `Exit Property` statement. In an `Operator` procedure, you must use `Return``expression`.  
  
 You can include as many `Return` statements as appropriate in the same procedure.  
  
> [!NOTE]
>  The code in a `Finally` block runs after a `Return` statement in a `Try` or `Catch` block is encountered, but before that `Return` statement executes. A `Return` statement cannot be included in a `Finally` block.  
  
## Example  
 The following example uses the `Return` statement several times to return to the calling code when the procedure does not have to do anything else.  
  
 [!code[VbVbalrStatements#53](../vs140/codesnippet/VisualBasic/return-statement--visual-basic-_1.vb)]  
  
## See Also  
 [Function Statement](../vs140/function-statement--visual-basic-.md)   
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)   
 [Get Statement](../vs140/get-statement.md)   
 [Set Statement (Visual Basic)](../vs140/set-statement--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)   
 [Property Statement](../vs140/property-statement.md)   
 [Exit Statement (Visual Basic)](../vs140/exit-statement--visual-basic-.md)   
 [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md)