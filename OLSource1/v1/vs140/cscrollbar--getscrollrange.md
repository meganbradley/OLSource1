---
title: "CScrollBar::GetScrollRange"
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
  - "GetScrollRange"
  - "CScrollBar.GetScrollRange"
  - "CScrollBar::GetScrollRange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "maximum scroll bar position"
  - "ranges, scroll bar"
  - "CScrollBar class, operations"
  - "position, scroll bar"
  - "scroll bars, position"
  - "GetScrollRange method"
  - "minimum scroll bar position"
ms.assetid: 000a4f4a-198f-4937-a71d-c8e920bc0564
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CScrollBar::GetScrollRange
Copies the current minimum and maximum scroll-bar positions for the given scroll bar to the locations specified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to the integer variable that is to receive the minimum position.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Points to the integer variable that is to receive the maximum position.  
  
## Remarks  
 The default range for a scroll-bar control is empty (both values are 0).  
  
## Example  
 See the example for [CWnd::OnHScroll](../vs140/cwnd--onhscroll.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CScrollBar Class](../vs140/cscrollbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetScrollRange](http://msdn.microsoft.com/library/windows/desktop/bb787587)   
 [CScrollBar::SetScrollRange](../vs140/cscrollbar--setscrollrange.md)   
 [CScrollBar::GetScrollPos](../vs140/cscrollbar--getscrollpos.md)   
 [CScrollBar::SetScrollPos](../vs140/cscrollbar--setscrollpos.md)