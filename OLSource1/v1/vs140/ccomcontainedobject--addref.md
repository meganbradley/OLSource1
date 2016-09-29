---
title: "CComContainedObject::AddRef"
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
  - "ATL.CComContainedObject<Base>.AddRef"
  - "ATL::CComContainedObject::AddRef"
  - "CComContainedObject.AddRef"
  - "ATL::CComContainedObject<Base>::AddRef"
  - "CComContainedObject<Base>::AddRef"
  - "ATL.CComContainedObject.AddRef"
  - "AddRef"
  - "CComContainedObject::AddRef"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddRef method [ATL]"
  - "AddRef method [C++], object syntax"
ms.assetid: ded24bf3-53e2-49f0-a3be-422927d37d9c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComContainedObject::AddRef
Increments the reference count on the owner object.  
  
## Syntax  
  
```  
  
STDMETHOD_(ULONG, AddRef)( );  
  
```  
  
## Return Value  
 A value that may be useful for diagnostics or testing.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComContainedObject Class](../vs140/ccomcontainedobject-class.md)   
 [CComContainedObject::Release](../vs140/ccomcontainedobject--release.md)