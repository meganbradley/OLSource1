---
title: "CDockingManager::DeterminePaneAndStatus"
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
  - "DeterminePaneAndStatus"
  - "CDockingManager::DeterminePaneAndStatus"
  - "CDockingManager.DeterminePaneAndStatus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeterminePaneAndStatus method"
ms.assetid: fb33c9fe-c073-4fc5-9823-fe26250191ed
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::DeterminePaneAndStatus
Determines the pane that contains a given point and its docking status.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The location of the pane to check.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The value to increase the window rectangle of each checked pane. A pane satisfies the search criteria if the given point is in this increased region.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The alignment of the docking pane.  
  
 [out] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to a pointer to the target pane.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The pane that the method ignores.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
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