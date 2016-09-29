---
title: "CFrameWnd::DockControlBar"
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
  - "AFX_IDW_DOCKBAR_RIGHT"
  - "CFrameWnd::DockControlBar"
  - "CFrameWnd.DockControlBar"
  - "DockControlBar"
  - "AFX_IDW_DOCKBAR_TOP"
  - "AFX_IDW_DOCKBAR_LEFT"
  - "AFX_IDW_DOCKBAR_BOTTON"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AFX_IDW_DOCKBAR_TOP"
  - "AFX_IDW_DOCKBAR_LEFT"
  - "AFX_IDW_DOCKBAR_BOTTOM"
  - "DockControlBar method"
  - "CFrameWnd class, operations"
  - "AFX_IDW_DOCKBAR_RIGHT"
ms.assetid: b34a2a37-64fe-49ff-a556-537bed35b970
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd::DockControlBar
Causes a control bar to be docked to the frame window.  
  
## Syntax  
  
```  
  
      void DockControlBar(  
   CControlBar* pBar,  
   UINT nDockBarID = 0,  
   LPCRECT lpRect = NULL   
);  
```  
  
#### Parameters  
 `pBar`  
 Points to the control bar to be docked.  
  
 `nDockBarID`  
 Determines which sides of the frame window to consider for docking. It can be 0, or one or more of the following:  
  
-   `AFX_IDW_DOCKBAR_TOP` Dock to the top side of the frame window.  
  
-   **AFX_IDW_DOCKBAR_BOTTOM** Dock to the bottom side of the frame window.  
  
-   `AFX_IDW_DOCKBAR_LEFT` Dock to the left side of the frame window.  
  
-   `AFX_IDW_DOCKBAR_RIGHT` Dock to the right side of the frame window.  
  
 If 0, the control bar can be docked to any side enabled for docking in the destination frame window.  
  
 `lpRect`  
 Determines, in screen coordinates, where the control bar will be docked in the nonclient area of the destination frame window.  
  
## Remarks  
 The control bar will be docked to one of the sides of the frame window specified in the calls to both [CControlBar::EnableDocking](../vs140/ccontrolbar--enabledocking.md) and [CFrameWnd::EnableDocking](../vs140/cframewnd--enabledocking.md). The side chosen is determined by `nDockBarID`.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFrameWnd::FloatControlBar](../vs140/cframewnd--floatcontrolbar.md)