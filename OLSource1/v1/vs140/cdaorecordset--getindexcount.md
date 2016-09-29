---
title: "CDaoRecordset::GetIndexCount"
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
  - "GetIndexCount"
  - "CDaoRecordset.GetIndexCount"
  - "CDaoRecordset::GetIndexCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoRecordset class, getting index information"
  - "recordsets, getting index information"
  - "GetIndexCount method"
ms.assetid: 2a259785-64ed-49d2-9746-a6b88118d500
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::GetIndexCount
Call this member function to determine the number of indexes available on the table-type recordset.  
  
## Syntax  
  
```  
  
short GetIndexCount( );  
  
```  
  
## Return Value  
 The number of indexes in the table-type recordset.  
  
## Remarks  
 `GetIndexCount` is useful for looping through all indexes in the recordset. For that purpose, use `GetIndexCount` in conjunction with [GetIndexInfo](../vs140/cdaorecordset--getindexinfo.md). If you call this member function on dynaset-type or snapshot-type recordsets, MFC throws an exception.  
  
 For related information, see the topic "Attributes Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::GetFieldCount](../vs140/cdaorecordset--getfieldcount.md)   
 [CDaoRecordset::GetFieldInfo](../vs140/cdaorecordset--getfieldinfo.md)   
 [CDaoRecordset::GetIndexInfo](../vs140/cdaorecordset--getindexinfo.md)