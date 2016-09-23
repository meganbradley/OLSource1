---
title: "CDaoRecordset::GetCurrentIndex"
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
  - CDaoRecordset.GetCurrentIndex
  - GetCurrentIndex
  - CDaoRecordset::GetCurrentIndex
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetCurrentIndex method
  - CDaoRecordset class, getting current index
  - recordsets, getting index information
ms.assetid: 4980bee1-426e-4131-ac23-afa2c9cad4ce
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoRecordset::GetCurrentIndex
Call this member function to determine the index currently in use in an indexed table-type `CDaoRecordset` object.  
  
## Syntax  
  
```  
  
CString GetCurrentIndex( );  
  
```  
  
## Return Value  
 A `CString` containing the name of the index currently in use with a table-type recordset. Returns an empty string if no index has been set.  
  
## Remarks  
 This index is the basis for ordering records in a table-type recordset, and is used by the [Seek](../vs140/cdaorecordset--seek.md) member function to locate records.  
  
 A `CDaoRecordset` object can have more than one index but can use only one index at a time (although a [CDaoTableDef](../vs140/cdaotabledef-class.md) object may have several indexes defined on it).  
  
 For related information, see the topic "Index Object" and the definition "current index" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::SetCurrentIndex](../vs140/cdaorecordset--setcurrentindex.md)