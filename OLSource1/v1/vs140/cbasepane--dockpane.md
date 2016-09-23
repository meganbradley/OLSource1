---
title: "CBasePane::DockPane"
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
  - DockPane
  - CBasePane::DockPane
  - CBasePane.DockPane
dev_langs: 
  - C++
helpviewer_keywords: 
  - DockPane method
ms.assetid: 38e5aebb-54f5-441b-8245-c606344c6caf
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBasePane::DockPane
Docks a pane to another pane or to a frame window.  
  
## Syntax  
  
```  
virtual BOOL DockPane(  
   CBasePane* pDockBar,  
   LPCRECT lpRect,  
   AFX_DOCK_METHOD dockMethod   
);  
```  
  
#### Parameters  
 [in] `pDockBar`  
 A pointer to another pane.  
  
 [in] `lpRect`  
 Specifies the destination rectangle.  
  
 [in] `dockMethod`  
 Specifies the docking method.  
  
## Return Value  
 `TRUE` if the control bar was docked successfully; otherwise, `FALSE`.  
  
## Remarks  
 Call this function to dock a pane to another pane or a dock bar ([CDockSite Class](../vs140/cdocksite-class.md)) that is specified by `pDockBar`, or to a main frame if `pDockBar` is `NULL`.  
  
 `dockMethod` specifies how the pane is docked. See [CPane::DockPane](../vs140/cpane--dockpane.md) for a list of possible values.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPane::DockPane](../vs140/cpane--dockpane.md)