---
title: "CComApartment::Lock"
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
  - "CComApartment.Lock"
  - "ATL.CComApartment.Lock"
  - "CComApartment::Lock"
  - "ATL::CComApartment::Lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Lock method"
ms.assetid: c4655002-f4c9-40e0-980d-55b167b88d0c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComApartment::Lock
Increments the thread's lock count.  
  
## Syntax  
  
```  
  
LONG Lock( );  
  
```  
  
## Return Value  
 A value that may be useful for diagnostics or testing.  
  
## Remarks  
 Called by [CComAutoThreadModule::Lock](../vs140/ccomautothreadmodule--lock.md).  
  
 The lock count on the thread is used for statistical purposes.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComApartment Class](../vs140/ccomapartment-class.md)   
 [CComApartment::Unlock](../vs140/ccomapartment--unlock.md)   
 [CComApartment::GetLockCount](../vs140/ccomapartment--getlockcount.md)   
 [CComApartment::m_nLockCnt](../vs140/ccomapartment--m_nlockcnt.md)