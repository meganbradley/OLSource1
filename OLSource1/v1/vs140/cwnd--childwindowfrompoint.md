---
title: "CWnd::ChildWindowFromPoint"
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
  - "CWnd::ChildWindowFromPoint"
  - "ChildWindowFromPoint"
  - "CWnd.ChildWindowFromPoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ChildWindowFromPoint method"
ms.assetid: 41cd55e0-ea57-4d0b-bbdd-e56f2dc9db40
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::ChildWindowFromPoint
Determines which, if any, of the child windows belonging to `CWnd` contains the specified point.  
  
## Syntax  
  
```  
  
      CWnd* ChildWindowFromPoint(  
   POINT point   
) const;  
CWnd* ChildWindowFromPoint(  
   POINT point,  
   UINT nFlags   
) const;  
```  
  
#### Parameters  
 `point`  
 Specifies the client coordinates of the point to be tested.  
  
 *nflags*  
 Specifies which child windows to skip. This parameter can be a combination of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|**CWP_ALL**|Do not skip any child windows|  
|**CWP_SKIPINVISIBLE**|Skip invisible child windows|  
|**CWP_SKIPDISABLED**|Skip disabled child windows|  
|**CWP_SKIPTRANSPARENT**|Skip transparent child windows|  
  
## Return Value  
 Identifies the child window that contains the point. It is **NULL** if the given point lies outside of the client area. If the point is within the client area but is not contained within any child window, `CWnd` is returned.  
  
 This member function will return a hidden or disabled child window that contains the specified point.  
  
 More than one window may contain the given point. However, this function returns only the `CWnd`* of the first window encountered that contains the point.  
  
 The `CWnd`* that is returned may be temporary and should not be stored for later use.  
  
## Example  
 [!code[NVC_MFCWindowing#77](../vs140/codesnippet/CPP/cwnd--childwindowfrompoint_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::WindowFromPoint](../vs140/cwnd--windowfrompoint.md)   
 [ChildWindowFromPoint](http://msdn.microsoft.com/library/windows/desktop/ms632676)