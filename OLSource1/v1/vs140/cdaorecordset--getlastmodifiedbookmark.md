---
title: "CDaoRecordset::GetLastModifiedBookmark"
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
  - "CDaoRecordset::GetLastModifiedBookmark"
  - "GetLastModifiedBookmark"
  - "CDaoRecordset.GetLastModifiedBookmark"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, getting bookmarks"
  - "GetLastModifiedBookmark method"
  - "CDaoRecordset class, getting last modified bookmark"
ms.assetid: a7738bc3-a55c-47a1-abfc-ee25b79d8e3c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::GetLastModifiedBookmark
Call this member function to retrieve the bookmark of the most recently added or updated record.  
  
## Syntax  
  
```  
  
COleVariant GetLastModifiedBookmark( );  
  
```  
  
## Return Value  
 A `COleVariant` containing a bookmark that indicates the most recently added or changed record.  
  
## Remarks  
 When a recordset object is created or opened, each of its records already has a unique bookmark if it supports them. Call [GetBookmark](../vs140/cdaorecordset--getbookmark.md) to determine if the recordset supports bookmarks. If the recordset does not support bookmarks, a `CDaoException` is thrown.  
  
 When you add a record, it appears at the end of the recordset, and is not the current record. To make the new record current, call `GetLastModifiedBookmark` and then call `SetBookmark` to return to the newly added record.  
  
 For related information, see the topic "LastModified Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::GetBookmark](../vs140/cdaorecordset--getbookmark.md)   
 [CDaoRecordset::SetBookmark](../vs140/cdaorecordset--setbookmark.md)