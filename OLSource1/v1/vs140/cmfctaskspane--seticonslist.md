---
title: "CMFCTasksPane::SetIconsList"
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
  - "CMFCTasksPane.SetIconsList"
  - "CMFCTasksPane::SetIconsList"
  - "SetIconsList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetIconsList method"
ms.assetid: 8635d050-1c9b-41b5-b007-9b2cc5dc2dae
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::SetIconsList
Sets the image list.  
  
## Syntax  
  
```  
BOOL SetIconsList(  
    UINT uiImageListResID,  
    int cx,  
    COLORREF clrTransparent = RGB(255,0,255)  
);  
void SetIconsList(  
    HIMAGELIST hIcons  
);  
```  
  
#### Parameters  
 [in] `uiImageListResID`  
 Specifies the resource ID of the image list.  
  
 [in] `cx`  
 Specifies the size of icons in the image list.  
  
 [in] `clrTransparent`  
 Specifies the transparent color.  
  
 [in] `hIcons`  
 Specifies the image list that contains the icons for the task pane.  
  
## Remarks  
 The framework stores icons in an image list. Tasks are associated with icons that are stored in that list.  
  
 This method associates an image list with the task pane control. To set the icon for a task when you call [CMFCTasksPane::AddTask](../vs140/cmfctaskspane--addtask.md), set `nTaskIcon` to the appropriate zero-based index in this image list.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)