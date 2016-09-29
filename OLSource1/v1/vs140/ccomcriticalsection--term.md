---
title: "CComCriticalSection::Term"
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
  - "CComCriticalSection::Term"
  - "Term"
  - "CComCriticalSection.Term"
  - "ATL::CComCriticalSection::Term"
  - "ATL.CComCriticalSection.Term"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Term method"
ms.assetid: 042eecc2-5107-44ca-b204-446e15914087
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCriticalSection::Term
Calls the Win32 function [DeleteCriticalSection](http://msdn.microsoft.com/library/windows/desktop/ms682552), which releases all resources used by the critical section object contained in the [m_sec](../vs140/ccomcriticalsection--m_sec.md) data member.  
  
## Syntax  
  
```  
  
HRESULT Term( ) throw( );  
  
```  
  
## Return Value  
 Returns `S_OK`.  
  
## Remarks  
 Once `Term` has been called, the critical section can no longer be used for synchronization.  
  
## Requirements  
 **Header:** atlcore.h  
  
## See Also  
 [CComCriticalSection Class](../vs140/ccomcriticalsection-class.md)