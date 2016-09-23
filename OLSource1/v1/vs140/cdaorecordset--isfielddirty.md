---
title: "CDaoRecordset::IsFieldDirty"
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
  - CDaoRecordset.IsFieldDirty
  - IsFieldDirty
  - CDaoRecordset::IsFieldDirty
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDaoRecordset class, dirty fields
  - recordsets, dirty fields
  - IsFieldDirty method
ms.assetid: 397063e6-d0bb-4bd8-82c9-7cb8e9020803
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoRecordset::IsFieldDirty
Call this member function to determine whether the specified field data member of a dynaset has been flagged as "dirty" (changed).  
  
## Syntax  
  
```  
  
      BOOL IsFieldDirty(  
   void* pv   
);  
```  
  
#### Parameters  
 `pv`  
 A pointer to the field data member whose status you want to check, or **NULL** to determine if any of the fields are dirty.  
  
## Return Value  
 Nonzero if the specified field data member is flagged as dirty; otherwise 0.  
  
## Remarks  
 The data in all dirty field data members will be transferred to the record on the data source when the current record is updated by a call to the **Update** member function of `CDaoRecordset` (following a call to **Edit** or `AddNew`). With this knowledge, you can take further steps, such as unflagging the field data member to mark the column so it will not be written to the data source.  
  
 `IsFieldDirty` is implemented through `DoFieldExchange`.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::IsFieldNull](../vs140/cdaorecordset--isfieldnull.md)   
 [CDaoRecordset::IsFieldNullable](../vs140/cdaorecordset--isfieldnullable.md)