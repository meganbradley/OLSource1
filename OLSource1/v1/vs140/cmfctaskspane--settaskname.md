---
title: "CMFCTasksPane::SetTaskName"
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
  - "CMFCTasksPane::SetTaskName"
  - "CMFCTasksPane.SetTaskName"
  - "SetTaskName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTaskName method"
ms.assetid: 43b20d4a-67c2-421a-a4db-df1bda112480
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::SetTaskName
Sets the name for a task.  
  
## Syntax  
  
```  
BOOL SetTaskName(  
    int nGroup,  
    int nTask,  
    LPCTSTR lpszTaskName  
);  
```  
  
#### Parameters  
 [in] `nGroup`  
 Specifies the zero-based index of the task group.  
  
 [in] `nTask`  
 Specifies the zero-based index of the task.  
  
 [in] `lpszTaskName`  
 Specifies the task name.  
  
## Return Value  
 `TRUE` if the task name was successfully set; otherwise, `FALSE`.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)