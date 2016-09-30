---
title: "OrElse Operator (Visual Basic)"
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
  - "OrElse"
  - "vb.OrElse"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "short-circuiting"
  - "operators [Visual Basic], short-circuiting"
  - "operators [Visual Basic], disjunction"
  - "short-circuit evaluation"
  - "OrElse operator [Visual Basic]"
ms.assetid: 253803d8-05b0-47d7-b213-abd222847779
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OrElse Operator (Visual Basic)
Performs short-circuiting inclusive logical disjunction on two expressions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> expression.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> expression.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Required. Any <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> expression.  
  
## Remarks  
 A logical operation is said to be *short-circuiting* if the compiled code can bypass the evaluation of one expression depending on the result of another expression. If the result of the first expression evaluated determines the final result of the operation, there is no need to evaluate the second expression, because it cannot change the final result. Short-circuiting can improve performance if the bypassed expression is complex, or if it involves procedure calls.  
  
 If either or both expressions evaluate to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The following table illustrates how <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is determined.  
  
|If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is|And <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is|The value of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is|  
|-------------------------|--------------------------|------------------------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|(not evaluated)|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
  
## Data Types  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> operator is defined only for the [Boolean Data Type (Visual Basic)](../vs140/boolean-data-type--visual-basic-.md). Visual Basic converts each operand as necessary to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and performs the operation entirely in <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. If you assign the result to a numeric type, Visual Basic converts it from <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to that type. This could produce unexpected behavior. For example, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> results in <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> when converted to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
## Overloading  
 The [Or Operator (Visual Basic)](../vs140/or-operator--visual-basic-.md) and the [IsTrue Operator](../vs140/istrue-operator--visual-basic-.md) can be *overloaded*, which means that a class or structure can redefine their behavior when an operand has the type of that class or structure. Overloading the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> operators affects the behavior of the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> operator. If your code uses <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> on a class or structure that overloads <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, be sure you understand their redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> operator to perform logical disjunction on two expressions. The result is a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> value that represents whether either of the two expressions is true. If the first expression is <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, the second is not evaluated.  
  
 [!code[VbVbalrOperators#37](../vs140/codesnippet/VisualBasic/orelse-operator--visual-basic-_1.vb)]  
  
 The preceding example produces results of <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> respectively. In the calculation of <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, the second expression is not evaluated because the first is already <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. However, the second expression is evaluated in the calculation of <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
## Example  
 The following example shows an <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>45\</CodeContentPlaceHolder> statement containing two procedure calls. If the first call returns <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, the second procedure is not called. This could produce unexpected results if the second procedure performs important tasks that should always be performed when this section of the code runs.  
  
 [!code[VbVbalrOperators#38](../vs140/codesnippet/VisualBasic/orelse-operator--visual-basic-_2.vb)]  
  
## See Also  
 [Logical/Bitwise Operators (Visual Basic)](../vs140/logical-bitwise-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Or Operator](../vs140/or-operator--visual-basic-.md)   
 [IsTrue Operator](../vs140/istrue-operator--visual-basic-.md)   
 [Logical and Bitwise Operators in Visual Basic](../vs140/logical-and-bitwise-operators-in-visual-basic.md)