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
Uses short-circuit evaluation to conditionally return one of two values. The `If` operator can be called with three arguments or with two arguments.  
  
## Syntax  
  
```  
If( [argument1,] argument2, argument3 )  
```  
  
## If Operator Called with Three Arguments  
 When `If` is called by using three arguments, the first argument must evaluate to a value that can be cast as a `Boolean`. That `Boolean` value will determine which of the other two arguments is evaluated and returned. The following list applies only when the `If` operator is called by using three arguments.  
  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|`argument1`|Required. `Boolean`. Determines which of the other arguments to evaluate and return.|  
|`argument2`|Required. `Object`. Evaluated and returned if `argument1` evaluates to `True`.|  
|`argument3`|Required. `Object`. Evaluated and returned if `argument1` evaluates to `False` or if `argument1` is a [Nullable](../vs140/nullable-value-types--visual-basic-.md)`Boolean` variable that evaluates to [Nothing](../vs140/nothing--visual-basic-.md).|  
  
 An `If` operator that is called with three arguments works like an `IIf` function except that it uses short-circuit evaluation. An `IIf` function always evaluates all three of its arguments, whereas an `If` operator that has three arguments evaluates only two of them. The first `If` argument is evaluated and the result is cast as a `Boolean` value, `True` or `False`. If the value is `True`, `argument2` is evaluated and its value is returned, but `argument3` is not evaluated. If the value of the `Boolean` expression is `False`, `argument3` is evaluated and its value is returned, but `argument2` is not evaluated. The following examples illustrate the use of `If` when three arguments are used:  
  
 [!code[VbVbalrOperators#100](../vs140/codesnippet/VisualBasic/if-operator--visual-basic-_1.vb)]  
  
 The following example illustrates the value of short-circuit evaluation. The example shows two attempts to divide variable `number` by variable `divisor` except when `divisor` is zero. In that case, a 0 should be returned, and no attempt should be made to perform the division because a run-time error would result. Because the `If` expression uses short-circuit evaluation, it evaluates either the second or the third argument, depending on the value of the first argument. If the first argument is true, the divisor is not zero and it is safe to evaluate the second argument and perform the division. If the first argument is false, only the third argument is evaluated and a 0 is returned. Therefore, when the divisor is 0, no attempt is made to perform the division and no error results. However, because `IIf` does not use short-circuit evaluation, the second argument is evaluated even when the first argument is false. This causes a run-time divide-by-zero error.  
  
 [!code[VbVbalrOperators#101](../vs140/codesnippet/VisualBasic/if-operator--visual-basic-_2.vb)]  
  
## If Operator Called with Two Arguments  
 The first argument to `If` can be omitted. This enables the operator to be called by using only two arguments. The following list applies only when the `If` operator is called with two arguments.  
  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|`argument2`|Required. `Object`. Must be a reference or nullable type. Evaluated and returned when it evaluates to anything other than `Nothing`.|  
|`argument3`|Required. `Object`. Evaluated and returned if `argument2` evaluates to `Nothing`.|  
  
 When the `Boolean` argument is omitted, the first argument must be a reference or nullable type. If the first argument evaluates to `Nothing`, the value of the second argument is returned. In all other cases, the value of the first argument is returned. The following example illustrates how this evaluation works.  
  
 [!code[VbVbalrOperators#102](../vs140/codesnippet/VisualBasic/if-operator--visual-basic-_3.vb)]  
  
## See Also  
 <xref:Microsoft.VisualBasic.Interaction.IIf*>   
 [Nullable Value Types](../vs140/nullable-value-types--visual-basic-.md)   
 [Nothing](../vs140/nothing--visual-basic-.md)