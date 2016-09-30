---
title: "CWnd::OnVScroll"
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
  - "CWnd.OnVScroll"
  - "CWnd::OnVScroll"
  - "WM_VSCROLL"
  - "OnVScroll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_VSCROLL"
  - "OnVScroll method"
ms.assetid: 23cf0af9-41c8-4987-996e-199db0c2b3d6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnVScroll
The framework calls this member function when the user clicks the window's vertical scroll bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies a scroll-bar code that indicates the user's scrolling request. This parameter can be one of the following:  
  
-   **SB_BOTTOM** Scroll to bottom.  
  
-   **SB_ENDSCROLL** End scroll.  
  
-   **SB_LINEDOWN** Scroll one line down.  
  
-   **SB_LINEUP** Scroll one line up.  
  
-   **SB_PAGEDOWN** Scroll one page down.  
  
-   **SB_PAGEUP** Scroll one page up.  
  
-   **SB_THUMBPOSITION** Scroll to the absolute position. The current position is provided in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
-   **SB_THUMBTRACK** Drag scroll box to specified position. The current position is provided in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
-   **SB_TOP** Scroll to top.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Contains the current scroll-box position if the scroll-bar code is **SB_THUMBPOSITION** or **SB_THUMBTRACK**; otherwise not used. Depending on the initial scroll range, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> may be negative and should be cast to an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if necessary.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 If the scroll message came from a scroll-bar control, contains a pointer to the control. If the user clicked a window's scroll bar, this parameter is **NULL**. The pointer may be temporary and should not be stored for later use.  
  
## Remarks  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> typically is used by applications that give some feedback while the scroll box is being dragged.  
  
 If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> scrolls the contents of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object, it must also reset the position of the scroll box with the [SetScrollPos](../vs140/cwnd--setscrollpos.md) member function.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SetScrollPos](../vs140/cwnd--setscrollpos.md)   
 [CWnd::OnHScroll](../vs140/cwnd--onhscroll.md)   
 [WM_VSCROLL](http://msdn.microsoft.com/library/windows/desktop/bb787577)