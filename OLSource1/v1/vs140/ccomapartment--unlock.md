---
title: "CComApartment::Unlock"
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
  - "CComApartment::Unlock"
  - "ATL.CComApartment.Unlock"
  - "CComApartment.Unlock"
  - "ATL::CComApartment::Unlock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Unlock method"
ms.assetid: 56569cbf-50a4-4faf-b10b-c19a61d4987f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComApartment::Unlock
Decrements the thread's lock count.  
  
## Syntax  
  
```  
  
LONG Unlock( );  
  
```  
  
## Return Value  
 A value that may be useful for diagnostics or testing.  
  
## Remarks  
 Called by [CComAutoThreadModule::Unlock](../vs140/ccomautothreadmodule--lock.md).  
  
 The lock count on the thread is used for statistical purposes.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComApartment Class](../vs140/ccomapartment-class.md)   
 [CComApartment::Lock](../vs140/ccomapartment--lock.md)   
 [CComApartment::GetLockCount](../vs140/ccomapartment--getlockcount.md)   
 [CComApartment::m_nLockCnt](../vs140/ccomapartment--m_nlockcnt.md)