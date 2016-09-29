---
title: "CMFCTasksPane::SetGroupVertOffset"
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
  - "SetGroupVertOffset"
  - "CMFCTasksPane.SetGroupVertOffset"
  - "CMFCTasksPane::SetGroupVertOffset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetGroupVertOffset method"
ms.assetid: c3e73d0b-8b52-4b27-9dd7-0def1d0c4334
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::SetGroupVertOffset
Sets the vertical offset for a group.  
  
## Syntax  
  
```  
void SetGroupVertOffset(  
    int n = -1  
);  
```  
  
#### Parameters  
 [in] `n`  
 Specifies the vertical offset.  
  
## Remarks  
 The vertical offset is the distance between a task group and the border of the task pane.  
  
 Call this method to customize the margins of task pane elements. If `n` is -1, the framework determines the margin value by using the visual manager (`CMFCVisualManager::GetTasksPaneGroupVertOffset`). The default offset is 15 pixels.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)