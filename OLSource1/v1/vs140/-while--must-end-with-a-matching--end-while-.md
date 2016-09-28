---
title: "&#39;While&#39; must end with a matching &#39;End While&#39;"
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
  - "bc30082"
  - "vbc30082"
helpviewer_keywords: 
  - "BC30082"
ms.assetid: 50b722b1-906f-4cb1-b5d4-fefab2ba3907
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;While&#39; must end with a matching &#39;End While&#39;
A `While` statement occurs without a corresponding `End While` statement. An `End While` statement must be used to end the `While` block.  
  
 **Error ID:** BC30082  
  
### To correct this error  
  
1.  If this `While` block is part of a set of nested `While` blocks, make sure each block is properly terminated.  
  
2.  Add an `End While` statement to the end of the `While` block.  
  
## See Also  
 [While...End While Statement](../vs140/while...end-while-statement--visual-basic-.md)