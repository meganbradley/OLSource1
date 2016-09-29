---
title: "IRowsetIdentityImpl Class"
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
  - "ATL::IRowsetIdentityImpl"
  - "ATL.IRowsetIdentityImpl"
  - "IRowsetIdentityImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IRowsetIdentityImpl class"
ms.assetid: 56821edf-e045-40c8-96bd-231552cd5799
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IRowsetIdentityImpl Class
Implements the OLE DB [IRowsetIdentity](https://msdn.microsoft.com/en-us/library/ms715913.aspx) interface, which enables testing for row identity.  
  
## Syntax  
  
```  
template <class T, class RowClass = CSimpleRow>  
class ATL_NO_VTABLE IRowsetIdentityImpl   
   : public IRowsetIdentity  
```  
  
#### Parameters  
 `T`  
 A class derived from `IRowsetIdentityImpl`.  
  
 `RowClass`  
 The storage unit for the **HROW**.  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[IsSameRow](../vs140/irowsetidentityimpl--issamerow.md)|Compares two row handles to see if they refer to the same row.|  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)