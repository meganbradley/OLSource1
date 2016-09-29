---
title: "CWnd::OnParentNotify"
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
  - "CWnd.OnParentNotify"
  - "CWnd::OnParentNotify"
  - "OnParentNotify"
  - "WM_PARENTNOTIFY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_PARENTNOTIFY"
  - "OnParentNotify method"
ms.assetid: de628c78-460f-4c3b-81e4-cee21fdb5190
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnParentNotify
A parent's `OnParentNotify` member function is called by the framework when its child window is created or destroyed, or when the user clicks a mouse button while the cursor is over the child window.  
  
## Syntax  
  
```  
  
      afx_msg void OnParentNotify(  
   UINT message,  
   LPARAM lParam   
);  
```  
  
#### Parameters  
 `message`  
 Specifies the event for which the parent is being notified and the identifier of the child window. The event is the low-order word of `message`. If the event is `WM_CREATE` or `WM_DESTROY`, the high-order word of `message` is the identifier of the child window; otherwise, the high-order word is undefined. The event (low-order word of `message`) can be any of these values:  
  
-   `WM_CREATE` The child window is being created.  
  
-   `WM_DESTROY` The child window is being destroyed.  
  
-   `WM_LBUTTONDOWN` The user has placed the mouse cursor over the child window and clicked the left mouse button.  
  
-   `WM_MBUTTONDOWN` The user has placed the mouse cursor over the child window and clicked the middle mouse button.  
  
-   `WM_RBUTTONDOWN` The user has placed the mouse cursor over the child window and clicked the right mouse button.  
  
 `lParam`  
 If the event (low-order word) of `message` is `WM_CREATE` or `WM_DESTROY`, `lParam` specifies the window handle of the child window; otherwise `lParam` contains the x and y coordinates of the cursor. The x coordinate is in the low-order word and the y coordinate is in the high-order word.  
  
## Remarks  
 When the child window is being created, the system calls `OnParentNotify` just before the [Create](../vs140/cwnd--create.md) member function that creates the window returns. When the child window is being destroyed, the system calls `OnParentNotify` before any processing takes place to destroy the window.  
  
 `OnParentNotify` is called for all ancestor windows of the child window, including the top-level window.  
  
 All child windows except those that have the [WS_EX_NOPARENTNOTIFY](../vs140/extended-window-styles.md) style send this message to their parent windows. By default, child windows in a dialog box have the **WS_EX_NOPARENTNOTIFY** style unless the child window was created without this style by calling the [CreateEx](../vs140/cwnd--createex.md) member function.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnCreate](../vs140/cwnd--oncreate.md)   
 [CWnd::OnDestroy](../vs140/cwnd--ondestroy.md)   
 [CWnd::OnLButtonDown](../vs140/cwnd--onlbuttondown.md)   
 [CWnd::OnMButtonDown](../vs140/cwnd--onmbuttondown.md)   
 [CWnd::OnRButtonDown](../vs140/cwnd--onrbuttondown.md)   
 [WM_PARENTNOTIFY](https://msdn.microsoft.com/en-us/library/ms632638.aspx)