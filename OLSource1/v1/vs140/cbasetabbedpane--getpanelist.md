---
title: "CBaseTabbedPane::GetPaneList"
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
  - CBaseTabbedPane.GetPaneList
  - CBaseTabbedPane::GetPaneList
  - GetPaneList
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetPaneList method
ms.assetid: 0ae94bc8-f972-48eb-a822-1b570f41a1a5
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBaseTabbedPane::GetPaneList
Returns a list of panes that are contained in the tabbed pane.  
  
## Syntax  
  
```  
virtual void GetPaneList(  
   CObList& lst,  
   CRuntimeClass* pRTCFilter = NULL  
);  
```  
  
#### Parameters  
 [out] `lst`  
 A `CObList` that is filled with the panes that are contained in the tabbed pane.  
  
 [in] `pRTCFilter`  
 If it is not `NULL`, the returned list contains only panes that are of the specified runtime class.  
  
## Requirements  
 **Header:** afxbasetabbedpane.h  
  
## See Also  
 [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CDockingManager::GetPaneList](../vs140/cdockingmanager--getpanelist.md)