---
title: "Loop Structures (Visual Basic)"
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
  - "control flow, loops"
  - "For keyword [Visual Basic], loop structures"
  - "loops"
  - "loop structures"
  - "statements [Visual Basic], loop"
  - "Do statement, Do loops"
  - "conditional statements, loop structures"
ms.assetid: ecacb09b-a4c9-42be-98b2-a15d368b5db8
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Loop Structures (Visual Basic)
[!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] loop structures allow you to run one or more lines of code repetitively. You can repeat the statements in a loop structure until a condition is <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, until a condition is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, a specified number of times, or once for each element in a collection.  
  
 The following illustration shows a loop structure that runs a set of statements until a condition becomes true.  
  
 ![Flow chart of a Do...Until loop](../vs140/media/dountilloop.gif "DoUntilLoop")  
Running a set of statements until a condition becomes true  
  
## While Loops  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> construction runs a set of statements as long as the condition specified in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. For more information, see [While...End While Statement (Visual Basic)](../vs140/while...end-while-statement--visual-basic-.md).  
  
## Do Loops  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> construction allows you to test a condition at either the beginning or the end of a loop structure. You can also specify whether to repeat the loop while the condition remains <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or until it becomes <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. For more information, see [Do...Loop Statement (Visual Basic)](../vs140/do...loop-statement--visual-basic-.md).  
  
## For Loops  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> construction performs the loop a set number of times. It uses a loop control variable, also called a *counter*, to keep track of the repetitions. You specify the starting and ending values for this counter, and you can optionally specify the amount by which it increases from one repetition to the next. For more information, see [For...Next Statement (Visual Basic)](../vs140/for...next-statement--visual-basic-.md).  
  
## For Each Loops  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> construction runs a set of statements once for each element in a collection. You specify the loop control variable, but you do not have to determine starting or ending values for it. For more information, see [For Each...Next Statement (Visual Basic)](../vs140/for-each...next-statement--visual-basic-.md).  
  
## See Also  
 [Control Flow in Visual Basic](../vs140/control-flow-in-visual-basic.md)   
 [Decision Structures](../vs140/decision-structures--visual-basic-.md)   
 [Other Control Structures](../vs140/other-control-structures--visual-basic-.md)   
 [Nested Control Structures](../vs140/nested-control-structures--visual-basic-.md)