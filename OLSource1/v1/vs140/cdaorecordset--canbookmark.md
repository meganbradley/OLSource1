---
title: "CDaoRecordset::CanBookmark"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CDaoRecordset::CanBookmark
  - CDaoRecordset.CanBookmark
  - CanBookmark
dev_langs: 
  - C++
helpviewer_keywords: 
  - recordsets, bookmarks
  - CDaoRecordset class, bookmarking records
  - DAO recordsets, bookmarks
  - bookmarks, recordsets
  - DAO recordsets
  - CanBookmark method
ms.assetid: e8c8bcd0-aa84-4b1e-84dd-5186605dcf59
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoRecordset::CanBookmark
Call this member function to determine whether the previously opened recordset allows you to individually mark records using bookmarks.  
  
## Syntax  
  
```  
  
BOOL CanBookmark( );  
  
```  
  
## Return Value  
 Nonzero if the recordset supports bookmarks, otherwise 0.  
  
## Remarks  
 If you are using recordsets based entirely on Microsoft Jet database engine tables, bookmarks can be used except on snapshot-type recordsets flagged as forward-only scrolling recordsets. Other database products (external ODBC data sources) may not support bookmarks.  
  
 For related information, see the topic "Bookmarkable Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::CanAppend](../vs140/cdaorecordset--canappend.md)   
 [CDaoRecordset::CanRestart](../vs140/cdaorecordset--canrestart.md)   
 [CDaoRecordset::CanScroll](../vs140/cdaorecordset--canscroll.md)   
 [CDaoRecordset::CanTransact](../vs140/cdaorecordset--cantransact.md)   
 [CDaoRecordset::CanUpdate](../vs140/cdaorecordset--canupdate.md)