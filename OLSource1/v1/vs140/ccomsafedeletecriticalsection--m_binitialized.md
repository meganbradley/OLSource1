---
title: "CComSafeDeleteCriticalSection::m_bInitialized"
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
  - "m_bInitialized"
  - "CComSafeDeleteCriticalSection::m_bInitialized"
  - "ATL.CComSafeDeleteCriticalSection.m_bInitialized"
  - "ATL::CComSafeDeleteCriticalSection::m_bInitialized"
  - "CComSafeDeleteCriticalSection.m_bInitialized"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bInitialized"
ms.assetid: 8bf6998c-1419-41ca-9aab-1d5b64c3280d
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeDeleteCriticalSection::m_bInitialized
Flags whether the internal **CRITICAL_SECTION** object has been initialized.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The **m_bInitialized** data member is used to track validity of the underlying **CRITICAL_SECTION** object associated with the [CComSafeDeleteCriticalSection](../vs140/ccomsafedeletecriticalsection-class.md) class. The underlying **CRITICAL_SECTION** object will not be attempted to be released from memory if this flag is not set to **true**.  
  
## Requirements  
 **Header:** atlcore.h  
  
## See Also  
 [CComSafeDeleteCriticalSection Class](../vs140/ccomsafedeletecriticalsection-class.md)   
 [CComSafeDeleteCriticalSection::Lock](../vs140/ccomsafedeletecriticalsection--lock.md)   
 [CComSafeDeleteCriticalSection::Init](../vs140/ccomsafedeletecriticalsection--init.md)   
 [CComSafeDeleteCriticalSection::Term](../vs140/ccomsafedeletecriticalsection--term.md)