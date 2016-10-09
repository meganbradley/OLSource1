---
title: "&#39;Class&#39; statement must end with a matching &#39;End Class&#39;"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc30481"
  - "bc30481"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30481"
ms.assetid: 583f3029-bc3a-4e06-866f-92dbecc46f19
caps.latest.revision: 9
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# &#39;Class&#39; statement must end with a matching &#39;End Class&#39;
`Class` is used to initiate a `Class` block; hence it can only appear at the beginning of the block, with a matching `End Class` statement ending the block. Either you have a redundant `Class` statement, or you have not ended your `Class` block with `End Class`.  
  
 **Error ID:** BC30481  
  
### To correct this error  
  
-   Locate and remove the unnecessary `Class` statement.  
  
-   Conclude the `Class` block with a matching `End Class`.  
  
## See Also  
 [End \<keyword> Statement](../VS_visualbasic/end--keyword--statement--visual-basic-.md)   
 [Class Statement](../VS_visualbasic/class-statement--visual-basic-.md)