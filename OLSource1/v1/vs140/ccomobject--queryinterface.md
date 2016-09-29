---
title: "CComObject::QueryInterface"
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
  - "CComObject::QueryInterface"
  - "CComObject.QueryInterface"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryInterface method"
ms.assetid: 09272404-347b-4880-9d07-8330b130e841
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObject::QueryInterface
Retrieves a pointer to the requested interface.  
  
## Syntax  
  
```  
  
      STDMETHOD(QueryInterface)(  
   REFIID iid,  
   void** ppvObject   
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
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObject Class](../vs140/ccomobject-class.md)