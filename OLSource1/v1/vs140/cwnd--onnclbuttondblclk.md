---
title: "CWnd::OnNcLButtonDblClk"
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
  - "WM_NCLBUTTONDBLCLK"
  - "OnNcLButtonDblClk"
  - "CWnd::OnNcLButtonDblClk"
  - "CWnd.OnNcLButtonDblClk"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_NCLBUTTONDBLCLK"
  - "OnNcLButtonDblClk method"
ms.assetid: 2afb19d0-a0da-41b0-b244-d8f739985c57
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnNcLButtonDblClk
The framework calls this member function when the user double-clicks the left mouse button while the cursor is within a nonclient area of `CWnd`.  
  
## Syntax  
  
```  
  
      afx_msg void OnNcLButtonDblClk(  
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
 If appropriate, the [WM_SYSCOMMAND](../vs140/cwnd--onsyscommand.md) message is sent.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_NCLBUTTONDBLCLK](http://msdn.microsoft.com/library/windows/desktop/ms645619)   
 [CWnd::OnNcHitTest](../vs140/cwnd--onnchittest.md)