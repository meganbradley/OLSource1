---
title: "Comparison Operators in Visual Basic"
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
  - "comparison operators, comparing strings"
  - "comparison operators, comparing objects"
  - "strings [Visual Basic], comparing"
  - "comparison operators"
  - "string comparison [Visual Basic], operators"
  - "objects [Visual Basic], comparing"
  - "numbers, comparing"
  - "Visual Basic code, operators"
  - "string comparison [Visual Basic]"
  - "numeric values, comparing"
  - "comparison operators, comparing numeric values"
  - "operators [Visual Basic], comparison"
ms.assetid: 0b570339-5407-474f-8421-e183a8b303ee
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Comparison Operators in Visual Basic
Comparison operators compare two expressions and return a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> value that represents the relationship of their values. There are operators for comparing numeric values, operators for comparing strings, and operators for comparing objects. All three types of operators are discussed herein.  
  
## Comparing Numeric Values  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compares numeric values using six numeric comparison operators. Each operator takes as operands two expressions that evaluate to numeric values. The following table lists the operators and shows examples of each.  
  
|Operator|Condition tested|Examples|  
|--------------|----------------------|--------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> (Equality)|Is the value of the first expression equal to the value of the second?|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> (Inequality)|Is the value of the first expression unequal to the value of the second?|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder> (Less than)|Is the value of the first expression less than the value of the second?|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder> (Greater than)|Is the value of the first expression greater than the value of the second?|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder> (Less than or equal to)|Is the value of the first expression less than or equal to the value of the second?|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder> (Greater than or equal to)|Is the value of the first expression greater than or equal to the value of the second?|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|  
  
## Comparing Strings  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compares strings using the [Like Operator](../vs140/like-operator--visual-basic-.md) as well as the numeric comparison operators. The <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> operator allows you to specify a pattern. The string is then compared against the pattern, and if it matches, the result is <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>. Otherwise, the result is <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>. The numeric operators allow you to compare <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> values based on their sort order, as the following example shows.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  
 The result in the preceding example is <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> because the first character in the first string sorts before the first character in the second string. If the first characters were equal, the comparison would continue to the next character in both strings, and so on. You can also test equality of strings using the equality operator, as the following example shows.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
  
 If one string is a prefix of another, such as "aa" and "aaa", the longer string is considered to be greater than the shorter string. The following example illustrates this.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
  
 The sort order is based on either a binary comparison or a textual comparison depending on the setting of <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>. For more information see [Option Compare Statement](../vs140/option-compare-statement.md).  
  
## Comparing Objects  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compares two object reference variables with the [Is Operator (Visual Basic)](../vs140/is-operator--visual-basic-.md) and the [IsNot Operator](../vs140/isnot-operator--visual-basic-.md). You can use either of these operators to determine if two reference variables refer to the same object instance. The following example illustrates this.  
  
 [!code[VbVbalrOperators#65](../vs140/codesnippet/VisualBasic/comparison-operators-in-visual-basic_1.vb)]  
  
 In the preceding example, <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> evaluates to <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, because both variables refer to the same instance. Contrast this result with the following example.  
  
 [!code[VbVbalrOperators#66](../vs140/codesnippet/VisualBasic/comparison-operators-in-visual-basic_2.vb)]  
  
 In the preceding example, <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> evaluates to <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, because although the variables refer to objects of the same type, they refer to different instances of that type.  
  
 When you want to test for two objects not pointing to the same instance, the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> operator lets you avoid a grammatically clumsy combination of <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>. The following example illustrates this.  
  
 [!code[VbVbalrOperators#67](../vs140/codesnippet/VisualBasic/comparison-operators-in-visual-basic_3.vb)]  
  
 In the preceding example, <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.  
  
### Comparing Object Type  
 You can test whether an object is of a particular type with the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>83\</CodeContentPlaceHolder> expression. The syntax is as follows:  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
  
 When <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> specifies an interface type, then the <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>87\</CodeContentPlaceHolder> expression returns <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> if the object implements the interface type. When <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> is a class type, then the expression returns <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> if the object is an instance of the specified class or of a class that derives from the specified class. The following example illustrates this.  
  
 [!code[VbVbalrOperators#68](../vs140/codesnippet/VisualBasic/comparison-operators-in-visual-basic_4.vb)]  
  
 In the preceding example, the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> expression evaluates to <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> because the type of <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>, which inherits from <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>.  
  
 For more information, see [TypeOf Operator (Visual Basic)](../vs140/typeof-operator--visual-basic-.md).  
  
## See Also  
 [Value Comparisons](../vs140/value-comparisons--visual-basic-.md)   
 [Comparison Operators](../vs140/comparison-operators--visual-basic-.md)   
 [Operators](../vs140/operators--visual-basic-.md)   
 [Arithmetic Operators in Visual Basic](../vs140/arithmetic-operators-in-visual-basic.md)   
 [Concatenation Operators in Visual Basic](../vs140/concatenation-operators-in-visual-basic.md)   
 [Logical and Bitwise Operators in Visual Basic](../vs140/logical-and-bitwise-operators-in-visual-basic.md)