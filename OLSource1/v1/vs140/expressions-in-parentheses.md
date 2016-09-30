---
title: "Expressions in Parentheses"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "parentheses"
  - "expression evaluation, evaluation order"
  - "expressions [C++], evaluating"
  - "parentheses, expressions"
ms.assetid: b8636147-6982-408c-9e64-29e40678ee43
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expressions in Parentheses
You can enclose any operand in parentheses without changing the type or value of the enclosed expression. For example, in the expression:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 the parentheses around <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> mean that the value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is evaluated first and it becomes the left operand of the division (**/**) operator. The result of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is 3. Without the parentheses, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> would evaluate to 11.  
  
 Although parentheses affect the way operands are grouped in an expression, they cannot guarantee a particular order of evaluation in all cases. For example, neither the parentheses nor the left-to-right grouping of the following expression guarantees what the value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> will be in either of the subexpressions:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The compiler is free to evaluate the two sides of the multiplication in any order. If the initial value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is zero, the whole expression could be evaluated as either of these two statements:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Exceptions resulting from side effects are discussed in [Side Effects](../vs140/side-effects.md).  
  
## See Also  
 [C Primary Expressions](../vs140/c-primary-expressions.md)