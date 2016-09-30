---
title: "CMFCTasksPane::AddTask"
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
  - "CMFCTasksPane::AddTask"
  - "CMFCTasksPane.AddTask"
  - "AddTask"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddTask method"
ms.assetid: d8428e5c-9051-4f2e-8431-8e7cabdc77a9
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::AddTask
Adds a task to the specified task group.  
  
## Syntax  
  
```  
int AddTask(  
    int nGroup,  
    LPCTSTR lpszTaskName,  
    int nTaskIcon = -1,  
    UINT uiCommandID = 0,  
    DWORD dwUserData = 0  
);  
```  
  
#### Parameters  
 [in] `nGroup`  
 Specifies the group index where the task is added.  
  
 [in] `lpszTaskName`  
 Specifies the name of the task.  
  
 [in] `nTaskIcon`  
 Specifies the icon to display next to the task. The framework stores icons in a list of images. This parameter is an index into that list.  
  
 [in] `uiCommandID`  
 Specifies the command ID of the command to execute when the user clicks the task. The task is treated as a label if `uiCommandID` is 0.  
  
 [in] `dwUserData`  
 Specifies the user-defined data to be associated with the task.  
  
## Return Value  
 The zero-based index of the group where the task was added, or -1 if the group specified by `nGroup` does not exist.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)