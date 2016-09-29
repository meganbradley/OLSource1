---
title: "CComAggObject::AddRef"
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
  - "ATL.CComAggObject.AddRef"
  - "CComAggObject.AddRef"
  - "CComAggObject<contained>.AddRef"
  - "ATL::CComAggObject::AddRef"
  - "CComAggObject::AddRef"
  - "CComAggObject<contained>::AddRef"
  - "ATL::CComAggObject<contained>::AddRef"
  - "ATL.CComAggObject<contained>.AddRef"
  - "AddRef"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddRef method [ATL]"
  - "AddRef method [C++], object syntax"
ms.assetid: 0d18909f-3c4c-4d95-afed-99cd02d13264
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComAggObject::AddRef
Increments the reference count on the aggregated object.  
  
## Syntax  
  
```  
  
STDMETHOD_(ULONG, AddRef)( );  
  
```  
  
## Return Value  
 A value that may be useful for diagnostics or testing.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComAggObject Class](../vs140/ccomaggobject-class.md)   
 [CComAggObject::Release](../vs140/ccomaggobject--release.md)