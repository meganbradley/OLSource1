---
title: "CAtlModule::Lock"
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
  - "ATL::CAtlModule::Lock"
  - "CAtlModule.Lock"
  - "ATL.CAtlModule.Lock"
  - "CAtlModule::Lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Lock method"
ms.assetid: eb8f3a0b-d9b3-493d-b70e-d82d53167b57
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlModule::Lock
Increments the lock count.  
  
## Syntax  
  
```  
  
virtual LONG Lock( ) throw( );  
  
```  
  
## Return Value  
 Increments the lock count and returns the updated value. This value may be useful for diagnostics and debugging.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlModule Class](../vs140/catlmodule-class.md)