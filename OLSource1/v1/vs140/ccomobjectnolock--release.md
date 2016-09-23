---
title: "CComObjectNoLock::Release"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CComObjectNoLock::Release
  - ATL.CComObjectNoLock.Release
  - CComObjectNoLock.Release
  - CComObjectNoLock<Base>.Release
  - ATL::CComObjectNoLock<Base>::Release
  - CComObjectNoLock<Base>::Release
  - ATL.CComObjectNoLock<Base>.Release
  - ATL::CComObjectNoLock::Release
dev_langs: 
  - C++
helpviewer_keywords: 
  - Release method
ms.assetid: b49c8590-3833-4bc2-82da-3c21b3abd3d2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComObjectNoLock::Release
Decrements the reference count on the object.  
  
## Syntax  
  
```  
  
STDMETHOD_(ULONG, Release)( );  
  
```  
  
## Return Value  
 In debug builds, **Release** returns a value that may be useful for diagnostics or testing. In non-debug builds, **Release** always returns 0.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObjectNoLock Class](../vs140/ccomobjectnolock-class.md)   
 [CComObjectNoLock::AddRef](../vs140/ccomobjectnolock--addref.md)