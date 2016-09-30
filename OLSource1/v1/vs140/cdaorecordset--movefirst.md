---
title: "CDaoRecordset::MoveFirst"
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
  - "CDaoRecordset::MoveFirst"
  - "CDaoRecordset.MoveFirst"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoRecordset class, moving in"
  - "MoveFirst method"
  - "recordsets, moving to records"
ms.assetid: c01bacf3-1104-4dd4-877d-f79b3a912331
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::MoveFirst
Call this member function to make the first record in the recordset (if any) the current record.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 You do not have to call **MoveFirst** immediately after you open the recordset. At that time, the first record (if any) is automatically the current record.  
  
> [!CAUTION]
>  Calling any of the **Move** functions throws an exception if the recordset has no records. In general, call both <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> before a Move operation to determine whether the recordset has any records. After you call **Open** or **Requery**, call either <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  If you call any of the **Move** functions while the current record is being updated or added, the updates are lost without warning.  
  
 Use the **Move** functions to move from record to record without applying a condition. Use the Find operations to locate records in a dynaset-type or snapshot-type recordset object that satisfy a certain condition. To locate a record in a table-type recordset object, call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 If the recordset refers to a table-type recordset, movement follows the table's current index. You can set the current index by using the Index property of the underlying DAO object. If you do not set the current index, the order of returned records is undefined.  
  
 If you call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> on a recordset object based on a SQL query or querydef, the query is forced to completion and the recordset object is fully populated.  
  
 You cannot call the **MoveFirst** or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member function with a forward-only scrolling snapshot.  
  
 To move the position of the current record in a recordset object a specific number of records forward or backward, call **Move**.  
  
 For related information, see the topics "Move Method" and "MoveFirst, MoveLast, MoveNext, MovePrevious Methods" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::Move](../vs140/cdaorecordset--move.md)   
 [CDaoRecordset::MoveLast](../vs140/cdaorecordset--movelast.md)   
 [CDaoRecordset::MoveNext](../vs140/cdaorecordset--movenext.md)   
 [CDaoRecordset::MovePrev](../vs140/cdaorecordset--moveprev.md)