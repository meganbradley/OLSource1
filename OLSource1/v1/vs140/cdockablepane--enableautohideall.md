---
title: "CDockablePane::EnableAutohideAll"
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
  - CDockablePane::EnableAutohideAll
  - EnableAutohideAll
  - CDockablePane.EnableAutohideAll
dev_langs: 
  - C++
helpviewer_keywords: 
  - EnableAutohideAll method
ms.assetid: 23bd63aa-4455-4ac5-8d16-78732c581959
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDockablePane::EnableAutohideAll
Enables or disables autohide mode for this pane and for other panes in the container.  
  
## Syntax  
  
```  
void EnableAutohideAll(  
    BOOL bEnable = TRUE  
);  
```  
  
#### Parameters  
 [in] `bEnable`  
 `TRUE` to enable the autohide all feature for the dockable pane; otherwise, `FALSE`.  
  
## Remarks  
 When a user holds the `Ctrl` key and clicks the pin button to switch a pane to autohide mode, all other panes in the same container are also switched to autohide mode.  
  
 Call this method with `bEnable` set to `FALSE` to disable this feature for a particular pane.  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)