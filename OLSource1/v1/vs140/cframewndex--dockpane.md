---
title: "CFrameWndEx::DockPane"
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
  - "CFrameWndEx::DockPane"
  - "CFrameWndEx.DockPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DockPane method"
ms.assetid: 77214502-2872-4230-bb7f-71ad5934c8e9
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::DockPane
Docks the specified pane to the frame window.  
  
## Syntax  
  
```  
void DockPane(  
   CBasePane* pBar,  
   UINT nDockBarID=0,  
   LPCRECT lpRect=NULL   
);  
```  
  
#### Parameters  
 [in] `pBar`  
 A pointer to the control bar to be docked.  
  
 [in] `nDockBarID`  
 The ID of the side of the frame window to dock to.  
  
 [in] `lpRect`  
 A pointer to a constant Rect structure that specifies the window's screen position and size.  
  
## Remarks  
 The `nDockBarID` parameter can have one of the following values:  
  
-   AFX_IDW_DOCKBAR_TOP  
  
-   AFX_IDW_DOCKBAR_BOTTOM  
  
-   AFX_IDW_DOCKBAR_LEFT  
  
-   AFX_IDW_DOCKBAR_RIGHT  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)