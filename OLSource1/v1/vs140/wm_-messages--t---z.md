---
title: "WM_ Messages: T - Z"
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
  - "ON_WM_TCARD"
  - "ON_WM_WININICHANGE"
  - "ON_WM_VSCROLLCLIPBOARD"
  - "ON_WM_VSCROLL"
  - "ON_WM_WINDOWPOSCHANGED"
  - "ON_WM_TIMECHANGE"
  - "ON_WM_TIMER"
  - "ON_WM_VKEYTOITEM"
  - "ON_WM_WINDOWPOSCHANGING"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_WM_VSCROLLCLIPBOARD"
  - "ON_WM_WININICHANGE"
  - "ON_WM_WINDOWPOSCHANGED"
  - "ON_WM_TCARD"
  - "ON_WM_TIMECHANGE"
  - "ON_WM_TIMER"
  - "WM_ messages"
  - "ON_WM_WINDOWPOSCHANGING"
  - "ON_WM_VKEYTOITEM"
  - "ON_WM_VSCROLL"
ms.assetid: c528bb2e-ddb5-4da6-b652-432a387408b8
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# WM_ Messages: T - Z
The following map entries correspond to the function prototypes:  
  
|Map entry|Function prototype|  
|---------------|------------------------|  
|ON_WM_TCARD()|afx_msg void [OnTCard](../vs140/cwnd--ontcard.md)( UINT, DWORD );|  
|ON_WM_TIMECHANGE()|afx_msg void [OnTimeChange](../vs140/cwnd--ontimechange.md)( );|  
|ON_WM_TIMER()|afx_msg void [OnTimer](../vs140/cwnd--ontimer.md)( UINT_PTR );|  
|ON_WM_UNICHAR()|afx_msg void [OnUniChar](../vs140/cwnd--onunichar.md)( UINT, UINT, UINT );|  
|ON_WM_UNINITMENUPOPUP()|afx_msg void [OnUnInitMenuPopup](../vs140/cwnd--onuninitmenupopup.md)( CMenu*, UINT );|  
|ON_WM_USERCHANGED()|afx_msg void [OnUserChanged](../vs140/cwnd--onuserchanged.md)();|  
|ON_WM_VKEYTOITEM()|afx_msg int [OnVKeyToItem](../vs140/cwnd--onvkeytoitem.md)( UINT, CWnd*, UINT );|  
|ON_WM_VSCROLL()|afx_msg void [OnVScroll](../vs140/cwnd--onvscroll.md)( UINT, UINT, CWnd* );|  
|ON_WM_VSCROLLCLIPBOARD()|afx_msg void [OnVScrollClipboard](../vs140/cwnd--onvscrollclipboard.md)( CWnd*, UINT, UINT );|  
|ON_WM_WINDOWPOSCHANGED()|afx_msg void [OnWindowPosChanged](../vs140/cwnd--onwindowposchanged.md)( WINDOWPOS*);|  
|ON_WM_WINDOWPOSCHANGING()|afx_msg void [OnWindowPosChanging](../vs140/cwnd--onwindowposchanging.md)( WINDOWPOS*);|  
|ON_WM_WININICHANGE()|afx_msg void [OnWinIniChange](../vs140/cwnd--onwininichange.md)( LPSTR );|  
|ON_WM_WTSSESSION_CHANGE()|afx_msg void [OnSessionChange](../vs140/cwnd--onsessionchange.md)( UINT, UINT );|  
|ON_WM_XBUTTONDBLCLK()|afx_msg void [OnXButtonDblClk](../vs140/cwnd--onxbuttondblclk.md)( UINT, UINT, CPoint );|  
|ON_WM_XBUTTONDOWN()|afx_msg void [OnXButtonDown](../vs140/cwnd--onxbuttondown.md)( UINT, UINT, CPoint );|  
|ON_WM_XBUTTONUP()|afx_msg void [OnXButtonUp](../vs140/cwnd--onxbuttonup.md)( UINT, UINT, CPoint );|  
  
## See Also  
 [Message Maps](../vs140/message-maps--mfc-.md)   
 [Handlers for WM_ Messages](../vs140/handlers-for-wm_-messages.md)