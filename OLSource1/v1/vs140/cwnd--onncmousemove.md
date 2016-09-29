---
title: "CWnd::OnNcMouseMove"
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
  - "CWnd::OnNcMouseMove"
  - "WM_NCMOUSEMOVE"
  - "CWnd.OnNcMouseMove"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnNcMouseMove method"
  - "WM_NCMOUSEMOVE"
ms.assetid: ca04ffa3-94ad-4fda-aeeb-3c627c8b5101
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnNcMouseMove
The framework calls this member function when the cursor is moved within a nonclient area.  
  
## Syntax  
  
```  
  
      afx_msg void OnNcMouseMove(  
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
 [CWnd::OnNcHitTest](../vs140/cwnd--onnchittest.md)   
 [CWnd::OnSysCommand](../vs140/cwnd--onsyscommand.md)   
 [CWnd::OnNcMouseMove](../vs140/cwnd--onncmousemove.md)