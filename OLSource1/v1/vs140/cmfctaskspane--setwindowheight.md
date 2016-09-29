---
title: "CMFCTasksPane::SetWindowHeight"
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
  - "CMFCTasksPane::SetWindowHeight"
  - "SetWindowHeight"
  - "CMFCTasksPane.SetWindowHeight"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetWindowHeight method"
ms.assetid: 93d1273a-f8c0-4333-8f17-ac396d119868
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::SetWindowHeight
Sets the height for a window control.  
  
## Syntax  
  
```  
BOOL SetWindowHeight(  
    int nGroup,  
    HWND hwndTask,  
    int nWndHeight  
);  
BOOL SetWindowHeight(  
    HWND hwndTask,  
    int nWndHeight  
);  
```  
  
#### Parameters  
 [in] `nGroup`  
 Specifies the zero-based index of the group that contains the window control.  
  
 [in] `hwndTask`  
 Specifies the handle to the window control.  
  
 [in] `nWndHeight`  
 Specifies the height to set.  
  
## Return Value  
 `TRUE` if the height of the window control was successfully set; `FALSE` if `nGroup` is invalid or if `hwndTask` does not exist.  
  
## Remarks  
 Call [CMFCTasksPane::AddWindow](../vs140/cmfctaskspane--addwindow.md) to add tasks with window controls.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)