---
title: "Relaxed Delegate Conversion (Visual Basic)"
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
  - "relaxed delegate conversion [Visual Basic]"
  - "delegates [Visual Basic], relaxed conversion"
  - "conversions, relaxed delegate"
ms.assetid: 64f371d0-5416-4f65-b23b-adcbf556e81c
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Relaxed Delegate Conversion (Visual Basic)
Relaxed delegate conversion enables you to assign subs and functions to delegates or handlers even when their signatures are not identical. Therefore, binding to delegates becomes consistent with the binding already allowed for method invocations.  
  
## Parameters and Return Type  
 In place of exact signature match, relaxed conversion requires that the following conditions be met when <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>:  
  
-   A widening conversion must exist from the data type of each delegate parameter to the data type of the corresponding parameter of the assigned function or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. In the following example, the delegate <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> has one parameter, an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Parameter <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in the assigned lambda expressions must have a data type for which there is a widening conversion from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, such as <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
     [!code[VbVbalrRelaxedDelegates#1](../vs140/codesnippet/VisualBasic/relaxed-delegate-conversion--visual-basic-_1.vb)]  
  
     [!code[VbVbalrRelaxedDelegates#2](../vs140/codesnippet/VisualBasic/relaxed-delegate-conversion--visual-basic-_2.vb)]  
  
     Narrowing conversions are permitted only when <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
     [!code[VbVbalrRelaxedDelegates#8](../vs140/codesnippet/VisualBasic/relaxed-delegate-conversion--visual-basic-_3.vb)]  
  
-   A widening conversion must exist in the opposite direction from the return type of the assigned function or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to the return type of the delegate. In the following examples, the body of each assigned lambda expression must evaluate to a data type that widens to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> because the return type of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
     [!code[VbVbalrRelaxedDelegates#3](../vs140/codesnippet/VisualBasic/relaxed-delegate-conversion--visual-basic-_4.vb)]  
  
 If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, the widening restriction is removed in both directions.  
  
 [!code[VbVbalrRelaxedDelegates#4](../vs140/codesnippet/VisualBasic/relaxed-delegate-conversion--visual-basic-_5.vb)]  
  
## Omitting Parameter Specifications  
 Relaxed delegates also allow you to completely omit parameter specifications in the assigned method:  
  
 [!code[VbVbalrRelaxedDelegates#5](../vs140/codesnippet/VisualBasic/relaxed-delegate-conversion--visual-basic-_6.vb)]  
  
 [!code[VbVbalrRelaxedDelegates#6](../vs140/codesnippet/VisualBasic/relaxed-delegate-conversion--visual-basic-_7.vb)]  
  
 Note that you cannot specify some parameters and omit others.  
  
 [!code[VbVbalrRelaxedDelegates#15](../vs140/codesnippet/VisualBasic/relaxed-delegate-conversion--visual-basic-_8.vb)]  
  
 The ability to omit parameters is helpful in a situation such as defining an event handler, where several complex parameters are involved. The arguments to some event handlers are not used. Instead, the handler directly accesses the state of the control on which the event is registered, and ignores the arguments. Relaxed delegates allow you to omit the arguments in such declarations when no ambiguities result. In the following example, the fully specified method <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> can be rewritten as <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## AddressOf Examples  
 Lambda expressions are used in the previous examples to make the type relationships easy to see. However, the same relaxations are permitted for delegate assignments that use <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 In the following example, functions <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> can all be assigned to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrRelaxedDelegates#1](../vs140/codesnippet/VisualBasic/relaxed-delegate-conversion--visual-basic-_1.vb)]  
  
 [!code[VbVbalrRelaxedDelegates#7](../vs140/codesnippet/VisualBasic/relaxed-delegate-conversion--visual-basic-_9.vb)]  
  
 [!code[VbVbalrRelaxedDelegates#9](../vs140/codesnippet/VisualBasic/relaxed-delegate-conversion--visual-basic-_10.vb)]  
  
 The following example is valid only when <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrRelaxedDelegates#14](../vs140/codesnippet/VisualBasic/relaxed-delegate-conversion--visual-basic-_11.vb)]  
  
## Dropping Function Returns  
 Relaxed delegate conversion enables you to assign a function to a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> delegate, effectively ignoring the return value of the function. However, you cannot assign a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> to a function delegate. In the following example, the address of function <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is assigned to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> delegate <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrRelaxedDelegates#10](../vs140/codesnippet/VisualBasic/relaxed-delegate-conversion--visual-basic-_12.vb)]  
  
 [!code[VbVbalrRelaxedDelegates#11](../vs140/codesnippet/VisualBasic/relaxed-delegate-conversion--visual-basic-_13.vb)]  
  
## See Also  
 [Lambda Expressions](../vs140/lambda-expressions--visual-basic-.md)   
 [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md)   
 [Delegates (Visual Basic)](../vs140/delegates--visual-basic-.md)   
 [How to: Pass Procedures to Another Procedure in Visual Basic](../vs140/how-to--pass-procedures-to-another-procedure-in-visual-basic.md)   
 [Local Type Inference](../vs140/local-type-inference--visual-basic-.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)