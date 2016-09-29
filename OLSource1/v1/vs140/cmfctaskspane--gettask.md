---
title: "CMFCTasksPane::GetTask"
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
  - "CMFCTasksPane::GetTask"
  - "CMFCTasksPane.GetTask"
  - "GetTask"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTask method"
ms.assetid: 17861f54-b9d8-47e8-be2b-252c6c2534d3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::GetTask
Retrieves a task.  
  
## Syntax  
  
```  
CMFCTasksPaneTask* GetTask(  
    int nGroup,  
    int nTask  
) const;  
```  
  
#### Parameters  
 [in] `nGroup`  
 Specifies the zero-based index of the group that contains the task.  
  
 [in] `nTask`  
 Specifies the zero-based index of the task in the list specified by `nGroup`.  
  
## Return Value  
 The task at the specified index.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCTasksPane::GetTaskLocation](../vs140/cmfctaskspane--gettasklocation.md)