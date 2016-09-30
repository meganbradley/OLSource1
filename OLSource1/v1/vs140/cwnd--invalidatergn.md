---
title: "CWnd::InvalidateRgn"
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
  - "InvalidateRgn"
  - "CWnd::InvalidateRgn"
  - "CWnd.InvalidateRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InvalidateRgn method"
ms.assetid: e71c7d35-d96c-4b66-bb45-8cdc68abba9d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::InvalidateRgn
Invalidates the client area within the given region by adding it to the current update region of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [CRgn](../vs140/crgn-class.md) object that identifies the region to be added to the update region. The region is assumed to have client coordinates. If this parameter is **NULL**, the entire client area is added to the update region.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies whether the background within the update region is to be erased.  
  
## Remarks  
 The invalidated region, along with all other areas in the update region, is marked for painting when the [WM_PAINT](../vs140/cwnd--onpaint.md) message is next sent. The invalidated areas accumulate in the update region until the region is processed when a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> message is next sent, or until the region is validated by the [ValidateRect](../vs140/cwnd--validaterect.md) or [ValidateRgn](../vs140/cwnd--validatergn.md) member function.  
  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter specifies whether the background within the update area is to be erased when the update region is processed. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is **TRUE**, the background is erased when the [BeginPaint](../vs140/cwnd--beginpaint.md) member function is called; if <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is **FALSE**, the background remains unchanged. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is **TRUE** for any part of the update region, the background in the entire region, not just in the given part, is erased.  
  
 Windows sends a [WM_PAINT](../vs140/cwnd--onpaint.md) message whenever the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> update region is not empty and there are no other messages in the application queue for that window.  
  
 The given region must have been previously created by one of the region functions.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::BeginPaint](../vs140/cwnd--beginpaint.md)   
 [CWnd::ValidateRect](../vs140/cwnd--validaterect.md)   
 [CWnd::ValidateRgn](../vs140/cwnd--validatergn.md)   
 [InvalidateRgn](http://msdn.microsoft.com/library/windows/desktop/dd145003)   
 [CWnd::Invalidate](../vs140/cwnd--invalidate.md)   
 [CWnd::InvalidateRect](../vs140/cwnd--invalidaterect.md)