---
title: "CWnd::GetScrollLimit"
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
  - "CWnd.GetScrollLimit"
  - "CWnd::GetScrollLimit"
  - "GetScrollLimit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetScrollLimit method"
  - "scroll bars, limits"
ms.assetid: 8d0e3d93-5088-46c6-a0cd-f805021fcb30
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetScrollLimit
Call this member function to retrieve the maximum scrolling position of the scroll bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the type of scroll bar. The parameter can take one of the following values:  
  
-   **SB_HORZ** Retrieves the scroll limit of the horizontal scroll bar.  
  
-   **SB_VERT** Retrieves the scroll limit of the vertical scroll bar.  
  
## Return Value  
 Specifies the maximum position of a scroll bar if successful; otherwise 0.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CScrollBar::GetScrollLimit](../vs140/cscrollbar--getscrolllimit.md)