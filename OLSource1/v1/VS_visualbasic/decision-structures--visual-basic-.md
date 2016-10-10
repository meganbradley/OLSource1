---
title: "Decision Structures (Visual Basic)"
ms.custom: na
ms.date: "10/10/2016"
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
  - "statements [Visual Basic], control flow"
  - "If statement, decision structures"
  - "If statement, If...Then...Else"
  - "control flow, decision structures"
  - "decision structures"
  - "conditional statements, decision structures"
ms.assetid: 2e2e0895-4483-442a-b17c-26aead751ec2
caps.latest.revision: 29
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
# Decision Structures (Visual Basic)
[!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] lets you test conditions and perform different operations depending on the results of that test. You can test for a condition being true or false, for various values of an expression, or for various exceptions generated when you execute a series of statements.  
  
 The following illustration shows a decision structure that tests for a condition being true and takes different actions depending on whether it is true or false.  
  
 ![Flow chart of an If...Then...Else construction](../VS_visualbasic/media/ifthenelse.gif "IfThenElse")  
Taking different actions when a condition is true and when it is false  
  
## If...Then...Else Construction  
 `If...Then...Else` constructions let you test for one or more conditions and run one or more statements depending on each condition. You can test conditions and take actions in the following ways:  
  
-   Run one or more statements if a condition is `True`  
  
-   Run one or more statements if a condition is `False`  
  
-   Run some statements if a condition is `True` and others if it is `False`  
  
-   Test an additional condition if a prior condition is `False`  
  
 The control structure that offers all these possibilities is the [If...Then...Else Statement](../VS_visualbasic/if...then...else-statement--visual-basic-.md). You can use a single-line version if you have just one test and one statement to run. If you have a more complex set of conditions and actions, you can use the multiple-line version.  
  
## Select...Case Construction  
 The `Select...Case` construction lets you evaluate an expression one time and run different sets of statements based on different possible values. For more information, see [Select...Case Statement](../VS_visualbasic/select...case-statement--visual-basic-.md).  
  
## Try...Catch...Finally Construction  
 `Try...Catch...Finally` constructions let you run a set of statements under an environment that retains control if any one of your statements causes an exception. You can take different actions for different exceptions. You can optionally specify a block of code that runs before you exit the whole `Try...Catch...Finally` construction, regardless of what occurs. For more information, see [Try...Catch...Finally Statement](../VS_visualbasic/try...catch...finally-statement--visual-basic-.md).  
  
> [!NOTE]
>  For many control structures, when you click a keyword, all of the keywords in the structure are highlighted. For instance, when you click `If` in an `If...Then...Else` construction, all instances of `If`, `Then`, `ElseIf`, `Else`, and `End If` in the construction are highlighted. To move to the next or previous highlighted keyword, press CTRL+SHIFT+DOWN ARROW or CTRL+SHIFT+UP ARROW.  
  
## See Also  
 [Control Flow](../VS_visualbasic/control-flow-in-visual-basic.md)   
 [Loop Structures](../VS_visualbasic/loop-structures--visual-basic-.md)   
 [Other Control Structures](../VS_visualbasic/other-control-structures--visual-basic-.md)   
 [Nested Control Structures](../VS_visualbasic/nested-control-structures--visual-basic-.md)   
 [If Operator](../VS_visualbasic/if-operator--visual-basic-.md)