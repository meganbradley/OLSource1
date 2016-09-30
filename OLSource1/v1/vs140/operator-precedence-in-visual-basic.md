---
title: "Operator Precedence in Visual Basic"
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
  - "arithmetic operators, precedence"
  - "operator precedence"
  - "logical operators, precedence"
  - "operators [Visual Basic], associativity"
  - "operators [Visual Basic], resolution"
  - "associativity of operators"
  - "operators [Visual Basic], precedence"
  - "precedence, of operators"
  - "comparison operators, precedence"
  - "math operators"
  - "order of precedence"
ms.assetid: cbbdb282-f572-458e-a520-008a675f8063
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operator Precedence in Visual Basic
When several operations occur in an expression, each part is evaluated and resolved in a predetermined order called *operator precedence*.  
  
## Precedence Rules  
 When expressions contain operators from more than one category, they are evaluated according to the following rules:  
  
-   The arithmetic and concatenation operators have the order of precedence described in the following section, and all have greater precedence than the comparison, logical, and bitwise operators.  
  
-   All comparison operators have equal precedence, and all have greater precedence than the logical and bitwise operators, but lower precedence than the arithmetic and concatenation operators.  
  
-   The logical and bitwise operators have the order of precedence described in the following section, and all have lower precedence than the arithmetic, concatenation, and comparison operators.  
  
-   Operators with equal precedence are evaluated left to right in the order in which they appear in the expression.  
  
## Precedence Order  
 Operators are evaluated in the following order of precedence:  
  
### Await Operator  
 Await  
  
### Arithmetic and Concatenation Operators  
 Exponentiation (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>)  
  
 Unary identity and negation (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>)  
  
 Multiplication and floating-point division (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>)  
  
 Integer division (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>)  
  
 Modulus arithmetic (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>)  
  
 Addition and subtraction (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>)  
  
 String concatenation (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>)  
  
 Arithmetic bit shift (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>)  
  
### Comparison Operators  
 All comparison operators (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>)  
  
### Logical and Bitwise Operators  
 Negation (<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>)  
  
 Conjunction (<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>)  
  
 Inclusive disjunction (<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>)  
  
 Exclusive disjunction (<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>)  
  
### Comments  
 The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> operator is only the equality comparison operator, not the assignment operator.  
  
 The string concatenation operator (<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>) is not an arithmetic operator, but in precedence it is grouped with the arithmetic operators.  
  
 The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> operators are object reference comparison operators. They do not compare the values of two objects; they check only to determine whether two object variables refer to the same object instance.  
  
## Associativity  
 When operators of equal precedence appear together in an expression, for example multiplication and division, the compiler evaluates each operation as it encounters it from left to right. The following example illustrates this.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The first expression evaluates the division 96 / 8 (which results in 12) and then the division 12 / 4, which results in three. Because the compiler evaluates the operations for <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> from left to right, the evaluation is the same when that order is explicitly indicated for <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. Both <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> have a result of three. By contrast, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> has a result of 48, because the parentheses force the compiler to evaluate 8 / 4 first.  
  
 Because of this behavior, operators are said to be *left associative* in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)].  
  
## Overriding Precedence and Associativity  
 You can use parentheses to force some parts of an expression to be evaluated before others. This can override both the order of precedence and the left associativity. [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] always performs operations that are enclosed in parentheses before those outside. However, within parentheses, it maintains ordinary precedence and associativity, unless you use parentheses within the parentheses. The following example illustrates this.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [= Operator](../vs140/=-operator--visual-basic-.md)   
 [Is Operator](../vs140/is-operator--visual-basic-.md)   
 [IsNot Operator](../vs140/isnot-operator--visual-basic-.md)   
 [Like Operator](../vs140/like-operator--visual-basic-.md)   
 [TypeOf Operator (Visual Basic)](../vs140/typeof-operator--visual-basic-.md)   
 [Await Operator (Visual Basic)](../vs140/await-operator--visual-basic-.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Operators and Expressions](../vs140/operators-and-expressions-in-visual-basic.md)