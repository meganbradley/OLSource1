---
title: "CDockablePane::DockToWindow"
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
  - "CDockablePane.DockToWindow"
  - "DockToWindow"
  - "CDockablePane::DockToWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DockToWindow method"
ms.assetid: f2707573-6ba2-4150-b914-0b79aed28b41
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::DockToWindow
Docks one docking pane to another docking pane.  
  
## Syntax  
  
```  
virtual BOOL DockToWindow(  
    CDockablePane* pTargetWindow,  
    DWORD dwAlignment,  
    LPCRECT lpRect = NULL  
);  
```  
  
#### Parameters  
 [in] [out] `pTargetWindow`  
 Specifies the dockable pane to dock this pane to.  
  
 [in] `dwAlignment`  
 Specifies the docking alignment for the pane. May be one of CBRS_ALIGN_LEFT, CBRS_ALIGN_TOP, CBRS_ALIGN_RIGHT, CBRS_ALIGN_BOTTOM or CBRS_ALIGN_ANY. (Defined in afxres.h.)  
  
 [in] `lpRect`  
 Specifies the docking rectangle for the pane.  
  
## Return Value  
 `TRUE` if the pane was docked successfully; otherwise, `FALSE`.  
  
## Remarks  
 Call this method to dock one pane to another pane with the alignment specified by `dwAlignment`.  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)