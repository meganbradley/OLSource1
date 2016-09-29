---
title: "While...End While Statement (Visual Basic)"
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
  - "vb.While"
  - "vb.While...EndWhile"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "While statement, While...End While"
  - "While statement"
  - "While...End While statements"
ms.assetid: b931d1ce-e8ed-44d8-a13d-92a4f5458a1e
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# While...End While Statement (Visual Basic)
Runs a series of statements as long as a given condition is `True`.  
  
## Syntax  
  
```  
While condition  
    [ statements ]  
    [ Continue While ]  
    [ statements ]  
    [ Exit While ]  
    [ statements ]  
End While  
```  
  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|`condition`|Required. `Boolean` expression. If `condition` is `Nothing`, Visual Basic treats it as `False`.|  
|`statements`|Optional. One or more statements following `While`, which run every time `condition` is `True`.|  
|`Continue While`|Optional. Transfers control to the next iteration of the `While` block.|  
|`Exit While`|Optional. Transfers control out of the `While` block.|  
|`End While`|Required. Terminates the definition of the `While` block.|  
  
## Remarks  
 Use a `While...End While` structure when you want to repeat a set of statements an indefinite number of times, as long as a condition remains `True`. If you want more flexibility with where you test the condition or what result you test it for, you might prefer the [Do...Loop Statement (Visual Basic)](../vs140/do...loop-statement--visual-basic-.md). If you want to repeat the statements a set number of times, the [For...Next Statement](../vs140/for...next-statement--visual-basic-.md) is usually a better choice.  
  
> [!NOTE]
>  The `While` keyword is also used in the [Do...Loop Statement (Visual Basic)](../vs140/do...loop-statement--visual-basic-.md), the [Skip While Clause (Visual Basic)](../vs140/skip-while-clause--visual-basic-.md) and the [Take While Clause (Visual Basic)](../vs140/take-while-clause--visual-basic-.md).  
  
 If `condition` is `True`, all of the `statements` run until the `End While` statement is encountered. Control then returns to the `While` statement, and `condition` is again checked. If `condition` is still `True`, the process is repeated. If it’s `False`, control passes to the statement that follows the `End While` statement.  
  
 The `While` statement always checks the condition before it starts the loop. Looping continues while the condition remains `True`. If `condition` is `False` when you first enter the loop, it doesn’t run even once.  
  
 The `condition` usually results from a comparison of two values, but it can be any expression that evaluates to a [Boolean Data Type (Visual Basic)](../vs140/boolean-data-type--visual-basic-.md) value (`True` or `False`). This expression can include a value of another data type, such as a numeric type, that has been converted to `Boolean`.  
  
 You can nest `While` loops by placing one loop within another. You can also nest different kinds of control structures within one another. For more information, see [Nested Control Structures](../vs140/nested-control-structures--visual-basic-.md).  
  
## Exit While  
 The [Exit While](../vs140/exit-statement--visual-basic-.md) statement can provide another way to exit a `While` loop. `Exit While` immediately transfers control to the statement that follows the `End While` statement.  
  
 You typically use `Exit While` after some condition is evaluated (for example, in an `If...Then...Else` structure). You might want to exit a loop if you detect a condition that makes it unnecessary or impossible to continue iterating, such as an erroneous value or a termination request. You can use `Exit While` when you test for a condition that could cause an *endless loop*, which is a loop that could run an extremely large or even infinite number of times. You can then use `Exit While` to escape the loop.  
  
 You can place any number of `Exit While` statements anywhere in the `While` loop.  
  
 When used within nested `While` loops, `Exit While` transfers control out of the innermost loop and into the next higher level of nesting.  
  
 The `Continue While` statement immediately transfers control to the next iteration of the loop. For more information, see [Continue Statement (Visual Basic)](../vs140/continue-statement--visual-basic-.md).  
  
## Example  
 In the following example, the statements in the loop continue to run until the `index` variable is greater than 10.  
  
 [!code[VbVbalrStatements#171](../vs140/codesnippet/VisualBasic/while...end-while-statement--visual-basic-_1.vb)]  
  
## Example  
 The following example illustrates the use of the `Continue While` and `Exit While` statements.  
  
 [!code[VbVbalrStatements#172](../vs140/codesnippet/VisualBasic/while...end-while-statement--visual-basic-_2.vb)]  
  
## Example  
 The following example reads all lines in a text file. The <xref:System.IO.File.OpenText*> method opens the file and returns a <xref:System.IO.StreamReader*> that reads the characters. In the `While` condition, the <xref:System.IO.StreamReader.Peek*> method of the `StreamReader` determines whether the file contains additional characters.  
  
 [!code[VbVbalrStatements#173](../vs140/codesnippet/VisualBasic/while...end-while-statement--visual-basic-_3.vb)]  
  
## See Also  
 [Loop Structures](../vs140/loop-structures--visual-basic-.md)   
 [Do...Loop Statement](../vs140/do...loop-statement--visual-basic-.md)   
 [For...Next Statement](../vs140/for...next-statement--visual-basic-.md)   
 [Boolean Data Type (Visual Basic)](../vs140/boolean-data-type--visual-basic-.md)   
 [Nested Control Structures](../vs140/nested-control-structures--visual-basic-.md)   
 [Exit Statement](../vs140/exit-statement--visual-basic-.md)   
 [Continue Statement (Visual Basic)](../vs140/continue-statement--visual-basic-.md)