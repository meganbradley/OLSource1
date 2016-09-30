---
title: "CView::OnScroll"
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
  - "OnScroll"
  - "CView.OnScroll"
  - "CView::OnScroll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scrollbar"
  - "OnScroll method"
  - "CView class, OLE overridables"
  - "scrolling"
ms.assetid: e649242b-5403-4200-b9d0-4629b5bef0b3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CView::OnScroll
Called by the framework to determine whether scrolling is possible.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A scroll-bar code that indicates the user's scrolling request. This parameter is composed of two parts: a low-order byte, which determines the type of scrolling occurring horizontally, and a high-order byte, which determines the type of scrolling occurring vertically:  
  
-   **SB_BOTTOM** Scrolls to bottom.  
  
-   **SB_LINEDOWN** Scrolls one line down.  
  
-   **SB_LINEUP** Scrolls one line up.  
  
-   **SB_PAGEDOWN** Scrolls one page down.  
  
-   **SB_PAGEUP** Scrolls one page up.  
  
-   **SB_THUMBTRACK** Drags scroll box to specified position. The current position is specified in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
-   **SB_TOP** Scrolls to top.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Contains the current scroll-box position if the scroll-bar code is **SB_THUMBTRACK**; otherwise it is not used. Depending on the initial scroll range, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> may be negative and should be cast to an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if necessary.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Determines whether you should actually do the specified scrolling action. If **TRUE,** then scrolling should take place; if **FALSE**, then scrolling should not occur.  
  
## Return Value  
 If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is **TRUE** and the view was actually scrolled, then return nonzero; otherwise 0. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is **FALSE**, then return the value that you would have returned if <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> were **TRUE**, even though you don't actually do the scrolling.  
  
## Remarks  
 In one case this function is called by the framework with <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> set to **TRUE** when the view receives a scrollbar message. In this case, you should actually scroll the view. In the other case this function is called with <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> set to **FALSE** when an OLE item is initially dragged into the auto-scrolling region of a drop target before scrolling actually takes place. In this case, you should not actually scroll the view.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CView Class](../vs140/cview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView::OnScrollBy](../vs140/cview--onscrollby.md)   
 [COleClientItem Class](../vs140/coleclientitem-class.md)