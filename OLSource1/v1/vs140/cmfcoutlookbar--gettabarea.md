---
title: "CMFCOutlookBar::GetTabArea"
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
  - "GetTabArea"
  - "CMFCOutlookBar.GetTabArea"
  - "CMFCOutlookBar::GetTabArea"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTabArea method"
ms.assetid: 94d776ed-e758-4bdd-9225-ef0ff45dc922
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCOutlookBar::GetTabArea
Determines the size and position of the tab areas on the Outlook bar.  
  
## Syntax  
  
```  
virtual void GetTabArea(  
   CRect& rectTabAreaTop,  
   CRect& rectTabAreaBottom   
) const;  
```  
  
#### Parameters  
 [out] `rectTabAreaTop`  
 Contains the size and position (in the client coordinates) of the top tab area when the function returns.  
  
 [out] `rectTabAreaBottom`  
 Contains the size and position (in the client coordinates) of the bottom tab area when the function returns.  
  
## Remarks  
 The framework calls this method to determine the type of docking to the target pane. When the framework determines that the user drags the pane to be docked over the tab area of the target pane, it tries to add the first pane as a new tab of the target pane. Otherwise, it tries to dock the first pane at an appropriate side of the target pane. The framework creates a new container with a slider to accommodate the additional docked pane.  
  
 The default implementation of `GetTabArea` returns the whole client area of the Outlook bar if the Outlook bar is static; that is, if the Outlook bar cannot float. Otherwise, it returns the area that page buttons take at the top and bottom of the Outlook bar control.  
  
 Override this method in class derived from `CMFCOutlookBar` to change this behavior.  
  
## Requirements  
 **Header:** afxoutlookbar.h  
  
## See Also  
 [CMFCOutlookBar Class](../vs140/cmfcoutlookbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)