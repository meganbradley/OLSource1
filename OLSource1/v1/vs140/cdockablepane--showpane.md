---
title: "CDockablePane::ShowPane"
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
  - "CDockablePane::ShowPane"
  - "ShowPane"
  - "CDockablePane.ShowPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShowPane method"
ms.assetid: d4eaa0a0-dd58-423b-959f-9e1ac5a05b58
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::ShowPane
Shows or hides a pane.  
  
## Syntax  
  
```  
virtual void ShowPane(  
    BOOL bShow,  
    BOOL bDelay,  
    BOOL bActivate  
);  
```  
  
#### Parameters  
 [in] `bShow`  
 `TRUE` to show the pane; `FALSE` to hide the pane.  
  
 [in] `bDelay`  
 `TRUE` to delay adjusting the docking layout; `FALSE` to adjust the docking layout immediately.  
  
 [in] `bActivate`  
 `TRUE` to activate the pane when shown; otherwise, `FALSE`.  
  
## Remarks  
 Call this method instead of the [CWnd::ShowWindow](../vs140/cwnd--showwindow.md) when showing or hiding dockable panes.  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)