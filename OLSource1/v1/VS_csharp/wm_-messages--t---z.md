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
|ON_WM_TCARD()|afx_msg void [OnTCard](../Topic/CWnd::OnTCard.md)( UINT, DWORD );|  
|ON_WM_TIMECHANGE()|afx_msg void [OnTimeChange](../Topic/CWnd::OnTimeChange.md)( );|  
|ON_WM_TIMER()|afx_msg void [OnTimer](../Topic/CWnd::OnTimer.md)( UINT_PTR );|  
|ON_WM_UNICHAR()|afx_msg void [OnUniChar](../Topic/CWnd::OnUniChar.md)( UINT, UINT, UINT );|  
|ON_WM_UNINITMENUPOPUP()|afx_msg void [OnUnInitMenuPopup](../Topic/CWnd::OnUnInitMenuPopup.md)( CMenu*, UINT );|  
|ON_WM_USERCHANGED()|afx_msg void [OnUserChanged](../Topic/CWnd::OnUserChanged.md)();|  
|ON_WM_VKEYTOITEM()|afx_msg int [OnVKeyToItem](../Topic/CWnd::OnVKeyToItem.md)( UINT, CWnd*, UINT );|  
|ON_WM_VSCROLL()|afx_msg void [OnVScroll](../Topic/CWnd::OnVScroll.md)( UINT, UINT, CWnd* );|  
|ON_WM_VSCROLLCLIPBOARD()|afx_msg void [OnVScrollClipboard](../Topic/CWnd::OnVScrollClipboard.md)( CWnd*, UINT, UINT );|  
|ON_WM_WINDOWPOSCHANGED()|afx_msg void [OnWindowPosChanged](../Topic/CWnd::OnWindowPosChanged.md)( WINDOWPOS*);|  
|ON_WM_WINDOWPOSCHANGING()|afx_msg void [OnWindowPosChanging](../Topic/CWnd::OnWindowPosChanging.md)( WINDOWPOS*);|  
|ON_WM_WININICHANGE()|afx_msg void [OnWinIniChange](../Topic/CWnd::OnWinIniChange.md)( LPSTR );|  
|ON_WM_WTSSESSION_CHANGE()|afx_msg void [OnSessionChange](../Topic/CWnd::OnSessionChange.md)( UINT, UINT );|  
|ON_WM_XBUTTONDBLCLK()|afx_msg void [OnXButtonDblClk](../Topic/CWnd::OnXButtonDblClk.md)( UINT, UINT, CPoint );|  
|ON_WM_XBUTTONDOWN()|afx_msg void [OnXButtonDown](../Topic/CWnd::OnXButtonDown.md)( UINT, UINT, CPoint );|  
|ON_WM_XBUTTONUP()|afx_msg void [OnXButtonUp](../Topic/CWnd::OnXButtonUp.md)( UINT, UINT, CPoint );|  
  
## See Also  
 [Message Maps](../VS_csharp/message-maps--mfc-.md)   
 [Handlers for WM_ Messages](../VS_csharp/handlers-for-wm_-messages.md)