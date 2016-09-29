---
title: "CWnd::OnNcMButtonDblClk"
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
  - "CWnd.OnNcMButtonDblClk"
  - "WM_NCMBUTTONDBLCLK"
  - "OnNcMButtonDblClk"
  - "CWnd::OnNcMButtonDblClk"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_NCMBUTTONDBLCLK"
  - "OnNcMButtonDblClk method"
ms.assetid: f4ee3ca9-1331-480d-ab0f-6ed43a121f74
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnNcMButtonDblClk
The framework calls this member function when the user double-clicks the middle mouse button while the cursor is within a nonclient area.  
  
## Syntax  
  
```  
  
      afx_msg void OnNcMButtonDblClk(  
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
 [CWnd::OnNcMButtonDown](../vs140/cwnd--onncmbuttondown.md)   
 [CWnd::OnNcMButtonUp](../vs140/cwnd--onncmbuttonup.md)   
 [CWnd::OnNcMButtonDblClk](../vs140/cwnd--onncmbuttondblclk.md)