---
title: "CDaoRecordView::IsOnLastRecord"
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
  - "CDaoRecordView::IsOnLastRecord"
  - "IsOnLastRecord"
  - "CDaoRecordView.IsOnLastRecord"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoRecordView class, locating last record"
  - "IsOnLastRecord method"
  - "record views, locating last record"
ms.assetid: c3e71c09-d0ba-46a2-a1ec-f8f8a04aab58
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordView::IsOnLastRecord
Call this member function to determine whether the current record is the last record in the recordset object associated with this record view.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the current record is the last record in the recordset; otherwise 0.  
  
## Remarks  
 This function is useful for writing your own implementations of the default command update handlers that ClassWizard writes to support a user interface for moving from record to record.  
  
> [!CAUTION]
>  The result of this function is reliable except that the view may not be able to detect the end of the recordset until the user has moved past it. The user might have to move beyond the last record before the record view can tell that it must disable any user interface objects for moving to the next or last record. If the user moves past the last record and then moves back to the last record (or before it), the record view can track the user's position in the recordset and disable user interface objects correctly.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordView Class](../vs140/cdaorecordview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordView::IsOnFirstRecord](../vs140/cdaorecordview--isonfirstrecord.md)