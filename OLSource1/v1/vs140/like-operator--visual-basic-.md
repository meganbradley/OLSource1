---
title: "Like Operator (Visual Basic)"
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
  - "Like"
  - "vb.Like"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "similar to"
  - "pattern matching"
  - "Like operator [Visual Basic]"
  - "? symbol, wildcard character"
  - "string comparison [Visual Basic], Like operator"
  - "strings [Visual Basic], comparing"
  - "comparison operators"
  - "symbols, wildcard"
  - "wildcards, Like operator"
  - "strings [Visual Basic], matching"
  - "string comparison [Visual Basic], sorting data"
  - "data [Visual Basic], sorting"
  - "text [Visual Basic], comparing"
  - "operators [Visual Basic], pattern-matching"
  - "data [Visual Basic], string comparisons"
  - "string comparison [Visual Basic], Like operators"
ms.assetid: 966283ec-80e2-4294-baa8-c75baff804f9
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Like Operator (Visual Basic)
Compares a string against a pattern.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> variable. The result is a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value indicating whether or not the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> satisfies the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> expression.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> expression conforming to the pattern-matching conventions described in "Remarks."  
  
## Remarks  
 If the value in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> satisfies the pattern contained in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. If the string does not satisfy the pattern, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. If both <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> are empty strings, the result is <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
## Comparison Method  
 The behavior of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> operator depends on the [Option Compare Statement](../vs140/option-compare-statement.md). The default string comparison method for each source file is <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
## Pattern Options  
 Built-in pattern matching provides a versatile tool for string comparisons. The pattern-matching features allow you to match each character in <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> against a specific character, a wildcard character, a character list, or a character range. The following table shows the characters allowed in <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and what they match.  
  
|Characters in <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Matches in <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
|-----------------------------|-------------------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Any single character|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Zero or more characters|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Any single digit (0–9)|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder> <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Any single character in <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder> <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|Any single character not in <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|  
  
## Character Lists  
 A group of one or more characters (<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>) enclosed in brackets (<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>) can be used to match any single character in <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> and can include almost any character code, including digits.  
  
 An exclamation point (<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>) at the beginning of <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> means that a match is made if any character except the characters in <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is found in <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. When used outside brackets, the exclamation point matches itself.  
  
## Special Characters  
 To match the special characters left bracket (<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>), question mark (<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>), number sign (<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>), and asterisk (<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>), enclose them in brackets. The right bracket (<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>) cannot be used within a group to match itself, but it can be used outside a group as an individual character.  
  
 The character sequence <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is considered a zero-length string (<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>). However, it cannot be part of a character list enclosed in brackets. If you want to check whether a position in <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> contains one of a group of characters or no character at all, you can use <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> twice. For an example, see [How to: Match a String against a Pattern](../vs140/how-to--match-a-string-against-a-pattern--visual-basic-.md).  
  
## Character Ranges  
 By using a hyphen (<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>) to separate the lower and upper bounds of the range, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> can specify a range of characters. For example, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> results in a match if the corresponding character position in <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> contains any character within the range <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>–<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> results in a match if the corresponding character position contains any character outside the range <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>–<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
 When you specify a range of characters, they must appear in ascending sort order, that is, from lowest to highest. Thus, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> is a valid pattern, but <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> is not.  
  
### Multiple Character Ranges  
 To specify multiple ranges for the same character position, put them within the same brackets without delimiters. For example, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> results in a match if the corresponding character position in <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> contains any character within either the range <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>–<CodeContentPlaceHolder>66\</CodeContentPlaceHolder> or the range <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>–<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
### Usage of the Hyphen  
 A hyphen (<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>) can appear either at the beginning (after an exclamation point, if any) or at the end of <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> to match itself. In any other location, the hyphen identifies a range of characters delimited by the characters on either side of the hyphen.  
  
## Collating Sequence  
 The meaning of a specified range depends on the character ordering at run time, as determined by <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> and the locale setting of the system the code is running on. With <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, the range <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> matches <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>. With <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> matches <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>. The range does not match <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> because accented characters collate after unaccented characters in the sort order.  
  
## Digraph Characters  
 In some languages, there are alphabetic characters that represent two separate characters. For example, several languages use the character <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> to represent the characters <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> when they appear together. The <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> operator recognizes that the single digraph character and the two individual characters are equivalent.  
  
 When a language that uses a digraph character is specified in the system locale settings, an occurrence of the single digraph character in either <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> matches the equivalent two-character sequence in the other string. Similarly, a digraph character in <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> enclosed in brackets (by itself, in a list, or in a range) matches the equivalent two-character sequence in <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.  
  
## Overloading  
 The <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> operator can be *overloaded*, which means that a class or structure can redefine its behavior when an operand has the type of that class or structure. If your code uses this operator on such a class or structure, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 This example uses the <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> operator to compare strings to various patterns. The results go into a <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> variable indicating whether each string satisfies the pattern.  
  
 [!code[VbVbalrOperators#30](../vs140/codesnippet/VisualBasic/like-operator--visual-basic-_1.vb)]  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Strings.InStr*>   
 \<xref:Microsoft.VisualBasic.Strings.StrComp*>   
 [Comparison Operators](../vs140/comparison-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Option Compare Statement](../vs140/option-compare-statement.md)   
 [Operators and Expressions](../vs140/operators-and-expressions-in-visual-basic.md)   
 [How to: Match a String against a Pattern](../vs140/how-to--match-a-string-against-a-pattern--visual-basic-.md)