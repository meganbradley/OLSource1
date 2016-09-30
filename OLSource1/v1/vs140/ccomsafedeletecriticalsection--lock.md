---
title: "CComSafeDeleteCriticalSection::Lock"
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
  - "CComSafeDeleteCriticalSection.Lock"
  - "ATL::CComSafeDeleteCriticalSection::Lock"
  - "ATL.CComSafeDeleteCriticalSection.Lock"
  - "CComSafeDeleteCriticalSection::Lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Lock method"
ms.assetid: 6b2fb65b-8e30-4b1e-8dea-13965cbaca0b
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeDeleteCriticalSection::Lock
Calls the base class implementation of [Lock](../vs140/ccomcriticalsection--lock.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the result of [CComCriticalSection::Lock](../vs140/ccomcriticalsection--lock.md).  
  
## Remarks  
 This method assumes the [m_bInitialized](../vs140/ccomsafedeletecriticalsection--m_binitialized.md) data member is set to **true** upon entry. An assertion is generated in Debug builds if this condidtion is not met.  
  
 For more information on the behavior of the function, refer to [CComCriticalSection::Lock](../vs140/ccomcriticalsection--lock.md).  
  
## Requirements  
 **Header:** atlcore.h  
  
## See Also  
 [CComSafeDeleteCriticalSection Class](../vs140/ccomsafedeletecriticalsection-class.md)