---
title: "CWnd::GetScrollRange"
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
  - "CWnd.GetScrollRange"
  - "CWnd::GetScrollRange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetScrollRange method"
ms.assetid: 42959253-3813-4f7d-9a10-7e32a9729bff
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetScrollRange
Copies the current minimum and maximum scroll-bar positions for the given scroll bar to the locations specified by `lpMinPos` and `lpMaxPos`.  
  
## Syntax  
  
```  
  
      void GetScrollRange(  
   int nBar,  
   LPINT lpMinPos,  
   LPINT lpMaxPos   
) const;  
```  
  
#### Parameters  
 `nBar`  
 Specifies the scroll bar to examine. The parameter can take one of the following values:  
  
-   **SB_HORZ** Retrieves the position of the horizontal scroll bar.  
  
-   **SB_VERT** Retrieves the position of the vertical scroll bar.  
  
 `lpMinPos`  
 Points to the integer variable that is to receive the minimum position.  
  
 `lpMaxPos`  
 Points to the integer variable that is to receive the maximum position.  
  
## Remarks  
 If `CWnd` does not have a scroll bar, then the `GetScrollRange` member function copies 0 to `lpMinPos` and `lpMaxPos`.  
  
 The default range for a standard scroll bar is 0 to 100. The default range for a scroll-bar control is empty (both values are 0).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetScrollRange](http://msdn.microsoft.com/library/windows/desktop/bb787587)