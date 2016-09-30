---
title: "CRowset Class"
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
  - "ATL.CRowset<TAccessor>"
  - "CRowset"
  - "ATL::CRowset"
  - "ATL::CRowset<TAccessor>"
  - "ATL.CRowset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRowset class"
ms.assetid: b0228a90-b8dd-47cc-b397-8d4c15c1e7f4
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRowset Class
Encapsulates an OLE DB rowset object and several related interfaces and provides manipulation methods for rowset data.  
  
## Syntax  
  
```  
template <class TAccessor = CAccessorBase>  
class CRowset  
```  
  
#### Parameters  
 `TAccessor`  
 An accessor class. The default is `CAccessorBase`.  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[AddRefRows](../vs140/crowset--addrefrows.md)|Increments the reference count associated with the current row.|  
|[Close](../vs140/crowset--close.md)|Releases rows and the current `IRowset` interface.|  
|[Compare](../vs140/crowset--compare.md)|Compares two bookmarks using [IRowsetLocate::Compare](https://msdn.microsoft.com/en-us/library/ms709539.aspx).|  
|[CRowset](../vs140/crowset--crowset.md)|Creates a new `CRowset` object and (optionally) associates it with an **IRowset** interface supplied as a parameter.|  
|[Delete](../vs140/crowset--delete.md)|Deletes rows from the rowset using [IRowsetChange:DeleteRows](https://msdn.microsoft.com/en-us/library/ms724362.aspx).|  
|[FindNextRow](../vs140/crowset--findnextrow.md)|Finds the next matching row after the specified bookmark.|  
|[GetApproximatePosition](../vs140/crowset--getapproximateposition.md)|Returns the approximate position of a row corresponding to a bookmark.|  
|[GetData](../vs140/crowset--getdata.md)|Retrieves data from the rowset's copy of the row.|  
|[GetDataHere](../vs140/crowset--getdatahere.md)|Retrieves data from the specified buffer.|  
|[GetOriginalData](../vs140/crowset--getoriginaldata.md)|Retrieves the data most recently fetched from or transmitted to the data source, ignoring pending changes.|  
|[GetRowStatus](../vs140/crowset--getrowstatus.md)|Returns the status of all rows.|  
|[Insert](../vs140/crowset--insert.md)|Creates and inserts a new row using [IRowsetChange:InsertRow](https://msdn.microsoft.com/en-us/library/ms716921.aspx).|  
|[IsSameRow](../vs140/crowset--issamerow.md)|Compares the specified row with the current row.|  
|[MoveFirst](../vs140/crowset--movefirst.md)|Repositions the next-fetch location to the initial position.|  
|[MoveLast](../vs140/crowset--movelast.md)|Moves to the last record.|  
|[MoveNext](../vs140/crowset--movenext.md)|Fetches data from the next sequential row or a specified number of positions beyond the next row.|  
|[MovePrev](../vs140/crowset--moveprev.md)|Moves to the previous record.|  
|[MoveToBookmark](../vs140/crowset--movetobookmark.md)|Fetches the row marked by a bookmark or the row at a specified offset from that bookmark.|  
|[MoveToRatio](../vs140/crowset--movetoratio.md)|Fetches rows starting from a fractional position in the rowset.|  
|[ReleaseRows](../vs140/crowset--releaserows.md)|Calls [IRowset::ReleaseRows](https://msdn.microsoft.com/en-us/library/ms719771.aspx) to release the current row handle.|  
|[SetData](../vs140/crowset--setdata.md)|Sets data values in one or more columns of a row using [IRowsetChange:SetData](https://msdn.microsoft.com/en-us/library/ms721232.aspx).|  
|[Undo](../vs140/crowset--undo.md)|Undoes any changes made to a row since the last fetch or [Update](../vs140/crowset--update.md).|  
|[Update](../vs140/crowset--update.md)|Transmits any pending changes made to the current row since the last fetch or update.|  
|[UpdateAll](../vs140/crowset--updateall.md)|Transmits any pending changes made to all rows since the last fetch or update.|  
  
## Remarks  
 In OLE DB, a rowset is the object through which a program sets and retrieves data.  
  
 This class is not meant to be instantiated but rather passed as a template parameter to `CTable` or `CCommand` (`CRowset` is the default).  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [DBViewer Sample](../vs140/visual-c---samples.md)   
 [MultiRead Sample](../vs140/visual-c---samples.md)   
 [MultiRead Attributes Sample](../vs140/visual-c---samples.md)   
 [OLE DB Consumer Templates](../vs140/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../vs140/ole-db-consumer-templates-reference.md)