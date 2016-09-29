---
title: "Exit Statement (Visual Basic)"
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
  - "vb.Exit"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "execution, ending"
  - "files, closing"
  - "programs, quitting"
  - "code, exiting"
  - "Exit statement"
  - "program termination"
  - "execution, stopping"
ms.assetid: 760bfb32-5c3f-4bdb-a432-9a6001c92db7
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exit Statement (Visual Basic)
Exits a procedure or block and transfers control immediately to the statement following the procedure call or the block definition.  
  
## Syntax  
  
```  
Exit { Do | For | Function | Property | Select | Sub | Try | While }  
```  
  
## Statements  
 `Exit Do`  
 Immediately exits the `Do` loop in which it appears. Execution continues with the statement following the `Loop` statement. `Exit Do` can be used only inside a `Do` loop. When used within nested `Do` loops, `Exit Do` exits the innermost loop and transfers control to the next higher level of nesting.  
  
 `Exit For`  
 Immediately exits the `For` loop in which it appears. Execution continues with the statement following the `Next` statement. `Exit For` can be used only inside a `For`...`Next` or `For Each`...`Next` loop. When used within nested `For` loops, `Exit For` exits the innermost loop and transfers control to the next higher level of nesting.  
  
 `Exit Function`  
 Immediately exits the `Function` procedure in which it appears. Execution continues with the statement following the statement that called the `Function` procedure. `Exit Function` can be used only inside a `Function` procedure.  
  
 To specify a return value, you can assign the value to the function name on a line before the `Exit Function` statement. To assign the return value and exit the function in one statement, you can instead use the [Return Statement (Visual Basic)](../vs140/return-statement--visual-basic-.md).  
  
 `Exit Property`  
 Immediately exits the `Property` procedure in which it appears. Execution continues with the statement that called the `Property` procedure, that is, with the statement requesting or setting the property's value. `Exit Property` can be used only inside a property's `Get` or `Set` procedure.  
  
 To specify a return value in a `Get` procedure, you can assign the value to the function name on a line before the `Exit Property` statement. To assign the return value and exit the `Get` procedure in one statement, you can instead use the `Return` statement.  
  
 In a `Set` procedure, the `Exit Property` statement is equivalent to the `Return` statement.  
  
 `Exit Select`  
 Immediately exits the `Select Case` block in which it appears. Execution continues with the statement following the `End Select` statement. `Exit Select` can be used only inside a `Select Case` statement.  
  
 `Exit Sub`  
 Immediately exits the `Sub` procedure in which it appears. Execution continues with the statement following the statement that called the `Sub` procedure. `Exit Sub` can be used only inside a `Sub` procedure.  
  
 In a `Sub` procedure, the `Exit Sub` statement is equivalent to the `Return` statement.  
  
 `Exit Try`  
 Immediately exits the `Try` or `Catch` block in which it appears. Execution continues with the `Finally` block if there is one, or with the statement following the `End Try` statement otherwise. `Exit Try` can be used only inside a `Try` or `Catch` block, and not inside a `Finally` block.  
  
 `Exit While`  
 Immediately exits the `While` loop in which it appears. Execution continues with the statement following the `End While` statement. `Exit While` can be used only inside a `While` loop. When used within nested `While` loops, `Exit While` transfers control to the loop that is one nested level above the loop where `Exit While` occurs.  
  
## Remarks  
 Do not confuse `Exit` statements with `End` statements. `Exit` does not define the end of a statement.  
  
## Example  
 In the following example, the loop condition stops the loop when the `index` variable is greater than 100. The `If` statement in the loop, however, causes the `Exit Do` statement to stop the loop when the index variable is greater than 10.  
  
 [!code[VbVbalrStatements#133](../vs140/codesnippet/VisualBasic/exit-statement--visual-basic-_1.vb)]  
  
## Example  
 The following example assigns the return value to the function name `myFunction`, and then uses `Exit Function` to return from the function.  
  
 [!code[VbVbalrStatements#23](../vs140/codesnippet/VisualBasic/exit-statement--visual-basic-_2.vb)]  
  
## Example  
 The following example uses the [Return Statement (Visual Basic)](../vs140/return-statement--visual-basic-.md) to assign the return value and exit the function.  
  
 [!code[VbVbalrStatements#24](../vs140/codesnippet/VisualBasic/exit-statement--visual-basic-_3.vb)]  
  
## See Also  
 [Continue Statement (Visual Basic)](../vs140/continue-statement--visual-basic-.md)   
 [Do...Loop Statement](../vs140/do...loop-statement--visual-basic-.md)   
 [End Statement](../vs140/end-statement.md)   
 [For Each...Next Statement](../vs140/for-each...next-statement--visual-basic-.md)   
 [For...Next Statement](../vs140/for...next-statement--visual-basic-.md)   
 [Function Statement](../vs140/function-statement--visual-basic-.md)   
 [Return Statement (Visual Basic)](../vs140/return-statement--visual-basic-.md)   
 [Stop Statement](../vs140/stop-statement--visual-basic-.md)   
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)   
 [Try...Catch...Finally Statement](../vs140/try...catch...finally-statement--visual-basic-.md)