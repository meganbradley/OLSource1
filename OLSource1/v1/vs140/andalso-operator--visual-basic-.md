---
title: "AndAlso Operator (Visual Basic)"
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
  - "vb.AndAlso"
  - "AndAlso"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "short-circuiting"
  - "AndAlso operator"
  - "operators [Visual Basic], short-circuiting"
  - "operators [Visual Basic], conjunction"
  - "short-circuit evaluation"
ms.assetid: bbc15191-b374-495b-9b8f-7b8c2f4388eb
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AndAlso Operator (Visual Basic)
Performs short-circuiting logical conjunction on two expressions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Required. Any <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> expression. The result is the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> result of comparison of the two expressions.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Required. Any <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> expression.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Required. Any <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> expression.|  
  
## Remarks  
 A logical operation is said to be *short-circuiting* if the compiled code can bypass the evaluation of one expression depending on the result of another expression. If the result of the first expression evaluated determines the final result of the operation, there is no need to evaluate the second expression, because it cannot change the final result. Short-circuiting can improve performance if the bypassed expression is complex, or if it involves procedure calls.  
  
 If both expressions evaluate to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The following table illustrates how <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is determined.  
  
||||  
|-|-|-|  
|If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is|And <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is|The value of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|(not evaluated)|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
  
## Data Types  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> operator is defined only for the [Boolean Data Type (Visual Basic)](../vs140/boolean-data-type--visual-basic-.md). Visual Basic converts each operand as necessary to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and performs the operation entirely in <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. If you assign the result to a numeric type, Visual Basic converts it from <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> to that type. This could produce unexpected behavior. For example, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> results in <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> when converted to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
## Overloading  
 The [And Operator](../vs140/and-operator--visual-basic-.md) and the [IsFalse Operator](../vs140/isfalse-operator--visual-basic-.md) can be *overloaded*, which means that a class or structure can redefine their behavior when an operand has the type of that class or structure. Overloading the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> operators affects the behavior of the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> operator. If your code uses <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> on a class or structure that overloads <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, be sure you understand their redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> operator to perform a logical conjunction on two expressions. The result is a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> value that represents whether the entire conjoined expression is true. If the first expression is <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, the second is not evaluated.  
  
 [!code[VbVbalrOperators#24](../vs140/codesnippet/VisualBasic/andalso-operator--visual-basic-_1.vb)]  
  
 The preceding example produces results of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, respectively. In the calculation of <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, the second expression is not evaluated because the first is already <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>. However, the second expression is evaluated in the calculation of <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
## Example  
 The following example shows a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> procedure that searches for a given value among the elements of an array. If the array is empty, or if the array length has been exceeded, the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> statement does not test the array element against the search value.  
  
 [!code[VbVbalrOperators#25](../vs140/codesnippet/VisualBasic/andalso-operator--visual-basic-_2.vb)]  
  
## See Also  
 [Logical/Bitwise Operators (Visual Basic)](../vs140/logical-bitwise-operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [And Operator](../vs140/and-operator--visual-basic-.md)   
 [IsFalse Operator](../vs140/isfalse-operator--visual-basic-.md)   
 [Logical and Bitwise Operators in Visual Basic](../vs140/logical-and-bitwise-operators-in-visual-basic.md)