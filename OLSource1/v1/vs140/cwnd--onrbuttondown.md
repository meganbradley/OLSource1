---
title: "CWnd::OnRButtonDown"
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
  - "CWnd.OnRButtonDown"
  - "WM_RBUTTONDOWN"
  - "CWnd::OnRButtonDown"
  - "OnRButtonDown"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnRButtonDown method"
  - "WM_RBUTTONDOWN"
ms.assetid: ea3887ba-2520-48af-a104-8256cb899d28
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnRButtonDown
The framework calls this member function when the user presses the right mouse button.  
  
## Syntax  
  
```  
  
      afx_msg void OnRButtonDown(  
   UINT nFlags,  
   CPoint point   
);  
```  
  
#### Parameters  
 `nFlags`  
 Indicates whether various virtual keys are down. This parameter can be any combination of the following values:  
  
-   **MK_CONTROL** Set if CTRL key is down.  
  
-   **MK_LBUTTON** Set if left mouse button is down.  
  
-   **MK_MBUTTON** Set if middle mouse button is down.  
  
-   **MK_RBUTTON** Set if right mouse button is down.  
  
-   **MK_SHIFT** Set if SHIFT key is down.  
  
 `point`  
 Specifies the x and y coordinates of the cursor. These coordinates are always relative to the upper-left corner of the window.  
  
## Remarks  
 This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnRButtonDblClk](../vs140/cwnd--onrbuttondblclk.md)   
 [CWnd::OnRButtonUp](../vs140/cwnd--onrbuttonup.md)   
 [WM_RBUTTONDOWN](http://msdn.microsoft.com/library/windows/desktop/ms646242)