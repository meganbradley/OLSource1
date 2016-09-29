---
title: "CMFCTasksPaneTask::CMFCTasksPaneTask"
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
  - "CMFCTasksPaneTask"
  - "CMFCTasksPaneTask::CMFCTasksPaneTask"
  - "CMFCTasksPaneTask.CMFCTasksPaneTask"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCTasksPaneTask class, constructor"
ms.assetid: c194e823-f6b0-46b1-ba68-00f3d96862ff
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPaneTask::CMFCTasksPaneTask
Creates and initializes a `CMFCTasksPaneTask` object.  
  
## Syntax  
  
```  
CMFCTasksPaneTask(  
    CMFCTasksPaneTaskGroup* pGroup,  
    LPCTSTR lpszName,  
    int nIcon,  
    UINT uiCommandID,  
    DWORD dwUserData = 0,  
    HWND hwndTask = NULL,  
    BOOL bAutoDestroyWindow = FALSE,  
    int nWindowHeight = 0  
);  
```  
  
#### Parameters  
 `pGroup`  
 Specifies the [CMFCTasksPaneTaskGroup](../vs140/cmfctaskspanetaskgroup-class.md) to which the task belongs.  
  
 `lpszName`  
 Specifies the name of the task.  
  
 `nIcon`  
 Specifies the index of the task's image in the image list.  
  
 `uiCommandID`  
 Specifies the command ID of the command that is executed when the task is clicked.  
  
 `dwUserData`  
 User-defined data.  
  
 `hwndTask`  
 Specifies the handle to the task window.  
  
 `bAutoDestroyWindow`  
 If `TRUE`, the task window will be destroyed automatically.  
  
 `nWindowHeight`  
 Specifies the height of the task window.  
  
## Remarks  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCTasksPaneTask Class](../vs140/cmfctaskspanetask-class.md)