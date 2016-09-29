---
title: "Operator &#39;&lt;operator&gt;&#39; must have two parameters"
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
  - "bc33015"
  - "vbc33015"
helpviewer_keywords: 
  - "BC33015"
ms.assetid: 506ea996-8abe-4dbe-aff4-d3910bf4399e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operator &#39;&lt;operator&gt;&#39; must have two parameters
A binary operator is defined with fewer than two or more than two parameters.  
  
 A binary operator must have exactly two parameters.  
  
 **Error ID:** BC33015  
  
### To correct this error  
  
-   Adjust the definition to specify exactly two parameters.  
  
-   If you need only one parameter, you must define a unary operator.  
  
-   If you need no parameters or more than two, you must use the [Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md) to define a `Function` procedure instead of an operator.  
  
## See Also  
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)