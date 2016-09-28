---
title: "&#39;Else&#39; must be preceded by a matching &#39;If&#39; or &#39;ElseIf&#39;"
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
  - "bc30086"
  - "vbc30086"
helpviewer_keywords: 
  - "BC30086"
ms.assetid: 5e76b3c6-571f-4a6f-b524-26150cb6e986
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Else&#39; must be preceded by a matching &#39;If&#39; or &#39;ElseIf&#39;
An `Else` statement occurs without a corresponding `If` statement. `Else` must be preceded by an `If` statement.  
  
 **Error ID:** BC30086  
  
### To correct this error  
  
1.  If this `If` block is part of a set of nested `If` blocks, make sure each block is properly terminated.  
  
2.  Verify that other control structures within the `If` block are correctly terminated.  
  
3.  Ensure that this `If` block is correctly formatted.  
  
## See Also  
 [If...Then...Else Statement](../vs140/if...then...else-statement--visual-basic-.md)