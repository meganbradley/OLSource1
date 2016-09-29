---
title: "CWnd::OnLButtonDblClk"
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
  - "OnLButtonDblClk"
  - "CWnd::OnLButtonDblClk"
  - "WM_LBUTTONDBLCLK"
  - "CWnd.OnLButtonDblClk"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_LBUTTONDBLCLK"
  - "OnLButtonDblClk method"
ms.assetid: 816b1d79-f757-443e-9e07-dd646c856ae3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnLButtonDblClk
The framework calls this member function when the user double-clicks the left mouse button.  
  
## Syntax  
  
```  
  
      afx_msg void OnLButtonDblClk(  
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
 Only windows that have the **CS_DBLCLKS** [WNDCLASS](http://msdn.microsoft.com/library/windows/desktop/ms633576) style will receive `OnLButtonDblClk` calls. This is the default for Microsoft Foundation Class windows. Windows calls `OnLButtonDblClk` when the user presses, releases, and then presses the left mouse button again within the system's double-click time limit. Double-clicking the left mouse button actually generates four events: [WM_LBUTTONDOWN](../vs140/cwnd--onlbuttondown.md), [WM_LBUTTONUP](../vs140/cwnd--onlbuttonup.md) messages, the `WM_LBUTTONDBLCLK` call, and another `WM_LBUTTONUP` message when the button is released.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnLButtonDown](../vs140/cwnd--onlbuttondown.md)   
 [CWnd::OnLButtonUp](../vs140/cwnd--onlbuttonup.md)   
 [WM_LBUTTONDBLCLK](http://msdn.microsoft.com/library/windows/desktop/ms645606)