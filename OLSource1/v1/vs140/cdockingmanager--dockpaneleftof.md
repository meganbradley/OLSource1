---
title: "CDockingManager::DockPaneLeftOf"
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
  - "DockPaneLeftOf"
  - "CDockingManager::DockPaneLeftOf"
  - "CDockingManager.DockPaneLeftOf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DockPaneLeftOf method"
ms.assetid: fe8eda08-e8f4-4cf1-b49a-94d53b6890c2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::DockPaneLeftOf
Docks a pane to the left of another pane.  
  
## Syntax  
  
```  
BOOL DockPaneLeftOf(  
   CPane* pBarToDock,  
   CPane* pTargetBar  
);  
```  
  
#### Parameters  
 [in] `pBarToDock`  
 A pointer to the pane to be docked to the left of `pTargetBar`.  
  
 [in] `pTargetBar`  
 A pointer to the target pane.  
  
## Return Value  
 `TRUE` if the pane was docked successfully; otherwise, `FALSE`.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)