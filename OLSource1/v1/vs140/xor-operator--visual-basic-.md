---
title: "Xor Operator (Visual Basic)"
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
  - "vb.Xor"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "exclusive OR operator"
  - "logical exclusion"
  - "operators [Visual Basic], exclusive or"
  - "exclusion operator"
  - "operators [Visual Basic], bitwise"
  - "bitwise operators, XOR operator"
  - "Xor operator [Visual Basic]"
  - "Xor keyword"
  - "bitwise comparison"
ms.assetid: 036000a9-3934-4e7f-a9d0-a816de3d84a6
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Xor Operator (Visual Basic)
Performs a logical exclusion on two <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> expressions, or a bitwise exclusion on two numeric expressions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or numeric variable. For Boolean comparison, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is the logical exclusion (exclusive logical disjunction) of two <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> values. For bitwise operations, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a numeric value that represents the bitwise exclusion (exclusive bitwise disjunction) of two numeric bit patterns.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or numeric expression.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or numeric expression.  
  
## Remarks  
 For Boolean comparison, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if and only if exactly one of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> evaluates to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. That is, if and only if <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> evaluate to opposite <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> values. The following table illustrates how <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is determined.  
  
|If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is|And <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is|The value of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is|  
|-------------------------|--------------------------|------------------------------|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
  
> [!NOTE]
>  In a Boolean comparison, the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> operator always evaluates both expressions, which could include making procedure calls. There is no short-circuiting counterpart to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, because the result always depends on both operands. For *short-circuiting* logical operators, see [AndAlso Operator](../vs140/andalso-operator--visual-basic-.md) and [OrElse Operator](../vs140/orelse-operator--visual-basic-.md).  
  
 For bitwise operations, the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> operator performs a bitwise comparison of identically positioned bits in two numeric expressions and sets the corresponding bit in <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> according to the following table.  
  
|If bit in <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is|And bit in <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is|The bit in <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is|  
|--------------------------------|---------------------------------|----------------------------|  
|1|1|0|  
|1|0|1|  
|0|1|1|  
|0|0|0|  
  
> [!NOTE]
>  Since the logical and bitwise operators have a lower precedence than other arithmetic and relational operators, any bitwise operations should be enclosed in parentheses to ensure accurate execution.  
  
 For example, 5 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> 3 is 6. To see why this is so, convert 5 and 3 to their binary representations, 101 and 011. Then use the previous table to determine that 101 Xor 011 is 110, which is the binary representation of the decimal number 6.  
  
## Data Types  
 If the operands consist of one <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> expression and one numeric expression, Visual Basic converts the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> expression to a numeric value (–1 for <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and 0 for <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>) and performs a bitwise operation.  
  
 For a <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> comparison, the data type of the result is <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. For a bitwise comparison, the result data type is a numeric type appropriate for the data types of <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>. See the "Relational and Bitwise Comparisons" table in [Data Types of Operator Results](../vs140/data-types-of-operator-results--visual-basic-.md).  
  
## Overloading  
 The <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> operator can be *overloaded*, which means that a class or structure can redefine its behavior when an operand has the type of that class or structure. If your code uses this operator on such a class or structure, make sure you understand its redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> operator to perform logical exclusion (exclusive logical disjunction) on two expressions. The result is a <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> value that represents whether exactly one of the expressions is <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrOperators#40](../vs140/codesnippet/VisualBasic/xor-operator--visual-basic-_1.vb)]  
  
 The previous example produces results of <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, respectively.  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> operator to perform logical exclusion (exclusive logical disjunction) on the individual bits of two numeric expressions. The bit in the result pattern is set if exactly one of the corresponding bits in the operands is set to 1.  
  
 [!code[VbVbalrOperators#41](../vs140/codesnippet/VisualBasic/xor-operator--visual-basic-_2.vb)]  
  
 The previous example produces results of 2, 12, and 14, respectively.  
  
## See Also  
 [Logical/Bitwise Operators (Visual Basic)](../vs140/logical-bitwise-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Logical and Bitwise Operators in Visual Basic](../vs140/logical-and-bitwise-operators-in-visual-basic.md)