---
title: "WM_ Message Handlers: D - E"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - ON_WM_ERASEBKGND
  - ON_WM_DEVICECHANGE
  - ON_WM_ENTERIDLE
  - ON_WM_DESTROYCLIPBOARD
  - ON_WM_DESTROY
  - ON_WM_DEADCHAR
  - ON_WM_DELETEITEM
  - ON_WM_DROPFILES
  - ON_WM_DEVMODECHANGE
  - ON_WM_ENDSESSION
  - ON_WM_ENABLE
  - ON_WM_DRAWITEM
  - ON_WM_DRAWCLIPBOARD
dev_langs: 
  - C++
helpviewer_keywords: 
  - ON_WM_ENTERIDLE
  - ON_WM_DESTROYCLIPBOARD
  - ON_WM_DEADCHAR
  - ON_WM_DEVMODECHANGE
  - ON_WM_ERASEBKGND
  - ON_WM_DESTROY
  - ON_WM_DRAWCLIPBOARD
  - ON_WM_ENDSESSION
  - ON_WM_DRAWITEM
  - ON_WM_ENABLE
  - ON_WM_DROPFILES
  - ON_WM_DELETEITEM
  - ON_WM_DEVICECHANGE
  - WM_ messages
ms.assetid: 56fb89c8-68a8-4adf-883e-a9f63bf677e9
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# WM_ Message Handlers: D - E
The following map entries on the left correspond to the function prototypes on the right:  
  
|Map entry|Function prototype|  
|---------------|------------------------|  
|ON_WM_DEADCHAR()|afx_msg void [OnDeadChar](../vs140/cwnd--ondeadchar.md)(UINT, UINT, UINT);|  
|ON_WM_DELETEITEM()|afx_msg void [OnDeleteItem](../vs140/cwnd--ondeleteitem.md)(LPDELETEITEMSTRUCT);|  
|ON_WM_DESTROY()|afx_msg void [OnDestroy](../vs140/cwnd--ondestroy.md)();|  
|ON_WM_DESTROYCLIPBOARD()|afx_msg void [OnDestroyClipboard](../vs140/cwnd--ondestroyclipboard.md)();|  
|ON_WM_DEVICECHANGE()|afx_msg void [OnDeviceChange](../vs140/cwnd--ondevicechange.md)(UINT, DWORD);|  
|ON_WM_DEVMODECHANGE()|afx_msg void [OnDevModeChange](../vs140/cwnd--ondevmodechange.md)(LPSTR);|  
|ON_WM_DRAWCLIPBOARD()|afx_msg void [OnDrawClipboard](../vs140/cwnd--ondrawclipboard.md)();|  
|ON_WM_DRAWITEM()|afx_msg void [OnDrawItem](../vs140/cwnd--ondrawitem.md)(LPDRAWITEMSTRUCT);|  
|ON_WM_DROPFILES()|afx_msg void [OnDropFiles](../vs140/cwnd--ondropfiles.md)(HDROP);|  
|ON_WM_DWMCOLORIZATIONCOLORCHANGED()|afx_msg void [OnColorizationColorChanged](../vs140/cwnd--oncolorizationcolorchanged.md)(DWORD, BOOL);|  
|ON_WM_DWMCOMPOSITIONCHANGED()|afx_msg void [OnCompositionChanged](../vs140/cwnd--oncompositionchanged.md)();|  
|ON_WM_DWMNCRENDERINGCHANGED()|afx_msg void [OnNcRenderingChanged](../vs140/cwnd--onncrenderingchanged.md)(BOOL);|  
|ON_WM_DWMWINDOWMAXIMIZEDCHANGE()|afx_msg void [OnWindowMaximizedChanged](../vs140/cwnd--onwindowmaximizedchanged.md)(BOOL);|  
|ON_WM_ENABLE()|afx_msg void [OnEnable](../vs140/cwnd--onenable.md)(BOOL);|  
|ON_WM_ENDSESSION()|afx_msg void [OnEndSession](../vs140/cwnd--onendsession.md)(BOOL);|  
|ON_WM_ENTERIDLE()|afx_msg void [OnEnterIdle](../vs140/cwnd--onenteridle.md)(UINT, CWnd*);|  
|ON_WM_ENTERSIZEMOVE()|afx_msg void [OnEnterSizeMove](../vs140/cwnd--onentersizemove.md)();|  
|ON_WM_ERASEBKGND()|afx_msg BOOL [OnEraseBkgnd](../vs140/cwnd--onerasebkgnd.md)(CDC*);|  
|ON_WM_EXITSIZEMOVE()|afx_msg void [OnExitSizeMove](../vs140/cwnd--onexitsizemove.md)();|  
  
## See Also  
 [Message Maps](../vs140/message-maps--mfc-.md)   
 [Handlers for WM_ Messages](../vs140/handlers-for-wm_-messages.md)