---
title: "CDaoRecordView::OnMove"
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
  - "ID_RECORD_FIRST"
  - "ID_RECORD_LAST"
  - "ID_RECORD_PREV"
  - "CDaoRecordView::OnMove"
  - "ID_RECORD_NEXT"
  - "CDaoRecordView.OnMove"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ID_RECORD_LAST"
  - "OnMove method"
  - "ID_RECORD_NEXT"
  - "ID_RECORD_PREV"
  - "record views, moving"
  - "ID_RECORD_FIRST"
  - "CDaoRecordView class, moving"
ms.assetid: 04e6e5a6-ccb2-40ce-892e-1713c075fc3d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordView::OnMove
Call this member function to move to a different record in the recordset and display its fields in the controls of the record view.  
  
## Syntax  
  
```  
  
      virtual BOOL OnMove(  
   UINT nIDMoveCommand   
);  
```  
  
#### Parameters  
 `nIDMoveCommand`  
 One of the following standard command ID values:  
  
-   `ID_RECORD_FIRST` Move to the first record in the recordset.  
  
-   `ID_RECORD_LAST` Move to the last record in the recordset.  
  
-   `ID_RECORD_NEXT` Move to the next record in the recordset.  
  
-   `ID_RECORD_PREV` Move to the previous record in the recordset.  
  
## Return Value  
 Nonzero if the move was successful; otherwise 0 if the move request was denied.  
  
## Remarks  
 The default implementation calls the appropriate Move member function of the `CDaoRecordset` object associated with the record view.  
  
 By default, `OnMove` updates the current record on the data source if the user has changed it in the record view.  
  
 The Application Wizard creates a menu resource with First Record, Last Record, Next Record, and Previous Record menu items. If you select the Initial Toolbar option, the Application Wizard also creates a toolbar with buttons corresponding to these commands.  
  
 If you move past the last record in the recordset, the record view continues to display the last record. If you move backward past the first record, the record view continues to display the first record.  
  
> [!CAUTION]
>  Calling `OnMove` throws an exception if the recordset has no records. Call the appropriate user interface update handler function — **OnUpdateRecordFirst**, **OnUpdateRecordLast**, **OnUpdateRecordNext**, or **OnUpdateRecordPrev** — before the corresponding move operation to determine whether the recordset has any records.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordView Class](../vs140/cdaorecordview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::Move](../vs140/cdaorecordset--move.md)