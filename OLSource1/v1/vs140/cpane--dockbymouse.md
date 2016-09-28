---
title: "CPane::DockByMouse"
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
  - "CPane::DockByMouse"
  - "CPane.DockByMouse"
  - "DockByMouse"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DockByMouse method"
ms.assetid: 54952c79-b707-45fe-a2e1-247b8f539b47
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::DockByMouse
Docks a pane by using the mouse.  
  
## Syntax  
  
```  
virtual BOOL DockByMouse(  
   CBasePane* pDockBar  
);  
```  
  
#### Parameters  
 [in] `pDockBar`  
 Specifies the base pane to which to dock this pane.  
  
## Return Value  
 `TRUE` if the pane was docked successfully; otherwise, `FALSE`.  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)