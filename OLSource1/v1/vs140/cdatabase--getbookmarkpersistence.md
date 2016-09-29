---
title: "CDatabase::GetBookmarkPersistence"
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
  - "SQL_BP_DELETE"
  - "SQL_BP_CLOSE"
  - "GetBookmarkPersistence"
  - "SQL_BP_TRANSACTION"
  - "SQL_BP_DROP"
  - "CDatabase.GetBookmarkPersistence"
  - "SQL_BP_UPDATE"
  - "SQL_BP_OTHER_HSTMT"
  - "CDatabase::GetBookmarkPersistence"
  - "SQL_BP_SCROLL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bookmarks, persistence"
  - "SQL_BP_SCROLL"
  - "SQL_BP_DELETE"
  - "SQL_BP_UPDATE"
  - "SQL_BP_DROP"
  - "GetBookmarkPersistence method"
  - "SQL_BP_TRANSACTION"
  - "SQL_BP_CLOSE"
  - "SQL_BP_OTHER_HSTMT"
ms.assetid: 568db51f-b026-4b73-944f-835ca9e6cecd
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDatabase::GetBookmarkPersistence
Call this member function to determine the persistence of bookmarks on a recordset object after certain operations.  
  
## Syntax  
  
```  
  
DWORD GetBookmarkPersistence( ) const;  
  
```  
  
## Return Value  
 A bitmask that identifies the operations through which bookmarks persist on a recordset object. For details, see Remarks.  
  
## Remarks  
 For example, if you call `CRecordset::GetBookmark` and then call `CRecordset::Requery`, the bookmark obtained from `GetBookmark` may no longer be valid. You should call `GetBookmarkPersistence` before calling `CRecordset::SetBookmark`.  
  
 The following table lists the bitmask values that can be combined for the return value of `GetBookmarkPersistence`.  
  
|Bitmask value|Bookmark persistence|  
|-------------------|--------------------------|  
|`SQL_BP_CLOSE`|Bookmarks are valid after a **Requery** operation.|  
|`SQL_BP_DELETE`|The bookmark for a row is valid after a **Delete** operation on that row.|  
|`SQL_BP_DROP`|Bookmarks are valid after a **Close** operation.|  
|`SQL_BP_SCROLL`|Bookmarks are valid after any **Move** operation. This simply identifies if bookmarks are supported on the recordset, as returned by `CRecordset::CanBookmark`.|  
|`SQL_BP_TRANSACTION`|Bookmarks are valid after a transaction is committed or rolled back.|  
|`SQL_BP_UPDATE`|The bookmark for a row is valid after an **Update** operation on that row.|  
|`SQL_BP_OTHER_HSTMT`|Bookmarks associated with one recordset object are valid on a second recordset.|  
  
 For more information about this return value, see the ODBC API function **SQLGetInfo** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information about bookmarks, see the article [Recordset: Bookmarks and Absolute Positions (ODBC)](../vs140/recordset--bookmarks-and-absolute-positions--odbc-.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDatabase Class](../vs140/cdatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset Class](../vs140/crecordset-class.md)   
 [CRecordset::CanBookmark](../vs140/crecordset--canbookmark.md)   
 [CRecordset::GetBookmark](../vs140/crecordset--getbookmark.md)   
 [CRecordset::SetBookmark](../vs140/crecordset--setbookmark.md)