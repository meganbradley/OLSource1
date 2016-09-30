---
title: "IsFalse Operator (Visual Basic)"
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
  - "vb.isfalse"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "AndAlso operator"
  - "IsFalse operator"
ms.assetid: 37fc9dbf-e5cc-4570-b93f-7213447974df
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IsFalse Operator (Visual Basic)
Determines whether an expression is <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.  
  
 You cannot call <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> explicitly in your code, but the Visual Basic compiler can use it to generate code from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clauses. If you define a class or structure and then use a variable of that type in an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause, you must define <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> on that class or structure.  
  
 The compiler considers the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> operators as a *matched pair*. This means that if you define one of them, you must also define the other one.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> operator can be *overloaded*, which means that a class or structure can redefine its behavior when its operand has the type of that class or structure. If your code uses this operator on such a class or structure, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 The following code example defines the outline of a structure that includes definitions for the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> operators.  
  
 [!code[VbVbalrOperators#28](../vs140/codesnippet/VisualBasic/isfalse-operator--visual-basic-_1.vb)]  
  
## See Also  
 [IsTrue Operator](../vs140/istrue-operator--visual-basic-.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [AndAlso Operator](../vs140/andalso-operator--visual-basic-.md)