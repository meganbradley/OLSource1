---
title: "Operator &#39;&lt;operator&gt;&#39; must have either one or two parameters"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc33016"
  - "vbc33016"
helpviewer_keywords: 
  - "BC33016"
ms.assetid: 70f43905-037e-4040-83c0-f39334b3e07a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operator &#39;&lt;operator&gt;&#39; must have either one or two parameters
An operator that can be either unary or binary is defined with no parameters or with more than two parameters.  
  
 A unary/binary operator must have either one or two parameters.  
  
 **Error ID:** BC33016  
  
### To correct this error  
  
-   Adjust the definition to specify either one or two parameters.  
  
-   If you need no parameters or more than two, you must use the [Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md) to define a `Function` procedure instead of an operator.  
  
## See Also  
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)