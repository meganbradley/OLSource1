---
title: "CSplitterWnd::DoScrollBy"
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
  - "DoScrollBy"
  - "CSplitterWnd.DoScrollBy"
  - "CSplitterWnd::DoScrollBy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSplitterWnd class, overridables"
  - "DoScrollBy method"
  - "splitter windows, scrolling"
  - "scrolling splitter windows"
ms.assetid: 62436eae-fb5e-4404-870a-8bb894dfa104
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::DoScrollBy
Scrolls split windows by a given number of pixels.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the view from which the scrolling message originates.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Number of pixels to be scrolled horizontally and vertically.  
  
 bDoScroll  
 Determines whether the specified scrolling action occurs. If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is **TRUE** (that is, if a child window exists, and if the split windows have a scroll range), then the specified scrolling action can take place; if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is **FALSE** (that is, if no child window exists, or the split views have no scroll range), then scrolling does not occur.  
  
## Return Value  
 Nonzero if synchronized scrolling occurs; otherwise 0.  
  
## Remarks  
 This member function is called by the framework in response to a scroll message, to perform synchronized scrolling of the split windows by the amount, in pixels, indicated by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Positive values indicate scrolling down and to the right; negative values indicate scrolling up and to the left.  
  
 Override to require an action by the user before allowing scroll.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWnd::DoScroll](../vs140/csplitterwnd--doscroll.md)   
 [CView::OnScroll](../vs140/cview--onscroll.md)