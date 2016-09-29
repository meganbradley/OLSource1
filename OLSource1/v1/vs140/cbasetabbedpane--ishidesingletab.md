---
title: "CBaseTabbedPane::IsHideSingleTab"
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
  - "CBaseTabbedPane.IsHideSingleTab"
  - "CBaseTabbedPane::IsHideSingleTab"
  - "IsHideSingleTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsHideSingleTab method"
ms.assetid: eab19c36-2b0f-448f-8322-f8411c4e5c62
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBaseTabbedPane::IsHideSingleTab
Determines whether the tabbed pane is hidden if only one tab is displayed.  
  
## Syntax  
  
```  
virtual BOOL IsHideSingleTab() const;  
```  
  
## Return Value  
 `TRUE` if the tab window is not shown when there is only one visible tab; otherwise, `FALSE`.  
  
## Remarks  
 If the pane is not displayed because only one tab is open, you can call this method to determine whether the tabbed pane is working correctly.  
  
## Requirements  
 **Header:** afxBaseTabbedPane.h  
  
## See Also  
 [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)