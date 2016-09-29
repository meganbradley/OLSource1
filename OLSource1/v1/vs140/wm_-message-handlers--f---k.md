---
title: "WM_ Message Handlers: F - K"
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
  - "ON_WM_FONTCHANGE"
  - "ON_WM_ICONERASEBKGND"
  - "ON_WM_KEYDOWN"
  - "ON_WM_GETMINMAXINFO"
  - "ON_WM_KEYUP"
  - "ON_WM_HSCROLL"
  - "ON_WM_KILLFOCUS"
  - "ON_WM_HSCROLLCLIPBOARD"
  - "ON_WM_GETDLGCODE"
  - "ON_WM_HELPINFO"
  - "ON_WM_INITMENUPOPUP"
  - "ON_WM_INITMENU"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_WM_HELPINFO"
  - "ON_WM_KILLFOCUS"
  - "ON_WM_GETMINMAXINFO"
  - "ON_WM_KEYUP"
  - "ON_WM_HSCROLL"
  - "ON_WM_INITMENUPOPUP"
  - "ON_WM_FONTCHANGE"
  - "ON_WM_ICONERASEBKGND"
  - "ON_WM_GETDLGCODE"
  - "ON_WM_HSCROLLCLIPBOARD"
  - "ON_WM_INITMENU"
  - "WM_ messages"
  - "ON_WM_KEYDOWN"
ms.assetid: 0e7de191-1499-499f-859c-62742797808e
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# WM_ Message Handlers: F - K
The following map entries on the left correspond to the function prototypes on the right:  
  
|Map entry|Function prototype|  
|---------------|------------------------|  
|ON_WM_FONTCHANGE()|afx_msg void [OnFontChange](../vs140/cwnd--onfontchange.md)();|  
|ON_WM_GETDLGCODE()|afx_msg UINT [OnGetDlgCode](../vs140/cwnd--ongetdlgcode.md)();|  
|ON_WM_GETMINMAXINFO()|afx_msg void [OnGetMinMaxInfo](../vs140/cwnd--ongetminmaxinfo.md)(LPPOINT);|  
|ON_WM_HELPINFO()|afx_msg BOOL [OnHelpInfo](../vs140/cwnd--onhelpinfo.md)(HELPINFO*);|  
|ON_WM_HOTKEY()|afx_msg void [OnHotKey](../vs140/cwnd--onhotkey.md)(UINT, UINT, UINT);|  
|ON_WM_HSCROLL()|afx_msg void [OnHScroll](../vs140/cwnd--onhscroll.md)(UINT, UINT, CWnd*);|  
|ON_WM_HSCROLLCLIPBOARD()|afx_msg void [OnHScrollClipboard](../vs140/cwnd--onhscrollclipboard.md)(CWnd*, UINT, UINT);|  
|ON_WM_ICONERASEBKGND()|afx_msg void [OnIconEraseBkgnd](../vs140/cwnd--oniconerasebkgnd.md)(CDC*);|  
|ON_WM_INITMENU()|afx_msg void [OnInitMenu](../vs140/cwnd--oninitmenu.md)(CMenu*);|  
|ON_WM_INITMENUPOPUP()|afx_msg void [OnInitMenuPopup](../vs140/cwnd--oninitmenupopup.md)(CMenu*, UINT, BOOL);|  
|ON_WM_INPUT()|afx_msg void [OnRawInput](../vs140/cwnd--onrawinput.md)(UINT, HRAWINPUT);|  
|ON_WM_INPUT_DEVICE_CHANGE()|afx_msg void [OnInputDeviceChange](../vs140/cwnd--oninputdevicechange.md)(unsigned short);|  
|ON_WM_INPUTLANGCHANGE()|afx_msg void [OnInputLangChange](../vs140/cwnd--oninputlangchange.md)(BYTE, UINT);|  
|ON_WM_INPUTLANGCHANGEREQUEST()|afx_msg void [OnInputLangChangeRequest](../vs140/cwnd--oninputlangchangerequest.md)(UINT, HKL);|  
|ON_WM_KEYDOWN()|afx_msg void [OnKeyDown](../vs140/cwnd--onkeydown.md)(UINT, UINT, UINT);|  
|ON_WM_KEYUP()|afx_msg void [OnKeyUp](../vs140/cwnd--onkeyup.md)(UINT, UINT, UINT);|  
|ON_WM_KILLFOCUS()|afx_msg void [OnKillFocus](../vs140/cwnd--onkillfocus.md)(CWnd*);|  
  
## See Also  
 [Message Maps](../vs140/message-maps--mfc-.md)   
 [Handlers for WM_ Messages](../vs140/handlers-for-wm_-messages.md)