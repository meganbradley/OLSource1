---
title: "CDockablePane::UndockPane"
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
  - "CDockablePane.UnDockPane"
  - "UnDockPane"
  - "CDockablePane::UnDockPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UnDockPane method"
ms.assetid: a1f85bfd-3818-42f4-aac4-c145bffd93c3
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::UndockPane
Undocks a pane from either the main frame window or a miniframe window container.  
  
## Syntax  
  
```  
virtual void UndockPane(  
    BOOL bDelay = FALSE  
);  
```  
  
#### Parameters  
 [in] `bDelay`  
 `TRUE` to delay calculating the docking layout; `FALSE` to recalculate the docking layout immediately.  
  
## Remarks  
 Call this method to undock a pane from the main frame window or from a multi-miniframe window container (a pane that is floating in a single miniframe window with other panes).  
  
 You must undock a pane before you perform any external operation that is not performed by the [CDockingManager](../vs140/cdockingmanager-class.md). For example, you must undock a pane to move it programmatically from one location to another.  
  
 The framework automatically undocks panes before they are destroyed.  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)