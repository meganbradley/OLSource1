---
title: "CDaoRecordView::IsOnFirstRecord"
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
  - "CDaoRecordView.IsOnFirstRecord"
  - "IsOnFirstRecord"
  - "CDaoRecordView::IsOnFirstRecord"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "record views, locating first record"
  - "CDaoRecordView class, locating first record"
  - "IsOnFirstRecord method"
ms.assetid: ec085c67-11cd-46dc-9704-ca856fbce251
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordView::IsOnFirstRecord
Call this member function to determine whether the current record is the first record in the recordset object associated with this record view.  
  
## Syntax  
  
```  
  
BOOL IsOnFirstRecord( );  
  
```  
  
## Return Value  
 Nonzero if the current record is the first record in the recordset; otherwise 0.  
  
## Remarks  
 This function is useful for writing your own implementations of the default command update handlers written by ClassWizard.  
  
 If the user moves to the first record, the framework disables any user interface objects (for example, menu items or toolbar buttons) you have for moving to the first or the previous record.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordView Class](../vs140/cdaorecordview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordView::IsOnLastRecord](../vs140/cdaorecordview--isonlastrecord.md)