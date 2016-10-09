---
title: "Loop Structures (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
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
  - "control flow, loops"
  - "For keyword [Visual Basic], loop structures"
  - "loops"
  - "loop structures"
  - "statements [Visual Basic], loop"
  - "Do statement, Do loops"
  - "conditional statements, loop structures"
ms.assetid: ecacb09b-a4c9-42be-98b2-a15d368b5db8
caps.latest.revision: 18
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
# Loop Structures (Visual Basic)
[!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] loop structures allow you to run one or more lines of code repetitively. You can repeat the statements in a loop structure until a condition is `True`, until a condition is `False`, a specified number of times, or once for each element in a collection.  
  
 The following illustration shows a loop structure that runs a set of statements until a condition becomes true.  
  
 ![Flow chart of a Do...Until loop](../VS_visualbasic/media/dountilloop.gif "DoUntilLoop")  
Running a set of statements until a condition becomes true  
  
## While Loops  
 The `While`...`End While` construction runs a set of statements as long as the condition specified in the `While` statement is `True`. For more information, see [While...End While Statement](../VS_visualbasic/while...end-while-statement--visual-basic-.md).  
  
## Do Loops  
 The `Do`...`Loop` construction allows you to test a condition at either the beginning or the end of a loop structure. You can also specify whether to repeat the loop while the condition remains `True` or until it becomes `True`. For more information, see [Do...Loop Statement](../VS_visualbasic/do...loop-statement--visual-basic-.md).  
  
## For Loops  
 The `For`...`Next` construction performs the loop a set number of times. It uses a loop control variable, also called a *counter*, to keep track of the repetitions. You specify the starting and ending values for this counter, and you can optionally specify the amount by which it increases from one repetition to the next. For more information, see [For...Next Statement](../VS_visualbasic/for...next-statement--visual-basic-.md).  
  
## For Each Loops  
 The `For Each`...`Next` construction runs a set of statements once for each element in a collection. You specify the loop control variable, but you do not have to determine starting or ending values for it. For more information, see [For Each...Next Statement](../VS_visualbasic/for-each...next-statement--visual-basic-.md).  
  
## See Also  
 [Control Flow](../VS_visualbasic/control-flow-in-visual-basic.md)   
 [Decision Structures](../VS_visualbasic/decision-structures--visual-basic-.md)   
 [Other Control Structures](../VS_visualbasic/other-control-structures--visual-basic-.md)   
 [Nested Control Structures](../VS_visualbasic/nested-control-structures--visual-basic-.md)