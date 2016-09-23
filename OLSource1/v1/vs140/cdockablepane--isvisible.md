---
title: "CDockablePane::IsVisible"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CDockablePane.IsVisible
  - CDockablePane::IsVisible
  - IsVisible
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsVisible method
ms.assetid: 55e838e9-7780-47c8-aca2-9030fbc21be5
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDockablePane::IsVisible
Determines whether the current pane is visible.  
  
## Syntax  
  
```  
virtual BOOL IsVisible() const;  
```  
  
## Return Value  
 `TRUE` if the dockable pane is visible; otherwise, `FALSE`.  
  
## Remarks  
 Call this method to determine whether a dockable pane is visible. You can use this method instead of calling [CWnd::IsWindowVisible](../vs140/cwnd--iswindowvisible.md) or testing for the `WS_VISIBLE` style. The returned visibility state depends on whether autohide mode is enabled or disabled and on the value of the [CDockablePane::IsHideInAutoHideMode](../vs140/cdockablepane--ishideinautohidemode.md) property.  
  
 If the dockable pane is in autohide mode and `IsHideInAutoHideMode` returns `FALSE` the visibility state is always `FALSE`.  
  
 If the dockable pane is in autohide mode and `IsHideInAutoHideMode` returns `TRUE` the visibility state depends on the visibility state of the related autohide toolbar.  
  
 If the dockable pane is not in autohide mode, the visibility state is determined by the [CBasePane::IsVisible](../vs140/cbasepane--isvisible.md) method.  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCAutoHideBar Class](../vs140/cmfcautohidebar-class.md)