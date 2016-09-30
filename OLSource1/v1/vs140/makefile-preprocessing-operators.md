---
title: "Makefile Preprocessing Operators"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operators [C++], makefile preprocessing"
  - "EXIST operator"
  - "preprocessing NMAKE makefile operators"
  - "NMAKE program, operators"
  - "DEFINED operator"
  - "makefiles, preprocessing operators"
ms.assetid: a46e4d39-afdb-43c1-ac3b-025d33e6ebdb
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Makefile Preprocessing Operators
Makefile preprocessing expressions can use operators that act on constant values, exit codes from commands, strings, macros, and file-system paths. To evaluate the expression, the preprocessor first expands macros, and then executes commands, and then performs the operations. Operations are evaluated in the order of explicit grouping in parentheses, and then in the order of operator precedence. The result is a constant value.  
  
 The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> operator is a logical operator that acts on a macro name. The expression <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>*macroname*<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is true if *macroname* is defined, even if it does not have an assigned value. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in combination with <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. However, unlike these directives, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> can be used in complex expressions.  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> operator is a logical operator that acts on a file-system path. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>*path*<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is true if *path* exists. The result from <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> can be used in binary expressions. If *path* contains spaces, enclose it in double quotation marks.  
  
 To compare two strings, use the equality (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>) operator or the inequality (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>) operator. Enclose strings in double quotation marks.  
  
 Integer constants can use the unary operators for numerical negation (<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>), one's complement (<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>), and logical negation (<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>).  
  
 Expressions can use the following operators. The operators of equal precedence are grouped together, and the groups are listed in decreasing order of precedence. Unary operators associate with the operand to the right. Binary operators of equal precedence associate operands from left to right.  
  
|Operator|Description|  
|--------------|-----------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> *macroname* <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Produces a logical value for the current definition state of *macroname*.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder> *path* <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Produces a logical value for the existence of a file at *path*.|  
|||  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Unary logical NOT.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Unary one’s complement.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Unary negation.|  
|||  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Multiplication.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Division.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Modulus (remainder).|  
|||  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Addition.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Subtraction.|  
|||  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Bitwise shift left.|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Bitwise shift right.|  
|||  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Less than or equal.|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Greater than or equal.|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|Less than.|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Greater than.|  
|||  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|Equality.|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|Inequality.|  
|||  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|Bitwise AND.|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|Bitwise XOR.|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|Bitwise OR.|  
|||  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|Logical AND.|  
|||  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|Logical OR.|  
  
> [!NOTE]
>  The bitwise XOR operator (<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>) is the same as the escape character, and must be escaped (as <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>) when it is used in an expression.  
  
## See Also  
 [Expressions in Makefile Preprocessing](../vs140/expressions-in-makefile-preprocessing.md)