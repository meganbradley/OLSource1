---
title: "CDaoRecordset::Move"
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
  - CDaoRecordset.Move
  - CDaoRecordset::Move
dev_langs: 
  - C++
helpviewer_keywords: 
  - Move method (recordsets)
  - CDaoRecordset class, moving in
  - recordsets, moving to records
ms.assetid: cb9b0f01-ff6c-40d3-8411-ea5ea52fd30f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoRecordset::Move
Call this member function to position the recordset `lRows` records from the current record.  
  
## Syntax  
  
```  
  
      virtual void Move(  
   long lRows   
);  
```  
  
#### Parameters  
 `lRows`  
 The number of records to move forward or backward. Positive values move forward, toward the end of the recordset. Negative values move backward, toward the beginning.  
  
## Remarks  
 You can move forward or backward. `Move( 1 )` is equivalent to `MoveNext`, and `Move( -1 )` is equivalent to `MovePrev`.  
  
> [!CAUTION]
>  Calling any of the **Move** functions throws an exception if the recordset has no records. In general, call both `IsBOF` and `IsEOF` before a Move operation to determine whether the recordset has any records. After you call **Open** or **Requery**, call either `IsBOF` or `IsEOF`.  
  
> [!NOTE]
>  If you have scrolled past the beginning or end of the recordset (`IsBOF` or `IsEOF` returns nonzero), a call to **Move** throws a `CDaoException`.  
  
> [!NOTE]
>  If you call any of the **Move** functions while the current record is being updated or added, the updates are lost without warning.  
  
 When you call **Move** on a forward-only scrolling snapshot, the `lRows` parameter must be a positive integer and bookmarks are not allowed, so you can move forward only.  
  
 To make the first, last, next, or previous record in a recordset the current record, call the **MoveFirst**, `MoveLast`, `MoveNext`, or `MovePrev` member function.  
  
 For related information, see the topics "Move Method" and "MoveFirst, MoveLast, MoveNext, MovePrevious Methods" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::MoveFirst](../vs140/cdaorecordset--movefirst.md)   
 [CDaoRecordset::MoveLast](../vs140/cdaorecordset--movelast.md)   
 [CDaoRecordset::MoveNext](../vs140/cdaorecordset--movenext.md)   
 [CDaoRecordset::MovePrev](../vs140/cdaorecordset--moveprev.md)