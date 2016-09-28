---
title: "CPane::DockToFrameWindow"
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
  - "CPane::DockToFrameWindow"
  - "DockToFrameWindow"
  - "CPane.DockToFrameWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DockToFrameWindow method"
ms.assetid: 36297639-ed93-4450-ba44-9677f684ed71
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::DockToFrameWindow
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
 The specified size.  
  
 [in] `dwDockFlags`  
 Ignored.  
  
 [in] `pRelativeBar`  
 Ignored.  
  
 [in] `nRelativeIndex`  
 Ignored.  
  
 [in] `bOuterEdge`  
 If `TRUE` and there are other dockable panes at the side that are specified by `dwAlignment`, the pane is docked outside the other panes, closer to the edge of the parent frame. If `FALSE`, the pane is docked closer to the center of the client area.  
  
## Return Value  
 `FALSE` if a pane divider ([CPaneDivider Class](../vs140/cpanedivider-class.md)) cannot be created; otherwise, `TRUE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDockablePane::DockToFrameWindow](assetId:///c2f2024b-ed6d-4d52-882f-425352f836c5)