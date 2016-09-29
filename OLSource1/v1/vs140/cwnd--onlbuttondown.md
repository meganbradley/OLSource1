---
title: "CWnd::OnLButtonDown"
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
  - "CWnd::OnLButtonDown"
  - "WM_LBUTTONDOWN"
  - "OnLButtonDown"
  - "CWnd.OnLButtonDown"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_LBUTTONDOWN"
  - "OnLButtonDown method"
ms.assetid: 29cda65c-ab8b-4a2f-abd6-17ba72a73f9c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnLButtonDown
The framework calls this member function when the user presses the left mouse button.  
  
## Syntax  
  
```  
  
      afx_msg void OnLButtonDown(  
   UINT nFlags,  
   CPoint point   
);  
```  
  
#### Parameters  
 `nFlags`  
 Indicates whether various virtual keys are down. This parameter can be any combination of the following values:  
  
-   **MK_CONTROL** Set if the CTRL key is down.  
  
-   **MK_LBUTTON** Set if the left mouse button is down.  
  
-   **MK_MBUTTON** Set if the middle mouse button is down.  
  
-   **MK_RBUTTON** Set if the right mouse button is down.  
  
-   **MK_SHIFT** Set if the SHIFT key is down.  
  
 `point`  
 Specifies the x- and y-coordinate of the cursor. These coordinates are always relative to the upper-left corner of the window.  
  
## Remarks  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnLButtonDblClk](../vs140/cwnd--onlbuttondblclk.md)   
 [CWnd::OnLButtonUp](../vs140/cwnd--onlbuttonup.md)