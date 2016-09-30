---
title: "CWnd::GetScrollBarCtrl"
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
  - "GetScrollBarCtrl"
  - "CWnd.GetScrollBarCtrl"
  - "CWnd::GetScrollBarCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetScrollBarCtrl method"
ms.assetid: 3d2269a8-3249-4774-85bc-30e6e0fcb30a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetScrollBarCtrl
Call this member function to obtain a pointer to the specified sibling scroll bar or splitter window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the type of scroll bar. The parameter can take one of the following values:  
  
-   **SB_HORZ** Retrieves the position of the horizontal scroll bar.  
  
-   **SB_VERT** Retrieves the position of the vertical scroll bar.  
  
## Return Value  
 A sibling scroll-bar control, or **NULL** if none.  
  
## Remarks  
 This member function does not operate on scroll bars created when the **WS_HSCROLL** or **WS_VSCROLL** bits are set during the creation of a window. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> implementation of this function simply returns **NULL**. Derived classes, such as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, implement the described functionality.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::EnableScrollBarCtrl](../vs140/cwnd--enablescrollbarctrl.md)