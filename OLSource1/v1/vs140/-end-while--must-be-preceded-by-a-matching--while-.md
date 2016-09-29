---
title: "&#39;End While&#39; must be preceded by a matching &#39;While&#39;"
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
  - "vbc30090"
  - "bc30090"
helpviewer_keywords: 
  - "BC30090"
ms.assetid: 302b26b8-8fa4-4e49-86f0-d7c49fec485f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;End While&#39; must be preceded by a matching &#39;While&#39;
An `End While` statement occurs without a corresponding `While` statement. `End While` must be preceded by a corresponding `While` statement.  
  
 **Error ID:** BC30090  
  
### To correct this error  
  
1.  If this `While` block is part of a set of nested `While` blocks, make sure each block is properly terminated.  
  
2.  Verify that other control structures within the `While` block are correctly terminated.  
  
3.  Ensure that this `While` block is correctly formatted.  
  
## See Also  
 [While...End While Statement](../vs140/while...end-while-statement--visual-basic-.md)