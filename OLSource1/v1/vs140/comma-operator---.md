---
title: "Comma Operator: ,"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "%2C"
  - ","
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "comma operator"
ms.assetid: 38e0238e-19da-42ba-ae62-277bfdab6090
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Comma Operator: ,
Allows grouping two statements where one is expected.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The comma operator has left-to-right associativity. Two expressions separated by a comma are evaluated left to right. The left operand is always evaluated, and all side effects are completed before the right operand is evaluated.  
  
 Commas can be used as separators in some contexts, such as function argument lists. Do not confuse the use of the comma as a separator with its use as an operator; the two uses are completely different.  
  
 Consider the expression  
  
 *e1* , *e2*  
  
 The type and value of the expression are the type and value of *e2*; the result of evaluating *e1* is discarded. The result is an l-value if the right operand is an l-value.  
  
 Where the comma is normally used as a separator (for example in actual arguments to functions or aggregate initializers), the comma operator and its operands must be enclosed in parentheses. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In the function call to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> above, three arguments, separated by commas, are passed: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. In the function call to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, parentheses force the compiler to interpret the first comma as the sequential-evaluation operator. This function call passes two arguments to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The first argument is the result of the sequential-evaluation operation <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, which has the value and type of the expression <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>; the second argument is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **20**  
**30**   
## See Also  
 [Expressions with Binary Operators](../vs140/expressions-with-binary-operators.md)   
 [C++ Operators](../vs140/c---operators.md)   
 [C++ Built-in Operators, Precedence and Associativity](../vs140/c---built-in-operators--precedence-and-associativity.md)   
 [Sequential-Evaluation Operator](../vs140/sequential-evaluation-operator.md)