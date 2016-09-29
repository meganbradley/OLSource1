---
title: "CDockingManager::DisableRestoreDockState"
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
  - "DisableRestoreDockState"
  - "CDockingManager.DisableRestoreDockState"
  - "CDockingManager::DisableRestoreDockState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DisableRestoreDockState method"
ms.assetid: e8b7c043-b185-48d2-aa3b-4609a45ee11c
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::DisableRestoreDockState
Enables or disables loading of docking layout from the registry.  
  
## Syntax  
  
```  
void DisableRestoreDockState(  
    BOOL bDisable = TRUE  
);  
```  
  
#### Parameters  
 [in] `bDisable`  
 `TRUE` to disable loading of docking layout from the registry; otherwise, `FALSE`.  
  
## Remarks  
 Call this method when you must preserve the current layout of docking panes and toolbars when the application state is loading.  
  
## Requirements  
 **Header:** afxDockingManager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)