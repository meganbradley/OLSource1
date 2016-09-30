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
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::ScrollDC
Scrolls a rectangle of bits horizontally and vertically.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the number of horizontal scroll units.  
  
 *dy*  
 Specifies the number of vertical scroll units.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that contains the coordinates of the scrolling rectangle.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object that contains the coordinates of the clipping rectangle. When this rectangle is smaller than the original one pointed to by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, scrolling occurs only in the smaller rectangle.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Identifies the region uncovered by the scrolling process. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function defines this region; it is not necessarily a rectangle.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> structure or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object that receives the coordinates of the rectangle that bounds the scrolling update region. This is the largest rectangular area that requires repainting. The values in the structure or object when the function returns are in client coordinates, regardless of the mapping mode for the given device context.  
  
## Return Value  
 Nonzero if scrolling is executed; otherwise 0.  
  
## Remarks  
 If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is **NULL**, Windows does not compute the update rectangle. If both <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> are **NULL**, Windows does not compute the update region. If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is not **NULL**, Windows assumes that it contains a valid pointer to the region uncovered by the scrolling process (defined by the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> member function). The update region returned in <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> can be passed to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> if required.  
  
 An application should use the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> member function of class <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> when it is necessary to scroll the entire client area of a window. Otherwise, it should use <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
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