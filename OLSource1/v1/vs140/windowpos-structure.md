---
title: "WINDOWPOS Structure"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "WINDOWPOS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WINDOWPOS structure"
ms.assetid: a4ea7cd9-c4c2-4480-9c55-cbbff72195e1
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# WINDOWPOS Structure
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure contains information about the size and position of a window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *hwnd*  
 Identifies the window.  
  
 *hwndInsertAfter*  
 Identifies the window behind which this window is placed.  
  
 *x*  
 Specifies the position of the left edge of the window.  
  
 *y*  
 Specifies the position of the right edge of the window.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the window width, in pixels.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the window height, in pixels.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies window-positioning options. This member can be one of the following values:  
  
-   **SWP_DRAWFRAME** Draws a frame (defined in the class description for the window) around the window. The window receives a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> message.  
  
-   **SWP_FRAMECHANGED** Sends a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> message to the window, even if the window's size is not being changed. If this flag is not specified, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is sent only when the window's size is being changed.  
  
-   **SWP_HIDEWINDOW** Hides the window.  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> Does not activate the window.  
  
-   **SWP_NOCOPYBITS** Discards the entire contents of the client area. If this flag is not specified, the valid contents of the client area are saved and copied back into the client area after the window is sized or repositioned.  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> Retains current position (ignores the **x** and **y** members).  
  
-   **SWP_NOOWNERZORDER** Does not change the owner window's position in the Z-order.  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> Retains current size (ignores the **cx** and **cy** members).  
  
-   **SWP_NOREDRAW** Does not redraw changes.  
  
-   **SWP_NOREPOSITION** Same as **SWP_NOOWNERZORDER**.  
  
-   **SWP_NOSENDCHANGING** Prevents the window from receiving the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> message.  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> Retains current ordering (ignores the **hwndInsertAfter** member).  
  
-   **SWP_SHOWWINDOW** Displays the window.  
  
## Requirements  
 **Header:** winuser.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)   
 [CWnd::OnWindowPosChanging](../vs140/cwnd--onwindowposchanging.md)