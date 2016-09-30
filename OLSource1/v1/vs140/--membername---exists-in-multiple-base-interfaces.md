---
title: "&#39;&lt;membername&gt;&#39; exists in multiple base interfaces"
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
  - "vbc31040"
  - "bc31040"
helpviewer_keywords: 
  - "BC31040"
ms.assetid: c1a80d64-3986-417f-af92-412183e490ad
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;membername&gt;&#39; exists in multiple base interfaces
'\<membername>' exists in multiple base interfaces. Use the name of the interface that declares '\<membername>' in the 'Implements' clause instead of the name of the derived interface.  
  
 This interface inherits members with the same name from multiple interfaces, creating ambiguity.  
  
 **Error ID:** BC31040  
  
### To correct this error  
  
-   Use the defining interface name in the `Implements` clauses instead of the name of the derived interface.  
  
## See Also  
 [Interfaces](../vs140/interfaces--visual-basic-.md)   
 [Implements](../vs140/implements-clause--visual-basic-.md)