---
title: "CRecordset::Move"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CRecordset::Move"
  - "SQL_FETCH_RELATIVE"
  - "SQL_FETCH_BOOKMARK"
  - "SQL_FETCH_NEXT"
  - "SQL_FETCH_LAST"
  - "CRecordset.Move"
  - "SQL_FETCH_FIRST"
  - "SQL_FETCH_PRIOR"
  - "SQL_FETCH_ABSOLUTE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SQL_FETCH_RELATIVE"
  - "SQL_FETCH_PRIOR"
  - "SQL_FETCH_NEXT"
  - "SQL_FETCH_FIRST"
  - "SQL_FETCH_BOOKMARK"
  - "Move method (recordsets)"
  - "SQL_FETCH_ABSOLUTE"
  - "SQL_FETCH_LAST"
ms.assetid: 2823a210-69f6-4f0a-a0fa-c2d5a98f0860
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::Move
Moves the current record pointer within the recordset, either forward or backward.  
  
## Syntax  
  
```  
  
      virtual void Move(   
   long nRows,   
   WORD wFetchType = SQL_FETCH_RELATIVE    
);  
```  
  
#### Parameters  
 `nRows`  
 The number of rows to move forward or backward. Positive values move forward, toward the end of the recordset. Negative values move backward, toward the beginning.  
  
 `wFetchType`  
 Determines the rowset that **Move** will fetch. For details, see Remarks.  
  
## Remarks  
 If you pass a value of 0 for `nRows`, **Move** refreshes the current record; **Move** will end any current `AddNew` or **Edit** mode, and will restore the current record's value before `AddNew` or **Edit** was called.  
  
> [!NOTE]
>  When you move through a recordset, you cannot skip deleted records. See [CRecordset::IsDeleted](../vs140/crecordset--isdeleted.md) for more information. When you open a `CRecordset` with the **skipDeletedRecords** option set, **Move** asserts if the `nRows` parameter is 0. This behavior prevents the refresh of rows that are deleted by other client applications using the same data. See the `dwOption` parameter in [Open](../vs140/crecordset--open.md) for a description of **skipDeletedRecords**.  
  
 **Move** repositions the recordset by rowsets. Based on the values for `nRows` and `wFetchType`, **Move** fetches the appropriate rowset and then makes the first record in that rowset the current record. If you have not implemented bulk row fetching, then the rowset size is always 1. When fetching a rowset, **Move** directly calls the [CheckRowsetError](../vs140/crecordset--checkrowseterror.md) member function to handle any errors resulting from the fetch.  
  
 Depending on the values you pass, **Move** is equivalent to other `CRecordset` member functions. In particular, the value of `wFetchType` may indicate a member function that is more intuitive and often the preferred method for moving the current record.  
  
 The following table lists the possible values for `wFetchType`, the rowset that **Move** will fetch based on `wFetchType` and `nRows`, and any equivalent member function corresponding to `wFetchType`.  
  
|wFetchType|Fetched rowset|Equivalent member function|  
|----------------|--------------------|--------------------------------|  
|`SQL_FETCH_RELATIVE` (the default value)|The rowset starting `nRows` row(s) from the first row in the current rowset.||  
|`SQL_FETCH_NEXT`|The next rowset; `nRows` is ignored.|[MoveNext](../vs140/crecordset--movenext.md)|  
|`SQL_FETCH_PRIOR`|The previous rowset; `nRows` is ignored.|[MovePrev](../vs140/crecordset--moveprev.md)|  
|`SQL_FETCH_FIRST`|The first rowset in the recordset; `nRows` is ignored.|[MoveFirst](../vs140/crecordset--movefirst.md)|  
|`SQL_FETCH_LAST`|The last complete rowset in the recordset; `nRows` is ignored.|[MoveLast](../vs140/crecordset--movelast.md)|  
|`SQL_FETCH_ABSOLUTE`|If `nRows` > 0, the rowset starting `nRows` row(s) from the beginning of the recordset. If `nRows` < 0, the rowset starting `nRows` row(s) from the end of the recordset. If `nRows` = 0, then a beginning-of-file (BOF) condition is returned.|[SetAbsolutePosition](../vs140/crecordset--setabsoluteposition.md)|  
|`SQL_FETCH_BOOKMARK`|The rowset starting at the row whose bookmark value corresponds to `nRows`.|[SetBookmark](../vs140/crecordset--setbookmark.md)|  
  
> [!NOTE]
>  For foward-only recordsets, **Move** is only valid with a value of `SQL_FETCH_NEXT` for `wFetchType`.  
  
> [!CAUTION]
>  Calling **Move** throws an exception if the recordset has no records. To determine whether the recordset has any records, call [IsBOF](../vs140/crecordset--isbof.md) and [IsEOF](../vs140/crecordset--iseof.md).  
  
> [!NOTE]
>  If you have scrolled past the beginning or end of the recordset (`IsBOF` or `IsEOF` returns nonzero), calling a **Move** function will possibly throw a `CDBException`. For example, if `IsEOF` returns nonzero and `IsBOF` does not, then `MoveNext` will throw an exception, but `MovePrev` will not.  
  
> [!NOTE]
>  If you call **Move** while the current record is being updated or added, the updates are lost without warning.  
  
 For more information about recordset navigation, see the articles [Recordset: Scrolling (ODBC)](../vs140/recordset--scrolling--odbc-.md) and [Recordset: Bookmarks and Absolute Positions (ODBC)](../vs140/recordset--bookmarks-and-absolute-positions--odbc-.md). For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md). For related information, see the ODBC API function **SQLExtendedFetch** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Exceptions  
 This method can throw exceptions of type **CDBException\*** and `CMemoryException*`.  
  
## Example  
 [!code[NVC_MFCDatabase#28](../vs140/codesnippet/CPP/crecordset--move_1.cpp)]  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::MoveNext](../vs140/crecordset--movenext.md)   
 [CRecordset::MovePrev](../vs140/crecordset--moveprev.md)   
 [CRecordset::MoveFirst](../vs140/crecordset--movefirst.md)   
 [CRecordset::MoveLast](../vs140/crecordset--movelast.md)   
 [CRecordset::SetAbsolutePosition](../vs140/crecordset--setabsoluteposition.md)   
 [CRecordset::SetBookmark](../vs140/crecordset--setbookmark.md)   
 [CRecordset::IsBOF](../vs140/crecordset--isbof.md)   
 [CRecordset::IsEOF](../vs140/crecordset--iseof.md)   
 [CRecordset::CheckRowsetError](../vs140/crecordset--checkrowseterror.md)