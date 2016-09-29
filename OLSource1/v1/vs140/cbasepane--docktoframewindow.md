---
title: "CBasePane::DockToFrameWindow"
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
  - "DockToFrameWindow"
  - "CBasePane::DockToFrameWindow"
  - "CBasePane.DockToFrameWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DockToFrameWindow method"
ms.assetid: b16810fc-d4a8-4e88-bf4f-68d41d6f94b1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::DockToFrameWindow
Docks a dockable pane to a frame.  
  
## Syntax  
  
```  
virtual BOOL DockToFrameWindow(  
   DWORD dwAlignment,  
   LPCRECT lpRect = NULL,  
   DWORD dwDockFlags = DT_DOCK_LAST,  
   CBasePane* pRelativeBar = NULL,  
   int nRelativeIndex = -1,  
   BOOL bOuterEdge = FALSE  
);  
```  
  
#### Parameters  
 [in] `dwAlignment`  
 The side of the parent frame that you want to dock the pane to.  
  
 [in] `lpRect`  
 The desired size.  
  
 [in] `dwDockFlags`  
 Ignored.  
  
 [in] `pRelativeBar`  
 Ignored.  
  
 [in] `nRelativeIndex`  
 Ignored.  
  
 [in] `bOuterEdge`  
 If `TRUE` and there are other dockable panes at the side specified by `dwAlignment`, the pane is docked outside the other panes, closer to the edge of the parent frame. If `FALSE`, the pane is docked closer to the center of the client area.  
  
## Return Value  
 `TRUE` if the method was successful; otherwise `FALSE`.  
  
## Remarks  
 This method fails if a pane divider ([CPaneDivider Class](../vs140/cpanedivider-class.md)) cannot be created. Otherwise, it always returns `TRUE`.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)