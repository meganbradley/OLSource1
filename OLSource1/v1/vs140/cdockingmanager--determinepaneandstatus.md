---
title: "CDockingManager::DeterminePaneAndStatus"
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
  - DeterminePaneAndStatus
  - CDockingManager::DeterminePaneAndStatus
  - CDockingManager.DeterminePaneAndStatus
dev_langs: 
  - C++
helpviewer_keywords: 
  - DeterminePaneAndStatus method
ms.assetid: fb33c9fe-c073-4fc5-9823-fe26250191ed
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDockingManager::DeterminePaneAndStatus
Determines the pane that contains a given point and its docking status.  
  
## Syntax  
  
```  
virtual AFX_CS_STATUS DeterminePaneAndStatus(  
   CPoint pt,  
   int nSensitivity,  
   DWORD dwEnabledAlignment,  
   CBasePane** ppTargetBar,  
   const CBasePane* pBarToIgnore,  
   const CBasePane* pBarToDock  
);  
```  
  
#### Parameters  
 [in] `pt`  
 The location of the pane to check.  
  
 [in] `nSensitivity`  
 The value to increase the window rectangle of each checked pane. A pane satisfies the search criteria if the given point is in this increased region.  
  
 [in] `dwEnabledAlignment`  
 The alignment of the docking pane.  
  
 [out] `ppTargetBar`  
 A pointer to a pointer to the target pane.  
  
 [in] `pBarToIgnore`  
 The pane that the method ignores.  
  
 [in] `pBarToDock`  
 The pane that is docked.  
  
## Return Value  
 The docking status.  
  
## Remarks  
 The docking status can be one of the following values:  
  
|AFX_CS_STATUS value|Meaning|  
|---------------------------|-------------|  
|CS_NOTHING|The pointer is not over a dock site. Therefore, keep the pane floating.|  
|CS_DOCK_IMMEDIATELY|The pointer is over the dock site in the immediate mode (DT_IMMEDIATE style is enabled), so the pane must be docked immediately.|  
|CS_DELAY_DOCK|The pointer is over a dock site that is another docking pane or is an edge of the main frame.|  
|CS_DELAY_DOCK_TO_TAB|The pointer is over a dock site that causes the pane to be docked in a tabbed window. This occurs when the mouse is over a caption of another docking pane or over a tab area of a tabbed pane.|  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)