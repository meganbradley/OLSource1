---
title: "CComPolyObject::AddRef"
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
  - ATL.CComPolyObject.AddRef
  - ATL::CComPolyObject<contained>::AddRef
  - CComPolyObject.AddRef
  - ATL.CComPolyObject<contained>.AddRef
  - CComPolyObject::AddRef
  - CComPolyObject<contained>.AddRef
  - AddRef
  - CComPolyObject<contained>::AddRef
  - ATL::CComPolyObject::AddRef
dev_langs: 
  - C++
helpviewer_keywords: 
  - AddRef method [ATL]
  - AddRef method [C++], object syntax
ms.assetid: 36aac699-83db-4b4f-bb7b-06387462a3e2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComPolyObject::AddRef
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
 [CComPolyObject Class](../vs140/ccompolyobject-class.md)   
 [CComPolyObject::Release](../vs140/ccompolyobject--release.md)