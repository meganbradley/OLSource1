---
title: "GoTo Statement"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vb.GoTo
dev_langs: 
  - VB
helpviewer_keywords: 
  - GoTo statement
  - control flow, branching
  - unconditional branching
  - branching
  - branching, unconditional
  - branching, conditional
  - conditional statements, GoTo statement
  - GoTo statement, syntax
ms.assetid: 313274c2-8ab3-4b9c-9ba3-0fd6798e4f6d
caps.latest.revision: 23
translation.priority.ht: 
  - de-de
  - ja-jp
---
# GoTo Statement
Branches unconditionally to a specified line in a procedure.  
  
## Syntax  
  
```  
GoTo line  
```  
  
## Part  
 `line`  
 Required. Any line label.  
  
## Remarks  
 The `GoTo` statement can branch only to lines in the procedure in which it appears. The line must have a line label that `GoTo` can refer to. For more information, see [How to: Label Statements](../vs140/how-to--label-statements--visual-basic-.md).  
  
> [!NOTE]
>  `GoTo` statements can make code difficult to read and maintain. Whenever possible, use a control structure instead. For more information, see [Control Flow in Visual Basic](../vs140/control-flow-in-visual-basic.md).  
  
 You cannot use a `GoTo` statement to branch from outside a `For`...`Next`, `For Each`...`Next`, `SyncLock`...`End SyncLock`, `Try`...`Catch`...`Finally`, `With`...`End With`, or `Using`...`End Using` construction to a label inside.  
  
## Branching and Try Constructions  
 Within a `Try`...`Catch`...`Finally` construction, the following rules apply to branching with the `GoTo` statement.  
  
|Block or region|Branching in from outside|Branching out from inside|  
|---------------------|-------------------------------|-------------------------------|  
|`Try` block|Only from a `Catch` block of the same construction <sup>1</sup>|Only to outside the whole construction|  
|`Catch` block|Never allowed|Only to outside the whole construction, or to the `Try` block of the same construction <sup>1</sup>|  
|`Finally` block|Never allowed|Never allowed|  
  
 <sup>1</sup> If one `Try`...`Catch`...`Finally` construction is nested within another, a `Catch` block can branch into the `Try` block at its own nesting level, but not into any other `Try` block. A nested `Try`...`Catch`...`Finally` construction must be contained completely in a `Try` or `Catch` block of the construction within which it is nested.  
  
 The following illustration shows one `Try` construction nested within another. Various branches among the blocks of the two constructions are indicated as valid or invalid.  
  
 ![Graphic diagram of branching in Try constructions](../vs140/media/trybranching.gif "TryBranching")  
Valid and invalid branches in Try constructions  
  
## Example  
 The following example uses the `GoTo` statement to branch to line labels in a procedure.  
  
 [!code[VbVbalrStatements#31](../vs140/codesnippet/VisualBasic/goto-statement_1.vb)]
  
  
## See Also  
 [Do...Loop Statement](../vs140/do...loop-statement--visual-basic-.md)   
 [For...Next Statement](../vs140/for...next-statement--visual-basic-.md)   
 [For Each...Next Statement (Visual Basic)](../vs140/for-each...next-statement--visual-basic-.md)   
 [If...Then...Else Statement](../vs140/if...then...else-statement--visual-basic-.md)   
 [Select...Case Statement](../vs140/select...case-statement--visual-basic-.md)   
 [Try...Catch...Finally Statement](../vs140/try...catch...finally-statement--visual-basic-.md)   
 [While...End While Statement (Visual Basic)](../vs140/while...end-while-statement--visual-basic-.md)   
 [With...End With Statement (Visual Basic)](../vs140/with...end-with-statement--visual-basic-.md)