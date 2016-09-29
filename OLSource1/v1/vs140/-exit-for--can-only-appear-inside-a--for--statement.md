---
title: "&#39;Exit For&#39; can only appear inside a &#39;For&#39; statement"
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
  - "bc30096"
  - "vbc30096"
helpviewer_keywords: 
  - "BC30096"
ms.assetid: 1062a329-9364-4234-9175-4c70a51cb7ae
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Exit For&#39; can only appear inside a &#39;For&#39; statement
An `Exit For` statement occurs outside a `For` loop. `Exit For` is valid only between a `For` or `For Each` statement and a corresponding `Next` statement.  
  
 **Error ID:** BC30096  
  
### To correct this error  
  
1.  Make sure a valid `For` or `For Each` statement precedes the `Exit For`, and a valid `Next` statement appears after it.  
  
2.  Verify that other control structures within the `For` loop are correctly terminated.  
  
## See Also  
 [For...Next Statement](../vs140/for...next-statement--visual-basic-.md)   
 [For Each...Next Statement](../vs140/for-each...next-statement--visual-basic-.md)