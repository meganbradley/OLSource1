---
title: "For Each...Next Statement (Visual Basic)"
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
  - "vb.ForEach"
  - "vb.ForEachNext"
  - "vb.Each"
  - "ForEachNext"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "infinite loops"
  - "Next statement, For Each...Next"
  - "endless loops"
  - "loop structures, For Each...Next"
  - "loops, endless"
  - "Each keyword"
  - "instructions, repeating"
  - "For Each statement"
  - "collections, instruction repetition"
  - "loops, infinite"
  - "For Each...Next statements"
  - "For keyword [Visual Basic], For Each...Next statements"
  - "Exit statement, For Each...Next statements"
  - "iteration"
ms.assetid: ebce3120-95c3-42b1-b70b-fa7da40c75e2
caps.latest.revision: 60
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# For Each...Next Statement (Visual Basic)
Repeats a group of statements for each element in a collection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Required in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement. Optional in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement. Variable. Used to iterate through the elements of the collection.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Required if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> isn't already declared. Data type of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Required. A variable with a type that's a collection type or Object. Refers to the collection over which the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> are to be repeated.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Optional. One or more statements between <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> that run on each item in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Optional. Transfers control to the start of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> loop.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Optional. Transfers control out of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> loop.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Required. Terminates the definition of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> loop.|  
  
## Simple Example  
 Use a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>21\</CodeContentPlaceHolder> loop when you want to repeat a set of statements for each element of a collection or array.  
  
