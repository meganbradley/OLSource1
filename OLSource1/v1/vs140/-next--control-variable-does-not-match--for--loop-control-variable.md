---
title: "&#39;Next&#39; control variable does not match &#39;For&#39; loop control variable"
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
  - "vbc30976"
  - "bc30976"
helpviewer_keywords: 
  - "BC30976"
ms.assetid: 87c2d464-43bf-426f-b78b-7bc07ba171e6
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Next&#39; control variable does not match &#39;For&#39; loop control variable
The control variable in the `Next` statement of a `For...Next` loop must match the variable in the corresponding `For` statement.  
  
 **Error ID:** BC30976  
  
### To correct this error  
  
-   Check the spelling of the variable in the `Next` statement and in the corresponding `For` statement to make sure it matches.  
  
-   Ensure that no parts of the enclosing loop have been unintentionally deleted.  
  
-   If this loop is part of a set of nested loops, ensure that every loop is correctly terminated.  
  
## See Also  
 [For...Next Statement (Visual Basic)](../vs140/for...next-statement--visual-basic-.md)