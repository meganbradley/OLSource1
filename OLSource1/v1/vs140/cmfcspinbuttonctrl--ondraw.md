---
title: "CMFCSpinButtonCtrl::OnDraw"
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
  - "OnDraw"
  - "CMFCSpinButtonCtrl.OnDraw"
  - "CMFCSpinButtonCtrl::OnDraw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCSpinButtonCtrl::OnDraw"
  - "OnDraw method"
ms.assetid: 9ba5ac21-9cd6-45b8-bf25-c8e5ff697030
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCSpinButtonCtrl::OnDraw
Repaints the current spin button control.  
  
## Syntax  
  
```  
virtual void OnDraw(  
   CDC* pDC  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
## Remarks  
 The framework calls the `CMFCSpinButtonCtrl::OnPaint` method to handle the [WM_PAINT](../vs140/cwnd--onpaint.md) message, and that method in turn calls this `CMFCSpinButtonCtrl::OnDraw` method. Override this method to customize the way the framework draws the spin button control.  
  
## Requirements  
 **Header:** afxspinbuttonctrl.h  
  
## See Also  
 [CMFCSpinButtonCtrl Class](../vs140/cmfcspinbuttonctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CDC Class](../vs140/cdc-class.md)   
 [CWnd::OnPaint](../vs140/cwnd--onpaint.md)