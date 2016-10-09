---
title: "GoTo Statement"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.GoTo"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "GoTo statement"
  - "control flow, branching"
  - "unconditional branching"
  - "branching"
  - "branching, unconditional"
  - "branching, conditional"
  - "conditional statements, GoTo statement"
  - "GoTo statement, syntax"
ms.assetid: 313274c2-8ab3-4b9c-9ba3-0fd6798e4f6d
caps.latest.revision: 19
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
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
 The `GoTo` statement can branch only to lines in the procedure in which it appears. The line must have a line label that `GoTo` can refer to. For more information, see [How to: Label Statements](../VS_visualbasic/how-to--label-statements--visual-basic-.md).  
  
> [!NOTE]
>  `GoTo` statements can make code difficult to read and maintain. Whenever possible, use a control structure instead. For more information, see [Control Flow](../VS_visualbasic/control-flow-in-visual-basic.md).  
  
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
  
 ![Graphic diagram of branching in Try constructions](../VS_visualbasic/media/trybranching.gif "TryBranching")  
Valid and invalid branches in Try constructions  
  
## Example  
 The following example uses the `GoTo` statement to branch to line labels in a procedure.  
  
 [!code[VbVbalrStatements#31](../VS_visualbasic/codesnippet/VisualBasic/goto-statement_1.vb)]  
  
## See Also  
 [Do...Loop Statement](../VS_visualbasic/do...loop-statement--visual-basic-.md)   
 [For...Next Statement](../VS_visualbasic/for...next-statement--visual-basic-.md)   
 [For Each...Next Statement](../VS_visualbasic/for-each...next-statement--visual-basic-.md)   
 [If...Then...Else Statement](../VS_visualbasic/if...then...else-statement--visual-basic-.md)   
 [Select...Case Statement](../VS_visualbasic/select...case-statement--visual-basic-.md)   
 [Try...Catch...Finally Statement](../VS_visualbasic/try...catch...finally-statement--visual-basic-.md)   
 [While...End While Statement](../VS_visualbasic/while...end-while-statement--visual-basic-.md)   
 [With...End With Statement](../VS_visualbasic/with...end-with-statement--visual-basic-.md)