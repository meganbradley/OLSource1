---
title: "Exit Statement (Visual Basic)"
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
  - "vb.Exit"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "execution, ending"
  - "files, closing"
  - "programs, quitting"
  - "code, exiting"
  - "Exit statement"
  - "program termination"
  - "execution, stopping"
ms.assetid: 760bfb32-5c3f-4bdb-a432-9a6001c92db7
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exit Statement (Visual Basic)
Exits a procedure or block and transfers control immediately to the statement following the procedure call or the block definition.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Statements  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Immediately exits the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> loop in which it appears. Execution continues with the statement following the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> can be used only inside a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> loop. When used within nested <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> loops, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> exits the innermost loop and transfers control to the next higher level of nesting.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Immediately exits the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> loop in which it appears. Execution continues with the statement following the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> can be used only inside a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>15\</CodeContentPlaceHolder> loop. When used within nested <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> loops, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> exits the innermost loop and transfers control to the next higher level of nesting.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Immediately exits the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> procedure in which it appears. Execution continues with the statement following the statement that called the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> procedure. <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> can be used only inside a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> procedure.  
  
 To specify a return value, you can assign the value to the function name on a line before the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> statement. To assign the return value and exit the function in one statement, you can instead use the [Return Statement (Visual Basic)](../vs140/return-statement--visual-basic-.md).  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Immediately exits the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> procedure in which it appears. Execution continues with the statement that called the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> procedure, that is, with the statement requesting or setting the property's value. <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> can be used only inside a property's <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> procedure.  
  
 To specify a return value in a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> procedure, you can assign the value to the function name on a line before the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> statement. To assign the return value and exit the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> procedure in one statement, you can instead use the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> statement.  
  
 In a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> procedure, the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> statement is equivalent to the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> statement.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 Immediately exits the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> block in which it appears. Execution continues with the statement following the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> statement. <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> can be used only inside a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> statement.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Immediately exits the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> procedure in which it appears. Execution continues with the statement following the statement that called the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> procedure. <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> can be used only inside a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> procedure.  
  
 In a <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> procedure, the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> statement is equivalent to the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> statement.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Immediately exits the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> block in which it appears. Execution continues with the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> block if there is one, or with the statement following the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> statement otherwise. <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> can be used only inside a <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> block, and not inside a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> block.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Immediately exits the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> loop in which it appears. Execution continues with the statement following the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> statement. <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> can be used only inside a <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> loop. When used within nested <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> loops, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> transfers control to the loop that is one nested level above the loop where <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> occurs.  
  
## Remarks  
 Do not confuse <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> statements with <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> statements. <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> does not define the end of a statement.  
  
## Example  
 In the following example, the loop condition stops the loop when the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> variable is greater than 100. The <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> statement in the loop, however, causes the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> statement to stop the loop when the index variable is greater than 10.  
  
 [!code[VbVbalrStatements#133](../vs140/codesnippet/VisualBasic/exit-statement--visual-basic-_1.vb)]  
  
## Example  
 The following example assigns the return value to the function name <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, and then uses <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> to return from the function.  
  
 [!code[VbVbalrStatements#23](../vs140/codesnippet/VisualBasic/exit-statement--visual-basic-_2.vb)]  
  
## Example  
 The following example uses the [Return Statement (Visual Basic)](../vs140/return-statement--visual-basic-.md) to assign the return value and exit the function.  
  
 [!code[VbVbalrStatements#24](../vs140/codesnippet/VisualBasic/exit-statement--visual-basic-_3.vb)]  
  
## See Also  
 [Continue Statement (Visual Basic)](../vs140/continue-statement--visual-basic-.md)   
 [Do...Loop Statement](../vs140/do...loop-statement--visual-basic-.md)   
 [End Statement](../vs140/end-statement.md)   
 [For Each...Next Statement](../vs140/for-each...next-statement--visual-basic-.md)   
 [For...Next Statement](../vs140/for...next-statement--visual-basic-.md)   
 [Function Statement](../vs140/function-statement--visual-basic-.md)   
 [Return Statement (Visual Basic)](../vs140/return-statement--visual-basic-.md)   
 [Stop Statement](../vs140/stop-statement--visual-basic-.md)   
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)   
 [Try...Catch...Finally Statement](../vs140/try...catch...finally-statement--visual-basic-.md)