---
title: "CFrameWndEx::OnMouseMove"
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
  - "CFrameWndEx.OnMouseMove"
  - "CFrameWndEx::OnMouseMove"
  - "OnMouseMove"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnMouseMove method"
ms.assetid: 6590debd-cd74-42b2-a093-214562b681a4
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::OnMouseMove
The framework calls this method when the pointer moves.  
  
## Syntax  
  
```  
afx_msg void OnMouseMove(  
   UINT nFlags,  
   CPoint point  
);  
```  
  
#### Parameters  
 [in] `nFlags`  
 Indicates whether a user pressed modifier keys. For possible values see the parameter `wParam` in [WM_MOUSEMOVE Notification](http://msdn.microsoft.com/library/windows/desktop/ms645616).  
  
 [in] `point`  
 Specifies the x and y coordinates of the pointer relative to the upper-left corner of the window.  
  
## Remarks  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)