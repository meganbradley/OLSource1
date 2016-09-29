---
title: "CFrameWndEx::OnNcMouseMove"
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
  - "OnNcMouseMove"
  - "CFrameWndEx::OnNcMouseMove"
  - "CFrameWndEx.OnNcMouseMove"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnNcMouseMove method"
ms.assetid: f44a9ede-6c6d-4f82-89df-14dc08aec26c
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::OnNcMouseMove
Called by the framework when the pointer moves in a non-client area.  
  
## Syntax  
  
```  
afx_msg void OnNcMouseMove(  
   UINT nHitTest,  
   CPoint point  
);  
```  
  
#### Parameters  
 [in] `nHitTest`  
 A pointer hit enumerated value. For a list of possible values see [WM_NCHITTEST Notification](http://msdn.microsoft.com/library/windows/desktop/ms645618).  
  
 [in] `point`  
 The location of the pointer in screen coordinates.  
  
## Remarks  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)