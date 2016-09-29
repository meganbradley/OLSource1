---
title: "&#39;#Region&#39; statement must end with a matching &#39;#End Region&#39;"
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
  - "bc30681"
  - "vbc30681"
helpviewer_keywords: 
  - "BC30681"
ms.assetid: 05a0402b-da68-4ab8-b6d6-940379bc5973
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;#Region&#39; statement must end with a matching &#39;#End Region&#39;
Use the `#Region` directive to specify a block of code that you can expand or collapse when using the outlining feature of the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Code Editor. The start and end of `#Region` statements must be in the same code block.  
  
 **Error ID:** BC30681  
  
### To correct this error  
  
1.  Insert `#End Region` at the appropriate place in the code after the `#Region` statement.  
  
## See Also  
 [#Region Directive](../vs140/sharpregion-directive.md)