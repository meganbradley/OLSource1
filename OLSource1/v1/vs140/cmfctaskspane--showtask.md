---
title: "CMFCTasksPane::ShowTask"
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
  - "ShowTask"
  - "CMFCTasksPane::ShowTask"
  - "CMFCTasksPane.ShowTask"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShowTask method"
ms.assetid: a3dc34cf-64db-433c-8c7e-26e6c98b8458
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::ShowTask
Shows or hides a task.  
  
## Syntax  
  
```  
BOOL ShowTask(  
    int nGroup,  
    int nTask,  
    BOOL bShow = TRUE,  
    BOOL bRedraw = TRUE  
);  
```  
  
#### Parameters  
 [in] `nGroup`  
 Specifies the zero-based index of the group.  
  
 [in] `nTask`  
 Specifies the zero-based index of the task to show or hide.  
  
 [in] `bShow`  
 `TRUE` to show the task; `FALSE` to hide the task.  
  
 [in] `bRedraw`  
 `TRUE` to redraw the task pane; otherwise, `FALSE`.  
  
## Return Value  
 `TRUE` if the task was successfully shown or hidden; `FALSE` if the specified group or task does not exist.  
  
## Remarks  
 Use [CMFCTasksPane::ShowTaskByCmdId](../vs140/cmfctaskspane--showtaskbycmdid.md) to show or hide a task based on its command ID.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)