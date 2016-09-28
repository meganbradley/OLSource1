---
title: "CRecordView::OnMove"
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
  - "CRecordView.OnMove"
  - "CRecordView::OnMove"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnMove method"
ms.assetid: a2e2c140-37cc-4435-960a-a2b209cc5551
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordView::OnMove
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
 The default implementation calls the appropriate **Move** member function of the `CRecordset` object associated with the record view.  
  
 By default, `OnMove` updates the current record on the data source if the user has changed it in the record view.  
  
 The Application Wizard creates a menu resource with First Record, Last Record, Next Record, and Previous Record menu items. If you select the Dockable Toolbar option, the Application Wizard also creates a toolbar with buttons corresponding to these commands.  
  
 If you move past the last record in the recordset, the record view continues to display the last record. If you move backward past the first record, the record view continues to display the first record.  
  
> [!CAUTION]
>  Calling `OnMove` throws an exception if the recordset has no records. Call the appropriate user interface update handler function — **OnUpdateRecordFirst**, **OnUpdateRecordLast**, **OnUpdateRecordNext**, or **OnUpdateRecordPrev** — before the corresponding move operation to determine whether the recordset has any records.  
  
## Exceptions  
 This method can throw exceptions of type **CDBException\***.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordView Class](../vs140/crecordview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::Move](../vs140/crecordset--move.md)