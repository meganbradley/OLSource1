---
title: "Select...Case Statement (Visual Basic)"
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
  - "vb.Select"
  - "vb.Case"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Select statement"
  - "Case statement"
  - "Select...Case statements"
  - "conditional statements, Select Case"
  - "control flow, branching"
  - "Else keyword [Visual Basic], in Select...Case statements"
  - "execution, conditional"
  - "To keyword, in Select...Case statements"
  - "Select Case statement, Select...Case"
  - "Select statement, Select...Case"
  - "Is operator [Visual Basic], in Select...Case statements"
  - "branching, conditional"
  - "Case Else statement, Select...Case"
  - "End keyword, Select Case statements"
  - "Case statement, Select...Case"
ms.assetid: 68877b65-5419-4bf0-a465-20cd0e4c7d44
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Select...Case Statement (Visual Basic)
Runs one of several groups of statements, depending on the value of an expression.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Required. Expression. Must evaluate to one of the elementary data types (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>).|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Required in a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> statement. List of expression clauses representing match values for <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. Multiple expression clauses are separated by commas. Each clause can take one of the following forms:\<br />\<br /> -   *expression1* <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> *expression2*\<br />-   [ <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> ] *comparisonoperator* *expression*\<br />-   *expression*\<br />\<br /> Use the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> keyword to specify the boundaries of a range of match values for <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. The value of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> must be less than or equal to the value of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.\<br />\<br /> Use the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> keyword with a comparison operator (<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>) to specify a restriction on the match values for <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. If the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> keyword is not supplied, it is automatically inserted before *comparisonoperator*.\<br />\<br /> The form specifying only <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is treated as a special case of the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> form where *comparisonoperator* is the equal sign (<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>). This form is evaluated as <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.\<br />\<br /> The expressions in <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> can be of any data type, provided they are implicitly convertible to the type of <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and the appropriate <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is valid for the two types it is being used with.|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|Optional. One or more statements following <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> that run if <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> matches any clause in <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|Optional. One or more statements following <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> that run if <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> does not match any clause in the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> of any of the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> statements.|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|Terminates the definition of the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>55\</CodeContentPlaceHolder> construction.|  
  
## Remarks  
 If <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> matches any <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> clause, the statements following that <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> statement run up to the next <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> statement. Control then passes to the statement following <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> matches an <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> clause in more than one <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> clause, only the statements following the first match run.  
  
 The <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> statement is used to introduce the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> to run if no match is found between the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> and an <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> clause in any of the other <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> statements. Although not required, it is a good idea to have a <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> statement in your <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> construction to handle unforeseen <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> values. If no <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> clause matches <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> and there is no <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> statement, control passes to the statement following <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.  
  
 You can use multiple expressions or ranges in each <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> clause. For example, the following line is valid.  
  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> keyword used in the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> statements is not the same as the [Is Operator](../vs140/is-operator--visual-basic-.md), which is used for object reference comparison.  
  
 You can specify ranges and multiple expressions for character strings. In the following example, <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> matches any string that is exactly equal to "apples", has a value between "nuts" and "soup" in alphabetical order, or contains the exact same value as the current value of <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
  
 The setting of <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> can affect string comparisons. Under <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>, the strings "Apples" and "apples" compare as equal, but under <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>, they do not.  
  
> [!NOTE]
>  A <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> statement with multiple clauses can exhibit behavior known as *short-circuiting*. Visual Basic evaluates the clauses from left to right, and if one produces a match with <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>, the remaining clauses are not evaluated. Short-circuiting can improve performance, but it can produce unexpected results if you are expecting every expression in <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> to be evaluated. For more information on short-circuiting, see [Boolean Expressions](../vs140/boolean-expressions--visual-basic-.md).  
  
 If the code within a <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> statement block does not need to run any more of the statements in the block, it can exit the block by using the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> statement. This transfers control immediately to the statement following <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> constructions can be nested. Each nested <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> construction must have a matching <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> statement and must be completely contained within a single <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> statement block of the outer <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> construction within which it is nested.  
  
## Example  
 The following example uses a <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> construction to write a line corresponding to the value of the variable <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>. The second <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> statement contains the value that matches the current value of <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>, so the statement that writes "Between 6 and 8, inclusive" runs.  
  
 [!code[VbVbalrStatements#54](../vs140/codesnippet/VisualBasic/select...case-statement--visual-basic-_1.vb)]  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Interaction.Choose*>   
 [End Statement](../vs140/end-statement.md)   
 [If...Then...Else Statement](../vs140/if...then...else-statement--visual-basic-.md)   
 [Option Compare Statement](../vs140/option-compare-statement.md)   
 [Exit Statement](../vs140/exit-statement--visual-basic-.md)