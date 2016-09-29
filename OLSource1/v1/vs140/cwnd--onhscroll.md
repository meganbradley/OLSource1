---
title: "CWnd::OnHScroll"
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
  - "OnHScroll"
  - "WM_HSCROLL"
  - "CWnd.OnHScroll"
  - "CWnd::OnHScroll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnHScroll method"
  - "WM_HSCROLL"
ms.assetid: 13dcf63f-f6ce-4574-9dbc-6548554932e4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnHScroll
The framework calls this member function when the user clicks a window's horizontal scroll bar.  
  
## Syntax  
  
```  
  
      afx_msg void OnHScroll(  
   UINT nSBCode,  
   UINT nPos,  
   CScrollBar* pScrollBar   
);  
```  
  
#### Parameters  
 `nSBCode`  
 Specifies a scroll-bar code that indicates the user's scrolling request. This parameter can be one of the following:  
  
-   **SB_LEFT** Scroll to far left.  
  
-   **SB_ENDSCROLL** End scroll.  
  
-   **SB_LINELEFT** Scroll left.  
  
-   **SB_LINERIGHT** Scroll right.  
  
-   **SB_PAGELEFT** Scroll one page left.  
  
-   **SB_PAGERIGHT** Scroll one page right.  
  
-   **SB_RIGHT** Scroll to far right.  
  
-   **SB_THUMBPOSITION** Scroll to absolute position. The current position is specified by the `nPos` parameter.  
  
-   **SB_THUMBTRACK** Drag scroll box to specified position. The current position is specified by the `nPos` parameter.  
  
 `nPos`  
 Specifies the scroll-box position if the scroll-bar code is **SB_THUMBPOSITION** or **SB_THUMBTRACK**; otherwise, not used. Depending on the initial scroll range, `nPos` may be negative and should be cast to an `int` if necessary.  
  
 `pScrollBar`  
 If the scroll message came from a scroll-bar control, contains a pointer to the control. If the user clicked a window's scroll bar, this parameter is **NULL**. The pointer may be temporary and should not be stored for later use.  
  
## Remarks  
 The **SB_THUMBTRACK** scroll-bar code typically is used by applications that give some feedback while the scroll box is being dragged.  
  
 If an application scrolls the contents controlled by the scroll bar, it must also reset the position of the scroll box with the [SetScrollPos](../vs140/cwnd--setscrollpos.md) member function.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Example  
 [!code[NVC_MFCWindowing#108](../vs140/codesnippet/CPP/cwnd--onhscroll_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SetScrollPos](../vs140/cwnd--setscrollpos.md)   
 [CWnd::OnVScroll](../vs140/cwnd--onvscroll.md)   
 [WM_HSCROLL](http://msdn.microsoft.com/library/windows/desktop/bb787575)