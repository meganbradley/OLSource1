---
title: "CRecordView::IsOnLastRecord"
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
  - "CRecordView::IsOnLastRecord"
  - "CRecordView.IsOnLastRecord"
  - "IsOnLastRecord"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsOnLastRecord method"
ms.assetid: 3a964df1-c1f8-4f4c-ac7b-1c17fff7d55f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordView::IsOnLastRecord
Call this member function to determine whether the current record is the last record in the recordset object associated with this record view.  
  
## Syntax  
  
```  
  
BOOL IsOnLastRecord( );  
```  
  
## Return Value  
 Nonzero if the current record is the last record in the recordset; otherwise 0.  
  
## Remarks  
 This function is useful for writing your own implementations of the default command update handlers that ClassWizard writes to support a user interface for moving from record to record.  
  
> [!CAUTION]
>  The result of this function is reliable except that the view cannot detect the end of the recordset until the user has moved past it. The user must move beyond the last record before the record view can tell that it must disable any user interface objects for moving to the next or last record. If the user moves past the last record and then moves back to the last record (or before it), the record view can track the user's position in the recordset and disable user interface objects correctly. `IsOnLastRecord` is also unreliable after a call to the implementation function **OnRecordLast**, which handles the `ID_RECORD_LAST` command, or `CRecordset::MoveLast`.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordView Class](../vs140/crecordview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordView::OnMove](../vs140/crecordview--onmove.md)   
 [CRecordView::IsOnFirstRecord](../vs140/crecordview--isonfirstrecord.md)   
 [CRecordset::IsEOF](../vs140/crecordset--iseof.md)   
 [CRecordset::GetRecordCount](../vs140/crecordset--getrecordcount.md)