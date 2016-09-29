---
title: "CFrameWnd::EnableDocking"
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
  - "CFrameWnd::EnableDocking"
  - "CFrameWnd.EnableDocking"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CBRS_ALIGN_RIGHT constant"
  - "CBRS_ALIGN_ANY constant"
  - "CFrameWnd class, operations"
  - "CBRS_ALIGN_TOP constant"
  - "CBRS_ALIGN_BOTTOM constant"
  - "EnableDocking method"
  - "CBRS_ALIGN_LEFT constant"
ms.assetid: 66983e25-2d6d-4784-8640-bdf46646d386
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd::EnableDocking
Call this function to enable dockable control bars in a frame window.  
  
## Syntax  
  
```  
  
      void EnableDocking(  
   DWORD dwDockStyle   
);  
```  
  
#### Parameters  
 `dwDockStyle`  
 Specifies which sides of the frame window can serve as docking sites for control bars. It can be one or more of the following:  
  
-   `CBRS_ALIGN_TOP` Allows docking at the top of the client area.  
  
-   `CBRS_ALIGN_BOTTOM` Allows docking at the bottom of the client area.  
  
-   `CBRS_ALIGN_LEFT` Allows docking on the left side of the client area.  
  
-   `CBRS_ALIGN_RIGHT` Allows docking on the right side of the client area.  
  
-   `CBRS_ALIGN_ANY` Allows docking on any side of the client area.  
  
## Remarks  
 By default, control bars will be docked to a side of the frame window in the following order: top, bottom, left, right.  
  
## Example  
 See the example for [CToolBar::Create](../vs140/ctoolbar--create.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CControlBar::EnableDocking](../vs140/ccontrolbar--enabledocking.md)   
 [CFrameWnd::DockControlBar](../vs140/cframewnd--dockcontrolbar.md)   
 [CFrameWnd::FloatControlBar](../vs140/cframewnd--floatcontrolbar.md)