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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required. Expression. Must evaluate to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, or to a data type that is implicitly convertible to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 If the expression is a [Nullable](../vs140/nullable-value-types--visual-basic-.md)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> variable that evaluates to [Nothing](../vs140/nothing--visual-basic-.md), the condition is treated as if the expression is not <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> block is executed.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Required in the single-line syntax; optional in the multiple-line syntax.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Optional. One or more statements following <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> that are executed if <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> evaluates to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Required if <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is present. Expression. Must evaluate to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, or to a data type that is implicitly convertible to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Optional. One or more statements following <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>21\</CodeContentPlaceHolder> that are executed if <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> evaluates to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Optional. One or more statements that are executed if no previous <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> expression evaluates to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Terminates the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>31\</CodeContentPlaceHolder> block.  
  
## Remarks  
  
## Multiple-Line Syntax  
 When an <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>34\</CodeContentPlaceHolder> statement is encountered, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is tested. If <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, the statements following <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> are executed. If <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, each <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> statement (if there are any) is evaluated in order. When a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is found, the statements immediately following the associated <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> are executed. If no <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> evaluates to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, or if there are no <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> statements, the statements following <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> are executed. After executing the statements following <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, execution continues with the statement following <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> clauses are both optional. You can have as many <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> clauses as you want in an <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>57\</CodeContentPlaceHolder> statement, but no <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> clause can appear after an <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> clause. <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>62\</CodeContentPlaceHolder> statements can be nested within each other.  
  
 In the multiple-line syntax, the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> statement must be the only statement on the first line. The <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> statements can be preceded only by a line label. The <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>69\</CodeContentPlaceHolder> block must end with an <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> statement.  
  
> [!TIP]
>  The [Select...Case Statement](../vs140/select...case-statement--visual-basic-.md) might be more useful when you evaluate a single expression that has several possible values.  
  
## Single-Line Syntax  
 You can use the single-line syntax for short, simple tests. However, the multiple-line syntax provides more structure and flexibility and is usually easier to read, maintain, and debug.  
  
 What follows the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> keyword is examined to determine whether a statement is a single-line <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>. If anything other than a comment appears after <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> on the same line, the statement is treated as a single-line <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> statement. If <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> is absent, it must be the start of a multiple-line <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.  
  
 In the single-line syntax, you can have multiple statements executed as the result of an <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>80\</CodeContentPlaceHolder> decision. All statements must be on the same line and be separated by colons.  
  
## Example  
 The following example illustrates the use of the multiple-line syntax of the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>83\</CodeContentPlaceHolder> statement.  
  
 [!code[VbVbalrStatements#101](../vs140/codesnippet/VisualBasic/if...then...else-statement--visual-basic-_1.vb)]  
  
## Example  
 The following example contains nested <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>86\</CodeContentPlaceHolder> statements.  
  
 [!code[VbVbalrStatements#102](../vs140/codesnippet/VisualBasic/if...then...else-statement--visual-basic-_2.vb)]  
  
## Example  
 The following example illustrates the use of the single-line syntax.  
  
 [!code[VbVbalrStatements#103](../vs140/codesnippet/VisualBasic/if...then...else-statement--visual-basic-_3.vb)]  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Interaction.Choose*>   
 \<xref:Microsoft.VisualBasic.Interaction.Switch*>   
 [#If...Then...#Else Directives](../vs140/sharpif...then...sharpelse-directives.md)   
 [Select...Case Statement](../vs140/select...case-statement--visual-basic-.md)   
 [Nested Control Structures](../vs140/nested-control-structures--visual-basic-.md)   
 [Decision Structures](../vs140/decision-structures--visual-basic-.md)   
 [Logical and Bitwise Operators in Visual Basic](../vs140/logical-and-bitwise-operators-in-visual-basic.md)   
 [If Operator (Visual Basic)](../vs140/if-operator--visual-basic-.md)