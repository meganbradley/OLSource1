---
title: "CRecordset::m_strSort"
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
  - CRecordset::m_strSort
  - CRecordset.m_strSort
  - m_strSort
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_strSort
ms.assetid: 34dc533c-a670-4208-91a9-b63b38944d9c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRecordset::m_strSort
After you construct the recordset object, but before you call its **Open** member function, use this data member to store a `CString` containing a SQL **ORDER BY** clause.  
  
## Remarks  
 The recordset uses this string to sort the records it selects during the **Open** or **Requery** call. You can use this feature to sort a recordset on one or more columns. The ODBC SQL syntax for an **ORDER BY** clause is  
  
 `ORDER BY sort-specification [, sort-specification]...`  
  
 where a sort-specification is an integer or a column name. You can also specify ascending or descending order (the order is ascending by default) by appending "ASC" or "DESC" to the column list in the sort string. The selected records are sorted first by the first column listed, then by the second, and so on. For example, you might order a "Customers" recordset by last name, then first name. The number of columns you can list depends on the data source. For more information, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
 Note that you do not include the **ORDER BY** keyword in your string. The framework supplies it.  
  
 For more information about SQL clauses, see the article [SQL](../vs140/sql.md). For more information about sorting records, see the article [Recordset: Sorting Records (ODBC)](../vs140/recordset--sorting-records--odbc-.md).  
  
## Example  
 [!code[NVC_MFCDatabase#31](../vs140/codesnippet/CPP/crecordset--m_strsort_1.cpp)]
  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::m_strFilter](../vs140/crecordset--m_strfilter.md)   
 [CRecordset::Requery](../vs140/crecordset--requery.md)