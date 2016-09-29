---
title: "CMFCTasksPane::GetTaskGroup"
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
  - "CMFCTasksPane.GetTaskGroup"
  - "CMFCTasksPane::GetTaskGroup"
  - "GetTaskGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTaskGroup method"
ms.assetid: 4273a1b2-3b64-4e29-ae78-60003bf579a3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::GetTaskGroup
Returns a task group for a specified group index.  
  
## Syntax  
  
```  
CMFCTasksPaneTaskGroup* GetTaskGroup(  
    int nGroup  
) const;  
```  
  
#### Parameters  
 [in] `nGroup`  
 Specifies the zero-based index of the group to retrieve.  
  
## Return Value  
 The task group at the specified index.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCTasksPane::GetGroupLocation](../vs140/cmfctaskspane--getgrouplocation.md)