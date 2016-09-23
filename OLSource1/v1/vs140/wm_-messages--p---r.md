---
title: "WM_ Messages: P - R"
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
  - ON_WM_RBUTTONUP
  - ON_WM_PALETTECHANGED
  - ON_WM_RBUTTONDBLCLK
  - ON_WM_QUERYENDSESSION
  - ON_WM_PARENTNOTIFY
  - ON_WM_PALETTEISCHANGING
  - ON_WM_QUERYOPEN
  - ON_WM_PAINT
  - ON_WM_QUERYNEWPALETTE
  - ON_WM_RBUTTONDOWN
  - ON_WM_RENDERALLFORMATS
  - ON_WM_PAINTCLIPBOARD
  - ON_WM_RENDERFORMAT
  - ON_WM_QUERYDRAGICON
dev_langs: 
  - C++
helpviewer_keywords: 
  - ON_WM_RENDERFORMAT
  - ON_WM_QUERYOPEN
  - ON_WM_RBUTTONDOWN
  - ON_WM_PAINTCLIPBOARD
  - ON_WM_QUERYNEWPALETTE
  - ON_WM_RBUTTONUP
  - ON_WM_PARENTNOTIFY
  - ON_WM_RBUTTONDBLCLK
  - ON_WM_PALETTECHANGED
  - ON_WM_PALETTEISCHANGING
  - ON_WM_QUERYDRAGICON
  - ON_WM_PAINT
  - ON_WM_RENDERALLFORMATS
  - ON_WM_QUERYENDSESSION
  - WM_ messages
ms.assetid: f46962e5-8329-4f1f-9b4d-fdad2a5ce1f8
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# WM_ Messages: P - R
The following map entries correspond to the function prototypes:  
  
|Map entry|Function prototype|  
|---------------|------------------------|  
|ON_WM_PAINT()|afx_msg void [OnPaint](../vs140/cwnd--onpaint.md)();|  
|ON_WM_PAINTCLIPBOARD()|afx_msg void [OnPaintClipboard](../vs140/cwnd--onpaintclipboard.md)( CWnd*, HANDLE );|  
|ON_WM_PALETTECHANGED()|afx_msg void [OnPaletteChanged](../vs140/cwnd--onpalettechanged.md)( CWnd* );|  
|ON_WM_PALETTEISCHANGING()|afx_msg void [OnPaletteIsChanging](../vs140/cwnd--onpaletteischanging.md)( CWnd* );|  
|ON_WM_PARENTNOTIFY()|afx_msg void [OnParentNotify](../vs140/cwnd--onparentnotify.md)( UINT, LONG );|  
|ON_WM_POWERBROADCAST()|afx_msg UINT [OnPowerBroadcast](../vs140/cwnd--onpowerbroadcast.md)( UINT, UINT );|  
|ON_WM_QUERYDRAGICON()|afx_msg HCURSOR [OnQueryDragIcon](../vs140/cwnd--onquerydragicon.md)()();|  
|ON_WM_QUERYENDSESSION()|afx_msg BOOL [OnQueryEndSession](../vs140/cwnd--onqueryendsession.md)()();|  
|ON_WM_QUERYNEWPALETTE()|afx_msg BOOL [OnQueryNewPalette](../vs140/cwnd--onquerynewpalette.md)()();|  
|ON_WM_QUERYOPEN()|afx_msg BOOL [OnQueryOpen](../vs140/cwnd--onqueryopen.md)()();|  
|ON_WM_RBUTTONDBLCLK()|afx_msg void [OnRButtonDblClk](../vs140/cwnd--onrbuttondblclk.md)( UINT, CPoint );|  
|ON_WM_RBUTTONDOWN()|afx_msg void [OnRButtonDown](../vs140/cwnd--onrbuttondown.md)( UINT, CPoint );|  
|ON_WM_RBUTTONUP()|afx_msg void [OnRButtonUp](../vs140/cwnd--onrbuttonup.md)( UINT, CPoint );|  
|ON_WM_RENDERALLFORMATS()|afx_msg void [OnRenderAllFormats](../vs140/cwnd--onrenderallformats.md)();|  
|ON_WM_RENDERFORMAT()|afx_msg void [OnRenderFormat](../vs140/cwnd--onrenderformat.md)( UINT );|  
  
## See Also  
 [Message Maps](../vs140/message-maps--mfc-.md)   
 [Handlers for WM_ Messages](../vs140/handlers-for-wm_-messages.md)