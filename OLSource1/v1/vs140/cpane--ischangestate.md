---
title: "CPane::IsChangeState"
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
  - CPane.IsChangeState
  - IsChangeState
  - CPane::IsChangeState
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsChangeState method
ms.assetid: f087a997-dfab-49ca-aeca-6fa3b9c1873f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPane::IsChangeState
As the pane is being moved, this method analyzes its position relative to other panes, dock rows, and mini-frame windows, and returns the appropriate `AFX_CS_STATUS` value.  
  
## Syntax  
  
```  
virtual AFX_CS_STATUS IsChangeState(  
   int nOffset,  
   CBasePane** ppTargetBar  
) const;  
```  
  
#### Parameters  
 [in] `nOffset`  
 Specifies docking sensitivity. For example, a pane that is moved within `nOffset` pixels from a dock row will be docked.  
  
 [in] `ppTargetBar`  
 When the method returns, `ppTargetBar` contains either a pointer to the object to which the current pane should be docked, or `NULL` if no docking should occur.  
  
## Return Value  
 One of the following `AFX_CS_STATUS` values:  
  
|Value|Description|  
|-----------|-----------------|  
|`CS_NOTHING`|The pane is not near a dock site. The framework does not dock the pane.|  
|`CS_DOCK_IMMEDIATELY`|The pane is over a dock site, and the `DT_IMMEDIATE` style is enabled. The framework docks the pane immediately.|  
|`CS_DELAY_DOCK`|The pane is over a dock site that is either another docking pane or an edge of the main frame. The framework docks the pane when the user releases the move.|  
|`CS_DELAY_DOCK_TO_TAB`|The pane is over a dock site that causes the pane to be docked in a tabbed window. This occurs when the pane is either over the caption of another docking pane or over the tab area of a tabbed pane. The framework docks the pane when the user releases the move.|  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)