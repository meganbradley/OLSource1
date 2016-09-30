---
title: "Decision Structures (Visual Basic)"
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
  - "statements [Visual Basic], control flow"
  - "If statement, decision structures"
  - "If statement, If...Then...Else"
  - "control flow, decision structures"
  - "decision structures"
  - "conditional statements, decision structures"
ms.assetid: 2e2e0895-4483-442a-b17c-26aead751ec2
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Decision Structures (Visual Basic)
[!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] lets you test conditions and perform different operations depending on the results of that test. You can test for a condition being true or false, for various values of an expression, or for various exceptions generated when you execute a series of statements.  
  
 The following illustration shows a decision structure that tests for a condition being true and takes different actions depending on whether it is true or false.  
  
 ![Flow chart of an If...Then...Else construction](../vs140/media/ifthenelse.gif "IfThenElse")  
Taking different actions when a condition is true and when it is false  
  
## If...Then...Else Construction  
 <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> constructions let you test for one or more conditions and run one or more statements depending on each condition. You can test conditions and take actions in the following ways:  
  
-   Run one or more statements if a condition is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
-   Run one or more statements if a condition is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
-   Run some statements if a condition is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and others if it is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
-   Test an additional condition if a prior condition is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 The control structure that offers all these possibilities is the [If...Then...Else Statements (Visual Basic)](../vs140/if...then...else-statement--visual-basic-.md). You can use a single-line version if you have just one test and one statement to run. If you have a more complex set of conditions and actions, you can use the multiple-line version.  
  
## Select...Case Construction  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> construction lets you evaluate an expression one time and run different sets of statements based on different possible values. For more information, see [Select...Case Statement (Visual Basic)](../vs140/select...case-statement--visual-basic-.md).  
  
## Try...Catch...Finally Construction  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> constructions let you run a set of statements under an environment that retains control if any one of your statements causes an exception. You can take different actions for different exceptions. You can optionally specify a block of code that runs before you exit the whole <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> construction, regardless of what occurs. For more information, see [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md).  
  
> [!NOTE]
>  For many control structures, when you click a keyword, all of the keywords in the structure are highlighted. For instance, when you click <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> construction, all instances of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> in the construction are highlighted. To move to the next or previous highlighted keyword, press CTRL+SHIFT+DOWN ARROW or CTRL+SHIFT+UP ARROW.  
  
## See Also  
 [Control Flow in Visual Basic](../vs140/control-flow-in-visual-basic.md)   
 [Loop Structures](../vs140/loop-structures--visual-basic-.md)   
 [Other Control Structures](../vs140/other-control-structures--visual-basic-.md)   
 [Nested Control Structures](../vs140/nested-control-structures--visual-basic-.md)   
 [If Operator (Visual Basic)](../vs140/if-operator--visual-basic-.md)