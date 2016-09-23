---
title: "CWnd::SetClipboardViewer"
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
  - CWnd.SetClipboardViewer
  - CWnd::SetClipboardViewer
  - SetClipboardViewer
dev_langs: 
  - C++
helpviewer_keywords: 
  - Clipboard viewer
  - Clipboard, viewing
  - SetClipboardViewer method
ms.assetid: 57ad2adb-b091-49e1-be58-b53ebd1b28a0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::SetClipboardViewer
Adds this window to the chain of windows that are notified (by means of the `WM_DRAWCLIPBOARD` message) whenever the content of the Clipboard is changed.  
  
## Syntax  
  
```  
  
HWND SetClipboardViewer( );  
```  
  
## Return Value  
 A handle to the next window in the Clipboard-viewer chain if successful. Applications should save this handle (it can be stored as a member variable) and use it when responding to Clipboard-viewer chain messages.  
  
## Remarks  
 A window that is part of the Clipboard-viewer chain must respond to [WM_DRAWCLIPBOARD](../vs140/cwnd--ondrawclipboard.md), [WM_CHANGECBCHAIN](../vs140/cwnd--onchangecbchain.md), and [WM_DESTROY](../vs140/cwnd--ondestroy.md) messages and pass the message to the next window in the chain.  
  
 This member function sends a `WM_DRAWCLIPBOARD` message to the window. Since the handle to the next window in the Clipboard-viewer chain has not yet been returned, the application should not pass on the `WM_DRAWCLIPBOARD` message that it receives during the call to `SetClipboardViewer`.  
  
 To remove itself from the Clipboard-viewer chain, an application must call the [ChangeClipboardChain](../vs140/cwnd--changeclipboardchain.md) member function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::ChangeClipboardChain](../vs140/cwnd--changeclipboardchain.md)   
 [SetClipboardViewer](http://msdn.microsoft.com/library/windows/desktop/ms649052)