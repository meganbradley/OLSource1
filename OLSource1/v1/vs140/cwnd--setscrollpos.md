---
title: "CWnd::SetScrollPos"
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
  - "CWnd.SetScrollPos"
  - "CWnd::SetScrollPos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scrolling functions"
  - "SetScrollPos method"
  - "scroll position"
ms.assetid: f52fb650-957c-4fea-b3fa-c51bacb47754
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::SetScrollPos
Sets the current position of a scroll box and, if requested, redraws the scroll bar to reflect the new position of the scroll box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the scroll bar to be set. This parameter can be either of the following:  
  
-   **SB_HORZ** Sets the position of the scroll box in the horizontal scroll bar of the window.  
  
-   **SB_VERT** Sets the position of the scroll box in the vertical scroll bar of the window.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the new position of the scroll box. It must be within the scrolling range.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies whether the scroll bar should be repainted to reflect the new scroll-box position. If this parameter is **TRUE**, the scroll bar is repainted; if **FALSE**, the scroll bar is not repainted.  
  
## Return Value  
 The previous position of the scroll box.  
  
## Remarks  
 Setting <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to **FALSE** is useful whenever the scroll bar will be redrawn by a subsequent call to another function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [SetScrollPos](http://msdn.microsoft.com/library/windows/desktop/bb787597)   
 [CWnd::GetScrollPos](../vs140/cwnd--getscrollpos.md)   
 [CScrollBar::SetScrollPos](../vs140/cscrollbar--setscrollpos.md)