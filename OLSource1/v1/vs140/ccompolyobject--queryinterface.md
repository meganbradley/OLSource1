---
title: "CComPolyObject::QueryInterface"
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
  - "CComPolyObject<contained>::QueryInterface"
  - "CComPolyObject::QueryInterface"
  - "CComPolyObject.QueryInterface"
  - "ATL::CComPolyObject<contained>::QueryInterface"
  - "ATL::CComPolyObject::QueryInterface"
  - "ATL.CComPolyObject.QueryInterface"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryInterface method"
ms.assetid: 66878b7a-805d-4013-b37c-6782c1fcff52
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComPolyObject::QueryInterface
Retrieves a pointer to the requested interface.  
  
## Syntax  
  
```  
  
      STDMETHOD(QueryInterface)(  
   REFIID iid,  
   void** ppvObject   
);  
template <class Q>  
HRESULT QueryInterface(Q ** pp);  
```  
  
#### Parameters  
 `Q`  
 The COM interface.  
  
 `iid`  
 [in] The identifier of the interface being requested.  
  
 `ppvObject`  
 [out] A pointer to the interface pointer identified by `iid`. If the object does not support this interface, `ppvObject` is set to **NULL**.  
  
 `pp`  
 [out] A pointer to the interface identified by **__uuidof(Q)**.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 For an aggregated object, if the requested interface is **IUnknown**, `QueryInterface` returns a pointer to the aggregated object's own **IUnknown** and increments the reference count. Otherwise, this method queries for the interface through the `CComContainedObject` data member, [m_contained](../vs140/ccompolyobject--m_contained.md).  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComPolyObject Class](../vs140/ccompolyobject-class.md)