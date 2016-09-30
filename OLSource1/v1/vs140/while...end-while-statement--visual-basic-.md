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
Runs a series of statements as long as a given condition is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Required. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> expression. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, Visual Basic treats it as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional. One or more statements following <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, which run every time <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Optional. Transfers control to the next iteration of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> block.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Optional. Transfers control out of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> block.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Required. Terminates the definition of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> block.|  
  
## Remarks  
 Use a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> structure when you want to repeat a set of statements an indefinite number of times, as long as a condition remains <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. If you want more flexibility with where you test the condition or what result you test it for, you might prefer the [Do...Loop Statement (Visual Basic)](../vs140/do...loop-statement--visual-basic-.md). If you want to repeat the statements a set number of times, the [For...Next Statement](../vs140/for...next-statement--visual-basic-.md) is usually a better choice.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> keyword is also used in the [Do...Loop Statement (Visual Basic)](../vs140/do...loop-statement--visual-basic-.md), the [Skip While Clause (Visual Basic)](../vs140/skip-while-clause--visual-basic-.md) and the [Take While Clause (Visual Basic)](../vs140/take-while-clause--visual-basic-.md).  
  
 If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, all of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> run until the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> statement is encountered. Control then returns to the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> statement, and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is again checked. If <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is still <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, the process is repeated. If it’s <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, control passes to the statement that follows the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> statement.  
  
 The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> statement always checks the condition before it starts the loop. Looping continues while the condition remains <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> when you first enter the loop, it doesn’t run even once.  
  
 The <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> usually results from a comparison of two values, but it can be any expression that evaluates to a [Boolean Data Type (Visual Basic)](../vs140/boolean-data-type--visual-basic-.md) value (<CodeContentPlaceHolder>35\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>). This expression can include a value of another data type, such as a numeric type, that has been converted to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
 You can nest <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> loops by placing one loop within another. You can also nest different kinds of control structures within one another. For more information, see [Nested Control Structures](../vs140/nested-control-structures--visual-basic-.md).  
  
## Exit While  
 The [Exit While](../vs140/exit-statement--visual-basic-.md) statement can provide another way to exit a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> loop. <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> immediately transfers control to the statement that follows the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> statement.  
  
 You typically use <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> after some condition is evaluated (for example, in an <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> structure). You might want to exit a loop if you detect a condition that makes it unnecessary or impossible to continue iterating, such as an erroneous value or a termination request. You can use <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> when you test for a condition that could cause an *endless loop*, which is a loop that could run an extremely large or even infinite number of times. You can then use <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> to escape the loop.  
  
 You can place any number of <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> statements anywhere in the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> loop.  
  
 When used within nested <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> loops, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> transfers control out of the innermost loop and into the next higher level of nesting.  
  
 The <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> statement immediately transfers control to the next iteration of the loop. For more information, see [Continue Statement (Visual Basic)](../vs140/continue-statement--visual-basic-.md).  
  
## Example  
 In the following example, the statements in the loop continue to run until the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> variable is greater than 10.  
  
 [!code[VbVbalrStatements#171](../vs140/codesnippet/VisualBasic/while...end-while-statement--visual-basic-_1.vb)]  
  
## Example  
 The following example illustrates the use of the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> statements.  
  
 [!code[VbVbalrStatements#172](../vs140/codesnippet/VisualBasic/while...end-while-statement--visual-basic-_2.vb)]  
  
## Example  
 The following example reads all lines in a text file. The \<xref:System.IO.File.OpenText*> method opens the file and returns a \<xref:System.IO.StreamReader*> that reads the characters. In the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> condition, the \<xref:System.IO.StreamReader.Peek*> method of the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> determines whether the file contains additional characters.  
  
 [!code[VbVbalrStatements#173](../vs140/codesnippet/VisualBasic/while...end-while-statement--visual-basic-_3.vb)]  
  
## See Also  
 [Loop Structures](../vs140/loop-structures--visual-basic-.md)   
 [Do...Loop Statement](../vs140/do...loop-statement--visual-basic-.md)   
 [For...Next Statement](../vs140/for...next-statement--visual-basic-.md)   
 [Boolean Data Type (Visual Basic)](../vs140/boolean-data-type--visual-basic-.md)   
 [Nested Control Structures](../vs140/nested-control-structures--visual-basic-.md)   
 [Exit Statement](../vs140/exit-statement--visual-basic-.md)   
 [Continue Statement (Visual Basic)](../vs140/continue-statement--visual-basic-.md)