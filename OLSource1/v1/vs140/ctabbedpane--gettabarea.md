---
title: "CTabbedPane::GetTabArea"
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
  - "CTabbedPane::GetTabArea"
  - "CTabbedPane.GetTabArea"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTabArea method"
ms.assetid: b143fffb-b2c4-47ae-ae47-fe1bb8cce94e
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabbedPane::GetTabArea
Returns the size and position of the tab area in the tabbed window.  
  
## Syntax  
  
```  
virtual void GetTabArea(  
    CRect& rectTabAreaTop,  
    CRect& rectTabAreaBottom   
) const;  
```  
  
#### Parameters  
 [out] `rectTabAreaTop`  
 Contains the size and position, in screen coordinates, of the top tab area.  
  
 [out] `rectTabAreaBottom`  
 Contains the size and position, in screen coordinates, of the bottom tab area.  
  
## Remarks  
 The framework calls this method to determine how to dock a pane that a user is dragging. When the user drags a pane over the tab area of the target pane, the framework tries to add it as a new tab of the target pane. Otherwise, it tries to dock the pane to the side of the target pane, which involves creating a new pane container with a pane divider that separates the two panes.  
  
 Override this method in a `CTabbedPane`-derived class to change this behavior.  
  
## Requirements  
 **Header:** afxTabbedPane.h  
  
## See Also  
 [CTabbedPane Class](../vs140/ctabbedpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)