---
title: "CMFCTasksPane::SetHorzMargin"
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
  - "CMFCTasksPane.SetHorzMargin"
  - "CMFCTasksPane::SetHorzMargin"
  - "SetHorzMargin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetHorzMargin method"
ms.assetid: 27e8784c-8cc6-4016-ab6c-dc3c861a5941
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::SetHorzMargin
Sets the horizontal margin.  
  
## Syntax  
  
```  
void SetHorzMargin(  
    int n = -1  
);  
```  
  
#### Parameters  
 [in] `n`  
 Specifies the margin, in pixels.  
  
## Remarks  
 The horizontal margin is the distance between a task pane and the top or bottom edge of the client area.  
  
 If n is -1, and the framework determines the margin value by using the visual manager (`CMFCVisualManager::GetTasksPaneHorzMargin`). The default horizontal margin is 12 pixels.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)