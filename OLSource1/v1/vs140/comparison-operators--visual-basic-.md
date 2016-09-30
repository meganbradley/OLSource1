---
title: "Comparison Operators (Visual Basic)"
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
  - "vb.<>"
  - "vb.>="
  - "vb.<="
  - "vb.>"
  - "vb.<"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "greater than or equal to operator [Visual Basic]"
  - ">= operator [Visual Basic]"
  - "= operator [Visual Basic]"
  - "< operator [Visual Basic]"
  - "less than operator [Visual Basic]"
  - "relational operators, syntax"
  - "Like operator [Visual Basic]"
  - "<> operator [Visual Basic]"
  - "> operator [Visual Basic]"
  - "equal operator [Visual Basic]"
  - "less than or equal to operator [Visual Basic]"
  - "symbols, operators"
  - "greater than operator [Visual Basic]"
  - "comparing values [Visual Basic]"
  - "operators [Visual Basic], relational"
  - "string comparison [Visual Basic]"
  - "not equal to comparison operator [Visual Basic]"
  - "<= operator [Visual Basic]"
  - "operators [Visual Basic], comparison"
  - "Is operator [Visual Basic]"
  - "comparison operators, Visual Basicl"
ms.assetid: d6cb12a8-e52e-46a7-8aaf-f804d634a825
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Comparison Operators (Visual Basic)
The following are the comparison operators defined in Visual Basic.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> operator  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> operator  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operator  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> operator  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> operator  
  
 [Is Operator (Visual Basic)](../vs140/is-operator--visual-basic-.md)  
  
 [IsNot Operator](../vs140/isnot-operator--visual-basic-.md)  
  
 [Like Operator](../vs140/like-operator--visual-basic-.md)  
  
 These operators compare two expressions to determine whether or not they are equal, and if not, how they differ. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> are discussed in detail on separate Help pages. The relational comparison operators are discussed in detail on this page.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Required. A <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> value representing the result of the comparison.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Required. Any expression.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Required. Any relational comparison operator.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Required. Any reference object names.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> expression.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> expression or range of characters.  
  
## Remarks  
 The following table contains a list of the relational comparison operators and the conditions that determine whether <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
|Operator|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder> if|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder> if|  
|--------------|---------------|----------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> (Less than)|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder> < <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder> >= <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder> (Less than or equal to)|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder> <= <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder> > <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder> (Greater than)|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder> > <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder> <= <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder> (Greater than or equal to)|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder> >= <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder> < <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder> (Equal to)|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder> <> <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder> (Not equal to)|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder> <> <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|  
  
> [!NOTE]
>  The [= Operator (Visual Basic)](../vs140/=-operator--visual-basic-.md) is also used as an assignment operator.  
  
 The <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> operator, the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> operator, and the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> operator have specific comparison functionalities that differ from the operators in the preceding table.  
  
## Comparing Numbers  
 When you compare an expression of type <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> to one of type <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> expression is converted to <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>. This behavior is opposite to the behavior found in Visual Basic 6.  
  
 Similarly, when you compare an expression of type <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> to an expression of type <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> expression is converted to <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>. For <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> expressions, any fractional value less than 1E-28 might be lost. Such fractional value loss may cause two values to compare as equal when they are not. For this reason, you should take care when using equality (<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>) to compare two floating-point variables. It is safer to test whether the absolute value of the difference between the two numbers is less than a small acceptable tolerance.  
  
### Floating-point Imprecision  
 When you work with floating-point numbers, keep in mind that they do not always have a precise representation in memory. This could lead to unexpected results from certain operations, such as value comparison and the [Mod Operator (Visual Basic)](../vs140/mod-operator--visual-basic-.md). For more information, see [Troubleshooting Data Types](../vs140/troubleshooting-data-types--visual-basic-.md).  
  
## Comparing Strings  
 When you compare strings, the string expressions are evaluated based on their alphabetical sort order, which depends on the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> setting.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> bases string comparisons on a sort order derived from the internal binary representations of the characters. The sort order is determined by the code page. The following example shows a typical binary sort order.  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> bases string comparisons on a case-insensitive, textual sort order determined by your application's locale. When you set <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> and sort the characters in the preceding example, the following text sort order applies:  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
  
### Locale Dependence  
 When you set <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, the result of a string comparison can depend on the locale in which the application is running. Two characters might compare as equal in one locale but not in another. If you are using a string comparison to make important decisions, such as whether to accept an attempt to log on, you should be alert to locale sensitivity. Consider either setting <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> or calling the \<xref:Microsoft.VisualBasic.Strings.StrComp*>, which takes the locale into account.  
  
## Typeless Programming with Relational Comparison Operators  
 The use of relational comparison operators with <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> expressions is not allowed under <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>. When <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>, and either <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> is an <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> expression, the run-time types determine how they are compared. The following table shows how the expressions are compared and the result from the comparison, depending on the runtime type of the operands.  
  
|If operands are|Comparison is|  
|---------------------|-------------------|  
|Both <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>|Sort comparison based on string sorting characteristics.|  
|Both numeric|Objects converted to <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>, numeric comparison.|  
|One numeric and one <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>|The <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> is converted to a <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> and numeric comparison is performed. If the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> cannot be converted to <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>, an \<xref:System.InvalidCastException*> is thrown.|  
|Either or both are reference types other than <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>|An \<xref:System.InvalidCastException*> is thrown.|  
  
 Numeric comparisons treat <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> as 0. String comparisons treat <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> as <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> (an empty string).  
  
## Overloading  
 The relational comparison operators (<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>) can be *overloaded*, which means that a class or structure can redefine their behavior when an operand has the type of that class or structure. If your code uses any of these operators on such a class or structure, be sure you understand the redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
 Notice that the [= Operator (Visual Basic)](../vs140/=-operator--visual-basic-.md) can be overloaded only as a relational comparison operator, not as an assignment operator.  
  
## Example  
 The following example shows various uses of relational comparison operators, which you use to compare expressions. Relational comparison operators return a <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> result that represents whether or not the stated expression evaluates to <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>. When you apply the <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> operators to strings, the comparison is made using the normal alphabetical sorting order of the strings. This order can be dependent on your locale setting. Whether the sort is case-sensitive or not depends on the [Option Compare](../vs140/option-compare-statement.md) setting.  
  
 [!code[VbVbalrOperators#1](../vs140/codesnippet/VisualBasic/comparison-operators--visual-basic-_1.vb)]  
  
 In the preceding example, the first comparison returns <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> and the remaining comparisons return <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>.  
  
## See Also  
 \<xref:System.InvalidCastException*>   
 [= Operator](../vs140/=-operator--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Troubleshooting Data Types](../vs140/troubleshooting-data-types--visual-basic-.md)   
 [Comparison Operators in Visual Basic](../vs140/comparison-operators-in-visual-basic.md)