---
title: "CScrollBar::GetScrollPos"
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
  - "CScrollBar.GetScrollPos"
  - "CScrollBar::GetScrollPos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ranges, scroll bar"
  - "CScrollBar class, operations"
  - "current scroll bar position"
  - "position, scroll bar"
  - "GetScrollPos method"
  - "scroll bars, position"
  - "scrolling ranges"
ms.assetid: 1f9ee5cb-906b-4e42-b136-db0808c3d959
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CScrollBar::GetScrollPos
Retrieves the current position of a scroll box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Specifies the current position of the scroll box if successful; otherwise 0.  
  
## Remarks  
 The current position is a relative value that depends on the current scrolling range. For example, if the scrolling range is 100 to 200 and the scroll box is in the middle of the bar, the current position is 150.  
  
## Example  
 See the example for [CWnd::OnHScroll](../vs140/cwnd--onhscroll.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CScrollBar Class](../vs140/cscrollbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CScrollBar::SetScrollPos](../vs140/cscrollbar--setscrollpos.md)   
 [CScrollBar::GetScrollRange](../vs140/cscrollbar--getscrollrange.md)   
 [CScrollBar::SetScrollRange](../vs140/cscrollbar--setscrollrange.md)   
 [GetScrollPos](http://msdn.microsoft.com/library/windows/desktop/bb787585)