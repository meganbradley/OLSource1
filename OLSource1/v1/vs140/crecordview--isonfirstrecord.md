---
title: "CRecordView::IsOnFirstRecord"
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
  - "IsOnFirstRecord"
  - "CRecordView::IsOnFirstRecord"
  - "CRecordView.IsOnFirstRecord"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsOnFirstRecord method"
ms.assetid: b5185382-1422-405d-aaec-cb37efcd26a4
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordView::IsOnFirstRecord
Call this member function to determine whether the current record is the first record in the recordset object associated with this record view.  
  
## Syntax  
  
```  
  
BOOL IsOnFirstRecord( );  
```  
  
## Return Value  
 Nonzero if the current record is the first record in the recordset; otherwise 0.  
  
## Remarks  
 This function is useful for writing your own implementations of default command update handlers written by ClassWizard.  
  
 If the user moves to the first record, the framework disables any user interface objects you have for moving to the first or the previous record.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordView Class](../vs140/crecordview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordView::OnMove](../vs140/crecordview--onmove.md)   
 [CRecordView::IsOnLastRecord](../vs140/crecordview--isonlastrecord.md)   
 [CRecordset::IsBOF](../vs140/crecordset--isbof.md)   
 [CRecordset::GetRecordCount](../vs140/crecordset--getrecordcount.md)