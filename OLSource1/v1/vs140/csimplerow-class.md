---
title: "CSimpleRow Class"
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
  - "CSimpleRow"
  - "ATL::CSimpleRow"
  - "ATL.CSimpleRow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSimpleRow class"
ms.assetid: 06d9621d-60cc-4508-8b0c-528d1b1a809b
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleRow Class
Provides a default implementation for the row handle, which is used in the [IRowsetImpl](../vs140/irowsetimpl-class.md) class.  
  
## Syntax  
  
```  
class CSimpleRow  
```  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[AddRefRow](../vs140/csimplerow--addrefrow.md)|Adds a reference count to an existing row handle.|  
|[Compare](../vs140/csimplerow--compare.md)|Compares two rows to see if they refer to the same row instance.|  
|[CSimpleRow](../vs140/csimplerow--csimplerow.md)|The constructor.|  
|[ReleaseRow](../vs140/csimplerow--releaserow.md)|Releases rows.|  
  
### Data Members  
  
|||  
|-|-|  
|[m_dwRef](../vs140/csimplerow--m_dwref.md)|Reference count to an existing row handle.|  
|[m_iRowset](../vs140/csimplerow--m_irowset.md)|An index to the rowset representing the cursor.|  
  
## Remarks  
 A row handle is logically a unique tag for a result row. `IRowsetImpl` creates a new `CSimpleRow` for every row requested in [IRowsetImpl::GetNextRows](../vs140/irowsetimpl--getnextrows.md). `CSimpleRow` can also be replaced with your own implementation of the row handle, as it is a default template argument to `IRowsetImpl`. The only requirement to replacing this class is to have the replacement class provide a constructor that accepts a single parameter of type **LONG**.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)   
 [IRowsetImpl Class](../vs140/irowsetimpl-class.md)