---
title: "CFrameWndEx::OnLButtonUp"
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
  - "OnLButtonUp"
  - "CFrameWndEx.OnLButtonUp"
  - "CFrameWndEx::OnLButtonUp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnLButtonUp method"
ms.assetid: b4eb01f9-7b42-414d-84bd-2764ad55ba97
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::OnLButtonUp
The framework calls this method when the user releases the left mouse button.  
  
## Syntax  
  
```  
afx_msg void OnLButtonUp(  
   UINT nFlags,  
   CPoint point  
);  
```  
  
#### Parameters  
 [in] `nFlags`  
 Indicates whether the user pressed modifier keys. For possible values see the parameter `wParam` in [WM_LBUTTONUP Notification](http://msdn.microsoft.com/library/windows/desktop/ms645608).  
  
 [in] `point`  
 Specifies the x and y coordinates of the pointer, relative to the upper-left corner of the window.  
  
## Remarks  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)