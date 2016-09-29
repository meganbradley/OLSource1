---
title: "CFrameWnd::FloatControlBar"
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
  - "CFrameWnd::FloatControlBar"
  - "FloatControlBar"
  - "CFrameWnd.FloatControlBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFrameWnd class, operations"
  - "FloatControlBar method"
ms.assetid: 3f125a30-6f3f-446e-b0af-3853f641148f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd::FloatControlBar
Call this function to cause a control bar to not be docked to the frame window.  
  
## Syntax  
  
```  
  
      void FloatControlBar(  
   CControlBar * pBar,  
   CPoint point,  
   DWORD dwStyle = CBRS_ALIGN_TOP   
);  
```  
  
#### Parameters  
 `pBar`  
 Points to the control bar to be floated.  
  
 `point`  
 The location, in screen coordinates, where the top left corner of the control bar will be placed.  
  
 `dwStyle`  
 Specifies whether to align the control bar horizontally or vertically within its new frame window. It can be any one of the following:  
  
-   `CBRS_ALIGN_TOP` Orients the control bar vertically.  
  
-   `CBRS_ALIGN_BOTTOM` Orients the control bar vertically.  
  
-   `CBRS_ALIGN_LEFT` Orients the control bar horizontally.  
  
-   `CBRS_ALIGN_RIGHT` Orients the control bar horizontally.  
  
 If styles are passed specifying both horizontal and vertical orientation, the toolbar will be oriented horizontally.  
  
## Remarks  
 Typically, this is done at application startup when the program is restoring settings from the previous execution.  
  
 This function is called by the framework when the user causes a drop operation by releasing the left mouse button while dragging the control bar over a location that is not available for docking.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFrameWnd::DockControlBar](../vs140/cframewnd--dockcontrolbar.md)