---
title: "CMFCRibbonMiniToolBar::ShowWithContextMenu"
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
  - ShowWithContextMenu
  - CMFCRibbonMiniToolBar.ShowWithContextMenu
  - CMFCRibbonMiniToolBar::ShowWithContextMenu
dev_langs: 
  - C++
helpviewer_keywords: 
  - ShowWithContextMenu method
ms.assetid: 074575bf-18ef-477e-ae5e-6844c9610e66
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonMiniToolBar::ShowWithContextMenu
Displays the mini toolbar together with a context menu.  
  
## Syntax  
  
```  
BOOL ShowWithContextMenu(  
    int x,  
    int y,  
    UINT uiMenuResID,  
    CWnd* pWndOwner   
);  
```  
  
#### Parameters  
 [in] `x`  
 Specifies the horizontal position of the context menu in screen coordinates.  
  
 [in] `y`  
 Specifies the vertical position of the context menu in screen coordinates.  
  
 [in] `uiMenuResID`  
 Specifies the resource ID of the context menu to display.  
  
 [in] `pWndOwner`  
 Identifies the window which receives messages from the context menu.  
  
## Return Value  
 `TRUE` if the context menu was displayed successfully; otherwise, `FALSE`.  
  
## Remarks  
 Use this function to display a mini toolbar that has a context menu. The context menu is positioned 15 pixels below the mini toolbar.  
  
## Requirements  
 **Header:** afxRibbonMiniToolBar.h  
  
## See Also  
 [CMFCRibbonMiniToolBar Class](../vs140/cmfcribbonminitoolbar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)