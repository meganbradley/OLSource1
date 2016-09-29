---
title: "CScrollBar::ShowScrollBar"
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
  - "CScrollBar::ShowScrollBar"
  - "CScrollBar.ShowScrollBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CScrollBar class, operations"
  - "scroll bars, showing"
  - "scroll bars, hiding"
  - "ShowScrollBar method"
  - "hiding scroll bars"
ms.assetid: 15d7b7b1-8b07-4316-baf4-1da2a1c1ebed
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CScrollBar::ShowScrollBar
Shows or hides a scroll bar.  
  
## Syntax  
  
```  
  
      void ShowScrollBar(  
   BOOL bShow = TRUE   
);  
```  
  
#### Parameters  
 `bShow`  
 Specifies whether the scroll bar is shown or hidden. If this parameter is **TRUE**, the scroll bar is shown; otherwise it is hidden.  
  
## Remarks  
 An application should not call this function to hide a scroll bar while processing a scroll-bar notification message.  
  
## Example  
 See the example for [CScrollBar::Create](../vs140/cscrollbar--create.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CScrollBar Class](../vs140/cscrollbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CScrollBar::GetScrollPos](../vs140/cscrollbar--getscrollpos.md)   
 [CScrollBar::GetScrollRange](../vs140/cscrollbar--getscrollrange.md)   
 [CWnd::ScrollWindow](../vs140/cwnd--scrollwindow.md)   
 [CScrollBar::SetScrollPos](../vs140/cscrollbar--setscrollpos.md)   
 [CScrollBar::SetScrollRange](../vs140/cscrollbar--setscrollrange.md)