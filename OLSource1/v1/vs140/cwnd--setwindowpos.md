---
title: "CWnd::SetWindowPos"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CWnd.SetWindowPos
  - CWnd::SetWindowPos
dev_langs: 
  - C++
helpviewer_keywords: 
  - wndNoTopMost CWnd constant
  - window positions
  - SetWindowPos method
  - wndTopMost CWnd constant
  - wndTop CWnd constant
  - wndBottom CWnd constant
ms.assetid: ff6b37f3-9ebb-49d8-b81c-5114182bd35b
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::SetWindowPos
Changes the size, position, and Z-order of child, pop-up, and top-level windows.  
  
## Syntax  
  
```  
  
      BOOL SetWindowPos(  
   const CWnd* pWndInsertAfter,  
   int x,  
   int y,  
   int cx,  
   int cy,  
   UINT nFlags   
);  
```  
  
#### Parameters  
 `pWndInsertAfter`  
 Identifies the `CWnd` object that will precede (be higher than) this `CWnd` object in the Z-order. This parameter can be a pointer to a `CWnd` or a **Pointer** to one of the following values:  
  
-   **wndBottom** Places the window at the bottom of the Z-order. If this `CWnd` is a topmost window, the window loses its topmost status; the system places the window at the bottom of all other windows.  
  
-   **wndTop** Places the window at the top of the Z-order.  
  
-   **wndTopMost** Places the window above all non-topmost windows. The window maintains its topmost position even when it is deactivated.  
  
-   **wndNoTopMost** Repositions the window to the top of all non-topmost windows (that is, behind all topmost windows). This flag has no effect if the window is already a non-topmost window.  
  
 For rules about how to use this parameter, see the "Remarks" section of this topic.  
  
 *x*  
 Specifies the new position of the left side of the window.  
  
 *y*  
 Specifies the new position of the top of the window.  
  
 `cx`  
 Specifies the new width of the window.  
  
 `cy`  
 Specifies the new height of the window.  
  
 `nFlags`  
 Specifies sizing and positioning options. This parameter can be a combination of the following flags:  
  
-   **SWP_DRAWFRAME** Draws a frame (defined when the window was created) around the window.  
  
-   **SWP_FRAMECHANGED** Sends a `WM_NCCALCSIZE` message to the window, even if the window's size is not being changed. If this flag is not specified, `WM_NCCALCSIZE` is sent only when the window's size is being changed.  
  
-   **SWP_HIDEWINDOW** Hides the window.  
  
-   `SWP_NOACTIVATE` Does not activate the window. If this flag is not set, the window is activated and moved to the top of either the topmost or the non-topmost group (depending on the setting of the `pWndInsertAfter` parameter).  
  
-   **SWP_NOCOPYBITS** Discards the entire contents of the client area. If this flag is not specified, the valid contents of the client area are saved and copied back into the client area after the window is sized or repositioned.  
  
-   `SWP_NOMOVE` Retains current position (ignores the *x* and *y* parameters).  
  
-   **SWP_NOOWNERZORDER** Does not change the owner window's position in the Z-order.  
  
-   **SWP_NOREDRAW** Does not redraw changes. If this flag is set, no repainting of any kind occurs. This applies to the client area, the nonclient area (including the title and scroll bars), and any part of the parent window uncovered as a result of the moved window. When this flag is set, the application must explicitly invalidate or redraw any parts of the window and parent window that must be redrawn.  
  
-   **SWP_NOREPOSITION** Same as **SWP_NOOWNERZORDER**.  
  
-   **SWP_NOSENDCHANGING** Prevents the window from receiving the `WM_WINDOWPOSCHANGING` message.  
  
-   `SWP_NOSIZE` Retains current size (ignores the `cx` and `cy` parameters).  
  
-   `SWP_NOZORDER` Retains current ordering (ignores `pWndInsertAfter`).  
  
-   **SWP_SHOWWINDOW** Displays the window.  
  
## Return Value  
 Nonzero if the function is successful; otherwise, 0.  
  
## Remarks  
 Windows are ordered on the screen according to their Z-order; the window at the top of the Z-order appears on top of all other windows in the order.  
  
 All coordinates for child windows are client coordinates (relative to the upper-left corner of the parent window's client area).  
  
 A window can be moved to the top of the Z-order either by setting the `pWndInsertAfter` parameter to **&wndTopMost** and ensuring that the `SWP_NOZORDER` flag is not set or by setting a window's Z-order so that it is above any existing topmost windows. When a non-topmost window is made topmost, its owned windows are also made topmost. Its owners are not changed.  
  
 A topmost window is no longer topmost if it is repositioned to the bottom (**&wndBottom**) of the Z-order or after any non-topmost window. When a topmost window is made non-topmost, all of its owners and its owned windows are also made non-topmost windows.  
  
 If neither `SWP_NOACTIVATE` nor `SWP_NOZORDER` is specified (that is, when the application requests that a window be simultaneously activated and placed in the specified Z-order), the value specified in `pWndInsertAfter` is used only in the following circumstances:  
  
-   Neither **&wndTopMost** nor **&wndNoTopMost** is specified in the `pWndInsertAfter` parameter.  
  
-   This window is not the active window.  
  
 An application cannot activate an inactive window without also bringing it to the top of the Z-order. Applications can change the Z-order of an activated window without restrictions.  
  
 A non-topmost window may own a topmost window, but not vice versa. Any window (for example, a dialog box) owned by a topmost window is itself made a topmost window to ensure that all owned windows stay above their owner.  
  
 With Windows versions 3.1 and later, windows can be moved to the top of the Z-order and locked there by setting their **WS_EX_TOPMOST** styles. Such a topmost window maintains its topmost position even when deactivated. For example, selecting the WinHelp Always On Top command makes the Help window topmost, and it then remains visible when you return to your application.  
  
 To create a topmost window, call `SetWindowPos` with the `pWndInsertAfter` parameter equal to **&wndTopMost**, or set the **WS_EX_TOPMOST** style when you create the window.  
  
 If the Z-order contains any windows with the **WS_EX_TOPMOST** style, a window moved with the **&wndTopMost** value is placed at the top of all non-topmost windows, but below any topmost windows. When an application activates an inactive window without the **WS_EX_TOPMOST** bit, the window is moved above all non-topmost windows but below any topmost windows.  
  
 If `SetWindowPos` is called when the `pWndInsertAfter` parameter is **&wndBottom** and `CWnd` is a topmost window, the window loses its topmost status (**WS_EX_TOPMOST** is cleared), and the system places the window at the bottom of the Z-order.  
  
## Example  
 [!code[NVC_MFCWindowing#120](../vs140/codesnippet/CPP/cwnd--setwindowpos_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [DeferWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms632681)   
 [SetWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms633545)