---
title: "CBaseTabbedPane::ShowTab"
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
  - CBaseTabbedPane::ShowTab
  - ShowTab
  - CBaseTabbedPane.ShowTab
dev_langs: 
  - C++
helpviewer_keywords: 
  - ShowTab method
ms.assetid: 76ceccea-19fa-4b60-b2c3-71b97dd2c92c
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBaseTabbedPane::ShowTab
Shows or hides a tab.  
  
## Syntax  
  
```  
virtual BOOL ShowTab(  
    CWnd* pBar,  
    BOOL bShow,  
    BOOL bDelay,  
    BOOL bActivate  
);  
```  
  
#### Parameters  
 [in] `pBar`  
 A pointer to the pane to show or hide.  
  
 [in] `bShow`  
 `TRUE` to show the pane; `FALSE` to hide the pane.  
  
 [in] `bDelay`  
 `TRUE` to delay the adjustment of the tab layout; otherwise, `FALSE`.  
  
 [in] `bActivate`  
 `TRUE` to make the tab the active tab; otherwise, `FALSE`.  
  
## Return Value  
 `TRUE` if the tab was either shown or hidden successfully; otherwise, `FALSE`.  
  
## Remarks  
 When you call this method, a pane is either shown or hidden, depending on the value of the `bShow` parameter. If you hide a tab and it is the last visible tab in the underlying tab window, the tabbed pane is hidden. If you show a tab when there were previously no tabs visible, the tabbed pane is shown.  
  
## Requirements  
 **Header:** afxBaseTabbedPane.h  
  
## See Also  
 [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)