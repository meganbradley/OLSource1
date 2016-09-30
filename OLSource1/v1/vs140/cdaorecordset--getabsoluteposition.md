---
title: "CDaoRecordset::GetAbsolutePosition"
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
  - "GetAbsolutePosition"
  - "CDaoRecordset.GetAbsolutePosition"
  - "CDaoRecordset::GetAbsolutePosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoRecordset class, getting absolute position"
  - "recordsets, getting position"
  - "GetAbsolutePosition method"
ms.assetid: d3012d70-7179-4882-b79b-fab09c88a3de
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::GetAbsolutePosition
Returns the record number of a recordset object's current record.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 An integer from 0 to the number of records in the recordset. Corresponds to the ordinal position of the current record in the recordset.  
  
## Remarks  
 The AbsolutePosition property value of the underlying DAO object is zero-based; a setting of 0 refers to the first record in the recordset. You can determine the number of populated records in the recordset by calling [GetRecordCount](../vs140/cdaorecordset--getrecordcount.md). Calling <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> may take some time because it must access all records to determine the count.  
  
 If there is no current record, as when there are no records in the recordset, – 1 is returned. If the current record is deleted, the AbsolutePosition property value is not defined, and MFC throws an exception if it is referenced. For dynaset-type recordsets, new records are added to the end of the sequence.  
  
> [!NOTE]
>  This property is not intended to be used as a surrogate record number. Bookmarks are still the recommended way of retaining and returning to a given position and are the only way to position the current record across all types of recordset objects. In particular, the position of a given record changes when record(s) preceding it are deleted. There is also no assurance that a given record will have the same absolute position if the recordset is re-created again because the order of individual records within a recordset is not guaranteed unless it is created with a SQL statement using an **ORDER BY** clause.  
  
> [!NOTE]
>  This member function is valid only for dynaset-type and snapshot-type recordsets.  
  
 For related information, see the topic "AbsolutePosition Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::SetAbsolutePosition](../vs140/cdaorecordset--setabsoluteposition.md)