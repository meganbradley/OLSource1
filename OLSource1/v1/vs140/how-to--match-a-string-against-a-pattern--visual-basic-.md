---
title: "How to: Match a String against a Pattern (Visual Basic)"
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
  - "pattern matching"
  - "strings [Visual Basic], comparing"
  - "string comparison [Visual Basic], operators"
  - "Visual Basic code, operators"
  - "pattern matching, string comparison"
  - "string comparison [Visual Basic]"
  - "Like operator [Visual Basic], pattern matching"
  - "pattern matching, empty strings"
  - "operators [Visual Basic], comparison"
ms.assetid: 19a83804-b5af-4739-928b-ac93e64e457f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Match a String against a Pattern (Visual Basic)
If you want to find out if an expression of the [String Data Type (Visual Basic)](../vs140/string-data-type--visual-basic-.md) satisfies a pattern, then you can use the [Like Operator](../vs140/like-operator--visual-basic-.md).  
  
 <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> takes two operands. The left operand is a string expression, and the right operand is a string containing the pattern to be used for matching. <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> returns a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value indicating whether the string expression satisfies the pattern.  
  
 You can match each character in the string expression against a specific character, a wildcard character, a character list, or a character range. The positions of the specifications in the pattern string correspond to the positions of the characters to be matched in the string expression.  
  
### To match a character in the string expression against a specific character  
  
-   Put the specific character directly in the pattern string. Certain special characters must be enclosed in brackets (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>). For more information, see [Like Operator](../vs140/like-operator--visual-basic-.md).  
  
     The following example tests whether <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> consists exactly of the single character <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
     [!code[VbVbalrOperators#70](../vs140/codesnippet/VisualBasic/how-to--match-a-string-against-a-pattern--visual-basic-_1.vb)]  
  
### To match a character in the string expression against a wildcard character  
  
-   Put a question mark (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) in the pattern string. Any valid character in this position makes a successful match.  
  
     The following example tests whether <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> consists of the single character <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> followed by exactly two characters of any values.  
  
     [!code[VbVbalrOperators#71](../vs140/codesnippet/VisualBasic/how-to--match-a-string-against-a-pattern--visual-basic-_2.vb)]  
  
### To match a character in the string expression against a list of characters  
  
-   Put brackets (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) in the pattern string, and inside the brackets put the list of characters. Do not separate the characters with commas or any other separator. Any single character in the list makes a successful match.  
  
     The following example tests whether <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> consists of any valid character followed by exactly one of the characters <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
     [!code[VbVbalrOperators#72](../vs140/codesnippet/VisualBasic/how-to--match-a-string-against-a-pattern--visual-basic-_3.vb)]  
  
     Note that this match is case-sensitive.  
  
### To match a character in the string expression against a range of characters  
  
-   Put brackets (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>) in the pattern string, and inside the brackets put the lowest and highest characters in the range, separated by a hyphen (<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>). Any single character within the range makes a successful match.  
  
     The following example tests whether <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> consists of the characters <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> followed by exactly one of the characters <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
     [!code[VbVbalrOperators#73](../vs140/codesnippet/VisualBasic/how-to--match-a-string-against-a-pattern--visual-basic-_4.vb)]  
  
     Note that this match is case-sensitive.  
  
## Matching Empty Strings  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> treats the sequence <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> as a zero-length string (<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>). You can use <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to test whether the entire string expression is empty, but you cannot use it to test if a particular position in the string expression is empty. If an empty position is one of the options you need to test for, you can use <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> more than once.  
  
#### To match a character in the string expression against a list of characters or no character  
  
1.  Call the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> operator twice on the same string expression, and connect the two calls with either the [Or Operator (Visual Basic)](../vs140/or-operator--visual-basic-.md) or the [OrElse Operator](../vs140/orelse-operator--visual-basic-.md).  
  
2.  In the pattern string for the first <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> clause, include the character list, enclosed in brackets (<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>).  
  
3.  In the pattern string for the second <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> clause, do not put any character at the position in question.  
  
     The following example tests the seven-digit telephone number <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> for exactly three numeric digits, followed by a space, a hyphen (<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>), a period (<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>), or no character at all, followed by exactly four numeric digits.  
  
     [!code[VbVbalrOperators#74](../vs140/codesnippet/VisualBasic/how-to--match-a-string-against-a-pattern--visual-basic-_5.vb)]  
  
## See Also  
 [Comparison Operators](../vs140/comparison-operators--visual-basic-.md)   
 [Operators and Expressions](../vs140/operators-and-expressions-in-visual-basic.md)   
 [Like Operator](../vs140/like-operator--visual-basic-.md)   
 [String Data Type (Visual Basic)](../vs140/string-data-type--visual-basic-.md)