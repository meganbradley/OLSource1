---
title: "How to: Test Whether Two Objects Are the Same (Visual Basic)"
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
  - "variables [Visual Basic], reference"
  - "Is operator [Visual Basic], comparing objects"
  - "reference variables"
  - "variables [Visual Basic], referring to same object"
  - "objects [Visual Basic], variables referring to same"
  - "Visual Basic code, operators"
ms.assetid: f760e828-8704-4256-bc2d-c22a4c93b524
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Test Whether Two Objects Are the Same (Visual Basic)
If you have two variables that refer to objects, you can use either the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> operator, or both, to determine whether they refer to the same instance.  
  
### To test whether two objects are the same  
  
-   Use the [Is Operator](../vs140/is-operator--visual-basic-.md) or the [IsNot Operator](../vs140/isnot-operator--visual-basic-.md) with the two variables as operands.  
  
     [!code[VbVbalrOperators#69](../vs140/codesnippet/VisualBasic/how-to--test-whether-two-objects-are-the-same--visual-basic-_1.vb)]  
  
 You might want to take a certain action depending on whether two objects refer to the same instance. The preceding example compares control <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> against the active control on form <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If there is no active control, or if there is one but it is not the same control instance as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, then the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement fails and the procedure returns without further processing.  
  
 Whether you use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a matter of personal convenience to you. One might be easier to read than the other in a given expression.  
  
## See Also  
 [Comparison Operators in Visual Basic](../vs140/comparison-operators-in-visual-basic.md)