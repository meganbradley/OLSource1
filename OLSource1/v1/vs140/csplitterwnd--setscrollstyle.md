---
title: "CSplitterWnd::SetScrollStyle"
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
  - "SetScrollStyle"
  - "CSplitterWnd::SetScrollStyle"
  - "CSplitterWnd.SetScrollStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSplitterWnd class, operations"
  - "splitter windows, scrolling"
  - "SetScrollStyle method"
ms.assetid: 53a03ec5-0fb7-4c3d-95d5-aa880267796a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::SetScrollStyle
Specifies the new scroll style for the splitter window's shared scroll-bar support.  
  
## Syntax  
  
```  
  
      void SetScrollStyle(  
   DWORD dwStyle   
);  
```  
  
#### Parameters  
 `dwStyle`  
 The new scroll style for the splitter window's shared scroll-bar support, which can be one of the following values:  
  
-   **WS_HSCROLL** Create/show horizontal shared scroll bars.  
  
-   **WS_VSCROLL** Create/show vertical shared scroll bars.  
  
## Remarks  
 Once a scroll bar is created it will not be destroyed even if `SetScrollStyle` is called without that style; instead those scroll bars are hidden. This allows the scroll bars to retain their state even though they are hidden. After calling `SetScrollStyle` it is necessary to call [RecalcLayout](../vs140/csplitterwnd--recalclayout.md) for all the changes to take effect.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWnd::GetScrollStyle](../vs140/csplitterwnd--getscrollstyle.md)