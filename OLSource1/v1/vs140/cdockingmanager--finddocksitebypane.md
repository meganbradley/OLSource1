---
title: "CDockingManager::FindDockSiteByPane"
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
  - CDockingManager.FindDockSiteByPane
  - FindDockSiteByPane
  - CDockingManager::FindDockSiteByPane
dev_langs: 
  - C++
helpviewer_keywords: 
  - FindDockSiteByPane method
ms.assetid: c9352ad1-971f-4d98-b533-1840840dd752
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDockingManager::FindDockSiteByPane
Returns the bar pane that has the id of the target bar pane.  
  
## Syntax  
  
```  
virtual CDockSite* FindDockSiteByPane(  
   CPane* pTargetBar  
);  
```  
  
#### Parameters  
 [in] `pTargetBar`  
 A pointer to the target bar pane.  
  
## Return Value  
 The bar pane that has the id of the target bar pane; `NULL` if no such bar pane exists.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)