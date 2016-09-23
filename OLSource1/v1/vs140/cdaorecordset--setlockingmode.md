---
title: "CDaoRecordset::SetLockingMode"
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
  - CDaoRecordset.SetLockingMode
  - CDaoRecordset::SetLockingMode
  - SetLockingMode
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDaoRecordset class, setting locking mode
  - recordsets, setting locking mode
  - SetLockingMode method
ms.assetid: 04bc2ea0-7d68-442e-b7bb-41ba66334cbe
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoRecordset::SetLockingMode
Call this member function to set the type of locking for the recordset.  
  
## Syntax  
  
```  
  
      void SetLockingMode(  
   BOOL bPessimistic   
);  
```  
  
#### Parameters  
 *bPessimistic*  
 A flag that indicates the type of locking.  
  
## Remarks  
 When pessimistic locking is in effect, the 2K page containing the record you are editing is locked as soon as you call the **Edit** member function. The page is unlocked when you call the **Update** or **Close** member function or any of the Move or Find operations.  
  
 When optimistic locking is in effect, the 2K page containing the record is locked only while the record is being updated with the **Update** member function.  
  
 If a page is locked, no other user can edit records on the same page. If you call `SetLockingMode` and pass a nonzero value and another user already has the page locked, an exception is thrown when you call **Edit**. Other users can read data from locked pages.  
  
 If you call `SetLockingMode` with a zero value and later call **Update** while the page is locked by another user, an exception occurs. To see the changes made to your record by another user (and lose your changes), call the `SetBookmark` member function with the bookmark value of the current record.  
  
 When working with ODBC data sources, the locking mode is always optimistic.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::GetLockingMode](../vs140/cdaorecordset--getlockingmode.md)