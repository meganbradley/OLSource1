---
title: "CAtlServiceModuleT::Unlock"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CAtlServiceModuleT::Unlock"
  - "ATL.CAtlServiceModuleT.Unlock"
  - "CAtlServiceModuleT.Unlock"
  - "ATL::CAtlServiceModuleT::Unlock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Unlock method"
ms.assetid: e76cbc84-78a7-47aa-a846-08473deab0bc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlServiceModuleT::Unlock
Decrements the service's lock count.  
  
## Syntax  
  
```  
  
LONG Unlock( ) throw( );  
  
```  
  
## Return Value  
 Returns the lock count, which may be useful for diagnostics and debugging.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlServiceModuleT Class](../vs140/catlservicemodulet-class.md)