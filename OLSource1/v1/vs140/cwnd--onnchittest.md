---
title: "CWnd::OnNcHitTest"
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
  - "CWnd.OnNcHitTest"
  - "OnNcHitTest"
  - "CWnd::OnNcHitTest"
  - "WM_NCHITTEST"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnNcHitTest method"
  - "WM_NCHITTEST"
  - "mouse, hit-test enumerated values"
  - "HitTest method [MFC]"
ms.assetid: 5fdc6d47-0a6c-4a2c-99f4-7120df774798
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnNcHitTest
The framework calls this member function for the `CWnd` object that contains the cursor (or the `CWnd` object that used the [SetCapture](../vs140/cwnd--setcapture.md) member function to capture the mouse input) every time the mouse is moved.  
  
## Syntax  
  
```  
  
      afx_msg LRESULT OnNcHitTest(  
   CPoint point   
);  
```  
  
#### Parameters  
 `point`  
 Contains the x- and y-coordinates of the cursor. These coordinates are always screen coordinates.  
  
## Return Value  
 One of the mouse hit-test enumerated values listed below.  
  
## Remarks  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Mouse Enumerated Values  
  
-   **HTBORDER** In the border of a window that does not have a sizing border.  
  
-   **HTBOTTOM** In the lower horizontal border of the window.  
  
-   **HTBOTTOMLEFT** In the lower-left corner of the window border.  
  
-   **HTBOTTOMRIGHT** In the lower-right corner of the window border.  
  
-   **HTCAPTION** In a title-bar area.  
  
-   **HTCLIENT** In a client area.  
  
-   **HTCLOSE** In a Close button.  
  
-   **HTERROR** On the screen background or on a dividing line between windows (same as **HTNOWHERE** except that the **DefWndProc** Windows function produces a system beep to indicate an error).  
  
-   **HTGROWBOX** In a size box.  
  
-   **HTHELP** In a Help button.  
  
-   **HTHSCROLL** In the horizontal scroll bar.  
  
-   **HTLEFT** In the left border of the window.  
  
-   **HTMAXBUTTON** In a Maximize button.  
  
-   **HTMENU** In a menu area.  
  
-   **HTMINBUTTON** In a Minimize button.  
  
-   **HTNOWHERE** On the screen background or on a dividing line between windows.  
  
-   **HTREDUCE** In a Minimize button.  
  
-   **HTRIGHT** In the right border of the window.  
  
-   **HTSIZE** In a size box (same as **HTGROWBOX**).  
  
-   **HTSYSMENU** In a Control menu or in a Close button in a child window.  
  
-   **HTTOP** In the upper horizontal border of the window.  
  
-   **HTTOPLEFT** In the upper-left corner of the window border.  
  
-   **HTTOPRIGHT** In the upper-right corner of the window border.  
  
-   **HTTRANSPARENT** In a window currently covered by another window.  
  
-   **HTVSCROLL** In the vertical scroll bar.  
  
-   **HTZOOM** In a Maximize button.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetCapture](../vs140/cwnd--getcapture.md)   
 [WM_NCHITTEST](http://msdn.microsoft.com/library/windows/desktop/ms645618)