---
title: "CFrameWndEx::EnablePaneMenu"
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
  - "CFrameWndEx::EnablePaneMenu"
  - "CFrameWndEx.EnablePaneMenu"
  - "EnablePaneMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnablePaneMenu method"
ms.assetid: 190123b7-888e-473e-a294-833c66dc00af
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::EnablePaneMenu
Enables or disables the automatic handling of the pane menu.  
  
## Syntax  
  
```  
void EnablePaneMenu(  
   BOOL bEnable,  
   UINT uiCustomizeCmd,  
   const CString& strCustomizeLabel,  
   UINT uiViewToolbarsMenuEntryID,  
   BOOL bContextMenuShowsToolbarsOnly=FALSE,  
   BOOL bViewMenuShowsToolbarsOnly=FALSE   
);  
```  
  
#### Parameters  
 [in] `bEnable`  
 `TRUE` to enable the automatic handling of the control bar pop-up menus; `FALSE` to disable the automatic handling of the control bar pop-up menus.  
  
 [in] `uiCustomizeCmd`  
 The command ID of the **Customize** menu item.  
  
 [in] `strCustomizeLabel`  
 The label to be displayed for the **Customize** menu item  
  
 [in] `uiViewToolbarsMenuEntryID`  
 The ID of a toolbar menu item that opens the pop-up menu in the control bar.  
  
 [in] `bContextMenuShowsToolbarsOnly`  
 If `TRUE`, the control bar context menu displays the list of toolbars only. If `FALSE`, the menu displays the list of the toolbars and the docking bars.  
  
 [in] `bViewMenuShowsToolbarsOnly`  
 If `TRUE`, the control bar menu displays the list of the toolbars only. If `FALSE`, the menu displays the list of the toolbars and the docking bars.  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)