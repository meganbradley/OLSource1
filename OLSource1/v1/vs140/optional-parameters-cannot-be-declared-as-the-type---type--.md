---
title: "Optional parameters cannot be declared as the type &#39;&lt;type&gt;&#39;"
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
  - "bc30423"
  - "vbc30423"
helpviewer_keywords: 
  - "BC30423"
ms.assetid: 972dab8b-d91e-4a89-b822-2b8e4aadd25f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Optional parameters cannot be declared as the type &#39;&lt;type&gt;&#39;
Optional parameters cannot be of the data type of a structure.  
  
 **Error ID:** BC30423  
  
### To correct this error  
  
1.  To pass a structure to an optional parameter, declare the parameter as <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.  
  
2.  Use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to cast the parameter to that structure type within the procedure.  
  
## See Also  
 [Structures and Classes](../vs140/structures-and-classes--visual-basic-.md)   
 [CType Function](../vs140/ctype-function--visual-basic-.md)