---
title: "&#39;GoTo &lt;labelname&gt;&#39; is not valid because &#39;&lt;labelname&gt;&#39; is inside a &#39;SyncLock&#39; statement that does not contain this statement"
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
  - "bc30755"
  - "vbc30755"
helpviewer_keywords: 
  - "BC30755"
ms.assetid: 95fb48c1-4982-45fc-81f0-f30cf0df173f
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;GoTo &lt;labelname&gt;&#39; is not valid because &#39;&lt;labelname&gt;&#39; is inside a &#39;SyncLock&#39; statement that does not contain this statement
You cannot branch into a `SyncLock` block.  
  
 **Error ID:** BC30755  
  
### To correct this error  
  
-   Restructure your code so that the label precedes the `SyncLock` block.  
  
## See Also  
 [SyncLock Statement](../vs140/synclock-statement.md)