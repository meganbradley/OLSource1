---
title: "CRecordset::GetRowsFetched"
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
  - "CRecordset::GetRowsFetched"
  - "CRecordset.GetRowsFetched"
  - "GetRowsFetched"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bulk row fetching, retrieving records"
  - "GetRowsFetched method"
  - "rowsets, retrieving records"
ms.assetid: e2a02a81-c11d-4003-823b-21ac6d1f3b57
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::GetRowsFetched
Determines how many records were actually retrieved after a fetch.  
  
## Syntax  
  
```  
  
DWORD GetRowsFetched( ) const;  
  
```  
  
## Return Value  
 The number of rows retrieved from the data source after a given fetch.  
  
## Remarks  
 This is useful when you have implemented bulk row fetching. The rowset size normally indicates how many rows will be retrieved from a fetch; however, the total number of rows in the recordset also affects how many rows will be retrieved in a rowset. For example, if your recordset has 10 records with a rowset size setting of 4, then looping through the recordset by calling `MoveNext` will result in the final rowset having only 2 records.  
  
 To implement bulk row fetching, you must specify the `CRecordset::useMultiRowFetch` option in the `dwOptions` parameter of the [Open](../vs140/crecordset--open.md) member function. To specify the rowset size, call [SetRowsetSize](../vs140/crecordset--setrowsetsize.md).  
  
 For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
## Example  
 [!code[NVC_MFCDatabase#24](../vs140/codesnippet/CPP/crecordset--getrowsfetched_1.cpp)]  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::SetRowsetSize](../vs140/crecordset--setrowsetsize.md)   
 [CRecordset::CheckRowsetError](../vs140/crecordset--checkrowseterror.md)