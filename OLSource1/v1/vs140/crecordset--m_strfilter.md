---
title: "CRecordset::m_strFilter"
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
  - CRecordset::m_strFilter
  - CRecordset.m_strFilter
  - m_strFilter
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_strFilter
ms.assetid: d483ec4f-2dd1-4544-9eca-1c3df2228df4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRecordset::m_strFilter
After you construct the recordset object, but before you call its **Open** member function, use this data member to store a `CString` containing a SQL **WHERE** clause.  
  
## Remarks  
 The recordset uses this string to constrain (or filter) the records it selects during the **Open** or **Requery** call. This is useful for selecting a subset of records, such as "all salespersons based in California" ("state = CA"). The ODBC SQL syntax for a **WHERE** clause is  
  
 `WHERE search-condition`  
  
 Note that you do not include the **WHERE** keyword in your string. The framework supplies it.  
  
 You can also parameterize your filter string by placing '?' placeholders in it, declaring a parameter data member in your class for each placeholder, and passing parameters to the recordset at run time. This lets you construct the filter at run time. For more information, see the article [Recordset: Parameterizing a Recordset (ODBC)](../vs140/recordset--parameterizing-a-recordset--odbc-.md).  
  
 For more information about SQL **WHERE** clauses, see the article [SQL](../vs140/sql.md). For more information about selecting and filtering records, see the article [Recordset: Filtering Records (ODBC)](../vs140/recordset--filtering-records--odbc-.md).  
  
## Example  
 [!code[NVC_MFCDatabase#30](../vs140/codesnippet/CPP/crecordset--m_strfilter_1.cpp)]
  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::m_strSort](../vs140/crecordset--m_strsort.md)   
 [CRecordset::Requery](../vs140/crecordset--requery.md)