---
title: "CComTearOffObject::AddRef"
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
  - CComTearOffObject<Base>::AddRef
  - ATL::CComTearOffObject<Base>::AddRef
  - CComTearOffObject<Base>.AddRef
  - CComTearOffObject::AddRef
  - ATL::CComTearOffObject::AddRef
  - ATL.CComTearOffObject<Base>.AddRef
  - CComTearOffObject.AddRef
  - AddRef
  - ATL.CComTearOffObject.AddRef
dev_langs: 
  - C++
helpviewer_keywords: 
  - AddRef method [ATL]
  - AddRef method [C++], object syntax
ms.assetid: 1e9d81f5-9fc1-4298-8100-177853a5768d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComTearOffObject::AddRef
Increments the reference count of the `CComTearOffObject` object by one.  
  
## Syntax  
  
```  
  
STDMETHOD_(ULONG, AddRef)( );  
  
```  
  
## Return Value  
 A value that may be useful for diagnostics and testing.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComTearOffObject Class](../vs140/ccomtearoffobject-class.md)   
 [CComTearOffObject::Release](../vs140/ccomtearoffobject--release.md)