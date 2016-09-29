---
title: "CDockingManager::AlignAutoHidePane"
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
  - "CDockingManager.AlignAutoHidePane"
  - "AlignAutoHidePane"
  - "CDockingManager::AlignAutoHidePane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AlignAutoHidePane method"
ms.assetid: e75daaa2-c7e0-4e93-b2b5-c49ad3d5dfbc
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::AlignAutoHidePane
Resizes a docking pane in autohide mode so that it takes the full width or height of the frame’s client area surrounded by dock sites.  
  
## Syntax  
  
```  
void AlignAutoHidePane(  
   CPaneDivider* pDefaultSlider,  
   BOOL bIsVisible = TRUE  
);  
```  
  
#### Parameters  
 [in] `pDefaultSlider`  
 The docking slider pane.  
  
 [in] `bIsVisible`  
 `TRUE` if the docking pane is visible; `FALSE` otherwise.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)