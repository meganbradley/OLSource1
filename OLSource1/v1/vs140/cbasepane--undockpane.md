---
title: "CBasePane::UndockPane"
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
  - "CBasePane::UndockPane"
  - "CBasePane.UndockPane"
  - "UndockPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UnDockPane method"
ms.assetid: 412045c9-3b5f-4a72-b196-006d33a89708
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::UndockPane
Removes the pane from the dock site, default slider, or mini-frame window where it is currently docked.  
  
## Syntax  
  
```  
virtual void UndockPane(  
   BOOL bDelay=FALSE  
);  
```  
  
#### Parameters  
 `bDelay`  
 If TRUE, the docking layout is not recalculated immediately.  
  
## Remarks  
 Call this method to manipulate the pane state or exclude the pane from the docking layout.  
  
 If you want to continue to use this pane, call either [CBasePane::DockPane](../vs140/cbasepane--dockpane.md) or [CBasePane::FloatPane](../vs140/cbasepane--floatpane.md) before calling this method.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)