---
title: "CWnd::Invalidate"
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
  - "CWnd::Invalidate"
  - "CWnd.Invalidate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Invalidate method"
ms.assetid: 104a3e69-ef04-480f-bead-55617f284afb
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::Invalidate
Invalidates the entire client area of `CWnd`.  
  
## Syntax  
  
```  
  
      void Invalidate(  
   BOOL bErase = TRUE   
);  
```  
  
#### Parameters  
 `bErase`  
 Specifies whether the background within the update region is to be erased.  
  
## Remarks  
 The client area is marked for painting when the next [WM_PAINT](../vs140/cwnd--onpaint.md) message occurs. The region can also be validated before a `WM_PAINT` message occurs by the [ValidateRect](../vs140/cwnd--validaterect.md) or [ValidateRgn](../vs140/cwnd--validatergn.md) member function.  
  
 The `bErase` parameter specifies whether the background within the update area is to be erased when the update region is processed. If `bErase` is **TRUE**, the background is erased when the [BeginPaint](../vs140/cwnd--beginpaint.md) member function is called; if `bErase` is **FALSE**, the background remains unchanged. If `bErase` is **TRUE** for any part of the update region, the background in the entire region, not just in the given part, is erased.  
  
 Windows sends a [WM_PAINT](../vs140/cwnd--onpaint.md) message whenever the `CWnd` update region is not empty and there are no other messages in the application queue for that window.  
  
## Example  
 See the example for [CWnd::UpdateWindow](../vs140/cwnd--updatewindow.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::BeginPaint](../vs140/cwnd--beginpaint.md)   
 [CWnd::ValidateRect](../vs140/cwnd--validaterect.md)   
 [CWnd::ValidateRgn](../vs140/cwnd--validatergn.md)   
 [InvalidateRect](http://msdn.microsoft.com/library/windows/desktop/dd145002)   
 [CWnd::InvalidateRect](../vs140/cwnd--invalidaterect.md)   
 [CWnd::InvalidateRgn](../vs140/cwnd--invalidatergn.md)