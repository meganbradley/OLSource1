---
title: "CRecordset::m_hstmt"
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
  - "m_hstmt"
  - "CRecordset.m_hstmt"
  - "CRecordset::m_hstmt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_hstmt"
ms.assetid: adf94cf5-3a7c-4176-a411-e36892806643
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::m_hstmt
Contains a handle to the ODBC statement data structure, of type **HSTMT**, associated with the recordset.  
  
## Remarks  
 Each query to an ODBC data source is associated with an **HSTMT**.  
  
> [!CAUTION]
>  Do not use **m_hstmt** before [Open](../vs140/crecordset--open.md) has been called.  
  
 Normally you do not need to access the **HSTMT** directly, but you might need it for direct execution of SQL statements. The `ExecuteSQL` member function of class `CDatabase` provides an example of using **m_hstmt**.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase::ExecuteSQL](../vs140/cdatabase--executesql.md)