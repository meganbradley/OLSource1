---
title: "CWnd::InvalidateRect"
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
  - "CWnd.InvalidateRect"
  - "CWnd::InvalidateRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InvalidateRect method"
ms.assetid: d7b0dec5-b92d-40f9-acc2-2455d747ea18
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::InvalidateRect
Invalidates the client area within the given rectangle by adding that rectangle to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> update region.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object or a [RECT](../vs140/rect-structure.md) structure that contains the rectangle (in client coordinates) to be added to the update region. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is **NULL**, the entire client area is added to the region.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies whether the background within the update region is to be erased.  
  
## Remarks  
 The invalidated rectangle, along with all other areas in the update region, is marked for painting when the next [WM_PAINT](../vs140/cwnd--onpaint.md) message is sent. The invalidated areas accumulate in the update region until the region is processed when the next <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> call occurs, or until the region is validated by the [ValidateRect](../vs140/cwnd--validaterect.md) or [ValidateRgn](../vs140/cwnd--validatergn.md) member function.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter specifies whether the background within the update area is to be erased when the update region is processed. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is **TRUE**, the background is erased when the [BeginPaint](../vs140/cwnd--beginpaint.md) member function is called; if <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is **FALSE**, the background remains unchanged. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is **TRUE** for any part of the update region, the background in the entire region is erased, not just in the given part.  
  
 Windows sends a [WM_PAINT](../vs140/cwnd--onpaint.md) message whenever the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> update region is not empty and there are no other messages in the application queue for that window.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::BeginPaint](../vs140/cwnd--beginpaint.md)   
 [CWnd::ValidateRect](../vs140/cwnd--validaterect.md)   
 [CWnd::ValidateRgn](../vs140/cwnd--validatergn.md)   
 [InvalidateRect](http://msdn.microsoft.com/library/windows/desktop/dd145002)   
 [CWnd::Invalidate](../vs140/cwnd--invalidate.md)   
 [CWnd::InvalidateRgn](../vs140/cwnd--invalidatergn.md)