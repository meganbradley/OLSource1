---
title: "CWnd::OnRButtonDblClk"
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
  - "CWnd::OnRButtonDblClk"
  - "CWnd.OnRButtonDblClk"
  - "WM_RBUTTONDBLCLK"
  - "OnRButtonDblClk"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnRButtonDblClk method"
  - "WM_RBUTTONDBLCLK"
ms.assetid: 00631032-29a7-4e74-b239-b9ce7fbf3a31
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnRButtonDblClk
The framework calls this member function when the user double-clicks the right mouse button.  
  
## Syntax  
  
```  
  
      afx_msg void OnRButtonDblClk(  
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
 Only windows that have the **CS_DBLCLKS** [WNDCLASS](http://msdn.microsoft.com/library/windows/desktop/ms633576) style can receive `OnRButtonDblClk` calls. This is the default for windows within the Microsoft Foundation Class Library. Windows calls `OnRButtonDblClk` when the user presses, releases, and then again presses the right mouse button within the system's double-click time limit. Double-clicking the right mouse button actually generates four events: [WM_RBUTTONDOWN](../vs140/cwnd--onrbuttondown.md) and [WM_RBUTTONUP](../vs140/cwnd--onrbuttonup.md) messages, the `OnRButtonDblClk` call, and another `WM_RBUTTONUP` message when the button is released.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnRButtonDown](../vs140/cwnd--onrbuttondown.md)   
 [CWnd::OnRButtonUp](../vs140/cwnd--onrbuttonup.md)   
 [WM_RBUTTONDBLCLK](http://msdn.microsoft.com/library/windows/desktop/ms646241)