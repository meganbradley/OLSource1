---
title: "CComSafeDeleteCriticalSection::~CComSafeDeleteCriticalSection"
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
  - "CComSafeDeleteCriticalSection.~CComSafeDeleteCriticalSection"
  - "CComSafeDeleteCriticalSection::~CComSafeDeleteCriticalSection"
  - "ATL.CComSafeDeleteCriticalSection.~CComSafeDeleteCriticalSection"
  - "~CComSafeDeleteCriticalSection"
  - "ATL::CComSafeDeleteCriticalSection::~CComSafeDeleteCriticalSection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComSafeDeleteCriticalSection destructor"
  - "CComSafeDeleteCriticalSection class, destructor"
ms.assetid: 7accebc9-9249-4289-9626-19ba98ffa19c
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeDeleteCriticalSection::~CComSafeDeleteCriticalSection
The destructor.  
  
## Syntax  
  
```  
  
~CComSafeDeleteCriticalSection() throw();  
  
```  
  
## Remarks  
 Releases the internal **CRITICAL_SECTION** object from memory if the [m_bInitialized](../vs140/ccomsafedeletecriticalsection--m_binitialized.md) data member is set to **true**.  
  
## Requirements  
 **Header:** atlcore.h  
  
## See Also  
 [CComSafeDeleteCriticalSection Class](../vs140/ccomsafedeletecriticalsection-class.md)