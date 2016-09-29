---
title: "CDaoRecordset::GetLockingMode"
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
  - "CDaoRecordset::GetLockingMode"
  - "CDaoRecordset.GetLockingMode"
  - "GetLockingMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, getting information"
  - "GetLockingMode method"
  - "CDaoRecordset class, getting locking mode"
ms.assetid: df816b93-1dbe-4e37-8dd6-cb34a0c6aafb
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::GetLockingMode
Call this member function to determine the type of locking in effect for the recordset.  
  
## Syntax  
  
```  
  
BOOL GetLockingMode( );  
  
```  
  
## Return Value  
 Nonzero if the type of locking is pessimistic, otherwise 0 for optimistic record locking.  
  
## Remarks  
 When pessimistic locking is in effect, the data page containing the record you are editing is locked as soon as you call the [Edit](../vs140/cdaorecordset--edit.md) member function. The page is unlocked when you call the [Update](../vs140/cdaorecordset--update.md) or [Close](../vs140/cdaorecordset--close.md) member function or any of the Move or Find operations.  
  
 When optimistic locking is in effect, the data page containing the record is locked only while the record is being updated with the **Update** member function.  
  
 When working with ODBC data sources, the locking mode is always optimistic.  
  
 For related information, see the topics "LockEdits Property" and "Locking Behavior in Multiuser Applications" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::SetLockingMode](../vs140/cdaorecordset--setlockingmode.md)