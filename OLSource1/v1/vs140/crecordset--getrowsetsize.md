---
title: "CRecordset::GetRowsetSize"
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
  - "CRecordset::GetRowsetSize"
  - "GetRowsetSize"
  - "CRecordset.GetRowsetSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, rowsets"
  - "rowset size"
  - "GetRowSetSize method"
ms.assetid: 4c886140-d98b-4035-b3c5-5415cdffcb9f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::GetRowsetSize
Obtains the current setting for the number of rows you wish to retrieve during a given fetch.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The number of rows to retrieve during a given fetch.  
  
## Remarks  
 If you are using bulk row fetching, the default rowset size when the recordset is opened is 25; otherwise, it is 1.  
  
 To implement bulk row fetching, you must specify the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> option in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter of the [Open](../vs140/crecordset--open.md) member function. To change the setting for the rowset size, call [SetRowsetSize](../vs140/crecordset--setrowsetsize.md).  
  
 For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::Open](../vs140/crecordset--open.md)   
 [CRecordset::SetRowsetSize](../vs140/crecordset--setrowsetsize.md)   
 [CRecordset::CheckRowsetError](../vs140/crecordset--checkrowseterror.md)   
 [CRecordset::DoBulkFieldExchange](../vs140/crecordset--dobulkfieldexchange.md)