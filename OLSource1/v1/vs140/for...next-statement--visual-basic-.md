---
title: "For...Next Statement (Visual Basic)"
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
  - "vb.Step"
  - "vb.Next"
  - "vb.To"
  - "vb.for"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "infinite loops"
  - "Next keyword, For...Next statements"
  - "For keyword [Visual Basic], For...Next statements"
  - "Step keyword, For...Next statements"
  - "operator overloading, For...Next statement"
  - "To keyword, For...Next statements"
  - "endless loops"
  - "loops, endless"
  - "instructions, repeating"
  - "Next statement, For...Next"
  - "For...Next statements"
  - "loop structures, For...Next"
  - "loops, infinite"
  - "Exit statement, For...Next statements"
  - "For statement"
ms.assetid: f5fc0d51-67ce-4c36-9f09-31c9a91c94e9
caps.latest.revision: 68
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# For...Next Statement (Visual Basic)
Repeats a group of statements a specified number of times.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|Part|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Required in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement. Numeric variable. The control variable for the loop. For more information, see [Counter Argument](#BKMK_Counter) later in this topic.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional. Data type of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. For more information, see [Counter Argument](#BKMK_Counter) later in this topic.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Required. Numeric expression. The initial value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Required. Numeric expression. The final value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Optional. Numeric expression. The amount by which <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is incremented each time through the loop.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Optional. One or more statements between <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> that run the specified number of times.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Optional. Transfers control to the next loop iteration.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Optional. Transfers control out of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> loop.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Required. Terminates the definition of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> loop.|  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> keyword is used in this statement to specify the range for the counter. You can also use this keyword in the [Select...Case Statement (Visual Basic)](../vs140/select...case-statement--visual-basic-.md) and in array declarations. For more information about array declarations, see [Dim Statement (Visual Basic)](../vs140/dim-statement--visual-basic-.md).  
  
## Simple Examples  
 You use a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>21\</CodeContentPlaceHolder> structure when you want to repeat a set of statements a set number of times.  
  
 In the following example, the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> variable starts with a value of 1 and is incremented with each iteration of the loop, ending after the value of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> reaches 5.  
  
 [!code[VbVbalrStatements#111](../vs140/codesnippet/VisualBasic/for...next-statement--visual-basic-_1.vb)]  
  
 In the following example, the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> variable starts at 2 and is reduced by 0.25 on each iteration of the loop, ending after the value of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> reaches 0. The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> argument of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> reduces the value by 0.25 on each iteration of the loop.  
  
 [!code[VbVbalrStatements#112](../vs140/codesnippet/VisualBasic/for...next-statement--visual-basic-_2.vb)]  
  
> [!TIP]
>  A [While...End While Statement](../vs140/while...end-while-statement--visual-basic-.md) or [Do...Loop Statement](../vs140/do...loop-statement--visual-basic-.md) works well when you don't know in advance how many times to run the statements in the loop. However, when you expect to run the loop a specific number of times, a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>29\</CodeContentPlaceHolder> loop is a better choice. You determine the number of iterations when you first enter the loop.  
  
## Nesting Loops  
 You can nest <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> loops by putting one loop within another. The following example demonstrates nested <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>32\</CodeContentPlaceHolder> structures that have different step values. The outer loop creates a string for every iteration of the loop. The inner loop decrements a loop counter variable for every iteration of the loop.  
  
 [!code[VbVbalrStatements#113](../vs140/codesnippet/VisualBasic/for...next-statement--visual-basic-_3.vb)]  
  
 When nesting loops, each loop must have a unique <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> variable.  
  
 You can also nest different kinds control structures within each other. For more information, see [Nested Control Structures](../vs140/nested-control-structures--visual-basic-.md).  
  
## Exit For and Continue For  
 The <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> statement immediately exits the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>…<CodeContentPlaceHolder>36\</CodeContentPlaceHolder> loop and transfers control to the statement that follows the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> statement.  
  
 The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> statement transfers control immediately to the next iteration of the loop. For more information, see [Continue Statement (Visual Basic)](../vs140/continue-statement--visual-basic-.md).  
  
 The following example illustrates the use of the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> statements.  
  
 [!code[VbVbalrStatements#115](../vs140/codesnippet/VisualBasic/for...next-statement--visual-basic-_4.vb)]  
  
 You can put any number of <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> statements in a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>…<CodeContentPlaceHolder>43\</CodeContentPlaceHolder> loop. When used within nested <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>…<CodeContentPlaceHolder>45\</CodeContentPlaceHolder> loops, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> exits the innermost loop and transfers control to the next higher level of nesting.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is often used after you evaluate some condition (for example, in an <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>50\</CodeContentPlaceHolder> structure). You might want to use <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> for the following conditions:  
  
-   Continuing to iterate is unnecessary or impossible. An erroneous value or a termination request might create this condition.  
  
-   A <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>54\</CodeContentPlaceHolder> statement catches an exception. You might use <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> at the end of the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> block.  
  
-   You have an endless loop, which is a loop that could run a large or even infinite number of times. If you detect such a condition, you can use <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> to escape the loop. For more information, see [Do...Loop Statement (Visual Basic)](../vs140/do...loop-statement--visual-basic-.md).  
  
## Technical Implementation  
 When a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>59\</CodeContentPlaceHolder> loop starts, Visual Basic evaluates <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>. Visual Basic evaluates these values only at this time and then assigns <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>. Before the statement block runs, Visual Basic compares <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> is already larger than the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> value (or smaller if <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> is negative), the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> loop ends and control passes to the statement that follows the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> statement. Otherwise, the statement block runs.  
  
 Each time Visual Basic encounters the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> statement, it increments <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> by <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> and returns to the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> statement. Again it compares <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>, and again it either runs the block or exits the loop, depending on the result. This process continues until <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> passes <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> or an <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> statement is encountered.  
  
 The loop doesn't stop until <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> has passed <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> is equal to <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>, the loop continues. The comparison that determines whether to run the block is <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> <= <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> is positive and <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> >= <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> is negative.  
  
 If you change the value of <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> while inside a loop, your code might be more difficult to read and debug. Changing the value of <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> doesn't affect the iteration values that were determined when the loop was first entered.  
  
 If you nest loops, the compiler signals an error if it encounters the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> statement of an outer nesting level before the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> statement of an inner level. However, the compiler can detect this overlapping error only if you specify <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> in every <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> statement.  
  
### Step Argument  
 The value of <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> can be either positive or negative. This parameter determines loop processing according to the following table:  
  
|**Step value**|**Loop executes if**|  
|--------------------|--------------------------|  
|Positive or zero|<CodeContentPlaceHolder>100\</CodeContentPlaceHolder> <= <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>|  
|Negative|<CodeContentPlaceHolder>102\</CodeContentPlaceHolder> >= <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>|  
  
 The default value of <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> is 1.  
  
###  \<a name="BKMK_Counter">\</a> Counter Argument  
 The following table indicates whether <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> defines a new local variable that’s scoped to the entire <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> loop. This determination depends on whether <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> is present and whether <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> is already defined.  
  
|Is <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> present?|Is <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> already defined?|Result (whether <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> defines a new local variable that’s scoped to the entire <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> loop)|  
|----------------------------|-----------------------------------|-------------------------------------------------------------------------------------------------------------|  
|No|Yes|No, because <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> is already defined. If the scope of <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> isn't local to the procedure, a compile-time warning occurs.|  
|No|No|Yes. The data type is inferred from the <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> expressions. For information about type inference, see [Option Infer Statement](../vs140/option-infer-statement.md) and [Local Type Inference (Visual Basic)](../vs140/local-type-inference--visual-basic-.md).|  
|Yes|Yes|Yes, but only if the existing <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> variable is defined outside the procedure. That variable remains separate. If the scope of the existing <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> variable is local to the procedure, a compile-time error occurs.|  
|Yes|No|Yes.|  
  
 The data type of <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> determines the type of the iteration, which must be one of the following types:  
  
-   A <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>.  
  
-   An enumeration that you declare by using an [Enum Statement (Visual Basic)](../vs140/enum-statement--visual-basic-.md).  
  
-   An <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>.  
  
-   A type <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> that has the following operators, where <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> is a type that can be used in a <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> expression.  
  
     <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
  
 You can optionally specify the <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> variable in the <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> statement. This syntax improves the readability of your program, especially if you have nested <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> loops. You must specify the variable that appears in the corresponding <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> statement.  
  
 The <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> expressions can evaluate to any data type that widens to the type of <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>. If you use a user-defined type for <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>, you might have to define the <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> conversion operator to convert the types of <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> to the type of <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>.  
  
## Example  
 The following example removes all elements from a generic list. Instead of a [For Each...Next Statement (Visual Basic)](../vs140/for-each...next-statement--visual-basic-.md), the example shows a <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>155\</CodeContentPlaceHolder> statement that iterates in descending order. The example uses this technique because the <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> method causes elements after the removed element to have a lower index value.  
  
 [!code[VbVbalrStatements#114](../vs140/codesnippet/VisualBasic/for...next-statement--visual-basic-_5.vb)]  
  
## Example  
 The following example iterates through an enumeration that's declared by using an [Enum Statement (Visual Basic)](../vs140/enum-statement--visual-basic-.md).  
  
 [!code[VbVbalrStatements#116](../vs140/codesnippet/VisualBasic/for...next-statement--visual-basic-_6.vb)]  
  
## Example  
 In the following example, the statement parameters use a class that has operator overloads for the <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> operators.  
  
 [!code[VbVbalrStatements#117](../vs140/codesnippet/VisualBasic/for...next-statement--visual-basic-_7.vb)]  
  
## See Also  
 \<xref:System.Collections.Generic.List`1*>   
 [Loop Structures](../vs140/loop-structures--visual-basic-.md)   
 [While...End While Statement](../vs140/while...end-while-statement--visual-basic-.md)   
 [Do...Loop Statement](../vs140/do...loop-statement--visual-basic-.md)   
 [Nested Control Structures](../vs140/nested-control-structures--visual-basic-.md)   
 [Exit Statement](../vs140/exit-statement--visual-basic-.md)   
 [Collections (C# and Visual Basic)](../vs140/collections--csharp-and-visual-basic-.md)