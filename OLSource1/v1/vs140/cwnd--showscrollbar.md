---
title: "CWnd::ShowScrollBar"
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
  - "CWnd.ShowScrollBar"
  - "CWnd::ShowScrollBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scrolling functions"
  - "scroll bars, showing"
  - "ShowScrollBar method"
ms.assetid: 3c3c391b-672a-4ea6-a5d6-0bf84da54fc9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::ShowScrollBar
Shows or hides a scroll bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies whether the scroll bar is a control or part of a window's nonclient area. If it is part of the nonclient area, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> also indicates whether the scroll bar is positioned horizontally, vertically, or both. It must be one of the following:  
  
-   **SB_BOTH** Specifies the horizontal and vertical scroll bars of the window.  
  
-   **SB_HORZ** Specifies that the window is a horizontal scroll bar.  
  
-   **SB_VERT** Specifies that the window is a vertical scroll bar.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies whether Windows shows or hides the scroll bar. If this parameter is **TRUE**, the scroll bar is shown; otherwise the scroll bar is hidden.  
  
## Remarks  
 An application should not call <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to hide a scroll bar while processing a scroll-bar notification message.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [ShowScrollBar](http://msdn.microsoft.com/library/windows/desktop/bb787601)   
 [CScrollBar::ShowScrollBar](../vs140/cscrollbar--showscrollbar.md)