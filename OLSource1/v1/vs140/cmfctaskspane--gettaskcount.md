---
title: "CMFCTasksPane::GetTaskCount"
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
  - "CMFCTasksPane.GetTaskCount"
  - "CMFCTasksPane::GetTaskCount"
  - "GetTaskCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTaskCount method"
ms.assetid: 6c26d09b-3cda-440e-8b70-a3dd571e502f
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::GetTaskCount
Returns the number of tasks in a specified group.  
  
## Syntax  
  
```  
int GetTaskCount(  
    int nGroup  
) const;  
```  
  
#### Parameters  
 [in] `nGroup`  
 Specifies the index of the task group.  
  
## Return Value  
 The number of tasks in the specified group, or 0 if `nGroup` is invalid.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)