---
title: "ICollectionOnSTLImpl::get__NewEnum"
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
  - "ICollectionOnSTLImpl::get__NewEnum"
  - "ATL.ICollectionOnSTLImpl.get__NewEnum"
  - "ATL::ICollectionOnSTLImpl::get__NewEnum"
  - "get__NewEnum"
  - "ICollectionOnSTLImpl.get__NewEnum"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get__NewEnum method"
ms.assetid: 936d1710-1f4c-46d4-a453-aba42e68444b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ICollectionOnSTLImpl::get__NewEnum
Returns an enumerator object for the collection.  
  
## Syntax  
  
```  
  
      STDMETHOD(get__NewEnum)(  
   IUnknown** ppUnk   
);  
```  
  
#### Parameters  
 `ppUnk`  
 [out] The **IUnknown** pointer of a newly created enumerator object.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The newly created enumerator maintains an iterator on the original collection, `m_coll`, (so no copy is made) and holds a COM reference on the collection object to ensure that the collection remains alive while there are outstanding enumerators.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [ICollectionOnSTLImpl Class](../vs140/icollectiononstlimpl-class.md)   
 [Collections and Enumerators](../vs140/atl-collections-and-enumerators.md)