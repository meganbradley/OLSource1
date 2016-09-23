---
title: "CMFCTasksPane::SetVertMargin"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCTasksPane.SetVertMargin
  - CMFCTasksPane::SetVertMargin
  - SetVertMargin
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetVertMargin method
ms.assetid: 8099d42b-aaa9-44e6-a3e1-488a9ea4c4f7
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCTasksPane::SetVertMargin
Sets the vertical margin.  
  
## Syntax  
  
```  
void SetVertMargin(  
    int n = -1  
);  
```  
  
#### Parameters  
 [in] `n`  
 Specifies the vertical margin to set.  
  
## Remarks  
 The vertical margin is the distance between a task pane and the vertical edges of the client area.  
  
 If `n` is -1, the framework determines the margin value by using  the visual manager (`CMFCVisualManager::GetTasksPaneVertMargin`). The default margin is 12 pixels.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)