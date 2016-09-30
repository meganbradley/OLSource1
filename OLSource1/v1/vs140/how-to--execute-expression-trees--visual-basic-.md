---
title: "How to: Execute Expression Trees (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: 9dfb5ab3-f48f-417e-975f-f8f6f1cdc18d
caps.latest.revision: 7
---
# How to: Execute Expression Trees (Visual Basic)
This topic shows you how to execute an expression tree. Executing an expression tree may return a value, or it may just perform an action such as calling a method.  
  
 Only expression trees that represent lambda expressions can be executed. Expression trees that represent lambda expressions are of type \<xref:System.Linq.Expressions.LambdaExpression*> or <xref:System.Linq.Expressions.Expression<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>1*>, you must call the \<xref:System.Delegate.DynamicInvoke*> method on the delegate instead of invoking it directly.  
  
 If an expression tree does not represent a lambda expression, you can create a new lambda expression that has the original expression tree as its body, by calling the \<xref:System.Linq.Expressions.Expression.Lambda``1(System.Linq.Expressions.Expression,System.Collections.Generic.IEnumerable{System.Linq.Expressions.ParameterExpression})> method. Then, you can execute the lambda expression as described earlier in this section.  
  
## Example  
 The following code example demonstrates how to execute an expression tree that represents raising a number to a power by creating a lambda expression and executing it. The result, which represents the number raised to the power, is displayed.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Compiling the Code  
  
-   Add a project reference to System.Core.dll if it is not already referenced.  
  
-   Include the System.Linq.Expressions namespace.  
  
## See Also  
 [Expression Trees (Visual Basic)](../vs140/expression-trees--visual-basic-.md)   
 [How to: Modify Expression Trees (Visual Basic)](../vs140/how-to--modify-expression-trees--visual-basic-.md)