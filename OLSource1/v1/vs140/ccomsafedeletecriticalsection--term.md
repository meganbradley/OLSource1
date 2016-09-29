---
title: "CComSafeDeleteCriticalSection::Term"
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
  - "ATL::CComSafeDeleteCriticalSection::Term"
  - "CComSafeDeleteCriticalSection::Term"
  - "Term"
  - "CComSafeDeleteCriticalSection.Term"
  - "ATL.CComSafeDeleteCriticalSection.Term"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Term method"
ms.assetid: 818b08bb-20e0-4f20-89c2-ea0ed38dcd76
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeDeleteCriticalSection::Term
Calls the base class implementation of [CComCriticalSection::Term](../vs140/ccomcriticalsection--term.md) if the internal **CRITICAL_SECTION** object is valid.  
  
## Syntax  
  
```  
  
HRESULT Term() throw();  
  
```  
  
## Return Value  
 Returns the result of [CComCriticalSection::Term](../vs140/ccomcriticalsection--term.md), or **S_OK** if [m_bInitialized](../vs140/ccomsafedeletecriticalsection--m_binitialized.md) was set to **false** upon entry.  
  
## Remarks  
 It is safe to call this method even if the internal **CRITICAL_SECTION** object is not valid. The destructor of this class calls this method if the [m_bInitialized](../vs140/ccomsafedeletecriticalsection--m_binitialized.md) data member is set to **true**.  
  
## Requirements  
 **Header:** atlcore.h  
  
## See Also  
 [CComSafeDeleteCriticalSection Class](../vs140/ccomsafedeletecriticalsection-class.md)