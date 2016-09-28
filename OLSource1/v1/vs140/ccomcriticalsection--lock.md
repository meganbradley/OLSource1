---
title: "CComCriticalSection::Lock"
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
  - "ATL.CComCriticalSection.Lock"
  - "CComCriticalSection::Lock"
  - "CComCriticalSection.Lock"
  - "ATL::CComCriticalSection::Lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Lock method"
ms.assetid: 98e84134-93b2-4bb2-b7a6-be3877bcdec7
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCriticalSection::Lock
Calls the Win32 function [EnterCriticalSection](http://msdn.microsoft.com/library/windows/desktop/ms682608), which waits until the thread can take ownership of the critical section object contained in the [m_sec](../vs140/ccomcriticalsection--m_sec.md) data member.  
  
## Syntax  
  
```  
  
HRESULT Lock( ) throw( );  
  
```  
  
## Return Value  
 Returns `S_OK` on success, **E_OUTOFMEMORY** or **E_FAIL** on failure.  
  
## Remarks  
 The critical section object must first be initialized with a call to the [Init](../vs140/ccomcriticalsection--init.md) method. When the protected code has finished executing, the thread must call [Unlock](../vs140/ccomcriticalsection--unlock.md) to release ownership of the critical section.  
  
## Requirements  
 **Header:** atlcore.h  
  
## See Also  
 [CComCriticalSection Class](../vs140/ccomcriticalsection-class.md)