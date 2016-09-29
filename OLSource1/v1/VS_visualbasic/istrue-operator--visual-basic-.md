---
title: "IsTrue Operator (Visual Basic)"
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
  - "vb.istrue"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "IsTrue operator"
  - "OrElse operator [Visual Basic]"
ms.assetid: b6cec0f2-61b1-4331-a7f0-4d07ee3179d6
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IsTrue Operator (Visual Basic)
Determines whether an expression is `True`.  
  
 You cannot call `IsTrue` explicitly in your code, but the Visual Basic compiler can use it to generate code from `OrElse` clauses. If you define a class or structure and then use a variable of that type in an `OrElse` clause, you must define `IsTrue` on that class or structure.  
  
 The compiler considers the `IsTrue` and `IsFalse` operators as a *matched pair*. This means that if you define one of them, you must also define the other one.  
  
## Compiler Use of IsTrue  
 When you have defined a class or structure, you can use a variable of that type in a `For`, `If`, `Else``If`, or `While` statement, or in a `When` clause. If you do this, the compiler requires an operator that converts your type into a `Boolean` value so it can test a condition. It searches for a suitable operator in the following order:  
  
1.  A widening conversion operator from your class or structure to `Boolean`.  
  
2.  A widening conversion operator from your class or structure to `Boolean?`.  
  
3.  The `IsTrue` operator on your class or structure.  
  
4.  A narrowing conversion to `Boolean?` that does not involve a conversion from `Boolean` to `Boolean?`.  
  
5.  A narrowing conversion operator from your class or structure to `Boolean`.  
  
 If you have not defined any conversion to `Boolean` or an `IsTrue` operator, the compiler signals an error.  
  
> [!NOTE]
>  The `IsTrue` operator can be *overloaded*, which means that a class or structure can redefine its behavior when its operand has the type of that class or structure. If your code uses this operator on such a class or structure, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../VS_csharp/operator-procedures--visual-basic-.md).  
  
## Example  
 The following code example defines the outline of a structure that includes definitions for the `IsFalse` and `IsTrue` operators.  
  
 [!code[VbVbalrOperators#28](../VS_csharp/codesnippet/VisualBasic/istrue-operator--visual-basic-_1.vb)]  
  
## See Also  
 [IsFalse Operator](../VS_csharp/isfalse-operator--visual-basic-.md)   
 [How to: Define an Operator](../VS_csharp/how-to--define-an-operator--visual-basic-.md)   
 [OrElse Operator](../VS_csharp/orelse-operator--visual-basic-.md)