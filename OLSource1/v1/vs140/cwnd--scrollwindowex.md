---
title: "CWnd::ScrollWindowEx"
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
  - "CWnd::ScrollWindowEx"
  - "ScrollWindowEx"
  - "CWnd.ScrollWindowEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scrolling functions [C++]"
  - "windows [C++], scrolling"
  - "ScrollWindowEx method"
  - "scrolling [C++], extended"
ms.assetid: cec2c073-1051-41ff-bb2d-5a395d1fd61b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::ScrollWindowEx
Scrolls the contents of a window's client area.  
  
## Syntax  
  
```  
  
      int ScrollWindowEx(  
   int dx,  
   int dy,  
   LPCRECT lpRectScroll,  
   LPCRECT lpRectClip,  
   CRgn* prgnUpdate,  
   LPRECT lpRectUpdate,  
   UINT flags   
);   
```  
  
#### Parameters  
 `dx`  
 Specifies the amount, in device units, of horizontal scrolling. This parameter must have a negative value to scroll to the left.  
  
 *dy*  
 Specifies the amount, in device units, of vertical scrolling. This parameter must have a negative value to scroll up.  
  
 `lpRectScroll`  
 Points to a [RECT](../vs140/rect-structure.md) structure that specifies the portion of the client area to be scrolled. If this parameter is **NULL**, the entire client area is scrolled.  
  
 `lpRectClip`  
 Points to a `RECT` structure that specifies the clipping rectangle to scroll. This structure takes precedence over the rectangle pointed to by `lpRectScroll`. Only bits inside this rectangle are scrolled. Bits outside this rectangle are not affected even if they are in the `lpRectScroll` rectangle. If this parameter is **NULL**, no clipping is performed on the scroll rectangle.  
  
 *prgnUpdate*  
 Identifies the region that is modified to hold the region invalidated by scrolling. This parameter may be **NULL**.  
  
 `lpRectUpdate`  
 Points to a `RECT` structure that will receive the boundaries of the rectangle invalidated by scrolling. This parameter may be **NULL**.  
  
 `flags`  
 Can have one of the following values:  
  
-   **SW_ERASE** When specified with **SW_INVALIDATE**, erases the newly invalidated region by sending a [WM_ERASEBKGND](http://msdn.microsoft.com/library/windows/desktop/ms648055) message to the window.  
  
-   **SW_INVALIDATE** Invalidates the region identified by *prgnUpdate* after scrolling.  
  
-   **SW_SCROLLCHILDREN** Scrolls all child windows that intersect the rectangle pointed to by `lpRectScroll` by the number of pixels specified in `dx` and *dy*. Windows sends a [WM_MOVE](http://msdn.microsoft.com/library/windows/desktop/ms632631) message to all child windows that intersect `lpRectScroll`, even if they do not move. The caret is repositioned when a child window is scrolled and the cursor rectangle intersects the scroll rectangle.  
  
## Return Value  
 The return value is **SIMPLEREGION** (rectangular invalidated region), **COMPLEXREGION** (nonrectangular invalidated region; overlapping rectangles), or **NULLREGION** (no invalidated region), if the function is successful; otherwise the return value is **ERROR**.  
  
## Remarks  
 This function is similar to the [ScrollWindow](http://msdn.microsoft.com/library/windows/desktop/bb787591) function, with some additional features.  
  
 If [SW_INVALIDATE](http://msdn.microsoft.com/library/windows/desktop/bb787593) and [SW_ERASE](http://msdn.microsoft.com/library/windows/desktop/bb787593) are not specified, the `ScrollWindowEx` member function does not invalidate the area that is scrolled away from. If either of these flags is set, `ScrollWindowEx` invalidates this area. The area is not updated until the application calls the [UpdateWindow](http://msdn.microsoft.com/library/windows/desktop/dd145167) member function, calls the [RedrawWindow](http://msdn.microsoft.com/library/windows/desktop/dd162911) member function (specifying [RDW_UPDATENOW](http://msdn.microsoft.com/library/windows/desktop/dd162911) or [RDW_ERASENOW](http://msdn.microsoft.com/library/windows/desktop/dd162911)), or retrieves the [WM_PAINT](http://msdn.microsoft.com/library/windows/desktop/dd145213) message from the application queue.  
  
 If the window has the [WS_CLIPCHILDREN](http://msdn.microsoft.com/library/windows/desktop/ms632679) style, the returned areas specified by *prgnUpdate* and `lpRectUpdate` represent the total area of the scrolled window that must be updated, including any areas in child windows that need updating.  
  
 If the [SW_SCROLLCHILDREN](http://msdn.microsoft.com/library/windows/desktop/bb787593) flag is specified, Windows will not properly update the screen if part of a child window is scrolled. The part of the scrolled child window that lies outside the source rectangle will not be erased and will not be redrawn properly in its new destination. Use the [DeferWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms632681) Windows function to move child windows that do not lie completely within the `lpRectScroll` rectangle. The cursor is repositioned if the **SW_SCROLLCHILDREN** flag is set and the caret rectangle intersects the scroll rectangle.  
  
 All input and output coordinates (for `lpRectScroll`, `lpRectClip`, `lpRectUpdate`, and *prgnUpdate*) are assumed to be in client coordinates, regardless of whether the window has the **CS_OWNDC** or **CS_CLASSDC** class style. Use the [LPtoDP](http://msdn.microsoft.com/library/windows/desktop/dd145042) and [DPtoLP](http://msdn.microsoft.com/library/windows/desktop/dd162474) Windows functions to convert to and from logical coordinates, if necessary.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::RedrawWindow](../vs140/cwnd--redrawwindow.md)   
 [CDC::ScrollDC](../vs140/cdc--scrolldc.md)   
 [CWnd::ScrollWindow](../vs140/cwnd--scrollwindow.md)   
 [CWnd::UpdateWindow](../vs140/cwnd--updatewindow.md)   
 [DeferWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms632681)   
 [ScrollWindowEx](http://msdn.microsoft.com/library/windows/desktop/bb787593)