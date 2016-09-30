---
title: "Or Operator (Visual Basic)"
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
  - "vb.Or"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Or operator"
  - "operators [Visual Basic], bitwise"
  - "inclusive Or operator"
  - "bitwise operators, OR operator"
  - "Or keyword"
  - "operators [Visual Basic], inclusive or"
  - "operators [Visual Basic], disjunction"
  - "bitwise comparison"
  - "logical disjunction"
  - "disjunction operator"
ms.assetid: 41ed6905-bf3d-468a-9e3b-03c10d461891
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Or Operator (Visual Basic)
Performs a logical disjunction on two <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> expressions, or a bitwise disjunction on two numeric expressions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or numeric expression. For <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> comparison, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is the inclusive logical disjunction of two <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> values. For bitwise operations, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a numeric value representing the inclusive bitwise disjunction of two numeric bit patterns.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or numeric expression.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or numeric expression.  
  
## Remarks  
 For <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> comparison, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> if and only if both <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> evaluate to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. The following table illustrates how <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is determined.  
  
|If <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is|And <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is|The value of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is|  
|-------------------------|--------------------------|------------------------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|  
  
> [!NOTE]
>  In a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> comparison, the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> operator always evaluates both expressions, which could include making procedure calls. The [OrElse Operator](../vs140/orelse-operator--visual-basic-.md) performs *short-circuiting*, which means that if <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is not evaluated.  
  
 For bitwise operations, the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> operator performs a bitwise comparison of identically positioned bits in two numeric expressions and sets the corresponding bit in <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> according to the following table.  
  
|If bit in <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is|And bit in <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is|The bit in <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is|  
|--------------------------------|---------------------------------|----------------------------|  
|1|1|1|  
|1|0|1|  
|0|1|1|  
|0|0|0|  
  
> [!NOTE]
>  Since the logical and bitwise operators have a lower precedence than other arithmetic and relational operators, any bitwise operations should be enclosed in parentheses to ensure accurate execution.  
  
## Data Types  
 If the operands consist of one <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> expression and one numeric expression, Visual Basic converts the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> expression to a numeric value (–1 for <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> and 0 for <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>) and performs a bitwise operation.  
  
 For a <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> comparison, the data type of the result is <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>. For a bitwise comparison, the result data type is a numeric type appropriate for the data types of <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>. See the "Relational and Bitwise Comparisons" table in [Data Types of Operator Results](../vs140/data-types-of-operator-results--visual-basic-.md).  
  
## Overloading  
 The <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> operator can be *overloaded*, which means that a class or structure can redefine its behavior when an operand has the type of that class or structure. If your code uses this operator on such a class or structure, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> operator to perform an inclusive logical disjunction on two expressions. The result is a <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> value that represents whether either of the two expressions is <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrOperators#35](../vs140/codesnippet/VisualBasic/or-operator--visual-basic-_1.vb)]  
  
 The preceding example produces results of <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, respectively.  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> operator to perform inclusive logical disjunction on the individual bits of two numeric expressions. The bit in the result pattern is set if either of the corresponding bits in the operands is set to 1.  
  
 [!code[VbVbalrOperators#36](../vs140/codesnippet/VisualBasic/or-operator--visual-basic-_2.vb)]  
  
 The preceding example produces results of 10, 14, and 14, respectively.  
  
## See Also  
 [Logical/Bitwise Operators (Visual Basic)](../vs140/logical-bitwise-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [OrElse Operator](../vs140/orelse-operator--visual-basic-.md)   
 [Logical and Bitwise Operators in Visual Basic](../vs140/logical-and-bitwise-operators-in-visual-basic.md)