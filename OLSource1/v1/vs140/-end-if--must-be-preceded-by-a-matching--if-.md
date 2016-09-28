---
title: "&#39;End If&#39; must be preceded by a matching &#39;If&#39;"
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
  - "bc30087"
  - "vbc30087"
helpviewer_keywords: 
  - "BC30087"
ms.assetid: 81c056bb-267e-44ef-9a44-3a41273090ea
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;End If&#39; must be preceded by a matching &#39;If&#39;
An `End If` statement occurs without a corresponding `If` statement. `End If` must be preceded by an `If` statement.  
  
 **Error ID:** BC30087  
  
### To correct this error  
  
1.  If this `If` block is part of a set of nested `If` blocks, make sure each block is properly terminated.  
  
2.  Verify that other control structures within the `If` block are correctly terminated.  
  
3.  Ensure that this `If` block is correctly formatted.  
  
## See Also  
 [If...Then...Else Statement](../vs140/if...then...else-statement--visual-basic-.md)