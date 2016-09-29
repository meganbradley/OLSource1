---
title: "COleIPFrameWndEx::DockPaneLeftOf"
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
  - "COleIPFrameWndEx.DockPaneLeftOf"
  - "DockPaneLeftOf"
  - "COleIPFrameWndEx::DockPaneLeftOf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DockPaneLeftOf method"
ms.assetid: 227799da-d29e-43c4-afd5-9d3bc85ee047
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleIPFrameWndEx::DockPaneLeftOf
Docks one pane to the left of another pane.  
  
## Syntax  
  
```  
BOOL DockPaneLeftOf(  
   CPane* pBar,  
   CPane* pLeftOf   
);  
```  
  
#### Parameters  
 [in] `pBar`  
 A pointer to the pane to dock.  
  
 [in] `pLeftOf`  
 A pointer to the pane that serves as origin.  
  
## Return Value  
 Returns `TRUE` if the operation is successful. Otherwise returns `FALSE`.  
  
## Remarks  
 Call this method to dock several pane objects in a predefined order. This method docks the pane specified by `pBar` to the left of the pane specified by `pLeftOf`.  
  
## Requirements  
 **Header:** afxoleipframewndex.h  
  
## See Also  
 [COleIPFrameWndEx Class](../vs140/coleipframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)