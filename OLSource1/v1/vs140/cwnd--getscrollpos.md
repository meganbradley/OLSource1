---
title: "CWnd::GetScrollPos"
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
  - "CWnd::GetScrollPos"
  - "CWnd.GetScrollPos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetScrollPos method"
ms.assetid: f044c7b5-b1d0-4f57-9501-addee9e7eec3
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetScrollPos
Retrieves the current position of the scroll box of a scroll bar.  
  
## Syntax  
  
```  
  
      int GetScrollPos(  
   int nBar   
) const;  
```  
  
#### Parameters  
 `nBar`  
 Specifies the scroll bar to examine. The parameter can take one of the following values:  
  
-   **SB_HORZ** Retrieves the position of the horizontal scroll bar.  
  
-   **SB_VERT** Retrieves the position of the vertical scroll bar.  
  
## Return Value  
 Specifies the current position of the scroll box in the scroll bar if successful; otherwise 0.  
  
## Remarks  
 The current position is a relative value that depends on the current scrolling range. For example, if the scrolling range is 50 to 100 and the scroll box is in the middle of the bar, the current position is 75.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetScrollPos](http://msdn.microsoft.com/library/windows/desktop/bb787585)   
 [CScrollBar::GetScrollPos](../vs140/cscrollbar--getscrollpos.md)