---
title: "CBulkRowset Class"
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
  - "ATL::CBulkRowset"
  - "ATL.CBulkRowset"
  - "ATL::CBulkRowset<TAccessor>"
  - "CBulkRowset"
  - "ATL.CBulkRowset<TAccessor>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CBulkRowset class"
ms.assetid: c6bde426-c543-4022-a98a-9519d9e2ae59
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBulkRowset Class
Fetches and manipulates rows to work on data in bulk by retrieving multiple row handles with a single call.  
  
## Syntax  
  
```  
template <class TAccessor>  
class CBulkRowset : public CRowset<TAccessor>  
```  
  
#### Parameters  
 `TAccessor`  
 An accessor class.  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[AddRefRows](../vs140/cbulkrowset--addrefrows.md)|Increments the reference count.|  
|[CBulkRowset](../vs140/cbulkrowset--cbulkrowset.md)|Constructor.|  
|[MoveFirst](../vs140/cbulkrowset--movefirst.md)|Retrieves the first row of data, performing a new bulk fetch if necessary.|  
|[MoveLast](../vs140/cbulkrowset--movelast.md)|Moves to the last row.|  
|[MoveNext](../vs140/cbulkrowset--movenext.md)|Retrieves the next row of data.|  
|[MovePrev](../vs140/cbulkrowset--moveprev.md)|Moves to the previous row.|  
|[MoveToBookmark](../vs140/cbulkrowset--movetobookmark.md)|Fetches the row marked by a bookmark or the row at a specified offset from that bookmark.|  
|[MoveToRatio](../vs140/cbulkrowset--movetoratio.md)|Fetches rows starting from a fractional position in the rowset.|  
|[ReleaseRows](../vs140/cbulkrowset--releaserows.md)|Sets the current row (**m_nCurrentRow**) to zero and releases all rows.|  
|[SetRows](../vs140/cbulkrowset--setrows.md)|Sets the number of row handles to be retrieved by one call.|  
  
## Example  
 The following example demonstrates use of the `CBulkRowset` class.  
  
 [!code[NVC_OLEDB_Consumer#1](../vs140/codesnippet/CPP/cbulkrowset-class_1.cpp)]  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [OLE DB Consumer Templates](../vs140/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../vs140/ole-db-consumer-templates-reference.md)