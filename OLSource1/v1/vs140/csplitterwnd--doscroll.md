---
title: "CSplitterWnd::DoScroll"
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
  - CSplitterWnd.DoScroll
  - DoScroll
  - CSplitterWnd::DoScroll
dev_langs: 
  - C++
helpviewer_keywords: 
  - synchonization, scrolling
  - synchonization
  - CSplitterWnd class, overridables
  - DoScroll method
  - splitter windows, scrolling
  - scrolling splitter windows
ms.assetid: 156419b6-0544-4051-a863-2e8f5ef172ce
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSplitterWnd::DoScroll
Performs synchronized scrolling of split windows.  
  
## Syntax  
  
```  
  
      virtual BOOL DoScroll(  
   CView* pViewFrom,  
   UINT nScrollCode,  
   BOOL bDoScroll = TRUE   
);  
```  
  
#### Parameters  
 `pViewFrom`  
 A pointer to the view from which the scrolling message originates.  
  
 `nScrollCode`  
 A scroll-bar code that indicates the user's scrolling request. This parameter is composed of two parts: a low-order byte, which determines the type of scrolling occurring horizontally, and a high-order byte, which determines the type of scrolling occurring vertically:  
  
-   **SB_BOTTOM** Scrolls to bottom.  
  
-   **SB_LINEDOWN** Scrolls one line down.  
  
-   **SB_LINEUP** Scrolls one line up.  
  
-   **SB_PAGEDOWN** Scrolls one page down.  
  
-   **SB_PAGEUP** Scrolls one page up.  
  
-   **SB_TOP** Scrolls to top.  
  
 `bDoScroll`  
 Determines whether the specified scrolling action occurs. If `bDoScroll` is **TRUE** (that is, if a child window exists, and if the split windows have a scroll range), then the specified scrolling action can take place; if `bDoScroll` is **FALSE** (that is, if no child window exists, or the split views have no scroll range), then scrolling does not occur.  
  
## Return Value  
 Nonzero if synchronized scrolling occurs; otherwise 0.  
  
## Remarks  
 This member function is called by the framework to perform synchronized scrolling of split windows when the view receives a scroll message. Override to require an action by the user before synchronized scrolling is allowed.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWnd::DoScrollBy](../vs140/csplitterwnd--doscrollby.md)   
 [CView::OnScroll](../vs140/cview--onscroll.md)