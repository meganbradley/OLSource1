---
title: "CComObjectNoLock::QueryInterface"
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
  - "ATL.CComObjectNoLock.QueryInterface"
  - "ATL::CComObjectNoLock<Base>::QueryInterface"
  - "ATL::CComObjectNoLock::QueryInterface"
  - "CComObjectNoLock<Base>::QueryInterface"
  - "CComObjectNoLock.QueryInterface"
  - "CComObjectNoLock::QueryInterface"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryInterface method"
ms.assetid: ffffe7ca-9d3a-41da-b594-d30a6e090701
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectNoLock::QueryInterface
Retrieves a pointer to the requested interface.  
  
## Syntax  
  
```  
  
      STDMETHOD(QueryInterface)(  
   REFIID iid,  
   void** ppvObject   
);  
```  
  
#### Parameters  
 `iid`  
 [in] The identifier of the interface being requested.  
  
 `ppvObject`  
 [out] A pointer to the interface pointer identified by `iid`. If the object does not support this interface, `ppvObject` is set to **NULL**.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObjectNoLock Class](../vs140/ccomobjectnolock-class.md)