---
title: "IOpenRowsetImpl Class"
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
  - IOpenRowsetImpl
dev_langs: 
  - C++
helpviewer_keywords: 
  - IOpenRowsetImpl class
ms.assetid: d259cedc-1db4-41cf-bc9f-5030907ab486
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IOpenRowsetImpl Class
Provides implementation for the `IOpenRowset` interface.  
  
## Syntax  
  
```  
template <class SessionClass>  
class IOpenRowsetImpl : public IOpenRowset  
```  
  
#### Parameters  
 `SessionClass`  
 Your class, derived from `IOpenRowsetImpl`.  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[CreateRowset](../vs140/iopenrowsetimpl--createrowset.md)|Creates a rowset object. Not called directly by user.|  
|[OpenRowset](../vs140/iopenrowsetimpl--openrowset.md)|Opens and returns a rowset that includes all rows from a single base table or index. (Not in ATLDB.H)|  
  
## Remarks  
 The [IOpenRowset](https://msdn.microsoft.com/en-us/library/ms716946.aspx) interface is mandatory for a session object. It opens and returns a rowset that includes all rows from a single base table or index.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)