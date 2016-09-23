---
title: "CMDIChildWndEx::DockPaneLeftOf"
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
  - DockPaneLeftOf
  - CMDIChildWndEx.DockPaneLeftOf
  - CMDIChildWndEx::DockPaneLeftOf
dev_langs: 
  - C++
helpviewer_keywords: 
  - DockPaneLeftOf method
ms.assetid: fbb23334-a8dd-41f9-a043-2b105177f8c3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMDIChildWndEx::DockPaneLeftOf
Docks one pane to the left of another pane.  
  
## Syntax  
  
```  
BOOL DockPaneLeftOf(  
   CPane* pBar,  
   CPane* pLeftOf   
);  
```  
  
#### Parameters  
 `pBar`  
 A pointer to the pane that is to be docked.  
  
 `pLeftOf`  
 A pointer to the pane that serves as the point of reference.  
  
## Return Value  
 `TRUE` on success, `FALSE` on failure.  
  
## Remarks  
 This method takes the pane specified by `pBar` and docks it at the left side of the pane specified by `pLeftOf`.  
  
 Call this method when you want to dock several panes in predefined order.  
  
## Requirements  
 **Header:** afxMDIChildWndEx.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)