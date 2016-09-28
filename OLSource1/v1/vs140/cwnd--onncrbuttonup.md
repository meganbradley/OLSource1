---
title: "CWnd::OnNcRButtonUp"
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
  - "CWnd::OnNcRButtonUp"
  - "OnNcRButtonUp"
  - "WM_NCRBUTTONUP"
  - "CWnd.OnNcRButtonUp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_NCRBUTTONUP"
  - "OnNcRButtonUp method"
ms.assetid: 7e0ae9c6-c5de-46dc-b9e5-09c58b7f0577
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnNcRButtonUp
The framework calls this member function when the user releases the right mouse button while the cursor is within a nonclient area.  
  
## Syntax  
  
```  
  
      afx_msg void OnNcRButtonUp(  
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
 [CWnd::OnNcRButtonDblClk](../vs140/cwnd--onncrbuttondblclk.md)   
 [CWnd::OnNcRButtonDown](../vs140/cwnd--onncrbuttondown.md)   
 [CWnd::OnNcRButtonUp](../vs140/cwnd--onncrbuttonup.md)