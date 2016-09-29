---
title: "WM_ Messages: S"
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
  - "ON_WM_SYSDEADCHAR"
  - "ON_WM_SYSKEYDOWN"
  - "ON_WM_STYLECHANGING"
  - "ON_WM_STYLECHANGED"
  - "ON_WM_SPOOLERSTATUS"
  - "ON_WM_SYSCHAR"
  - "ON_WM_SETFOCUS"
  - "ON_WM_SIZE"
  - "ON_WM_SIZING"
  - "ON_WM_SETCURSOR"
  - "ON_WM_SYSCOMMAND"
  - "ON_WM_SETTINGCHANGE"
  - "ON_WM_SHOWWINDOW"
  - "ON_WM_SYSKEYUP"
  - "ON_WM_SIZECLIPBOARD"
  - "ON_WM_SYSCOLORCHANGE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_WM_SIZE"
  - "ON_WM_SETFOCUS"
  - "ON_WM_SIZING"
  - "ON_WM_SYSCHAR"
  - "ON_WM_SETTINGCHANGE"
  - "ON_WM_SYSDEADCHAR"
  - "ON_WM_SHOWWINDOW"
  - "ON_WM_STYLECHANGING"
  - "ON_WM_SYSCOMMAND"
  - "ON_WM_STYLECHANGED"
  - "ON_WM_SPOOLERSTATUS"
  - "ON_WM_SYSCOLORCHANGE"
  - "ON_WM_SETCURSOR"
  - "ON_WM_SIZECLIPBOARD"
  - "ON_WM_SYSKEYUP"
  - "ON_WM_SYSKEYDOWN"
  - "WM_ messages"
ms.assetid: 4b9aec79-a98f-4aa0-a3d9-110941b6dcbc
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# WM_ Messages: S
The following map entries correspond to the function prototypes.  
  
|Map entry|Function prototype|  
|---------------|------------------------|  
|ON_WM_SETCURSOR( )|afx_msg BOOL [OnSetCursor](../vs140/cwnd--onsetcursor.md)( CWnd*, UINT, UINT );|  
|ON_WM_SETFOCUS( )|afx_msg void [OnSetFocus](../vs140/cwnd--onsetfocus.md)( CWnd* );|  
|ON_WM_SETTINGCHANGE( )|afx_msg void [OnSettingChange](../vs140/cwnd--onsettingchange.md)( UINT uFlags, LPCTSTR lpszSection );|  
|ON_WM_SHOWWINDOW( )|afx_msg void [OnShowWindow](../vs140/cwnd--onshowwindow.md)( BOOL, UINT );|  
|ON_WM_SIZE( )|afx_msg void [OnSize](../vs140/cwnd--onsize.md)( UINT, int, int );|  
|ON_WM_SIZECLIPBOARD( )|afx_msg void [OnSizeClipboard](../vs140/cwnd--onsizeclipboard.md)( CWnd*, HANDLE );|  
|ON_WM_SIZING( )|afx_msg void [OnSizing](../vs140/cwnd--onsizing.md)( UINT, LPRECT );|  
|ON_WM_SPOOLERSTATUS( )|afx_msg void [OnSpoolerStatus](../vs140/cwnd--onspoolerstatus.md)( UINT, UINT );|  
|ON_WM_STYLECHANGED( )|afx_msg void [OnStyleChanged](../vs140/cwnd--onstylechanged.md)( int, LPSTYLESTRUCT );|  
|ON_WM_STYLECHANGING( )|afx_msg void [OnStyleChanging](../vs140/cwnd--onstylechanging.md)( int, LPSTYLESTRUCT );|  
|ON_WM_SYSCHAR( )|afx_msg void [OnSysChar](../vs140/cwnd--onsyschar.md)( UINT, UINT, UINT );|  
|ON_WM_SYSCOLORCHANGE( )|afx_msg void [OnSysColorChange](../vs140/cwnd--onsyscolorchange.md)( );|  
|ON_WM_SYSCOMMAND( )|afx_msg void [OnSysCommand](../vs140/cwnd--onsyscommand.md)( UINT, LONG );|  
|ON_WM_SYSDEADCHAR( )|afx_msg void [OnSysDeadChar](../vs140/cwnd--onsysdeadchar.md)( UINT, UINT, UINT );|  
|ON_WM_SYSKEYDOWN( )|afx_msg void [OnSysKeyDown](../vs140/cwnd--onsyskeydown.md)( UINT, UINT, UINT );|  
|ON_WM_SYSKEYUP( )|afx_msg void [OnSysKeyUp](../vs140/cwnd--onsyskeyup.md)( UINT, UINT, UINT );|  
  
## See Also  
 [Message Maps](../vs140/message-maps--mfc-.md)   
 [Handlers for WM_ Messages](../vs140/handlers-for-wm_-messages.md)