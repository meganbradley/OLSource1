---
title: "CDaoRecordset::m_strFilter"
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
  - "CDaoRecordset.m_strFilter"
  - "CDaoRecordset::m_strFilter"
  - "m_strFilter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoRecordset class, filter"
  - "recordsets, filtering"
  - "m_strFilter"
ms.assetid: 9a139ff2-4ac9-427b-a2d8-a340ee45e41b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::m_strFilter
Contains a string that is used to construct the **WHERE** clause of a SQL statement.  
  
## Remarks  
 It does not include the reserved word **WHERE** to filter the recordset. The use of this data member is not applicable to table-type recordsets. The use of **m_strFilter** has no effect when opening a recordset using a `CDaoQueryDef` pointer.  
  
 Use the U.S. date format (month-day-year) when you filter fields containing dates, even if you are not using the U.S. version of the Microsoft Jet database engine; otherwise, the data may not be filtered as you expect.  
  
 For related information, see the topic "Filter Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::m_strSort](../vs140/cdaorecordset--m_strsort.md)