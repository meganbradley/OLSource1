---
title: "Properties declared &#39;WriteOnly&#39; cannot have a &#39;Get&#39;"
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
  - "bc30023"
  - "vbc30023"
helpviewer_keywords: 
  - "BC30023"
ms.assetid: ac290f7d-cbc3-4979-a5d9-1ae1bb26e79d
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Properties declared &#39;WriteOnly&#39; cannot have a &#39;Get&#39;
The `Get` procedure reads the value of a property. `WriteOnly` properties cannot be read.  
  
 **Error ID:** BC30023  
  
### To correct this error  
  
-   Remove the `WriteOnly` keyword from the `Property` statement, or remove the `Get` procedure from the property body.  
  
## See Also  
 [Property Statement](../vs140/property-statement.md)   
 [Get Statement](../vs140/get-statement.md)   
 [WriteOnly](../vs140/writeonly--visual-basic-.md)