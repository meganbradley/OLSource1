---
title: "CSplitterWnd::GetScrollStyle"
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
  - "CSplitterWnd::GetScrollStyle"
  - "GetScrollStyle"
  - "CSplitterWnd.GetScrollStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSplitterWnd class, operations"
  - "GetScrollStyle method"
  - "splitter windows, scrolling"
ms.assetid: 632de700-15fe-4b00-b771-11e446dbc0e0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::GetScrollStyle
Returns the shared scroll-bar style for the splitter window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 One or more of the following windows style flags, if successful:  
  
-   **WS_HSCROLL** If the splitter currently manages shared horizontal scroll bars.  
  
-   **WS_VSCROLL** If the splitter currently manages shared vertical scroll bars.  
  
 If zero, the splitter window does not currently manage any shared scroll bars.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWnd::SetScrollStyle](../vs140/csplitterwnd--setscrollstyle.md)