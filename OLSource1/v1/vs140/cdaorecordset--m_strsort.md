---
title: "CDaoRecordset::m_strSort"
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
  - "CDaoRecordset::m_strSort"
  - "CDaoRecordset.m_strSort"
  - "m_strSort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sorting data, recordset data"
  - "CDaoRecordset class, sort"
  - "recordsets, sorting"
  - "m_strSort"
ms.assetid: 388573bc-8d83-43a5-b986-6990057bf096
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::m_strSort
Contains a string containing the **ORDER BY** clause of a SQL statement without the reserved words **ORDER BY**.  
  
## Remarks  
 You can sort on dynaset- and snapshot-type recordset objects.  
  
 You cannot sort table-type recordset objects. To determine the sort order of a table-type recordset, call [SetCurrentIndex](../vs140/cdaorecordset--setcurrentindex.md).  
  
 The use of `m_strSort` has no effect when opening a recordset using a `CDaoQueryDef` pointer.  
  
 For related information, see the topic "Sort Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::m_strFilter](../vs140/cdaorecordset--m_strfilter.md)