---
title: "CRecordset::GetTableName"
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
  - GetTableName
  - CRecordset::GetTableName
  - CRecordset.GetTableName
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetTableName method
ms.assetid: bad46137-66e6-4487-9444-a238996e0b7f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRecordset::GetTableName
Gets the name of the SQL table on which the recordset's query is based.  
  
## Syntax  
  
```  
  
const CString& GetTableName( ) const;  
```  
  
## Return Value  
 A **const** reference to a `CString` that contains the table name, if the recordset is based on a table; otherwise, an empty string.  
  
## Remarks  
 `GetTableName` is only valid if the recordset is based on a table, not a join of multiple tables or a predefined query (stored procedure). The name is read-only.  
  
> [!NOTE]
>  Call this member function only after calling [Open](../vs140/crecordset--open.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)