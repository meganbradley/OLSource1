---
title: "CWnd::SetScrollRange"
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
  - CWnd.SetScrollRange
  - CWnd::SetScrollRange
dev_langs: 
  - C++
helpviewer_keywords: 
  - scroll bars, scroll range
  - scrolling functions
  - SetScrollRange method
ms.assetid: fe1e818f-e4ac-4aa6-9673-6aaf7cc56ce7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::SetScrollRange
Sets minimum and maximum position values for the given scroll bar.  
  
## Syntax  
  
```  
  
      void SetScrollRange(  
   int nBar,  
   int nMinPos,  
   int nMaxPos,  
   BOOL bRedraw = TRUE   
);  
```  
  
#### Parameters  
 `nBar`  
 Specifies the scroll bar to be set. This parameter can be either of the following values:  
  
-   **SB_HORZ** Sets the range of the horizontal scroll bar of the window.  
  
-   **SB_VERT** Sets the range of the vertical scroll bar of the window.  
  
 `nMinPos`  
 Specifies the minimum scrolling position.  
  
 `nMaxPos`  
 Specifies the maximum scrolling position.  
  
 `bRedraw`  
 Specifies whether the scroll bar should be redrawn to reflect the change. If `bRedraw` is **TRUE**, the scroll bar is redrawn; if **FALSE**, the scroll bar is not redrawn.  
  
## Remarks  
 It can also be used to hide or show standard scroll bars.  
  
 An application should not call this function to hide a scroll bar while processing a scroll-bar notification message.  
  
 If the call to `SetScrollRange` immediately follows a call to the [SetScrollPos](../vs140/cwnd--setscrollpos.md) member function, the `bRedraw` parameter in the `SetScrollPos` member function should be 0 to prevent the scroll bar from being drawn twice.  
  
 The default range for a standard scroll bar is 0 through 100. The default range for a scroll bar control is empty (both the `nMinPos` and `nMaxPos` values are 0). The difference between the values specified by `nMinPos` and `nMaxPos` must not be greater than **INT_MAX**.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SetScrollPos](../vs140/cwnd--setscrollpos.md)   
 [SetScrollRange](http://msdn.microsoft.com/library/windows/desktop/bb787599)   
 [CWnd::GetScrollRange](../vs140/cwnd--getscrollrange.md)