---
title: "Too many DLL application clients"
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
  - "vbrID47"
ms.assetid: 4b87780b-67ad-4c96-9253-db954a751dad
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Too many DLL application clients
The dynamic-link library (DLL) for [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] can only accommodate access by a limited number of host applications. Your application and other applications that are [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] hosts (some of which may be accessed by your application) are all attempting to access the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] DLL at the same time.  
  
### To correct this error  
  
-   Reduce the number of open applications accessing [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)].  
  
## See Also  
 [Types of Errors](../vs140/error-types--visual-basic-.md)