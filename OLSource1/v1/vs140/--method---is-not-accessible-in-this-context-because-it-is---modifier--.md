---
title: "&#39;&lt;method&gt;&#39; is not accessible in this context because it is &#39;&lt;modifier&gt;&#39;"
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
  - "vbc30389"
  - "bc30389"
helpviewer_keywords: 
  - "BC30389"
ms.assetid: fae58a68-df91-4741-a8c9-f1bb10e166e2
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;method&gt;&#39; is not accessible in this context because it is &#39;&lt;modifier&gt;&#39;
You have attempted to access a method that is not accessible in this context because it has been declared `Private`. A possible cause for this error is that the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler imports all members of a class and is case-insensitive, so names differentiated only by casing may collide.  
  
 **Error ID:** BC30389  
  
### To correct this error  
  
-   Consider declaring the method `Public`.  
  
-   If the error is caused by a name collision, differentiate the colliding names by more than case.  
  
## See Also  
 [Private](../vs140/private--visual-basic-.md)