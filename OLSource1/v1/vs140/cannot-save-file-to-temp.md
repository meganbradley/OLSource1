---
title: "Cannot save file to TEMP"
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
  - "vbrID735"
ms.assetid: 1055fc15-9641-43b2-a40c-a0a9fbbb34b2
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Cannot save file to TEMP
Either a component cannot find a directory named TEMP, or the drive or partition containing the TEMP directory lacks sufficient space to save information.  
  
### To correct this error  
  
1.  Create a directory named "TEMP" and set the TEMP environment variable equal to its path.  
  
2.  Make space on the drive by erasing unnecessary files, or create a TEMP directory on another partition and set the TEMP environment variable equal to its path.  
  
## See Also  
 [Types of Errors](../vs140/error-types--visual-basic-.md)