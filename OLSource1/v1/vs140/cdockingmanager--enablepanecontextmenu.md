---
title: "CDockingManager::EnablePaneContextMenu"
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
  - "EnablePaneContextMenu"
  - "CDockingManager.EnablePaneContextMenu"
  - "CDockingManager::EnablePaneContextMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnablePaneContextMenu method"
ms.assetid: bbbd7ead-b879-4409-8c78-973755adfe63
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::EnablePaneContextMenu
Tells the library to display a special context menu that has a list of application toolbars and docking panes when the user clicks the right mouse button and the library is processing the WM_CONTEXTMENU message.  
  
## Syntax  
  
```  
void EnablePaneContextMenu(  
   BOOL bEnable,  
   UINT uiCustomizeCmd,  
   const CString& strCustomizeText,  
   BOOL bToolbarsOnly = FALSE  
);  
```  
  
#### Parameters  
 [in] `bEnable`  
 If `TRUE`, the library turns on the support for automatic context menu; if `FALSE` the library turns off the support for automatic context menu.  
  
 [in] `uiCustomizeCmd`  
 A command id for the **Customize** item in the menu.  
  
 [in] `strCustomizeText`  
 The text of the **Customize** item.  
  
 [in] `bToolbarsOnly`  
 If `TRUE`, the menu displays only a list of application toolbars; if `FALSE`, the library adds application docking panes to this list.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)