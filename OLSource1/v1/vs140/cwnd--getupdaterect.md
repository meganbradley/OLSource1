---
title: "CWnd::GetUpdateRect"
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
  - CWnd::GetUpdateRect
  - CWnd.GetUpdateRect
  - GetUpdateRect
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetUpdateRect method
ms.assetid: 7c2d3bd8-9acd-44dc-b35c-2601f710444a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::GetUpdateRect
Retrieves the coordinates of the smallest rectangle that completely encloses the update region.  
  
## Syntax  
  
```  
  
      BOOL GetUpdateRect(  
   LPRECT lpRect,  
   BOOL bErase = FALSE   
);  
```  
  
#### Parameters  
 `lpRect`  
 Points to a `CRect` object or [RECT](../vs140/rect-structure.md) structure that is to receive the client coordinates of the update that encloses the update region.  
  
 Set this parameter to **NULL** to determine whether an update region exists within the `CWnd`. If `lpRect` is **NULL**, the `GetUpdateRect` member function returns nonzero if an update region exists and 0 if one does not. This provides a way to determine whether a `WM_PAINT` message resulted from an invalid area. Do not set this parameter to **NULL** in Windows version 3.0 and earlier.  
  
 `bErase`  
 Specifies whether the background in the update region is to be erased.  
  
## Return Value  
 Specifies the status of the update region. The value is nonzero if the update region is not empty; otherwise 0.  
  
 If the `lpRect` parameter is set to **NULL**, the return value is nonzero if an update region exists; otherwise 0.  
  
## Remarks  
 If `CWnd` was created with the **CS_OWNDC** style and the mapping mode is not `MM_TEXT`, the `GetUpdateRect` member function gives the rectangle in logical coordinates. Otherwise, `GetUpdateRect` gives the rectangle in client coordinates. If there is no update region, `GetUpdateRect` sets the rectangle to be empty (sets all coordinates to 0).  
  
 The `bErase` parameter specifies whether `GetUpdateRect` should erase the background of the update region. If `bErase` is **TRUE** and the update region is not empty, the background is erased. To erase the background, `GetUpdateRect` sends the [WM_ERASEBKGND](../vs140/cwnd--onerasebkgnd.md) message.  
  
 The update rectangle retrieved by the [BeginPaint](../vs140/cwnd--beginpaint.md) member function is identical to that retrieved by the `GetUpdateRect` member function.  
  
 The `BeginPaint` member function automatically validates the update region, so any call to `GetUpdateRect` made immediately after a call to `BeginPaint` retrieves an empty update region.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::BeginPaint](../vs140/cwnd--beginpaint.md)   
 [GetUpdateRect](http://msdn.microsoft.com/library/windows/desktop/dd144943)   
 [CWnd::OnPaint](../vs140/cwnd--onpaint.md)   
 [CWnd::RedrawWindow](../vs140/cwnd--redrawwindow.md)