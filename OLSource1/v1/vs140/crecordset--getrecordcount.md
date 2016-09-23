---
title: "CRecordset::GetRecordCount"
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
  - CRecordset::GetRecordCount
  - CRecordset.GetRecordCount
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetRecordCount method
ms.assetid: edc3ab82-6245-46d5-bc84-544f7bba1d3b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRecordset::GetRecordCount
Determines the size of the recordset.  
  
## Syntax  
  
```  
  
long GetRecordCount( ) const;  
```  
  
## Return Value  
 The number of records in the recordset; 0 if the recordset contains no records; or –1 if the record count cannot be determined.  
  
## Remarks  
  
> [!CAUTION]
>  The record count is maintained as a "high water mark," the highest-numbered record yet seen as the user moves through the records. The total number of records is only known after the user has moved beyond the last record. For performance reasons, the count is not updated when you call `MoveLast`. To count the records yourself, call `MoveNext` repeatedly until `IsEOF` returns nonzero. Adding a record via **CRecordset:AddNew** and **Update** increases the count; deleting a record via `CRecordset::Delete` decreases the count.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::MoveLast](../vs140/crecordset--movelast.md)   
 [CRecordset::MoveNext](../vs140/crecordset--movenext.md)   
 [CRecordset::IsEOF](../vs140/crecordset--iseof.md)   
 [CRecordset::GetStatus](../vs140/crecordset--getstatus.md)