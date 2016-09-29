---
title: "CMFCTasksPane::SetGroupCaptionHeight"
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
  - "CMFCTasksPane.SetGroupCaptionHeight"
  - "SetGroupCaptionHeight"
  - "CMFCTasksPane::SetGroupCaptionHeight"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetGroupCaptionHeight method"
ms.assetid: bb7783f9-eb33-48e9-8da6-c4deaf598390
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::SetGroupCaptionHeight
Sets the height of a group caption.  
  
## Syntax  
  
```  
void SetGroupCaptionHeight(  
    int n = -1  
);  
```  
  
#### Parameters  
 [in] `n`  
 Specifies the caption height.  
  
## Remarks  
 Call this method to customize the margins of the task pane elements.  
  
 If `n` is -1, the framework determines the margin value by using the visual manager (`CMFCVisualManager::GetTasksPaneGroupCaptionHeight`). The default caption height is 25 pixels.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)