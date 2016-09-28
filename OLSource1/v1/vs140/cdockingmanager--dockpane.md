---
title: "CDockingManager::DockPane"
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
  - "DockPane"
  - "CDockingManager.DockPane"
  - "CDockingManager::DockPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DockPane method"
ms.assetid: a1ff633b-a15a-4f36-bb98-ac1117eeecc3
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::DockPane
Docks a pane to another pane or to a frame window.  
  
## Syntax  
  
```  
void DockPane(  
   CBasePane* pBar,  
   UINT nDockBarID = 0,  
   LPCRECT lpRect = NULL  
);  
```  
  
#### Parameters  
 [in] `pBar`  
 A pointer to a bar pane to dock to.  
  
 [in] `nDockBarID`  
 The id of the bar to dock.  
  
 [in] `lpRect`  
 The destination rectangle.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)