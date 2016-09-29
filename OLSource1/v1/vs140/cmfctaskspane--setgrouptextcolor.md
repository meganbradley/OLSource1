---
title: "CMFCTasksPane::SetGroupTextColor"
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
  - "CMFCTasksPane::SetGroupTextColor"
  - "CMFCTasksPane.SetGroupTextColor"
  - "SetGroupTextColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetGroupTextColor method"
ms.assetid: 34b10f83-a554-44ed-ba3f-97312629c0c0
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::SetGroupTextColor
Sets the text color for a group caption.  
  
## Syntax  
  
```  
BOOL SetGroupTextColor(  
    int nGroup,  
    COLORREF color,  
    COLORREF colorHot = (COLORREF)-1  
);  
```  
  
#### Parameters  
 [in] `nGroup`  
 Specifies the zero-based index of the group.  
  
 [in] `color`  
 Specifies the text color.  
  
 [in] `colorHot`  
 Specifies the text color for the highlighted group. If -1, the default highlight color is used.  
  
## Return Value  
 `TRUE` if the group text color was successfully changed; otherwise, `FALSE`.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)