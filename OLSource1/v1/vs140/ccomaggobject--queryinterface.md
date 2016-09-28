---
title: "CComAggObject::QueryInterface"
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
  - "ATL::CComAggObject::QueryInterface"
  - "ATL::CComAggObject<contained>::QueryInterface<Q>"
  - "ATL::CComAggObject<contained>::QueryInterface"
  - "CComAggObject<contained>::QueryInterface<Q>"
  - "CComAggObject.QueryInterface"
  - "CComAggObject::QueryInterface"
  - "ATL.CComAggObject.QueryInterface"
  - "CComAggObject<contained>::QueryInterface"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryInterface method"
ms.assetid: a6e44af6-c715-4a41-9cd2-d3baa286eb76
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComAggObject::QueryInterface
Retrieves a pointer to the requested interface.  
  
## Syntax  
  
```  
  
      STDMETHOD(QueryInterface)(  
   REFIID iid,   
   void ** ppvObject  
);  
template <class Q>  
HRESULT STDMETHODCALLTYPE QueryInterface(  
   Q** pp  
);  
```  
  
#### Parameters  
 `iid`  
 [in] The identifier of the interface being requested.  
  
 `ppvObject`  
 [out] A pointer to the interface pointer identified by `iid`. If the object does not support this interface, `ppvObject` is set to **NULL**.  
  
 `pp`  
 [out] A pointer to the interface pointer identified by type `Q`. If the object does not support this interface, `pp` is set to **NULL**.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 If the requested interface is **IUnknown**, `QueryInterface` returns a pointer to the aggregated object's own **IUnknown** and increments the reference count. Otherwise, this method queries for the interface through the `CComContainedObject` member, [m_contained](../vs140/ccomaggobject--m_contained.md).  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComAggObject Class](../vs140/ccomaggobject-class.md)