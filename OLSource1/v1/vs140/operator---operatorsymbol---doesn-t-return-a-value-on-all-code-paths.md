---
title: "Operator &#39;&lt;operatorsymbol&gt;&#39; doesn&#39;t return a value on all code paths"
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
  - "vbc42106"
  - "bc42106"
helpviewer_keywords: 
  - "BC42106"
ms.assetid: 175b2bc9-5233-462d-97de-9d97b003cc46
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operator &#39;&lt;operatorsymbol&gt;&#39; doesn&#39;t return a value on all code paths
Operator '\<operatorsymbol>' doesn't return a value on all code paths. A null reference exception could occur at run time when the result is used.  
  
 An operator procedure has at least one possible path through its code that does not return a value.  
  
 You can return a value from an operator procedure only by including it in a [Return Statement (Visual Basic)](../vs140/return-statement--visual-basic-.md).  
  
 If control passes to the `End Operator` statement, the operator procedure returns the default value of the property's data type. For more information, see "Behavior" in [Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md).  
  
 By default, this message is a warning. For more information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC42106  
  
### To correct this error  
  
-   Check your control flow logic and make sure every possible path ends with a `Return` statement. In particular, the last statement before `End Operator` should be a `Return` statement.  
  
## See Also  
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)