---
title: "If...Then...Else Statement (Visual Basic)"
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
  - "vb.ElseIf"
  - "vb.Then"
  - "vb.If"
  - "vb.EndIf"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "ElseIf statement, If...Then...Else"
  - "Then statement, If...Then...Else"
  - "control flow, branching"
  - "execution, conditional"
  - "TypeOf...Is expression, and If...Then...Else statements"
  - "If...Then...Else statements"
  - "If statement, If...Then...Else"
  - "If statement"
  - "Is operator [Visual Basic], in If...Then...Else statements"
  - "If Operator [Visual Basic]"
  - "branching, conditional"
  - "IIf function, and If...Then...Else statements"
  - "Else statement [Visual Basic]"
ms.assetid: 790068a2-1307-4e28-8a72-be5ebda099e9
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# If...Then...Else Statement (Visual Basic)
Conditionally executes a group of statements, depending on the value of an expression.  
  
## Syntax  
  
```  
' Multiple-line syntax:  
If condition [ Then ]  
    [ statements ]  
[ ElseIf elseifcondition [ Then ]  
    [ elseifstatements ] ]  
[ Else  
    [ elsestatements ] ]  
End If  
  
' Single-line syntax:  
If condition Then [ statements ] [ Else [ elsestatements ] ]  
```  
  
## Parts  
 `condition`  
 Required. Expression. Must evaluate to `True` or `False`, or to a data type that is implicitly convertible to `Boolean`.  
  
 If the expression is a [Nullable](../VS_csharp/nullable-value-types--visual-basic-.md)`Boolean` variable that evaluates to [Nothing](../VS_csharp/nothing--visual-basic-.md), the condition is treated as if the expression is not `True`, and the `Else` block is executed.  
  
 `Then`  
 Required in the single-line syntax; optional in the multiple-line syntax.  
  
 `statements`  
 Optional. One or more statements following `If`...`Then` that are executed if `condition` evaluates to `True`.  
  
 `elseifcondition`  
 Required if `ElseIf` is present. Expression. Must evaluate to `True` or `False`, or to a data type that is implicitly convertible to `Boolean`.  
  
 `elseifstatements`  
 Optional. One or more statements following `ElseIf`...`Then` that are executed if `elseifcondition` evaluates to `True`.  
  
 `elsestatements`  
 Optional. One or more statements that are executed if no previous `condition` or `elseifcondition` expression evaluates to `True`.  
  
 `End If`  
 Terminates the `If`...`Then`...`Else` block.  
  
## Remarks  
  
## Multiple-Line Syntax  
 When an `If`...`Then`...`Else` statement is encountered, `condition` is tested. If `condition` is `True`, the statements following `Then` are executed. If `condition` is `False`, each `ElseIf` statement (if there are any) is evaluated in order. When a `True``elseifcondition` is found, the statements immediately following the associated `ElseIf` are executed. If no `elseifcondition` evaluates to `True`, or if there are no `ElseIf` statements, the statements following `Else` are executed. After executing the statements following `Then`, `ElseIf`, or `Else`, execution continues with the statement following `End If`.  
  
 The `ElseIf` and `Else` clauses are both optional. You can have as many `ElseIf` clauses as you want in an `If`...`Then`...`Else` statement, but no `ElseIf` clause can appear after an `Else` clause. `If`...`Then`...`Else` statements can be nested within each other.  
  
 In the multiple-line syntax, the `If` statement must be the only statement on the first line. The `ElseIf`, `Else`, and `End If` statements can be preceded only by a line label. The `If`...`Then`...`Else` block must end with an `End If` statement.  
  
> [!TIP]
>  The [Select...Case Statement](../VS_csharp/select...case-statement--visual-basic-.md) might be more useful when you evaluate a single expression that has several possible values.  
  
## Single-Line Syntax  
 You can use the single-line syntax for short, simple tests. However, the multiple-line syntax provides more structure and flexibility and is usually easier to read, maintain, and debug.  
  
 What follows the `Then` keyword is examined to determine whether a statement is a single-line `If`. If anything other than a comment appears after `Then` on the same line, the statement is treated as a single-line `If` statement. If `Then` is absent, it must be the start of a multiple-line `If`...`Then`...`Else`.  
  
 In the single-line syntax, you can have multiple statements executed as the result of an `If`...`Then` decision. All statements must be on the same line and be separated by colons.  
  
## Example  
 The following example illustrates the use of the multiple-line syntax of the `If`...`Then`...`Else` statement.  
  
 [!code[VbVbalrStatements#101](../VS_csharp/codesnippet/VisualBasic/if...then...else-statement--visual-basic-_1.vb)]  
  
## Example  
 The following example contains nested `If`...`Then`...`Else` statements.  
  
 [!code[VbVbalrStatements#102](../VS_csharp/codesnippet/VisualBasic/if...then...else-statement--visual-basic-_2.vb)]  
  
## Example  
 The following example illustrates the use of the single-line syntax.  
  
 [!code[VbVbalrStatements#103](../VS_csharp/codesnippet/VisualBasic/if...then...else-statement--visual-basic-_3.vb)]  
  
## See Also  
 <xref:Microsoft.VisualBasic.Interaction.Choose*>   
 <xref:Microsoft.VisualBasic.Interaction.Switch*>   
 [#If...Then...#Else Directives](../VS_csharp/sharpif...then...sharpelse-directives.md)   
 [Select...Case Statement](../VS_csharp/select...case-statement--visual-basic-.md)   
 [Nested Control Structures](../VS_csharp/nested-control-structures--visual-basic-.md)   
 [Decision Structures](../VS_csharp/decision-structures--visual-basic-.md)   
 [Logical and Bitwise Operators in Visual Basic](../VS_csharp/logical-and-bitwise-operators-in-visual-basic.md)   
 [If Operator (Visual Basic)](../VS_csharp/if-operator--visual-basic-.md)