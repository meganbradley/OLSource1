---
title: "CMFCTasksPane::ShowTaskByCmdId"
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
  - "CMFCTasksPane.ShowTaskByCmdId"
  - "CMFCTasksPane::ShowTaskByCmdId"
  - "ShowTaskByCmdId"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShowTaskByCmdId method"
ms.assetid: 455a847c-1ce9-418c-95c8-8dc6f775c466
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::ShowTaskByCmdId
Shows or hides a task based on its command ID.  
  
## Syntax  
  
```  
BOOL ShowTaskByCmdId(  
    UINT uiCommandID,  
    BOOL bShow = TRUE,  
    BOOL bRedraw = TRUE  
);  
```  
  
#### Parameters  
 [in] `uiCommandID`  
 Specifies the command ID of the task to show or hide.  
  
 [in] `bShow`  
 `TRUE` to show the task; `FALSE` to hide the task.  
  
 [in] `bRedraw`  
 `TRUE` to redraw the task pane; otherwise, `FALSE`.  
  
## Return Value  
 `TRUE` if the task was successfully shown or hidden; `FALSE` if a task with the specified command ID does not exist.  
  
## Remarks  
 Use [CMFCTasksPane::ShowTask](../vs140/cmfctaskspane--showtask.md) to show or hide a task based on its command ID.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)