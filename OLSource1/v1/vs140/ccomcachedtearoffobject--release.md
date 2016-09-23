---
title: "CComCachedTearOffObject::Release"
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
  - ATL.CComCachedTearOffObject.Release
  - CComCachedTearOffObject::Release
  - CComCachedTearOffObject.Release
  - ATL::CComCachedTearOffObject::Release
  - CComCachedTearOffObject<contained>::Release
  - ATL::CComCachedTearOffObject<contained>::Release
dev_langs: 
  - C++
helpviewer_keywords: 
  - Release method
ms.assetid: f4fd05fd-59ef-4e83-8651-d41c9c17298c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComCachedTearOffObject::Release
Decrements the reference count by 1 and, if the reference count is 0, deletes the `CComCachedTearOffObject` object.  
  
## Syntax  
  
```  
  
STDMETHOD_(ULONG, Release)( );  
  
```  
  
## Return Value  
 In non-debug builds, always returns 0. In debug builds, returns a value that may be useful for diagnostics or testing.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComCachedTearOffObject Class](../vs140/ccomcachedtearoffobject-class.md)   
 [CComCachedTearOffObject::AddRef](../vs140/ccomcachedtearoffobject--addref.md)