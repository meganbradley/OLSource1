---
title: "CDaoRecordset::SetAbsolutePosition"
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
  - "CDaoRecordset::SetAbsolutePosition"
  - "CDaoRecordset.SetAbsolutePosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoRecordset class, setting absolute positions"
  - "recordsets, setting position"
  - "SetAbsolutePosition method, DAO recordsets"
ms.assetid: 33b5dfde-b254-4768-b865-8d721cb86add
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::SetAbsolutePosition
Sets the relative record number of a recordset object's current record.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *lPosition*  
 Corresponds to the ordinal position of the current record in the recordset.  
  
## Remarks  
 Calling <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> enables you to position the current record pointer to a specific record based on its ordinal position in a dynaset-type or snapshot-type recordset. You can also determine the current record number by calling [GetAbsolutePosition](../vs140/cdaorecordset--getabsoluteposition.md).  
  
> [!NOTE]
>  This member function is valid only for dynaset-type and snapshot-type recordsets.  
  
 The AbsolutePosition property value of the underlying DAO object is zero-based; a setting of 0 refers to the first record in the recordset. Setting a value greater than the number of populated records causes MFC to throw an exception. You can determine the number of populated records in the recordset by calling the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member function.  
  
 If the current record is deleted, the AbsolutePosition property value is not defined, and MFC throws an exception if it is referenced. New records are added to the end of the sequence.  
  
> [!NOTE]
>  This property is not intended to be used as a surrogate record number. Bookmarks are still the recommended way of retaining and returning to a given position and are the only way to position the current record across all types of recordset objects that support bookmarks. In particular, the position of a given record changes when record(s) preceding it are deleted. There is also no assurance that a given record will have the same absolute position if the recordset is re-created again because the order of individual records within a recordset is not guaranteed unless it is created with a SQL statement using an **ORDER BY** clause.  
  
 For related information, see the topic "AbsolutePosition Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::GetAbsolutePosition](../vs140/cdaorecordset--getabsoluteposition.md)