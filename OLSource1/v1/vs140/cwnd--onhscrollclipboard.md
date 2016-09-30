---
title: "CWnd::OnHScrollClipboard"
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
  - "OnHScrollClipboard"
  - "WM_HSCROLLCLIPBOARD"
  - "CWnd.OnHScrollClipboard"
  - "CWnd::OnHScrollClipboard"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnHScrollClipboard method"
  - "WM_HSCROLLCLIPBOARD"
ms.assetid: 09033ab4-81bc-4f06-af45-844a77551f05
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnHScrollClipboard
The Clipboard owner's <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function is called by the Clipboard viewer when the Clipboard data has the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> format and there is an event in the Clipboard viewer's horizontal scroll bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies a pointer to a Clipboard-viewer window. The pointer may be temporary and should not be stored for later use.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies one of the following scroll-bar codes in the low-order word:  
  
-   **SB_BOTTOM** Scroll to lower right.  
  
-   **SB_ENDSCROLL** End scroll.  
  
-   **SB_LINEDOWN** Scroll one line down.  
  
-   **SB_LINEUP** Scroll one line up.  
  
-   **SB_PAGEDOWN** Scroll one page down.  
  
-   **SB_PAGEUP** Scroll one page up.  
  
-   **SB_THUMBPOSITION** Scroll to the absolute position. The current position is provided in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
-   **SB_TOP** Scroll to upper left.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Contains the scroll-box position if the scroll-bar code is **SB_THUMBPOSITION**; otherwise not used.  
  
## Remarks  
 The owner should scroll the Clipboard image, invalidate the appropriate section, and update the scroll-bar values.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnVScrollClipboard](../vs140/cwnd--onvscrollclipboard.md)   
 [WM_HSCROLLCLIPBOARD](http://msdn.microsoft.com/library/windows/desktop/ms649026)