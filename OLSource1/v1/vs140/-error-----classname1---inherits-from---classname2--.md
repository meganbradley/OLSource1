---
title: "&lt;error&gt;: &#39;&lt;classname1&gt;&#39; inherits from &#39;&lt;classname2&gt;&#39;"
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
  - "bc30256"
  - "vbc30256"
helpviewer_keywords: 
  - "BC30256"
ms.assetid: 170a12ee-87ef-4a49-8c84-ebf57fac435e
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;error&gt;: &#39;&lt;classname1&gt;&#39; inherits from &#39;&lt;classname2&gt;&#39;
A circular inheritance hierarchy has been detected. A class is designated as inheriting from itself, or from another class which directly or ultimately inherits from it.  
  
 This message can appear more than once, to trace the circular inheritance path.  
  
 **Error ID:** BC30256  
  
### To correct this error  
  
-   Break the circularity by removing at least one `Inherits` statement in the circular inheritance path.  
  
## See Also  
 [Inheritance Basics](../vs140/inheritance-basics--visual-basic-.md)