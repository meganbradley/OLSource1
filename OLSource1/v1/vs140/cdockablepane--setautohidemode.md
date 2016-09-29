---
title: "CDockablePane::SetAutoHideMode"
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
  - "CDockablePane.SetAutoHideMode"
  - "CDockablePane::SetAutoHideMode"
  - "SetAutoHideMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAutoHideMode method"
ms.assetid: 38650132-b2f6-4ebe-b730-56ae0eb63999
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::SetAutoHideMode
Toggles the docking pane between visible and autohide mode.  
  
## Syntax  
  
```  
virtual CMFCAutoHideBar* SetAutoHideMode(  
    BOOL bMode,  
    DWORD dwAlignment,  
    CMFCAutoHideBar* pCurrAutoHideBar = NULL,  
    BOOL bUseTimer = TRUE  
);  
```  
  
#### Parameters  
 [in] `bMode`  
 `TRUE` to enable autohide mode; `FALSE` to enable regular docking mode.  
  
 [in] `dwAlignment`  
 Specifies the alignment of the autohide pane to create.  
  
 [in] [out] `pCurrAutoHideBar`  
 A pointer to the current autohide toolbar. Can be `NULL`.  
  
 [in] `bUseTimer`  
 Specifies whether to use the autohide effect when the user switches the pane to autohide mode or to hide the pane immediately.  
  
## Return Value  
 The autohide toolbar that was created as a result of switching to autohide mode, or `NULL`.  
  
## Remarks  
 The framework calls this method when a user clicks the pin button to switch the dockable pane to autohide mode or to regular docking mode.  
  
 Call this method to switch a dockable pane to autohide mode programmatically. The pane must be docked to the main frame window ([CDockablePane::GetDefaultPaneDivider](../vs140/cdockablepane--getdefaultpanedivider.md) must return a valid pointer to the [CPaneDivider](../vs140/cpanedivider-class.md)).  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)