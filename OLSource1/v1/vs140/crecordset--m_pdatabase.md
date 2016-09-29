---
title: "CRecordset::m_pDatabase"
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
  - "m_pDatabase"
  - "CRecordset::m_pDatabase"
  - "CRecordset.m_pDatabase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pDatabase"
ms.assetid: bb4a5049-6be0-47bf-b430-5a316a597b92
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::m_pDatabase
Contains a pointer to the `CDatabase` object through which the recordset is connected to a data source.  
  
## Remarks  
 This variable is set in two ways. Typically, you pass a pointer to an already connected `CDatabase` object when you construct the recordset object. If you pass **NULL** instead, `CRecordset` creates a `CDatabase` object for you and connects it. In either case, `CRecordset` stores the pointer in this variable.  
  
 Normally you will not directly need to use the pointer stored in **m_pDatabase**. If you write your own extensions to `CRecordset`, however, you might need to use the pointer. For example, you might need the pointer if you throw your own `CDBException`s. Or you might need it if you need to do something using the same `CDatabase` object, such as running transactions, setting timeouts, or calling the `ExecuteSQL` member function of class `CDatabase` to execute SQL statements directly.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)