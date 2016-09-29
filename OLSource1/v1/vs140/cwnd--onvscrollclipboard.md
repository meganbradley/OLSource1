---
title: "CWnd::OnVScrollClipboard"
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
  - "WM_VSCROLLCLIPBOARD"
  - "OnVScrollClipboard"
  - "CWnd.OnVScrollClipboard"
  - "CWnd::OnVScrollClipboard"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_VSCROLLCLIPBOARD"
  - "OnVScrollClipboard method"
ms.assetid: f34fecea-b295-46fb-89ba-e638f726b05b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnVScrollClipboard
The Clipboard owner's `OnVScrollClipboard` member function is called by the Clipboard viewer when the Clipboard data has the `CF_OWNERDISPLAY` format and there is an event in the Clipboard viewer's vertical scroll bar.  
  
## Syntax  
  
```  
  
      afx_msg void OnVScrollClipboard(  
   CWnd* pClipAppWnd,  
   UINT nSBCode,  
   UINT nPos   
);  
```  
  
#### Parameters  
 `pClipAppWnd`  
 Specifies a pointer to a Clipboard-viewer window. The pointer may be temporary and should not be stored for later use.  
  
 `nSBCode`  
 Specifies one of the following scroll-bar values:  
  
-   **SB_BOTTOM** Scroll to bottom.  
  
-   **SB_ENDSCROLL** End scroll.  
  
-   **SB_LINEDOWN** Scroll one line down.  
  
-   **SB_LINEUP** Scroll one line up.  
  
-   **SB_PAGEDOWN** Scroll one page down.  
  
-   **SB_PAGEUP** Scroll one page up.  
  
-   **SB_THUMBPOSITION** Scroll to the absolute position. The current position is provided in `nPos`.  
  
-   **SB_TOP** Scroll to top.  
  
 `nPos`  
 Contains the scroll-box position if the scroll-bar code is **SB_THUMBPOSITION**; otherwise `nPos` is not used.  
  
## Remarks  
 The owner should scroll the Clipboard image, invalidate the appropriate section, and update the scroll-bar values.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::Invalidate](../vs140/cwnd--invalidate.md)   
 [CWnd::OnHScrollClipboard](../vs140/cwnd--onhscrollclipboard.md)   
 [CWnd::InvalidateRect](../vs140/cwnd--invalidaterect.md)   
 [WM_VSCROLLCLIPBOARD](http://msdn.microsoft.com/library/windows/desktop/ms649032)   
 [CWnd::Default](../vs140/cwnd--default.md)