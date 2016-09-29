---
title: "&#39;Loop&#39; cannot have a condition if matching &#39;Do&#39; has one"
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
  - "vbc30238"
  - "bc30238"
helpviewer_keywords: 
  - "BC30238"
ms.assetid: 81513cb5-69e7-4d62-b33e-e54cb8c5e8bf
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Loop&#39; cannot have a condition if matching &#39;Do&#39; has one
A `Loop` statement contains a `While` or `Until` clause, and the corresponding `Do` statement also contains such a clause. Only one of the `Do` and `Loop` statements in a loop can specify a condition.  
  
 **Error ID:** BC30238  
  
### To correct this error  
  
-   Remove the `While` or `Until` clause from either the `Do` statement or the `Loop` statement.  
  
## See Also  
 [Do...Loop Statement](../vs140/do...loop-statement--visual-basic-.md)