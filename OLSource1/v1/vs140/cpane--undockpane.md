---
title: "CPane::UndockPane"
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
  - "CPane.UndockPane"
  - "UndockPane"
  - "CPane::UndockPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UndockPane method"
ms.assetid: 0f06a808-ee89-4835-b476-b175182b23c2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::UndockPane
Removes the pane from the dock site, default slider, or mini-frame window where it is currently docked.  
  
## Syntax  
  
```  
virtual void UndockPane(  
   BOOL bDelay = FALSE  
);  
```  
  
#### Parameters  
 [in] `bDelay`  
 If `FALSE`, the framework calls [CBasePane::AdjustDockingLayout](../vs140/cbasepane--adjustdockinglayout.md) to adjust the docking layout.  
  
## Remarks  
 Use this method to programmatically undock a pane.  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)