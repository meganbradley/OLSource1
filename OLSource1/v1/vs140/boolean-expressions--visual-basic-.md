---
title: "Boolean Expressions (Visual Basic)"
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
  - "short-circuiting"
  - "Boolean expressions"
  - "logical operators, Boolean expressions"
  - "expressions [Visual Basic], Boolean"
  - "expression evaluation, Boolean expressions"
  - "operators [Visual Basic], short-circuiting"
  - "Visual Basic code, operators"
  - "short-circuit evaluation"
  - "logical operators, short-circuiting"
  - "operators [Visual Basic], Boolean"
  - "Visual Basic code, expressions"
ms.assetid: d3d90406-55c8-4404-8143-50fd7f0d0d1a
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Boolean Expressions (Visual Basic)
A *Boolean expression* is an expression that evaluates to a value of the [Boolean Data Type](../vs140/boolean-data-type--visual-basic-.md): <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> expressions can take several forms. The simplest is the direct comparison of the value of a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> variable to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> literal, as shown in the following example.  
  
 [!code[VbVbalrOperators#87](../vs140/codesnippet/VisualBasic/boolean-expressions--visual-basic-_1.vb)]  
  
## Two Meanings of the = Operator  
 Notice that the assignment statement <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> looks the same as the expression in the preceding example, but it performs a different function and is used differently. In the preceding example, the expression <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> represents a Boolean value, and the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> sign is interpreted as a comparison operator. In a stand-alone statement, the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> sign is interpreted as an assignment operator and assigns the value on the right to the variable on the left. The following example illustrates this.  
  
 [!code[VbVbalrOperators#88](../vs140/codesnippet/VisualBasic/boolean-expressions--visual-basic-_2.vb)]  
  
 For further information, see [Value Comparisons](../vs140/value-comparisons--visual-basic-.md) and [Statements (Visual Basic)](../vs140/statements--visual-basic-.md).  
  
## Comparison Operators  
 Comparison operators such as <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> produce Boolean expressions by comparing the expression on the left side of the operator to the expression on the right side of the operator and evaluating the result as <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The following example illustrates this.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 Because 42 is less than 81, the Boolean expression in the preceding example evaluates to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. For more information on this kind of expression, see [Value Comparisons](../vs140/value-comparisons--visual-basic-.md).  
  
### Comparison Operators Combined with Logical Operators  
 Comparison expressions can be combined using logical operators to produce more complex Boolean expressions. The following example demonstrates the use of comparison operators in conjunction with a logical operator.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 In the preceding example, the value of the overall expression depends on the values of the expressions on each side of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> operator. If both expressions are <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, then the overall expression evaluates to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. If either expression is <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, then the entire expression evaluates to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
## Short-Circuiting Operators  
 The logical operators <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> exhibit behavior known as *short-circuiting*. A short-circuiting operator evaluates the left operand first. If the left operand determines the value of the entire expression, then program execution proceeds without evaluating the right expression. The following example illustrates this.  
  
 [!code[VbVbalrOperators#89](../vs140/codesnippet/VisualBasic/boolean-expressions--visual-basic-_3.vb)]  
  
 In the preceding example, the operator evaluates the left expression, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. Because the left expression evaluates to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, the entire logical expression must evaluate to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. Program execution thus skips execution of the code within the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> block without evaluating the right expression, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. This example does not call <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> because the left expression falsifies the entire expression.  
  
 Similarly, if the left expression in a logical expression using <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> evaluates to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, execution proceeds to the next line of code without evaluating the right expression, because the left expression has already validated the entire expression.  
  
### Comparison with Non-Short-Circuiting Operators  
 By contrast, both sides of the logical operator are evaluated when the logical operators <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> are used. The following example illustrates this.  
  
 [!code[VbVbalrOperators#90](../vs140/codesnippet/VisualBasic/boolean-expressions--visual-basic-_4.vb)]  
  
 The preceding example calls <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> even though the left expression evaluates to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
## Parenthetical Expressions  
 You can use parentheses to control the order of evaluation of Boolean expressions. Expressions enclosed by parentheses evaluate first. For multiple levels of nesting, precedence is granted to the most deeply nested expressions. Within parentheses, evaluation proceeds according to the rules of operator precedence. For more information, see [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md).  
  
## See Also  
 [Logical and Bitwise Operators in Visual Basic](../vs140/logical-and-bitwise-operators-in-visual-basic.md)   
 [Value Comparisons](../vs140/value-comparisons--visual-basic-.md)   
 [Statements in Visual Basic](../vs140/statements-in-visual-basic.md)   
 [Comparison Operators](../vs140/comparison-operators--visual-basic-.md)   
 [Efficient Combination of Operators](../vs140/efficient-combination-of-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Boolean Data Type (Visual Basic)](../vs140/boolean-data-type--visual-basic-.md)