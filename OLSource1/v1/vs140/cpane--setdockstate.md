---
title: "CPane::SetDockState"
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
  - CPane.SetDockState
  - SetDockState
  - CPane::SetDockState
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetDockState method
ms.assetid: 80a4e9f3-a1c5-4c5a-8d9b-becdcae3b88e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPane::SetDockState
Restores docking state information for the pane.  
  
## Syntax  
  
```  
virtual void SetDockState(  
   CDockingManager* pDockManager  
);  
```  
  
#### Parameters  
 [in] `pDockManager`  
 Pointer to the docking manager for the main frame window.  
  
## Remarks  
 This method is called by the framework to restore recent docking state information for the pane. A pane stores recent docking state information in [CPane::m_recentDockInfo](../vs140/cpane--m_recentdockinfo.md). For more information, see the [CRecentDockSiteInfo Class](../vs140/crecentdocksiteinfo-class.md).  
  
 You can also call this method to set the docking state when you load pane information from an external source.  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPane::m_recentDockInfo](../vs140/cpane--m_recentdockinfo.md)   
 [CRecentDockSiteInfo Class](../vs140/crecentdocksiteinfo-class.md)