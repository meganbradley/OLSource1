---
title: "CHandle::Attach"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL.CHandle.Attach
  - CHandle.Attach
  - ATL::CHandle::Attach
  - CHandle::Attach
dev_langs: 
  - C++
helpviewer_keywords: 
  - Attach method [ATL]
ms.assetid: 6099c224-c847-417f-98bc-81842c26f59b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHandle::Attach
Call this method to attach the `CHandle` object to an existing handle.  
  
## Syntax  
  
```  
  
      void Attach(  
   HANDLE h   
) throw( );  
```  
  
#### Parameters  
 `h`  
 `CHandle` will take ownership of the handle `h`.  
  
## Remarks  
 Assigns the `CHandle` object to the `h` handle. In debugs builds, an ATLASSERT will be raised if `h` is NULL. No other check as to the validity of the handle is made.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CHandle Class](../vs140/chandle-class.md)   
 [CHandle::Detach](../vs140/chandle--detach.md)