---
title: "CScrollBar::SetScrollRange"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CScrollBar::SetScrollRange
  - CScrollBar.SetScrollRange
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetScrollRange method
  - ranges, scroll bar
  - CScrollBar class, operations
  - scroll bars, position
  - maximum range of scroll bars
  - minimum ranges of scroll bars
ms.assetid: 5e10a0ac-9fdd-423c-9a9d-ab0481609b3a
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CScrollBar::SetScrollRange
Sets minimum and maximum position values for the given scroll bar.  
  
## Syntax  
  
```  
  
      void SetScrollRange(  
   int nMinPos,  
   int nMaxPos,  
   BOOL bRedraw = TRUE   
);  
```  
  
#### Parameters  
 `nMinPos`  
 Specifies the minimum scrolling position.  
  
 `nMaxPos`  
 Specifies the maximum scrolling position.  
  
 `bRedraw`  
 Specifies whether the scroll bar should be redrawn to reflect the change. If `bRedraw` is **TRUE**, the scroll bar is redrawn; if **FALSE**, it is not redrawn. It is redrawn by default.  
  
## Remarks  
 Set `nMinPos` and `nMaxPos` to 0 to hide standard scroll bars.  
  
 Do not call this function to hide a scroll bar while processing a scroll-bar notification message.  
  
 If a call to `SetScrollRange` immediately follows a call to the `SetScrollPos` member function, set `bRedraw` in `SetScrollPos` to 0 to prevent the scroll bar from being redrawn twice.  
  
 The difference between the values specified by `nMinPos` and `nMaxPos` must not be greater than 32,767. The default range for a scroll-bar control is empty (both `nMinPos` and `nMaxPos` are 0).  
  
## Example  
 [!code[NVC_MFC_CScrollBar#4](../vs140/codesnippet/CPP/cscrollbar--setscrollrange_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CScrollBar Class](../vs140/cscrollbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CScrollBar::GetScrollPos](../vs140/cscrollbar--getscrollpos.md)   
 [CScrollBar::SetScrollPos](../vs140/cscrollbar--setscrollpos.md)   
 [CScrollBar::GetScrollRange](../vs140/cscrollbar--getscrollrange.md)   
 [SetScrollRange](http://msdn.microsoft.com/library/windows/desktop/bb787599)