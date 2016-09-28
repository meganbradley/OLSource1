---
title: "CDaoRecordset::IsFieldNullable"
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
  - "IsFieldNullable"
  - "CDaoRecordset.IsFieldNullable"
  - "CDaoRecordset::IsFieldNullable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoRecordset class, nullable fields"
  - "recordsets, null and nullable fields"
  - "IsFieldNullable method"
  - "null values, recordset fields"
ms.assetid: 2ba079a6-3fdf-4ac1-94e8-f90300bc6f11
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::IsFieldNullable
Call this member function to determine whether the specified field data member is "nullable" (can be set to a Null value; C++ **NULL** is not the same as Null, which, in database terminology, means "having no value").  
  
## Syntax  
  
```  
  
      BOOL IsFieldNullable(  
   void* pv   
);  
```  
  
#### Parameters  
 `pv`  
 A pointer to the field data member whose status you want to check, or **NULL** to determine if any of the fields are Null.  
  
## Return Value  
 Nonzero if the specified field data member can be made Null; otherwise 0.  
  
## Remarks  
 A field that cannot be Null must have a value. If you attempt to set such a field to Null when adding or updating a record, the data source rejects the addition or update, and **Update** will throw an exception. The exception occurs when you call **Update**, not when you call `SetFieldNull`.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::IsFieldDirty](../vs140/cdaorecordset--isfielddirty.md)   
 [CDaoRecordset::IsFieldNull](../vs140/cdaorecordset--isfieldnull.md)