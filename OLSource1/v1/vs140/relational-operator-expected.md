---
title: "Relational operator expected"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - bc30239
  - vbc30239
helpviewer_keywords: 
  - BC30239
ms.assetid: c5701568-77a1-441b-a0f7-f7b36cbd17e3
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Relational operator expected
A `Case` statement contains an `Is` clause but no comparison operator such as `=` or `>`. If a `Case` statement does not include an operator, `=` is assumed and `Is` is not used.  
  
 **Error ID:** BC30239  
  
### To correct this error  
  
-   Remove the `Is` keyword or follow it with a comparison operator.  
  
## See Also  
 [Select...Case Statement](../vs140/select...case-statement--visual-basic-.md)   
 [Comparison Operators in Visual Basic](../vs140/comparison-operators-in-visual-basic.md)   
 [Comparison Operators](../vs140/comparison-operators--visual-basic-.md)