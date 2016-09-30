---
title: "CComCritSecLock::Unlock"
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
  - "CComCritSecLock::Unlock"
  - "CComCritSecLock<TLock>::Unlock"
  - "ATL.CComCritSecLock<TLock>.Unlock"
  - "ATL::CComCritSecLock<TLock>::Unlock"
  - "CComCritSecLock.Unlock"
  - "ATL::CComCritSecLock::Unlock"
  - "CComCritSecLock<TLock>.Unlock"
  - "ATL.CComCritSecLock.Unlock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Unlock method"
ms.assetid: 7298728d-cab7-4bb2-8c50-689c286e727a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCritSecLock::Unlock
Call this method to unlock the critical section object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If the object is already unlocked, an ASSERT error will occur in debug builds.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComCritSecLock Class](../vs140/ccomcritseclock-class.md)   
 [CComCritSecLock::Lock](../vs140/ccomcritseclock--lock.md)