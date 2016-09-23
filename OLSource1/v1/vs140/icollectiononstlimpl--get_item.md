---
title: "ICollectionOnSTLImpl::get_Item"
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
  - get_Item
  - ATL.ICollectionOnSTLImpl.get_Item
  - ATL::ICollectionOnSTLImpl::get_Item
  - ICollectionOnSTLImpl.get_Item
  - ICollectionOnSTLImpl::get_Item
dev_langs: 
  - C++
helpviewer_keywords: 
  - get_Item method
ms.assetid: 2880117d-22b6-40d1-8299-cbba06281c84
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ICollectionOnSTLImpl::get_Item
This method returns the specified item from the collection.  
  
## Syntax  
  
```  
  
      STDMETHOD(get_Item)(  
   long Index,  
   ItemType* pvar   
);  
```  
  
#### Parameters  
 `Index`  
 [in] The 1-based index of an item in the collection.  
  
 `pvar`  
 [out] The item corresponding to `Index`.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The item is obtained by copying the data at the specified position in [m_coll](../vs140/icollectiononstlimpl--m_coll.md) using the copy method of the [copy policy class](../vs140/atl-copy-policy-classes.md) passed as a template argument in the `ICollectionOnSTLImpl` specialization.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [ICollectionOnSTLImpl Class](../vs140/icollectiononstlimpl-class.md)