---
title: "Local variables within methods of structures cannot be declared &#39;Static&#39;"
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
  - "vbc31400"
  - "bc31400"
helpviewer_keywords: 
  - "BC31400"
ms.assetid: 38b8adee-3593-40fb-b0a4-e2a47599567f
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Local variables within methods of structures cannot be declared &#39;Static&#39;
The `Static` modifier cannot be used with local variables in structures.  
  
 **Error ID:** BC31400  
  
### To correct this error  
  
1.  Remove the `Static` modifier from the local variable.  
  
2.  Declare the variable as a static variable with broader scope.  
  
## See Also  
 [Static](../vs140/static--visual-basic-.md)