---
title: "COleControl::ParentToClient"
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
  - "ParentToClient"
  - "COleControl.ParentToClient"
  - "COleControl::ParentToClient"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ParentToClient method"
ms.assetid: b6c04fd9-9586-4ffb-8cdd-6bf716e5d05a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::ParentToClient
Translates the coordinates of `pPoint` into client coordinates.  
  
## Syntax  
  
```  
  
      virtual UINT ParentToClient(  
   LPCRECT lprcBounds,  
   LPPOINT pPoint,  
   BOOL bHitTest = FALSE   
) const;  
```  
  
#### Parameters  
 `lprcBounds`  
 Pointer to the bounds of the OLE control within the container. Not the client area but the area of the entire control including borders and scroll bars.  
  
 `pPoint`  
 Pointer to the parent (container) point to be translated into the coordinates of the client area of the control.  
  
 `bHitTest`  
 Specifies whether or not hit testing is to be done on the point.  
  
## Return Value  
 If `bHitTest` is **FALSE**, returns **HTNOWHERE**. If `bHitTest` is **TRUE**, returns the location in which the parent (container) point landed in the client area of the OLE control and is one of the following mouse hit-test values:  
  
-   **HTBORDER** In the border of a window that does not have a sizing border.  
  
-   **HTBOTTOM** In the lower horizontal border of the window.  
  
-   **HTBOTTOMLEFT** In the lower-left corner of the window border.  
  
-   **HTBOTTOMRIGHT** In the lower-right corner of the window border.  
  
-   **HTCAPTION** In a title-bar area.  
  
-   **HTCLIENT** In a client area.  
  
-   **HTERROR** On the screen background or on a dividing line between windows (same as **HTNOWHERE** except that the **DefWndProc** Windows function produces a system beep to indicate an error).  
  
-   **HTGROWBOX** In a size box.  
  
-   **HTHSCROLL** In the horizontal scroll bar.  
  
-   **HTLEFT** In the left border of the window.  
  
-   **HTMAXBUTTON** In a Maximize button.  
  
-   **HTMENU** In a menu area.  
  
-   **HTMINBUTTON** In a Minimize button.  
  
-   **HTNOWHERE** On the screen background or on a dividing line between windows.  
  
-   **HTREDUCE** In a Minimize button.  
  
-   **HTRIGHT** In the right border of the window.  
  
-   **HTSIZE** In a size box (same as **HTGROWBOX**).  
  
-   **HTSYSMENU** In a Control menu or in a Close button in a child window.  
  
-   **HTTOP** In the upper horizontal border of the window.  
  
-   **HTTOPLEFT** In the upper-left corner of the window border.  
  
-   **HTTOPRIGHT** In the upper-right corner of the window border.  
  
-   **HTTRANSPARENT** In a window currently covered by another window.  
  
-   **HTVSCROLL** In the vertical scroll bar.  
  
-   **HTZOOM** In a Maximize button.  
  
## Remarks  
 On input `pPoint` is relative to the origin of the parent (upper left corner of the container). On output `pPoint` is relative to the origin of the client area of the OLE control (upper left corner of the client area of the control).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::ClientToParent](../vs140/colecontrol--clienttoparent.md)   
 [COleControl::GetClientOffset](../vs140/colecontrol--getclientoffset.md)