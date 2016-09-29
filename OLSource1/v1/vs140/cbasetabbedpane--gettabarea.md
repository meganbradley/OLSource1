---
title: "CBaseTabbedPane::GetTabArea"
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
  - "GetTabArea"
  - "CBaseTabbedPane::GetTabArea"
  - "CBaseTabbedPane.GetTabArea"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTabArea method"
ms.assetid: 7584caac-cd92-4913-921b-9d3f0f3bf44f
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBaseTabbedPane::GetTabArea
Returns the bounding rectangles for the top and bottom tab areas.  
  
## Syntax  
  
```  
virtual void GetTabArea(  
    CRect& rectTabAreaTop,  
    CRect& rectTabAreaBottom  
) const = 0;  
```  
  
#### Parameters  
 [out] `rectTabAreaTop`  
 Receives the screen coordinates of the upper tab area.  
  
 [out] `rectTabAreaBottom`  
 Receives the screen coordinates of the lower tab area.  
  
## Remarks  
 Call this method to determine the bounding rectangles, in screen coordinates, for the upper and lower tab areas.  
  
## Requirements  
 **Header:** afxBaseTabbedPane.h  
  
## See Also  
 [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)