---
title: "CDaoRecordset::IsDeleted"
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
  - "CDaoRecordset::IsDeleted"
  - "IsDeleted"
  - "CDaoRecordset.IsDeleted"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoRecordset class, deleted records"
  - "IsDeleted method"
  - "recordsets, deleting records"
ms.assetid: 82cd3d7e-a93b-444a-a745-ed9efca322b8
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::IsDeleted
Call this member function to determine whether the current record has been deleted.  
  
## Syntax  
  
```  
  
BOOL IsDeleted( ) const;  
  
```  
  
## Return Value  
 Nonzero if the recordset is positioned on a deleted record; otherwise 0.  
  
## Remarks  
 If you scroll to a record and `IsDeleted` returns **TRUE** (nonzero), then you must scroll to another record before you can perform any other recordset operations.  
  
> [!NOTE]
>  You don't need to check the deleted status for records in a snapshot or table-type recordset. Because records cannot be deleted from a snapshot, there is no need to call `IsDeleted`. For table-type recordsets, deleted records are actually removed from the recordset. Once a record has been deleted, either by you, another user, or in another recordset, you cannot scroll back to that record. Therefore, there is no need to call `IsDeleted`.  
  
 When you delete a record from a dynaset, it is removed from the recordset and you cannot scroll back to that record. However, if a record in a dynaset is deleted either by another user or in another recordset based on the same table, `IsDeleted` will return **TRUE** when you later scroll to that record.  
  
 For related information, see the topics "Delete Method", "LastModified Property", and "EditMode Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::Delete](../vs140/cdaorecordset--delete.md)   
 [CDaoRecordset::IsBOF](../vs140/cdaorecordset--isbof.md)   
 [CDaoRecordset::IsEOF](../vs140/cdaorecordset--iseof.md)