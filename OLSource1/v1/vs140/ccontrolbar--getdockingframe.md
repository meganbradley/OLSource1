---
title: "CControlBar::GetDockingFrame"
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
  - "GetDockingFrame"
  - "CControlBar::GetDockingFrame"
  - "CControlBar.GetDockingFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CControlBar class, attributes"
  - "GetDockingFrame method"
ms.assetid: 8113bc0d-0cdb-40b6-9fe9-8d1a60176a5b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CControlBar::GetDockingFrame
Call this member function to obtain a pointer to the current frame window to which your control bar is docked.  
  
## Syntax  
  
```  
  
CFrameWnd* GetDockingFrame( ) const;  
  
```  
  
## Return Value  
 A pointer to a frame window if successful; otherwise **NULL**.  
  
 If the control bar is not docked to a frame window (that is, if the control bar is floating), this function will return a pointer to its parent [CMiniFrameWnd](../vs140/cminiframewnd-class.md).  
  
## Remarks  
 For more information about dockable control bars, see [CControlBar::EnableDocking](../vs140/ccontrolbar--enabledocking.md) and [CFrameWnd::DockControlBar](../vs140/cframewnd--dockcontrolbar.md).  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CControlBar Class](../vs140/ccontrolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CControlBar::EnableDocking](../vs140/ccontrolbar--enabledocking.md)   
 [CFrameWnd::DockControlBar](../vs140/cframewnd--dockcontrolbar.md)