---
title: "CPane::DockPaneStandard"
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
  - "DockPaneStandard"
  - "CPane.DockPaneStandard"
  - "CPane::DockPaneStandard"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DockPaneStandard method"
ms.assetid: b0c6b174-af49-4ec2-966d-506a9361968f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::DockPaneStandard
Docks a pane by using outline (standard) docking.  
  
## Syntax  
  
```  
virtual CPane* DockPaneStandard(  
   BOOL& bWasDocked  
);  
```  
  
#### Parameters  
 [in] `bWasDocked`  
 `TRUE` if the pane was successfully docked; otherwise, `FALSE`.  
  
## Return Value  
 This method always returns the `this` pointer.  
  
## Remarks  
 This method is used only for panes that are derived from the [CDockablePane Class](../vs140/cdockablepane-class.md). For more information, see [CDockablePane::DockPaneStandard](../vs140/cdockablepane--dockpanestandard.md).  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)