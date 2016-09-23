---
title: "CMDIFrameWndEx::DockPane"
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
  - CMDIFrameWndEx::DockPane
  - DockPane
  - CMDIFrameWndEx.DockPane
dev_langs: 
  - C++
helpviewer_keywords: 
  - DockPane method
ms.assetid: fb08253d-8e02-4709-8356-3fceb33ab694
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMDIFrameWndEx::DockPane
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
 Pointer to the pane to dock.  
  
 [in] `nDockBarID`  
 Specifies which sides of the frame window to dock to.  
  
 [in] `lpRect`  
 Not used.  
  
## Remarks  
 This method docks the specified the pane to one of the sides of the frame window that was specified when [CBasePane::EnableDocking](../vs140/cbasepane--enabledocking.md) and [CMDIFrameWndEx::EnableDocking](../vs140/cmdiframewndex--enabledocking.md) were called.  
  
## Example  
 The following example demonstrates the use of the `DockPane` method. This code snippet comes from the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#4](../vs140/codesnippet/CPP/cmdiframewndex--dockpane_1.cpp)]
  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)