---
title: "CWnd::BeginPaint"
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
  - "CWnd::BeginPaint"
  - "CWnd.BeginPaint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BeginPaint method"
  - "BeginPaint method, CWnd"
ms.assetid: c61f03d7-7d43-4da5-8149-7c415e0df109
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::BeginPaint
Prepares `CWnd` for painting and fills a `PAINTSTRUCT` data structure with information about the painting.  
  
## Syntax  
  
```  
  
      CDC* BeginPaint(  
   LPPAINTSTRUCT lpPaint   
);  
```  
  
#### Parameters  
 `lpPaint`  
 Points to the [PAINTSTRUCT](../vs140/paintstruct-structure.md) structure that is to receive painting information.  
  
## Return Value  
 Identifies the device context for `CWnd`. The pointer may be temporary and should not be stored beyond the scope of [EndPaint](../vs140/cwnd--endpaint.md).  
  
## Remarks  
 The paint structure contains a [RECT](../vs140/rect-structure.md) data structure that has the smallest rectangle that completely encloses the update region and a flag that specifies whether the background has been erased.  
  
 The update region is set by the [Invalidate](../vs140/cwnd--invalidate.md), [InvalidateRect](../vs140/cwnd--invalidaterect.md), or [InvalidateRgn](../vs140/cwnd--invalidatergn.md) member functions and by the system after it sizes, moves, creates, scrolls, or performs any other operation that affects the client area. If the update region is marked for erasing, `BeginPaint` sends an [WM_ONERASEBKGND](../vs140/cwnd--onerasebkgnd.md) message.  
  
 Do not call the `BeginPaint` member function except in response to a [WM_PAINT](../vs140/cwnd--onpaint.md) message. Each call to the `BeginPaint` member function must have a matching call to the [EndPaint](../vs140/cwnd--endpaint.md) member function. If the caret is in the area to be painted, the `BeginPaint` member function automatically hides the caret to prevent it from being erased.  
  
## Example  
 [!code[NVC_MFCWindowing#70](../vs140/codesnippet/CPP/cwnd--beginpaint_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::EndPaint](../vs140/cwnd--endpaint.md)   
 [CWnd::Invalidate](../vs140/cwnd--invalidate.md)   
 [CWnd::InvalidateRgn](../vs140/cwnd--invalidatergn.md)   
 [BeginPaint](http://msdn.microsoft.com/library/windows/desktop/dd183362)   
 [CPaintDC Class](../vs140/cpaintdc-class.md)