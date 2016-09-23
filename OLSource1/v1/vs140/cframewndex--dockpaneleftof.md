---
title: "CFrameWndEx::DockPaneLeftOf"
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
  - CFrameWndEx::DockPaneLeftOf
  - CFrameWndEx.DockPaneLeftOf
dev_langs: 
  - C++
helpviewer_keywords: 
  - DockPaneLeftOf method
ms.assetid: 92d9b686-e325-47e1-8bd8-fc66360cd99d
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFrameWndEx::DockPaneLeftOf
Docks the specified pane to the left of another pane.  
  
## Syntax  
  
```  
BOOL DockPaneLeftOf(  
   CPane* pBar,  
   CPane* pLeftOf   
);  
```  
  
#### Parameters  
 [in] `pBar`  
 A pointer to the pane object to be docked.  
  
 [in] `pLeftOf`  
 A pointer to the pane to the left of which to dock the pane specified by `pBar`.  
  
## Return Value  
 `TRUE` if `pBar` is docked successfully. `FALSE` otherwise.  
  
## Remarks  
 The method takes the toolbar specified by the `pBar` parameter and docks it at the left side of the toolbar specified by `pLeftOf` parameter.  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)