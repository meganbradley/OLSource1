---
title: "CDaoRecordset::MovePrev"
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
  - MovePrev
  - CDaoRecordset.MovePrev
  - CDaoRecordset::MovePrev
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDaoRecordset class, moving in
  - MovePrev method
  - recordsets, moving to records
ms.assetid: c61b12df-7726-439c-b34e-d9637dd038e9
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoRecordset::MovePrev
Call this member function to make the previous record in the recordset the current record.  
  
## Syntax  
  
```  
  
void MovePrev( );  
  
```  
  
## Remarks  
 It is recommended that you call `IsBOF` before you attempt to move to the previous record. A call to `MovePrev` will throw a `CDaoException` if `IsBOF` returns nonzero, indicating either that you have already scrolled before the first record or that no records were selected by the recordset.  
  
> [!CAUTION]
>  Calling any of the **Move** functions throws an exception if the recordset has no records. In general, call both `IsBOF` and `IsEOF` before a Move operation to determine whether the recordset has any records. After you call **Open** or **Requery**, call either `IsBOF` or `IsEOF`.  
  
> [!NOTE]
>  If you call any of the **Move** functions while the current record is being updated or added, the updates are lost without warning.  
  
 Use the **Move** functions to move from record to record without applying a condition. Use the Find operations to locate records in a dynaset-type or snapshot-type recordset object that satisfy a certain condition. To locate a record in a table-type recordset object, call `Seek`.  
  
 If the recordset refers to a table-type recordset, movement follows the table's current index. You can set the current index by using the Index property of the underlying DAO object. If you do not set the current index, the order of returned records is undefined.  
  
 You cannot call the **MoveFirst** or `MovePrev` member function with a forward-only scrolling snapshot.  
  
 To move the position of the current record in a recordset object a specific number of records forward or backward, call **Move**.  
  
 For related information, see the topics "Move Method" and "MoveFirst, MoveLast, MoveNext, MovePrevious Methods" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::Move](../vs140/cdaorecordset--move.md)   
 [CDaoRecordset::MoveFirst](../vs140/cdaorecordset--movefirst.md)   
 [CDaoRecordset::MoveLast](../vs140/cdaorecordset--movelast.md)   
 [CDaoRecordset::MoveNext](../vs140/cdaorecordset--movenext.md)