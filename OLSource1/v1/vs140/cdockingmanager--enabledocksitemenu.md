---
title: "CDockingManager::EnableDockSiteMenu"
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
  - CDockingManager::EnableDockSiteMenu
  - EnableDockSiteMenu
  - CDockingManager.EnableDockSiteMenu
dev_langs: 
  - C++
helpviewer_keywords: 
  - EnableDockSiteMenu method
ms.assetid: 7913d97b-4081-489e-8b6c-c751cae0b305
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDockingManager::EnableDockSiteMenu
Displays an additional button that opens a pop-up menu on the captions of all docking panes.  
  
## Syntax  
  
```  
static void EnableDockSiteMenu(  
    BOOL bEnable = TRUE  
);  
```  
  
#### Parameters  
 [in] `bEnable`  
 `TRUE` to enable the dock site menu; otherwise, `FALSE`.  
  
## Remarks  
 The dock site menu displays the following options for changing the docking state of the pane:  
  
-   `Floating` - Floats a pane  
  
-   `Docking` - Docks a pane at the main frame at the location where the pane was last docked  
  
-   `AutoHide` - Switches the pane to autohide mode  
  
-   `Hide` - Hides a pane  
  
 By default, this menu is not displayed.  
  
## Requirements  
 **Header:** afxDockingManager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)