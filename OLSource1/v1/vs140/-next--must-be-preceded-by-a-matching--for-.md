---
title: "&#39;Next&#39; must be preceded by a matching &#39;For&#39;"
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
  - "vbc30092"
  - "bc30092"
helpviewer_keywords: 
  - "BC30092"
ms.assetid: 4bf49bb2-c69b-443d-aa58-cb40fcfb1370
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Next&#39; must be preceded by a matching &#39;For&#39;
A `Next` statement occurs without a corresponding `For` or `For Each` statement. `Next` must be preceded by a corresponding `For` or `For Each` statement.  
  
 **Error ID:** BC30092  
  
### To correct this error  
  
1.  If this `For` loop is part of a set of nested `For` loops, make sure each loop is properly terminated.  
  
2.  Verify that other control structures within the `For` loop are correctly terminated.  
  
3.  Ensure that this `For` loop is correctly formatted.  
  
## See Also  
 [For...Next Statement](../vs140/for...next-statement--visual-basic-.md)   
 [For Each...Next Statement](../vs140/for-each...next-statement--visual-basic-.md)