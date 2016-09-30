---
title: "CDockablePane::m_bHideInAutoHideMode"
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
  - "CDockablePane::m_bHideInAutoHideMode"
  - "CDockablePane.m_bHideInAutoHideMode"
  - "m_bHideInAutoHideMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bHideInAutoHideMode"
  - "CDockablePane class, data members"
ms.assetid: c03bd9fb-a9f4-4005-bda2-7ed8d7735bb5
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::m_bHideInAutoHideMode
Determines the behavior of the pane when the pane is in autohide mode.  
  
## Syntax  
  
```  
AFX_IMPORT_DATA static BOOL m_bHideInAutoHideMode;  
```  
  
## Remarks  
 This value affects all docking panes in the application.  
  
 If you set this member to `TRUE`, dockable panes are hidden or shown with their related autohide toolbars and buttons when you call [CDockablePane::ShowPane](../vs140/cdockablepane--showpane.md).  
  
 If you set this member to `FALSE`, dockable panes are activated or deactivated when you call [CDockablePane::ShowPane](../vs140/cdockablepane--showpane.md).  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDockablePane::IsHideInAutoHideMode](../vs140/cdockablepane--ishideinautohidemode.md)