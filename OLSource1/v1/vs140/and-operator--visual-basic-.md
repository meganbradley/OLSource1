---
title: "And Operator (Visual Basic)"
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
  - "vb.And"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "operators [Visual Basic], bitwise"
  - "logical conjunction"
  - "bitwise AND operator [Visual Basic]"
  - "conjunction operator"
  - "And operator [Visual Basic]"
  - "bitwise operators, AND operator"
  - "operators [Visual Basic], conjunction"
  - "bitwise comparison"
ms.assetid: 2ea711f3-439a-4c7c-9e3a-1ffe3b0d6046
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# And Operator (Visual Basic)
Performs a logical conjunction on two <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> expressions, or a bitwise conjunction on two numeric expressions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or numeric expression. For Boolean comparison, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is the logical conjunction of two <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> values. For bitwise operations, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a numeric value representing the bitwise conjunction of two numeric bit patterns.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or numeric expression.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or numeric expression.  
  
## Remarks  
 For Boolean comparison, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if and only if both <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> evaluate to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. The following table illustrates how <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is determined.  
  
|If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is|And <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is|The value of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is|  
|-------------------------|--------------------------|------------------------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
  
> [!NOTE]
>  In a Boolean comparison, the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> operator always evaluates both expressions, which could include making procedure calls. The [AndAlso Operator](../vs140/andalso-operator--visual-basic-.md) performs *short-circuiting*, which means that if <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is not evaluated.  
  
 When applied to numeric values, the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> operator performs a bitwise comparison of identically positioned bits in two numeric expressions and sets the corresponding bit in <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> according to the following table.  
  
|If bit in <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is|And bit in <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is|The bit in <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is|  
|--------------------------------|---------------------------------|----------------------------|  
|1|1|1|  
|1|0|0|  
|0|1|0|  
|0|0|0|  
  
> [!NOTE]
>  Since the logical and bitwise operators have a lower precedence than other arithmetic and relational operators, any bitwise operations should be enclosed in parentheses to ensure accurate results.  
  
## Data Types  
 If the operands consist of one <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> expression and one numeric expression, Visual Basic converts the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> expression to a numeric value (–1 for <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> and 0 for <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>) and performs a bitwise operation.  
  
 For a Boolean comparison, the data type of the result is <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. For a bitwise comparison, the result data type is a numeric type appropriate for the data types of <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>. See the "Relational and Bitwise Comparisons" table in [Data Types of Operator Results](../vs140/data-types-of-operator-results--visual-basic-.md).  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> operator can be *overloaded*, which means that a class or structure can redefine its behavior when an operand has the type of that class or structure. If your code uses this operator on such a class or structure, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> operator to perform a logical conjunction on two expressions. The result is a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> value that represents whether both of the expressions are <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrOperators#22](../vs140/codesnippet/VisualBasic/and-operator--visual-basic-_1.vb)]  
  
 The preceding example produces results of <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, respectively.  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> operator to perform logical conjunction on the individual bits of two numeric expressions. The bit in the result pattern is set if the corresponding bits in the operands are both set to 1.  
  
 [!code[VbVbalrOperators#23](../vs140/codesnippet/VisualBasic/and-operator--visual-basic-_2.vb)]  
  
 The preceding example produces results of 8, 2, and 0, respectively.  
  
## See Also  
 [Logical/Bitwise Operators (Visual Basic)](../vs140/logical-bitwise-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [AndAlso Operator](../vs140/andalso-operator--visual-basic-.md)   
 [Logical and Bitwise Operators in Visual Basic](../vs140/logical-and-bitwise-operators-in-visual-basic.md)