> [!TIP]
>  A [For...Next Statement](../vs140/for...next-statement--visual-basic-.md) works well when you can associate each iteration of a loop with a control variable and determine that variable's initial and final values. However, when you are dealing with a collection, the concept of initial and final values isn't meaningful, and you don't necessarily know how many elements the collection has. In this kind of case, a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>23\</CodeContentPlaceHolder> loop is often a better choice.  
  
 In the following example, the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>…<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> statement iterates through all the elements of a List collection.  
  
 [!code[VbVbalrStatements#121](../vs140/codesnippet/VisualBasic/for-each...next-statement--visual-basic-_1.vb)]  
  
 For more examples, see [Collections (C# and Visual Basic)](../vs140/collections--csharp-and-visual-basic-.md) and [Arrays in Visual Basic](../vs140/arrays-in-visual-basic.md).  
  
## Nested Loops  
 You can nest <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> loops by putting one loop within another.  
  
 The following example demonstrates nested <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>…<CodeContentPlaceHolder>28\</CodeContentPlaceHolder> structures.  
  
 [!code[VbVbalrStatements#122](../vs140/codesnippet/VisualBasic/for-each...next-statement--visual-basic-_2.vb)]  
  
 When you nest loops, each loop must have a unique <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> variable.  
  
 You can also nest different kinds of control structures within each other. For more information, see [Nested Control Structures](../vs140/nested-control-structures--visual-basic-.md).  
  
## Exit For and Continue For  
 The [Exit For](../vs140/exit-statement--visual-basic-.md) statement causes execution to exit the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>…<CodeContentPlaceHolder>31\</CodeContentPlaceHolder> loop and transfers control to the statement that follows the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> statement.  
  
 The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> statement transfers control immediately to the next iteration of the loop. For more information, see [Continue Statement (Visual Basic)](../vs140/continue-statement--visual-basic-.md).  
  
 The following example shows how to use the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> statements.  
  
 [!code[VbVbalrStatements#123](../vs140/codesnippet/VisualBasic/for-each...next-statement--visual-basic-_3.vb)]  
  
 You can put any number of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> statements in a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> loop. When used within nested <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> loops, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> causes execution to exit the innermost loop and transfers control to the next higher level of nesting.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is often used after an evaluation of some condition, for example, in an <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>43\</CodeContentPlaceHolder> structure. You might want to use <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> for the following conditions:  
  
-   Continuing to iterate is unnecessary or impossible. This might be caused by an erroneous value or a termination request.  
  
-   An exception is caught in a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>. You might use <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> at the end of the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> block.  
  
-   There an endless loop, which is a loop that could run a large or even infinite number of times. If you detect such a condition, you can use <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> to escape the loop. For more information, see [Do...Loop Statement (Visual Basic)](../vs140/do...loop-statement--visual-basic-.md).  
  
## Iterators  
 You use an *iterator* to perform a custom iteration over a collection. An iterator can be a function or a <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> accessor. It uses a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> statement to return each element of the collection one at a time.  
  
 You call an iterator by using a <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> statement. Each iteration of the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> loop calls the iterator. When a <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> statement is reached in the iterator, the expression in the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> statement is returned, and the current location in code is retained. Execution is restarted from that location the next time that the iterator is called.  
  
 The following example uses an iterator function. The iterator function has a <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> statement that's inside a [For…Next](../vs140/for...next-statement--visual-basic-.md) loop. In the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> method, each iteration of the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> statement body creates a call to the iterator function, which proceeds to the next <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> statement.  
  
 [!code[VbVbalrStatements#127](../vs140/codesnippet/VisualBasic/for-each...next-statement--visual-basic-_4.vb)]  
  
 For more information, see [Iterators (C# and Visual Basic)](../vs140/iterators--csharp-and-visual-basic-.md), [Yield Statement (Visual Basic)](../vs140/yield-statement--visual-basic-.md), and [Iterator (Visual Basic)](../vs140/iterator--visual-basic-.md).  
  
## Technical Implementation  
 When a <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>…<CodeContentPlaceHolder>62\</CodeContentPlaceHolder> statement runs, Visual Basic evaluates the collection only one time, before the loop starts. If your statement block changes <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, these changes don't affect the iteration of the loop.  
  
 When all the elements in the collection have been successively assigned to <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> loop stops and control passes to the statement following the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> statement.  
  
 If <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> hasn't been declared outside this loop, you must declare it in the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> statement. You can declare the type of <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> explicitly by using an <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> statement, or you can rely on type inference to assign the type. In either case, the scope of <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> is the body of the loop. However, you cannot declare <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> both outside and inside the loop.  
  
 You can optionally specify <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> statement. This improves the readability of your program, especially if you have nested <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> loops. You must specify the same variable as the one that appears in the corresponding <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> statement.  
  
 You might want to avoid changing the value of <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> inside a loop. Doing this can make it more difficult to read and debug your code. Changing the value of <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> doesn't affect the collection or its elements, which were determined when the loop was first entered.  
  
 When you're nesting loops, if a <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> statement of an outer nesting level is encountered before the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> of an inner level, the compiler signals an error. However, the compiler can detect this overlapping error only if you specify <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> in every <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> statement.  
  
 If your code depends on traversing a collection in a particular order, a <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>85\</CodeContentPlaceHolder> loop isn't the best choice, unless you know the characteristics of the enumerator object the collection exposes. The order of traversal isn't determined by Visual Basic, but by the \<xref:System.Collections.IEnumerator.MoveNext*> method of the enumerator object. Therefore, you might not be able to predict which element of the collection is the first to be returned in <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>, or which is the next to be returned after a given element. You might achieve more reliable results using a different loop structure, such as <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>88\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>.  
  
 The data type of <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> must be such that the data type of the elements of <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> can be converted to it.  
  
 The data type of <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> must be a reference type that refers to a collection or an array that's enumerable. Most commonly this means that <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> refers to an object that implements the \<xref:System.Collections.IEnumerable*> interface of the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> namespace or the <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>System.Collections.Generic<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>System.Collections.IEnumerable<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>System.Collections.IEnumerator<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>System.Collections<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>Option Strict<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>On<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>For Each<CodeContentPlaceHolder>103\</CodeContentPlaceHolder>group<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>element<CodeContentPlaceHolder>105\</CodeContentPlaceHolder>m<CodeContentPlaceHolder>106\</CodeContentPlaceHolder>n<CodeContentPlaceHolder>107\</CodeContentPlaceHolder>Option Strict<CodeContentPlaceHolder>108\</CodeContentPlaceHolder>Long<CodeContentPlaceHolder>109\</CodeContentPlaceHolder>Integer<CodeContentPlaceHolder>110\</CodeContentPlaceHolder>For Each<CodeContentPlaceHolder>111\</CodeContentPlaceHolder>number<CodeContentPlaceHolder>112\</CodeContentPlaceHolder>Long<CodeContentPlaceHolder>113\</CodeContentPlaceHolder>Integer<CodeContentPlaceHolder>114\</CodeContentPlaceHolder>For Each<CodeContentPlaceHolder>115\</CodeContentPlaceHolder>For Each<CodeContentPlaceHolder>116\</CodeContentPlaceHolder>Next<CodeContentPlaceHolder>117\</CodeContentPlaceHolder>group<CodeContentPlaceHolder>118\</CodeContentPlaceHolder>MoveNext<CodeContentPlaceHolder>119\</CodeContentPlaceHolder>For Each<CodeContentPlaceHolder>120\</CodeContentPlaceHolder>Next<CodeContentPlaceHolder>121\</CodeContentPlaceHolder>element<CodeContentPlaceHolder>122\</CodeContentPlaceHolder>Next<CodeContentPlaceHolder>123\</CodeContentPlaceHolder>For Each<CodeContentPlaceHolder>124\</CodeContentPlaceHolder>MoveNext<CodeContentPlaceHolder>125\</CodeContentPlaceHolder>Current<CodeContentPlaceHolder>126\</CodeContentPlaceHolder>MoveNext<CodeContentPlaceHolder>127\</CodeContentPlaceHolder>Exit For<CodeContentPlaceHolder>128\</CodeContentPlaceHolder>For Each<CodeContentPlaceHolder>129\</CodeContentPlaceHolder>Next<CodeContentPlaceHolder>130\</CodeContentPlaceHolder>IEnumerable<CodeContentPlaceHolder>131\</CodeContentPlaceHolder>IEnumerable<CodeContentPlaceHolder>132\</CodeContentPlaceHolder>For Each<CodeContentPlaceHolder>133\</CodeContentPlaceHolder>Next<CodeContentPlaceHolder>134\</CodeContentPlaceHolder>Current<CodeContentPlaceHolder>135\</CodeContentPlaceHolder>BackColor<CodeContentPlaceHolder>136\</CodeContentPlaceHolder>thisControl<CodeContentPlaceHolder>137\</CodeContentPlaceHolder>thisControl<CodeContentPlaceHolder>138\</CodeContentPlaceHolder>BackColor<CodeContentPlaceHolder>139\</CodeContentPlaceHolder>thisControl<CodeContentPlaceHolder>140\</CodeContentPlaceHolder>thisControl<CodeContentPlaceHolder>141\</CodeContentPlaceHolder>For Each<CodeContentPlaceHolder>142\</CodeContentPlaceHolder>Next<CodeContentPlaceHolder>143\</CodeContentPlaceHolder>Car<CodeContentPlaceHolder>144\</CodeContentPlaceHolder>1*>. The <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> class implements the <xref:System.IComparable<CodeContentPlaceHolder>146\</CodeContentPlaceHolder>1.CompareTo*> method be implemented.  
  
 Each call to the <xref:System.IComparable<CodeContentPlaceHolder>147\</CodeContentPlaceHolder>CompareTo<CodeContentPlaceHolder>148\</CodeContentPlaceHolder>ListCars<CodeContentPlaceHolder>149\</CodeContentPlaceHolder>cars.Sort()<CodeContentPlaceHolder>150\</CodeContentPlaceHolder>1.Sort*> method of the <xref:System.Collections.Generic.List<CodeContentPlaceHolder>151\</CodeContentPlaceHolder>CompareTo<CodeContentPlaceHolder>152\</CodeContentPlaceHolder>Car<CodeContentPlaceHolder>153\</CodeContentPlaceHolder>List`.  
  
 [!code[VbVbalrStatements#125](../vs140/codesnippet/VisualBasic/for-each...next-statement--visual-basic-_7.vb)]  
  
## See Also  
 [Collections (C# and Visual Basic)](../vs140/collections--csharp-and-visual-basic-.md)   
 [For...Next Statement (Visual Basic)](../vs140/for...next-statement--visual-basic-.md)   
 [Loop Structures](../vs140/loop-structures--visual-basic-.md)   
 [While...End While Statement](../vs140/while...end-while-statement--visual-basic-.md)   
 [Do...Loop Statement](../vs140/do...loop-statement--visual-basic-.md)   
 [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md)   
 [Object Initializers: Named and Anonymous Types (Visual Basic)](../vs140/object-initializers--named-and-anonymous-types--visual-basic-.md)   
 [Collection Initializers Overview (Visual Basic)](../vs140/collection-initializers--visual-basic-.md)   
 [Arrays in Visual Basic](../vs140/arrays-in-visual-basic.md)