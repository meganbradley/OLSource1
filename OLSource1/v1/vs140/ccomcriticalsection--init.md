---
title: "CComCriticalSection::Init"
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
  - "ATL::CComCriticalSection::Init"
  - "CComCriticalSection::Init"
  - "ATL.CComCriticalSection.Init"
  - "CComCriticalSection.Init"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Init method"
ms.assetid: 762a16b7-a8a5-4176-ac3b-84f6e0aa576f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCriticalSection::Init
Calls the Win32 function [InitializeCriticalSection](http://msdn.microsoft.com/library/windows/desktop/ms683472), which initializes the critical section object contained in the [m_sec](../vs140/ccomcriticalsection--m_sec.md) data member.  
  
## Syntax  
  
```  
  
HRESULT Init( ) throw( );  
  
```  
  
## Return Value  
 Returns `S_OK` on success, **E_OUTOFMEMORY** or **E_FAIL** on failure.  
  
## Requirements  
 **Header:** atlcore.h  
  
## See Also  
 [CComCriticalSection Class](../vs140/ccomcriticalsection-class.md)