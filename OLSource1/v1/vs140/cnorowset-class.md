---
title: "CNoRowset Class"
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
  - "ATL.CNoRowset"
  - "ATL::CNoRowset<TAccessor>"
  - "CNoRowset"
  - "ATL.CNoRowset<TAccessor>"
  - "ATL::CNoRowset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CNoRowset class"
ms.assetid: 55c6c7a4-9e3a-4775-a2dd-c8b333012fa6
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CNoRowset Class
Can be used as a template argument (`TRowset`) for [CCommand](../vs140/ccommand-class.md) or [CTable](../vs140/ctable-class.md).  
  
## Syntax  
  
```  
template <class TAccessor = CAccessorBase>  
class CNoRowset  
```  
  
#### Parameters  
 `TAccessor`  
 An accessor class. The default is `CAccessorBase`.  
  
## Remarks  
 Use `CNoRowset` as a template argument if the command does not return a rowset.  
  
 `CNoRowset` implements the following stub methods, each of which correspond to other accessor class methods:  
  
-   **BindFinished** - Indicates when binding is complete (returns `S_OK`).  
  
-   **Close** - Releases rows and the current IRowset interface.  
  
-   `GetIID` - Retrieves the interface ID of a connection point.  
  
-   **GetInterface** - Retrieves an interface.  
  
-   `GetInterfacePtr` - Retrieves an encapsulated interface pointer.  
  
-   **SetAccessor** - Sets a pointer to the accessor.  
  
-   **SetupOptionalRowsetInterfaces** - Sets up optional interfaces for the rowset.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [OLE DB Consumer Templates](../vs140/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../vs140/ole-db-consumer-templates-reference.md)