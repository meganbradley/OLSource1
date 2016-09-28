---
title: "CBaseTabbedPane::AddTab"
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
  - "AddTab"
  - "CBaseTabbedPane.AddTab"
  - "CBaseTabbedPane::AddTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddTab method"
ms.assetid: 72ca5bee-59e8-4be0-ad0f-4672455a06f9
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBaseTabbedPane::AddTab
Adds a new tab to a tabbed pane.  
  
## Syntax  
  
```  
virtual BOOL AddTab(  
    CWnd* pNewBar,  
    BOOL bVisible = TRUE,  
    BOOL bSetActive = TRUE,  
    BOOL bDetachable = TRUE  
);  
```  
  
#### Parameters  
 [in] [out] `pNewBar`  
 A pointer to the pane to add. This pointer may become invalid after you call this method. For more information, see the Remarks section.  
  
 [in] `bVisible`  
 `TRUE` to make the tab visible; otherwise, `FALSE`.  
  
 [in] `bSetActive`  
 `TRUE` to make the tab the active tab; otherwise, `FALSE`.  
  
 [in] `bDetachable`  
 `TRUE` to make the tab detachable; otherwise, `FALSE`.  
  
## Return Value  
 `TRUE` if the pane was successfully added as a tab and was not destroyed in the process. `FALSE` if the pane being added is an object of type `CBaseTabbedPane`. For more information, see the Remarks section.  
  
## Remarks  
 Call this method to add a pane as a new tab on a tabbed pane. If `pNewBar` points to an object of type `CBaseTabbedPane`, all its tabs are copied onto the tabbed pane and then `pNewBar` is destroyed. Thus, `pNewBar` becomes an invalid pointer and should not be used.  
  
## Requirements  
 **Header:** afxBaseTabbedPane.h  
  
## See Also  
 [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)