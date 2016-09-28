---
title: "CDC::ScrollDC"
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
  - "CDC::ScrollDC"
  - "CDC.ScrollDC"
  - "ScrollDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ScrollDC method"
  - "CDC class, scrolling functions"
ms.assetid: 7d3cb1e8-c93b-4c92-a36f-50fd631a5bff
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::ScrollDC
Scrolls a rectangle of bits horizontally and vertically.  
  
## Syntax  
  
```  
  
      BOOL ScrollDC(  
   int dx,  
   int dy,  
   LPCRECT lpRectScroll,  
   LPCRECT lpRectClip,  
   CRgn* pRgnUpdate,  
   LPRECT lpRectUpdate   
);  
```  
  
#### Parameters  
 `dx`  
 Specifies the number of horizontal scroll units.  
  
 *dy*  
 Specifies the number of vertical scroll units.  
  
 `lpRectScroll`  
 Points to the `RECT` structure or `CRect` object that contains the coordinates of the scrolling rectangle.  
  
 `lpRectClip`  
 Points to the `RECT` structure or `CRect` object that contains the coordinates of the clipping rectangle. When this rectangle is smaller than the original one pointed to by `lpRectScroll`, scrolling occurs only in the smaller rectangle.  
  
 `pRgnUpdate`  
 Identifies the region uncovered by the scrolling process. The `ScrollDC` function defines this region; it is not necessarily a rectangle.  
  
 `lpRectUpdate`  
 Points to the `RECT` structure or `CRect` object that receives the coordinates of the rectangle that bounds the scrolling update region. This is the largest rectangular area that requires repainting. The values in the structure or object when the function returns are in client coordinates, regardless of the mapping mode for the given device context.  
  
## Return Value  
 Nonzero if scrolling is executed; otherwise 0.  
  
## Remarks  
 If `lpRectUpdate` is **NULL**, Windows does not compute the update rectangle. If both `pRgnUpdate` and `lpRectUpdate` are **NULL**, Windows does not compute the update region. If `pRgnUpdate` is not **NULL**, Windows assumes that it contains a valid pointer to the region uncovered by the scrolling process (defined by the `ScrollDC` member function). The update region returned in `lpRectUpdate` can be passed to `CWnd::InvalidateRgn` if required.  
  
 An application should use the `ScrollWindow` member function of class `CWnd` when it is necessary to scroll the entire client area of a window. Otherwise, it should use `ScrollDC`.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::InvalidateRgn](../vs140/cwnd--invalidatergn.md)   
 [CWnd::ScrollWindow](../vs140/cwnd--scrollwindow.md)   
 [ScrollDC](http://msdn.microsoft.com/library/windows/desktop/bb787589)   
 [CRgn Class](../vs140/crgn-class.md)   
 [RECT Structure](../vs140/rect-structure.md)   
 [CRect Class](../vs140/crect-class.md)