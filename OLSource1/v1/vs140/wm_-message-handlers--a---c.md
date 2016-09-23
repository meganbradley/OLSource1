---
title: "WM_ Message Handlers: A - C"
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
  - ON_WM_CREATE
  - ON_WM_COMPACTING
  - ON_WM_CHARTOITEM
  - ON_WM_ASKCBFORMATNAME
  - ON_WM_CTLCOLOR
  - ON_WM_COMPAREITEM
  - ON_WM_CHILDACTIVATE
  - ON_WM_CONTEXTMENU
  - ON_WM_ACTIVATE
  - ON_WM_CANCELMODE
  - ON_WM_CLOSE
  - ON_WM_CAPTURECHANGED
  - ON_WM_ACTIVATEAPP
  - ON_WM_CHAR
  - ON_WM_CHANGECBCHAIN
dev_langs: 
  - C++
helpviewer_keywords: 
  - ON_WM_COMPACTING
  - ON_WM_COMPAREITEM
  - ON_WM_CLOSE
  - ON_WM_CTLCOLOR
  - ON_WM_CHAR
  - ON_WM_CAPTURECHANGED
  - ON_WM_CHARTOITEM
  - ON_WM_CREATE
  - ON_WM_ACTIVATE
  - ON_WM_CONTEXTMENU
  - ON_WM_CANCELMODE
  - ON_WM_ASKCBFORMATNAME
  - ON_WM_CHILDACTIVATE
  - WM_ messages
  - ON_WM_ACTIVATEAPP
  - ON_WM_CHANGECBCHAIN
ms.assetid: 4e315896-d646-4b87-b0ab-41a4a753b045
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# WM_ Message Handlers: A - C
The following map entries on the left correspond to the function prototypes on the right:  
  
|Map entry|Function prototype|  
|---------------|------------------------|  
|ON_WM_ACTIVATE()|afx_msg void [OnActivate](../vs140/cwnd--onactivate.md)(UINT, CWnd*, BOOL);|  
|ON_WM_ACTIVATEAPP()|afx_msg void [OnActivateApp](../vs140/cwnd--onactivateapp.md)(BOOL, DWORD);|  
|ON_WM_APPCOMMAND()|afx_msg void [OnAppCommand](../vs140/cwnd--onappcommand.md)(CWnd*, UINT, UINT, UINT);|  
|ON_WM_ASKCBFORMATNAME()|afx_msg void [OnAskCbFormatName](../vs140/cwnd--onaskcbformatname.md)(UINT, LPSTR);|  
|ON_WM_CANCELMODE()|afx_msg void [OnCancelMode](../vs140/cwnd--oncancelmode.md)();|  
|ON_WM_CAPTURECHANGED()|afx_msg void [OnCaptureChanged](../vs140/cwnd--oncapturechanged.md)(CWnd*);|  
|ON_WM_CHANGECBCHAIN()|afx_msg void [OnChangeCbChain](../vs140/cwnd--onchangecbchain.md)(HWND, HWND);|  
|ON_WM_CHAR()|afx_msg void [OnChar](../vs140/cwnd--onchar.md)(UINT, UINT, UINT);|  
|ON_WM_CHARTOITEM()|afx_msg int [OnCharToItem](../vs140/cwnd--onchartoitem.md)(UINT, CWnd*, UINT);|  
|ON_WM_CHILDACTIVATE()|afx_msg void [OnChildActivate](../vs140/cwnd--onchildactivate.md)();|  
|ON_WM_CLIPBOARDUPDATE()|afx_msg void [OnClipboardUpdate](../vs140/cwnd--onclipboardupdate.md)();|  
|ON_WM_CLOSE()|afx_msg void [OnClose](../vs140/cwnd--onclose.md)();|  
|ON_WM_COMPACTING()|afx_msg void [OnCompacting](../vs140/cwnd--oncompacting.md)(UINT);|  
|ON_WM_COMPAREITEM()|afx_msg int [OnCompareItem](../vs140/cwnd--oncompareitem.md)(LPCOMPAREITEMSTRUCT);|  
|ON_WM_CONTEXTMENU()|afx_msg void [OnContextMenu](../vs140/cwnd--oncontextmenu.md)(CWnd*, CPoint);|  
|ON_WM_COPYDATA()|afx_msg BOOL [OnCopyData](../vs140/cwnd--oncopydata.md)(CWnd* pWnd, COPYDATASTRUCT\* pCopyDataStruct);|  
|ON_WM_CREATE()|afx_msg int [OnCreate](../vs140/cwnd--oncreate.md)(LPCREATESTRUCT);|  
|ON_WM_CTLCOLOR()|afx_msg HBRUSH [OnCtlColor](../vs140/cwnd--onctlcolor.md)(CDC*, CWnd\*, UINT);|  
  
## See Also  
 [Message Maps](../vs140/message-maps--mfc-.md)   
 [Handlers for WM_ Messages](../vs140/handlers-for-wm_-messages.md)