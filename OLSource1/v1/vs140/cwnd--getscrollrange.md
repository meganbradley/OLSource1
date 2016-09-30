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
Copies the current minimum and maximum scroll-bar positions for the given scroll bar to the locations specified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the scroll bar to examine. The parameter can take one of the following values:  
  
-   **SB_HORZ** Retrieves the position of the horizontal scroll bar.  
  
-   **SB_VERT** Retrieves the position of the vertical scroll bar.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Points to the integer variable that is to receive the minimum position.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Points to the integer variable that is to receive the maximum position.  
  
## Remarks  
 If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> does not have a scroll bar, then the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member function copies 0 to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 The default range for a standard scroll bar is 0 to 100. The default range for a scroll-bar control is empty (both values are 0).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetScrollRange](http://msdn.microsoft.com/library/windows/desktop/bb787587)