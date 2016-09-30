---
title: "CComCritSecLock::Lock"
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
  - "ATL::CComCritSecLock::Lock"
  - "CComCritSecLock::Lock"
  - "CComCritSecLock<TLock>.Lock"
  - "ATL.CComCritSecLock<TLock>.Lock"
  - "ATL::CComCritSecLock<TLock>::Lock"
  - "CComCritSecLock<TLock>::Lock"
  - "ATL.CComCritSecLock.Lock"
  - "CComCritSecLock.Lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Lock method"
ms.assetid: d247c378-7d7a-49c0-8236-436d765c3a04
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCritSecLock::Lock
Call this method to lock the critical section object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns S_OK if the object has successfully been locked, or an error HRESULT on failure.  
  
## Remarks  
 If the object is already locked, an ASSERT error will occur in debug builds.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComCritSecLock Class](../vs140/ccomcritseclock-class.md)   
 [CComCritSecLock::Unlock](../vs140/ccomcritseclock--unlock.md)