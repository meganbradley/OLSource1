---
title: "Do...Loop Statement (Visual Basic)"
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
  - "vb.Do"
  - "vb.Loop"
  - "vb.Until"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "conditional statements, Do…Loop"
  - "while statement, Do...Loop"
  - "execution, conditional"
  - "Do loops"
  - "Until keyword, Do...Loop statement"
  - "Do...Loop statement"
  - "instructions, repeating"
  - "Do statement"
  - "Exit statement, in Do...Loop statements"
  - "loop structures, Do…Loop statements"
  - "do-while statements"
  - "loops, exiting"
  - "Loop keyword, Do...Loop statement"
ms.assetid: 892f9096-b3e2-4aee-834d-83bc4e2c379d
caps.latest.revision: 41
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Do...Loop Statement (Visual Basic)
Repeats a block of statements while a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> condition is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or until the condition becomes <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Required. Starts the definition of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> loop.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Required unless <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is used. Repeat the loop until <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Required unless <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is used. Repeat the loop until <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Optional. <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> expression. If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, Visual Basic treats it as <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Optional. One or more statements that are repeated while, or until, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Optional. Transfers control to the next iteration of the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> loop.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Optional. Transfers control out of the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> loop.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Required. Terminates the definition of the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> loop.|  
  
## Remarks  
 Use a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> structure when you want to repeat a set of statements an indefinite number of times, until a condition is satisfied. If you want to repeat the statements a set number of times, the [For...Next Statement](../vs140/for...next-statement--visual-basic-.md) is usually a better choice.  
  
 You can use either <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> to specify <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, but not both.  
  
 You can test <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> only one time, at either the start or the end of the loop. If you test <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> at the start of the loop (in the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> statement), the loop might not run even one time. If you test at the end of the loop (in the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> statement), the loop always runs at least one time.  
  
 The condition usually results from a comparison of two values, but it can be any expression that evaluates to a [Boolean Data Type (Visual Basic)](../vs140/boolean-data-type--visual-basic-.md) value (<CodeContentPlaceHolder>36\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>). This includes values of other data types, such as numeric types, that have been converted to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
 You can nest <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> loops by putting one loop within another. You can also nest different kinds of control structures within each other. For more information, see [Nested Control Structures](../vs140/nested-control-structures--visual-basic-.md).  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> structure gives you more flexibility than the [While...End While Statement (Visual Basic)](../vs140/while...end-while-statement--visual-basic-.md) because it enables you to decide whether to end the loop when <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> stops being <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> or when it first becomes <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>. It also enables you to test <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> at either the start or the end of the loop.  
  
## Exit Do  
 The [Exit Do](../vs140/exit-statement--visual-basic-.md) statement can provide an alternative way to exit a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> transfers control immediately to the statement that follows the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> statement.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is often used after some condition is evaluated, for example in an <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> structure. You might want to exit a loop if you detect a condition that makes it unnecessary or impossible to continue iterating, such as an erroneous value or a termination request. One use of <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is to test for a condition that could cause an *endless loop*, which is a loop that could run a large or even infinite number of times. You can use <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> to escape the loop.  
  
 You can include any number of <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> statements anywhere in a <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
 When used within nested <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> loops, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> transfers control out of the innermost loop and into the next higher level of nesting.  
  
## Example  
 In the following example, the statements in the loop continue to run until the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> variable is greater than 10. The <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> clause is at the end of the loop.  
  
 [!code[VbVbalrStatements#131](../vs140/codesnippet/VisualBasic/do...loop-statement--visual-basic-_1.vb)]  
  
## Example  
 The following example uses a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> clause instead of an <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> clause, and <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is tested at the start of the loop instead of at the end.  
  
 [!code[VbVbalrStatements#132](../vs140/codesnippet/VisualBasic/do...loop-statement--visual-basic-_2.vb)]  
  
## Example  
 In the following example, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> stops the loop when the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> variable is greater than 100. The <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> statement in the loop, however, causes the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> statement to stop the loop when the index variable is greater than 10.  
  
 [!code[VbVbalrStatements#133](../vs140/codesnippet/VisualBasic/do...loop-statement--visual-basic-_3.vb)]  
  
## Example  
 The following example reads all lines in a text file. The \<xref:System.IO.File.OpenText*> method opens the file and returns a \<xref:System.IO.StreamReader*> that reads the characters. In the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> condition, the \<xref:System.IO.StreamReader.Peek*> method of the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> determines whether there are any additional characters.  
  
 [!code[VbVbalrStatements#134](../vs140/codesnippet/VisualBasic/do...loop-statement--visual-basic-_4.vb)]  
  
## See Also  
 [Loop Structures](../vs140/loop-structures--visual-basic-.md)   
 [For...Next Statement](../vs140/for...next-statement--visual-basic-.md)   
 [Boolean Data Type (Visual Basic)](../vs140/boolean-data-type--visual-basic-.md)   
 [Nested Control Structures](../vs140/nested-control-structures--visual-basic-.md)   
 [Exit Statement](../vs140/exit-statement--visual-basic-.md)   
 [While...End While Statement](../vs140/while...end-while-statement--visual-basic-.md)