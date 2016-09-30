---
title: "IDBInitializeImpl::m_dwStatus"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ATL::IDBInitializeImpl::m_dwStatus"
  - "IDBInitializeImpl.m_dwStatus"
  - "ATL.IDBInitializeImpl.m_dwStatus"
  - "IDBInitializeImpl::m_dwStatus"
  - "IDBInitializeImpl<T>::m_dwStatus"
  - "ATL.IDBInitializeImpl<T>.m_dwStatus"
  - "ATL::IDBInitializeImpl<T>::m_dwStatus"
  - "m_dwStatus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_dwStatus"
ms.assetid: 7621ccff-ca60-4b75-9c6a-c104bd0e2038
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDBInitializeImpl::m_dwStatus
Data source flags.  
  
## Syntax  
  
```  
  
DWORD m_dwStatus;  
  
```  
  
## Remarks  
 These flags specify or indicate the status of various attributes for the data source object. Contains one or more of the following `enum` values:  
  
 `enum DATASOURCE_FLAGS {`  
  
 `DSF_MASK_INIT     = 0xFFFFF00F,`  
  
 `DSF_PERSIST_DIRTY = 0x00000001,`  
  
 `DSF_INITIALIZED   = 0x00000010,`  
  
 `};`  
  
|||  
|-|-|  
|**DSF_MASK_INIT**|A mask to enable restoration of the uninitialized state.|  
|**DSF_PERSIST_DIRTY**|Set if data source object requires persistence (that is, if there have been changes).|  
|**DSF_INITIALIZED**|Set if data source has been initialized.|  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IDBInitializeImpl Class](../vs140/idbinitializeimpl-class.md)   
 [IDBInitializeImpl::IDBInitializeImpl](../vs140/idbinitializeimpl--idbinitializeimpl.md)   
 [IDBInitializeImpl::Uninitialize](../vs140/idbinitializeimpl--uninitialize.md)