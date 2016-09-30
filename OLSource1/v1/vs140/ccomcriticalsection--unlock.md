---
title: "CComCriticalSection::Unlock"
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
  - "CComCriticalSection::Unlock"
  - "ATL.CComCriticalSection.Unlock"
  - "CComCriticalSection.Unlock"
  - "ATL::CComCriticalSection::Unlock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Unlock method"
ms.assetid: 3b74ccf6-db0c-4f9f-a7df-69d979fb04a6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCriticalSection::Unlock
Calls the Win32 function [LeaveCriticalSection](http://msdn.microsoft.com/library/windows/desktop/ms684169), which releases ownership of the critical section object contained in the [m_sec](../vs140/ccomcriticalsection--m_sec.md) data member.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Remarks  
 To first obtain ownership, the thread must call the [Lock](../vs140/ccomcriticalsection--lock.md) method. Each call to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> requires a corresponding call to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to release ownership of the critical section.  
  
## Requirements  
 **Header:** atlcore.h  
  
## See Also  
 [CComCriticalSection Class](../vs140/ccomcriticalsection-class.md)