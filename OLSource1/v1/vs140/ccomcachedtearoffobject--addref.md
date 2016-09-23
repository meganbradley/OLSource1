---
title: "CComCachedTearOffObject::AddRef"
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
  - ATL.CComCachedTearOffObject.AddRef
  - ATL::CComCachedTearOffObject::AddRef
  - CComCachedTearOffObject::AddRef
  - ATL::CComCachedTearOffObject<contained>::AddRef
  - AddRef
  - CComCachedTearOffObject<contained>::AddRef
  - CComCachedTearOffObject.AddRef
dev_langs: 
  - C++
helpviewer_keywords: 
  - AddRef method [ATL]
  - AddRef method [C++], object syntax
ms.assetid: 028760f9-c361-4082-afec-0f47551b2f16
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComCachedTearOffObject::AddRef
Increments the reference count of the `CComCachedTearOffObject` object by 1.  
  
## Syntax  
  
```  
  
STDMETHOD_(ULONG, AddRef)( );  
  
```  
  
## Return Value  
 A value that may be useful for diagnostics and testing.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComCachedTearOffObject Class](../vs140/ccomcachedtearoffobject-class.md)   
 [CComCachedTearOffObject::Release](../vs140/ccomcachedtearoffobject--release.md)