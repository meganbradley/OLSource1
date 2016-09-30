---
title: "If Operator (Visual Basic)"
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
  - "vb.IfOperator"
  - "IfOperator"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "ternary operators"
  - "conditional execution"
  - "If expressions [Visual Basic]"
  - "conditional operator [Visual Basic]"
  - "If Operator [Visual Basic]"
ms.assetid: dd56c9df-7cd4-442c-9ba6-20c70ee44c8f
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# If Operator (Visual Basic)
Uses short-circuit evaluation to conditionally return one of two values. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> operator can be called with three arguments or with two arguments.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## If Operator Called with Three Arguments  
 When <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is called by using three arguments, the first argument must evaluate to a value that can be cast as a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. That <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> value will determine which of the other two arguments is evaluated and returned. The following list applies only when the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> operator is called by using three arguments.  
  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Required. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Determines which of the other arguments to evaluate and return.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Required. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. Evaluated and returned if <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> evaluates to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Required. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Evaluated and returned if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> evaluates to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or if <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a [Nullable](../vs140/nullable-value-types--visual-basic-.md)<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> variable that evaluates to [Nothing](../vs140/nothing--visual-basic-.md).|  
  
 An <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> operator that is called with three arguments works like an <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> function except that it uses short-circuit evaluation. An <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> function always evaluates all three of its arguments, whereas an <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> operator that has three arguments evaluates only two of them. The first <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> argument is evaluated and the result is cast as a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> value, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. If the value is <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is evaluated and its value is returned, but <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is not evaluated. If the value of the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> expression is <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is evaluated and its value is returned, but <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is not evaluated. The following examples illustrate the use of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> when three arguments are used:  
  
 [!code[VbVbalrOperators#100](../vs140/codesnippet/VisualBasic/if-operator--visual-basic-_1.vb)]  
  
 The following example illustrates the value of short-circuit evaluation. The example shows two attempts to divide variable <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> by variable <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> except when <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is zero. In that case, a 0 should be returned, and no attempt should be made to perform the division because a run-time error would result. Because the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> expression uses short-circuit evaluation, it evaluates either the second or the third argument, depending on the value of the first argument. If the first argument is true, the divisor is not zero and it is safe to evaluate the second argument and perform the division. If the first argument is false, only the third argument is evaluated and a 0 is returned. Therefore, when the divisor is 0, no attempt is made to perform the division and no error results. However, because <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> does not use short-circuit evaluation, the second argument is evaluated even when the first argument is false. This causes a run-time divide-by-zero error.  
  
 [!code[VbVbalrOperators#101](../vs140/codesnippet/VisualBasic/if-operator--visual-basic-_2.vb)]  
  
## If Operator Called with Two Arguments  
 The first argument to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> can be omitted. This enables the operator to be called by using only two arguments. The following list applies only when the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> operator is called with two arguments.  
  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|Required. <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. Must be a reference or nullable type. Evaluated and returned when it evaluates to anything other than <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|Required. <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. Evaluated and returned if <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> evaluates to <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.|  
  
 When the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> argument is omitted, the first argument must be a reference or nullable type. If the first argument evaluates to <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, the value of the second argument is returned. In all other cases, the value of the first argument is returned. The following example illustrates how this evaluation works.  
  
 [!code[VbVbalrOperators#102](../vs140/codesnippet/VisualBasic/if-operator--visual-basic-_3.vb)]  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Interaction.IIf*>   
 [Nullable Value Types](../vs140/nullable-value-types--visual-basic-.md)   
 [Nothing](../vs140/nothing--visual-basic-.md)