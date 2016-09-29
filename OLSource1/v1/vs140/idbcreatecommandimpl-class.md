---
title: "IDBCreateCommandImpl Class"
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
  - "ATL::IDBCreateCommandImpl"
  - "IDBCreateCommandImpl"
  - "ATL.IDBCreateCommandImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDBCreateCommandImpl class"
ms.assetid: eac4755e-1668-42e1-958e-a35620c385ae
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDBCreateCommandImpl Class
Provides an implementation of the [IDBCreateCommand](https://msdn.microsoft.com/en-us/library/ms711625.aspx) interface.  
  
## Syntax  
  
```  
template <class T, class CommandClass >  
class ATL_NO_VTABLE IDBCreateCommandImpl   
   : public IDBCreateCommand  
```  
  
#### Parameters  
 `T`  
 The session object derived from `IDBCreateCommandImpl`.  
  
 `CommandClass`  
 Your command class.  
  
## Members  
  
### Interface Methods  
  
|||  
|-|-|  
|[CreateCommand](../vs140/idbcreatecommandimpl--createcommand.md)|Creates a new command.|  
  
## Remarks  
 An optional interface on the session object to obtain a new command.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)