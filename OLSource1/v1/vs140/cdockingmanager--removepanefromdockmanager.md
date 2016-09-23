---
title: "CDockingManager::RemovePaneFromDockManager"
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
  - RemovePaneFromDockManager
  - CDockingManager.RemovePaneFromDockManager
  - CDockingManager::RemovePaneFromDockManager
dev_langs: 
  - C++
helpviewer_keywords: 
  - RemovePaneFromDockManager method
ms.assetid: ba04acc9-a33f-4eb0-b337-a6661fb8c75f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDockingManager::RemovePaneFromDockManager
Unregisters a pane and removes it from the list in the docking manager.  
  
## Syntax  
  
```  
void RemovePaneFromDockManager(  
   CBasePane* pWnd,  
   BOOL bDestroy,  
   BOOL bAdjustLayout,  
   BOOL bAutoHide = FALSE,  
   CBasePane* pBarReplacement = NULL  
);  
```  
  
#### Parameters  
 [in] `pWnd`  
 A pointer to a pane to be removed.  
  
 [in] `bDestroy`  
 If `TRUE`, the removed pane is destroyed.  
  
 [in] `bAdjustLayout`  
 If `TRUE`, adjust the docking layout immediately.  
  
 [in] `bAutoHide`  
 If `TRUE`, the pane is removed from the list of autohide bars. If `FALSE`, the pane is removed from the list of regular panes.  
  
 [in] `pBarReplacement`  
 A pointer to a pane that replaces the removed pane.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)