---
title: "CComSafeDeleteCriticalSection::Init"
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
  - "ATL::CComSafeDeleteCriticalSection::Init"
  - "CComSafeDeleteCriticalSection::Init"
  - "ATL.CComSafeDeleteCriticalSection.Init"
  - "CComSafeDeleteCriticalSection.Init"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Init method"
ms.assetid: 63aab6ef-4f9f-4bc6-9916-f1100722ba7c
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeDeleteCriticalSection::Init
Calls the base class implementation of [Init](../vs140/ccomcriticalsection--init.md) and sets [m_bInitialized](../vs140/ccomsafedeletecriticalsection--m_binitialized.md) to **true** if successful.  
  
## Syntax  
  
```  
  
HRESULT Init() throw();  
  
```  
  
## Return Value  
 Returns the result of [CComCriticalSection::Init](../vs140/ccomcriticalsection--init.md).  
  
## Requirements  
 **Header:** atlcore.h  
  
## See Also  
 [CComSafeDeleteCriticalSection Class](../vs140/ccomsafedeletecriticalsection-class.md)