---
title: "CPane::OnShowControlBarMenu"
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
  - "OnShowPaneMenu"
  - "CPane.OnShowPaneMenu"
  - "CPane::OnShowPaneMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnShowPaneMenu method"
ms.assetid: 920e17d6-26b1-4f44-b1fa-b3ad8f165b00
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::OnShowControlBarMenu
Called by the framework when a special pane menu is about to be displayed.  
  
## Syntax  
  
```  
virtual BOOL OnShowControlBarMenu(  
    CPoint point  
);  
```  
  
#### Parameters  
 [in] `point`  
 Specifies the menu location.  
  
## Return Value  
 `TRUE` if the menu can be displayed; otherwise, `FALSE`.  
  
## Remarks  
 The menu contains several items that enable you to specify the pane's behavior, namely: **Floating**, **Docking**, **AutoHide**, and **Hide**. You can enable this menu for all panes by calling [CDockingManager::EnableDockSiteMenu](../vs140/cdockingmanager--enabledocksitemenu.md).  
  
## Requirements  
 **Header:** afxPane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)