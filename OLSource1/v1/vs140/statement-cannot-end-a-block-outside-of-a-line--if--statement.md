---
title: "Statement cannot end a block outside of a line &#39;If&#39; statement"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vbc32005
  - bc32005
dev_langs: 
  - VB
helpviewer_keywords: 
  - BC32005
ms.assetid: 4039f51b-e0ee-4789-a89b-45d06de06b5d
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Statement cannot end a block outside of a line &#39;If&#39; statement
A single-line `If` statement contains several statements separated by colons (:), one of which is an `End` statement for a control block outside the single-line `If`. Single-line `If` statements do not use the `End If` statement.  
  
 **Error ID:** BC32005  
  
### To correct this error  
  
-   Move the single-line `If` statement outside the control block that contains the `End If` statement.  
  
## See Also  
 [If...Then...Else Statement](../vs140/if...then...else-statement--visual-basic-.md)