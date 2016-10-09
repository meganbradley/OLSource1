---
title: "How to: Test Whether Two Objects Are the Same (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 11
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Test Whether Two Objects Are the Same (Visual Basic)
If you have two variables that refer to objects, you can use either the `Is` or `IsNot` operator, or both, to determine whether they refer to the same instance.  
  
### To test whether two objects are the same  
  
-   Use the [Is Operator](../VS_visualbasic/is-operator--visual-basic-.md) or the [IsNot Operator](../VS_visualbasic/isnot-operator--visual-basic-.md) with the two variables as operands.  
  
     [!code[VbVbalrOperators#69](../VS_visualbasic/codesnippet/VisualBasic/how-to--test-whether-two-objects-are-the-same--visual-basic-_1.vb)]  
  
 You might want to take a certain action depending on whether two objects refer to the same instance. The preceding example compares control `c` against the active control on form `f`. If there is no active control, or if there is one but it is not the same control instance as `c`, then the `If` statement fails and the procedure returns without further processing.  
  
 Whether you use `Is` or `IsNot` is a matter of personal convenience to you. One might be easier to read than the other in a given expression.  
  
## See Also  
 [Comparison Operators in Visual Basic](../VS_visualbasic/comparison-operators-in-visual-basic.md)