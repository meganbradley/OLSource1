---
title: "CWnd::OnNcMButtonUp"
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
  - "WM_NCMBUTTONUP"
  - "OnNcMButtonUp"
  - "CWnd::OnNcMButtonUp"
  - "CWnd.OnNcMButtonUp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_NCMBUTTONUP"
  - "OnNcMButtonUp method"
ms.assetid: 61f7f6d1-0dab-4a56-b985-d02575c74e0d
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnNcMButtonUp
The framework calls this member function when the user releases the middle mouse button while the cursor is within a nonclient area.  
  
## Syntax  
  
```  
  
      afx_msg void OnNcMButtonUp(  
   UINT nHitTest,  
   CPoint point   
);  
```  
  
#### Parameters  
 `nHitTest`  
 Specifies the [hit-test code](../vs140/cwnd--onnchittest.md). A hit test is a test that determines the location of the cursor.  
  
 `point`  
 Specifies a `CPoint` object that contains the x and y screen coordinates of the cursor position. These coordinates are always relative to the upper-left corner of the screen.  
  
## Remarks  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnNcHitTest](../vs140/cwnd--onnchittest.md)   
 [CWnd::OnNcMButtonDblClk](../vs140/cwnd--onncmbuttondblclk.md)   
 [CWnd::OnNcMButtonDown](../vs140/cwnd--onncmbuttondown.md)   
 [CWnd::OnNcMButtonUp](#_mfc_cwnd.3a3a.onncmbuttonup)