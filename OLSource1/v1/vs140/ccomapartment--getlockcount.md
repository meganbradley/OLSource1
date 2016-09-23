---
title: "CComApartment::GetLockCount"
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
  - CComApartment::GetLockCount
  - GetLockCount
  - CComApartment.GetLockCount
  - ATL::CComApartment::GetLockCount
  - ATL.CComApartment.GetLockCount
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetLockCount method
ms.assetid: b0908f5d-3157-49bf-9227-5abb49eee139
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComApartment::GetLockCount
Returns the thread's current lock count.  
  
## Syntax  
  
```  
  
LONG GetLockCount( );  
  
```  
  
## Return Value  
 The lock count on the thread.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComApartment Class](../vs140/ccomapartment-class.md)   
 [CComApartment::Lock](../vs140/ccomapartment--lock.md)   
 [CComApartment::Unlock](../vs140/ccomapartment--unlock.md)   
 [CComApartment::m_nLockCnt](../vs140/ccomapartment--m_nlockcnt.md)