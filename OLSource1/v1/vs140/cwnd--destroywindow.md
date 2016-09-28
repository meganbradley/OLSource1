---
title: "CWnd::DestroyWindow"
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
  - "CWnd.DestroyWindow"
  - "CWnd::DestroyWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWnd class, construction/destruction"
  - "DestroyWindow method"
ms.assetid: 31a409ec-8430-4fb2-8895-d16bb5d18bc6
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::DestroyWindow
Destroys the Windows window attached to the `CWnd` object.  
  
## Syntax  
  
```  
  
virtual BOOL DestroyWindow( );  
```  
  
## Return Value  
 Nonzero if the window is destroyed; otherwise 0.  
  
## Remarks  
 The `DestroyWindow` member function sends appropriate messages to the window to deactivate it and remove the input focus. It also destroys the window's menu, flushes the application queue, destroys outstanding timers, removes Clipboard ownership, and breaks the Clipboard-viewer chain if `CWnd` is at the top of the viewer chain. It sends [WM_DESTROY](../vs140/cwnd--ondestroy.md) and [WM_NCDESTROY](../vs140/cwnd--onncdestroy.md) messages to the window. It does not destroy the `CWnd` object.  
  
 `DestroyWindow` is a place holder for performing cleanup. Because `DestroyWindow` is a virtual function, it is shown in any `CWnd`-derived class in Class View. But even if you override this function in your `CWnd`-derived class, `DestroyWindow` is not necessarily called. If `DestroyWindow` is not called in the MFC code, then you have to explicitly call it in your own code if you want it to be called.  
  
 Assume, for example, you have overridden `DestroyWindow` in a `CView`-derived class. Since MFC source code does not call `DestroyWindow` in any of its `CFrameWnd`-derived classes, your overridden `DestroyWindow` will not be called unless you call it explicitly.  
  
 If the window is the parent of any windows, these child windows are automatically destroyed when the parent window is destroyed. The `DestroyWindow` member function destroys child windows first and then the window itself.  
  
 The `DestroyWindow` member function also destroys modeless dialog boxes created by [CDialog::Create](../vs140/cdialog--create.md).  
  
 If the `CWnd` being destroyed is a child window and does not have the [WS_EX_NOPARENTNOTIFY](../vs140/extended-window-styles.md) style set, then the [WM_PARENTNOTIFY](https://msdn.microsoft.com/en-us/library/ms632638.aspx) message is sent to the parent.  
  
## Example  
 [!code[NVC_MFCWindowing#87](../vs140/codesnippet/CPP/cwnd--destroywindow_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnDestroy](../vs140/cwnd--ondestroy.md)   
 [CWnd::Detach](../vs140/cwnd--detach.md)   
 [DestroyWindow](http://msdn.microsoft.com/library/windows/desktop/ms632682)