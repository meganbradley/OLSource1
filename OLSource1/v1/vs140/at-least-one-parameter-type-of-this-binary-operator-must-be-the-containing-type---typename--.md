---
title: "At least one parameter type of this binary operator must be the containing type &#39;&lt;typename&gt;&#39;"
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
  - "bc33021"
  - "vbc33021"
helpviewer_keywords: 
  - "BC33021"
ms.assetid: 934d4d2e-d368-46d7-819e-5571cdc0ce4f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# At least one parameter type of this binary operator must be the containing type &#39;&lt;typename&gt;&#39;
A definition of a binary operator specifies both parameters with types other than that of the class or structure in which the operator is defined.  
  
 When you define an operator in a class or structure, at least one of the parameters must be of the type of that class or structure.  
  
 **Error ID:** BC33021  
  
### To correct this error  
  
-   Change the type of one or both of the parameters to the type of the class or structure in which the operator is defined.  
  
## See Also  
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)