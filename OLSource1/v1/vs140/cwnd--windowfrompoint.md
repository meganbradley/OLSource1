---
title: "CWnd::WindowFromPoint"
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
  - "WindowFromPoint"
  - "CWnd::WindowFromPoint"
  - "CWnd.WindowFromPoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WindowFromPoint method"
  - "pointers, to window objects"
ms.assetid: d2f7eae9-3895-40d0-9857-146fb24b1f08
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::WindowFromPoint
Retrieves the window that contains the specified point; <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> must specify the screen coordinates of a point on the screen.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies a [CPoint](../vs140/cpoint-class.md) object or [POINT](../vs140/point-structure.md) data structure that defines the point to be checked.  
  
## Return Value  
 A pointer to the window object in which the point lies. It is **NULL** if no window exists at the given point. The returned pointer may be temporary and should not be stored for later use.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> does not retrieve a hidden or disabled window, even if the point is within the window. An application should use the [ChildWindowFromPoint](../vs140/cwnd--childwindowfrompoint.md) member function for a nonrestrictive search.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WindowFromPoint](http://msdn.microsoft.com/library/windows/desktop/ms633558)   
 [CWnd::ChildWindowFromPoint](../vs140/cwnd--childwindowfrompoint.md)