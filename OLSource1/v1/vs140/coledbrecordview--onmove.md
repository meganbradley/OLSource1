---
title: "COleDBRecordView::OnMove"
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
  - "COleDBRecordView::OnMove"
  - "COleDBRecordView.OnMove"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDBRecordView class, operations"
  - "OnMove method"
ms.assetid: a2f5da8b-07e4-44d0-a861-9164269718c7
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDBRecordView::OnMove
Moves to a different record in the rowset and display its fields in the controls of the record view.  
  
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
 The default implementation calls the appropriate **Move** member function of the `CRowset` object associated with the record view.  
  
 By default, `OnMove` updates the current record on the data source if the user has changed it in the record view.  
  
 The Application Wizard creates a menu resource with First Record, Last Record, Next Record, and Previous Record menu items. If you select the Dockable Toolbar option, The Application Wizard also creates a toolbar with buttons corresponding to these commands.  
  
 If you move past the last record in the recordset, the record view continues to display the last record. If you move backward past the first record, the record view continues to display the first record.  
  
## Requirements  
 **Header:** afxoledb.h  
  
## See Also  
 [COleDBRecordView Class](../vs140/coledbrecordview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)