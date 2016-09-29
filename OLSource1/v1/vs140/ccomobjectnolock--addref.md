---
title: "CComObjectNoLock::AddRef"
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
  - "ATL.CComObjectNoLock<Base>.AddRef"
  - "CComObjectNoLock<Base>.AddRef"
  - "ATL::CComObjectNoLock::AddRef"
  - "CComObjectNoLock::AddRef"
  - "ATL.CComObjectNoLock.AddRef"
  - "CComObjectNoLock.AddRef"
  - "CComObjectNoLock<Base>::AddRef"
  - "AddRef"
  - "ATL::CComObjectNoLock<Base>::AddRef"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddRef method [ATL]"
  - "AddRef method [C++], object syntax"
ms.assetid: 0dce9d99-fd53-4f91-8839-375adbacebdb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectNoLock::AddRef
Increments the reference count on the object.  
  
## Syntax  
  
```  
  
STDMETHOD_(ULONG, AddRef)( );  
  
```  
  
## Return Value  
 A value that may be useful for diagnostics or testing.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObjectNoLock Class](../vs140/ccomobjectnolock-class.md)   
 [CComObjectNoLock::Release](../vs140/ccomobjectnolock--release.md)