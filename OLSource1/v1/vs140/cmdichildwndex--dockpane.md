---
title: "CMDIChildWndEx::DockPane"
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
  - "CMDIChildWndEx::DockPane"
  - "CMDIChildWndEx.DockPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DockPane method"
ms.assetid: 69dfabc0-4ee9-4929-a049-72c775749940
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWndEx::DockPane
Docks a pane.  
  
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
 A pointer to the pane.  
  
 [in] `nDockBarID`  
 The ID of the pane.  
  
 [in] `lpRect`  
 A pointer to a rectangle.  
  
## Remarks  
 The `lpRect` parameter is not used.  
  
## Requirements  
 **Header:** afxmdichildwndex.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)