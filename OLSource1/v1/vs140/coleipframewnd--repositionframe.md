---
title: "COleIPFrameWnd::RepositionFrame"
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
  - COleIPFrameWnd.RepositionFrame
  - COleIPFrameWnd::RepositionFrame
  - RepositionFrame
dev_langs: 
  - C++
helpviewer_keywords: 
  - COleIPFrameWnd class, overridables
  - RepositionFrame method
ms.assetid: 34d6b744-4ac0-4655-9259-f047460f506e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleIPFrameWnd::RepositionFrame
The framework calls the `RepositionFrame` member function to lay out control bars and reposition the in-place editing window so all of it is visible.  
  
## Syntax  
  
```  
  
      virtual void RepositionFrame(  
   LPCRECT lpPosRect,  
   LPCRECT lpClipRect   
);  
```  
  
#### Parameters  
 `lpPosRect`  
 Pointer to a `RECT` structure or a `CRect` object containing the in-place frame window's current position coordinates, in pixels, relative to the client area.  
  
 `lpClipRect`  
 Pointer to a `RECT` structure or a `CRect` object containing the in-place frame window's current clipping-rectangle coordinates, in pixels, relative to the client area.  
  
## Remarks  
 Layout of control bars in the container window differs from that performed by a non-OLE frame window. The non-OLE frame window calculates the positions of control bars and other objects from a given frame-window size, as in a call to [CFrameWnd::RecalcLayout](../vs140/cframewnd--recalclayout.md). The client area is what remains after space for control bars and other objects is subtracted. A `COleIPFrameWnd` window, on the other hand, positions toolbars in accordance with a given client area. In other words, `CFrameWnd::RecalcLayout` works "from the outside in," whereas `COleIPFrameWnd::RepositionFrame` works "from the inside out."  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleIPFrameWnd Class](../vs140/coleipframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFrameWnd::RecalcLayout](../vs140/cframewnd--recalclayout.md)