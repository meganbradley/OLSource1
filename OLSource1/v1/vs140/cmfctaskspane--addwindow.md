---
title: "CMFCTasksPane::AddWindow"
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
  - "CMFCTasksPane.AddWindow"
  - "CMFCTasksPane::AddWindow"
  - "AddWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddWindow method"
ms.assetid: deb05393-d999-45c1-b2ef-9f7a38d49563
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::AddWindow
Adds a child window to the task pane.  
  
## Syntax  
  
```  
int AddWindow(  
    int nGroup,  
    HWND hwndTask,  
    int nWndHeight,  
    BOOL bAutoDestroyWindow = FALSE,  
    DWORD dwUserData = 0  
);  
```  
  
#### Parameters  
 [in] `nGroup`  
 Specifies the group index where the window is added.  
  
 [in] `hwndTask`  
 Specifies the handle of the window to add.  
  
 [in] `nWndHeight`  
 Specifies the height of the window.  
  
 [in] `bAutoDestroyWindow`  
 `TRUE` to destroy the window when the task is removed; otherwise, `FALSE`.  
  
 [in] `dwUserData`  
 Specifies the user-defined data associated with the task.  
  
## Return Value  
 The zero-based index of the group where the window was added, or -1 if the group specified by `nGroup` does not exist.  
  
## Remarks  
 Call this method to add a control to a task pane. For example, you can add an edit control that functions like a search bar.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)