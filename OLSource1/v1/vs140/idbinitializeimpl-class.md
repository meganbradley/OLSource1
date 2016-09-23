---
title: "IDBInitializeImpl Class"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - ATL.IDBInitializeImpl<T>
  - ATL::IDBInitializeImpl<T>
  - IDBInitializeImpl
  - ATL::IDBInitializeImpl
  - ATL.IDBInitializeImpl
dev_langs: 
  - C++
helpviewer_keywords: 
  - IDBInitializeImpl class
ms.assetid: e4182f81-0443-44f5-a0d3-e7e075d6f883
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IDBInitializeImpl Class
Provides an implementation for the [IDBInitialize](https://msdn.microsoft.com/en-us/library/ms713706.aspx) interface.  
  
## Syntax  
  
```  
template <class T>  
class ATL_NO_VTABLE IDBInitializeImpl : public IDBInitialize  
```  
  
#### Parameters  
 `T`  
 Your class, derived from `IDBInitializeImpl`.  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[IDBInitializeImpl](../vs140/idbinitializeimpl--idbinitializeimpl.md)|The constructor.|  
  
### Interface Methods  
  
|||  
|-|-|  
|[Initialize](../vs140/idbinitializeimpl--initialize.md)|Starts the provider.|  
|[Uninitialize](../vs140/idbinitializeimpl--uninitialize.md)|Stops the provider.|  
  
### Data Members  
  
|||  
|-|-|  
|[m_dwStatus](../vs140/idbinitializeimpl--m_dwstatus.md)|Data source flags.|  
|[m_pCUtlPropInfo](../vs140/idbinitializeimpl--m_pcutlpropinfo.md)|A pointer to implementation of DB Properties information.|  
  
## Remarks  
 A mandatory interface on data source objects and optional interface on enumerators.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)