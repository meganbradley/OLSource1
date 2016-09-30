---
title: "CWnd::RepositionBars"
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
  - "CWnd::RepositionBars"
  - "RepositionBars"
  - "CWnd.RepositionBars"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scrolling functions"
  - "RepositionBars method"
  - "scrollbar functions"
  - "control bars, resizing"
  - "control bars, positioning"
ms.assetid: 608f3740-1165-411a-b452-8c24b12be5bf
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::RepositionBars
Called to reposition and resize control bars in the client area of a window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The ID of the first in a range of control bars to reposition and resize.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The ID of the last in a range of control bars to reposition and resize.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies ID of pane that fills the rest of the client area.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Can have one of the following values:  
  
-   **CWnd::reposDefault** Performs the layout of the control bars. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not used and can be **NULL**.  
  
-   **CWnd::reposQuery** The layout of the control bars is not done; instead <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is initialized with the size of the client area, as if the layout had actually been done.  
  
-   **CWnd::reposExtra** Adds the values of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to the client area of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and also performs the layout*.*  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) structure; the usage of which depends on the value of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 *lpRectClient*  
 Points to a [RECT](../vs140/rect-structure.md) structure containing the available client area. If **NULL**, the window's client area will be used.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Indicates whether the bar should be stretched to the size of the frame.  
  
## Remarks  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameters define a range of control-bar IDs to be repositioned in the client area. The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter specifies the ID of the child window (normally the view) which is repositioned and resized to fill the rest of the client area not filled by control bars.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFrameWnd::RecalcLayout](../vs140/cframewnd--recalclayout.md)