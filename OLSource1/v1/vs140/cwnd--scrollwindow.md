---
title: "CWnd::ScrollWindow"
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
  - CWnd::ScrollWindow
  - CWnd.ScrollWindow
  - ScrollWindow
dev_langs: 
  - C++
helpviewer_keywords: 
  - scrolling functions [C++]
  - windows [C++], scrolling
  - ScrollWindow method
ms.assetid: cab3c37d-5fc8-4472-9464-5ffe99b5bd8b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::ScrollWindow
Scrolls the contents of the client area of the current `CWnd` object.  
  
## Syntax  
  
```  
  
      void ScrollWindow(  
   int xAmount,  
   int yAmount,  
   LPCRECT lpRect = NULL,  
   LPCRECT lpClipRect = NULL   
);  
```  
  
#### Parameters  
 `xAmount`  
 Specifies the amount, in device units, of horizontal scrolling. This parameter must be a negative value to scroll to the left.  
  
 `yAmount`  
 Specifies the amount, in device units, of vertical scrolling. This parameter must be a negative value to scroll up.  
  
 `lpRect`  
 Points to a [CRect](../vs140/crect-class.md) object or [RECT](../vs140/rect-structure.md) structure that specifies the portion of the client area to be scrolled. If `lpRect` is **NULL**, the entire client area is scrolled. The caret is repositioned if the cursor rectangle intersects the scroll rectangle.  
  
 `lpClipRect`  
 Points to a `CRect` object or `RECT` structure that specifies the clipping rectangle to scroll. Only bits inside this rectangle are scrolled. Bits outside this rectangle are not affected even if they are in the `lpRect` rectangle. If `lpClipRect` is **NULL**, no clipping is performed on the scroll rectangle.  
  
## Remarks  
 If the caret is in the `CWnd` being scrolled, `ScrollWindow` automatically hides the caret to prevent it from being erased and then restores the caret after the scroll is finished. The caret position is adjusted accordingly.  
  
 The area uncovered by the `ScrollWindow` member function is not repainted but is combined into the current `CWnd` object's update region. The application will eventually receive a [WM_PAINT](http://msdn.microsoft.com/library/windows/desktop/dd145213) message notifying it that the region needs repainting. To repaint the uncovered area at the same time the scrolling is done, call the [UpdateWindow](../vs140/cwnd--updatewindow.md) member function immediately after calling `ScrollWindow`.  
  
 If `lpRect` is **NULL**, the positions of any child windows in the window are offset by the amount specified by `xAmount` and `yAmount`, and any invalid (unpainted) areas in the `CWnd` are also offset. `ScrollWindow` is faster when `lpRect` is **NULL**.  
  
 If `lpRect` is not **NULL**, the positions of child windows are not changed, and invalid areas in `CWnd` are not offset. To prevent updating problems when `lpRect` is not **NULL**, call the `UpdateWindow` member function to repaint `CWnd` before calling `ScrollWindow`.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::UpdateWindow](../vs140/cwnd--updatewindow.md)   
 [ScrollWindow](http://msdn.microsoft.com/library/windows/desktop/bb787591)