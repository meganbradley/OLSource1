---
title: "CPane::GetDockSiteRow"
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
  - CPane.GetDockSiteRow
  - CPane::GetDockSiteRow
  - GetDockSiteRow
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetDockSiteRow method
ms.assetid: 7db0d4ad-bd7a-40bd-8be0-b5b9024fe9b3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPane::GetDockSiteRow
Returns the dock row ([CDockingPanesRow Class](../vs140/cdockingpanesrow-class.md)) in which the pane is docked.  
  
## Syntax  
  
```  
CDockingPanesRow* GetDockSiteRow() const;  
```  
  
## Return Value  
 A `CDockingPanesRow`* that points to the dock row in which the pane is docked, or `NULL` if the pane is not docked.  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDockingPanesRow Class](../vs140/cdockingpanesrow-class.md)