---
title: "WM_ Message Handlers: L - M"
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
  - "ON_WM_MENUSELECT"
  - "ON_WM_MBUTTONDBLCLK"
  - "ON_WM_MOUSEACTIVATE"
  - "ON_WM_MOUSEMOVE"
  - "ON_WM_MOVING"
  - "ON_WM_LBUTTONUP"
  - "ON_WM_LBUTTONDBLCLK"
  - "ON_WM_MEASUREITEM"
  - "ON_WM_MDIACTIVATE"
  - "ON_WM_MOVE"
  - "ON_WM_LBUTTONDOWN"
  - "ON_WM_MBUTTONDOWN"
  - "ON_WM_MENUCHAR"
  - "ON_WM_MBUTTONUP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_WM_MENUSELECT"
  - "ON_WM_MBUTTONDBLCLK"
  - "ON_WM_MOVE"
  - "ON_WM_MOUSEACTIVATE"
  - "ON_WM_MBUTTONUP"
  - "ON_WM_MOUSEMOVE"
  - "ON_WM_MENUCHAR"
  - "ON_WM_MBUTTONDOWN"
  - "ON_WM_MEASUREITEM"
  - "ON_WM_MOVING"
  - "ON_WM_LBUTTONDOWN"
  - "ON_WM_MDIACTIVATE"
  - "ON_WM_LBUTTONDBLCLK"
  - "ON_WM_LBUTTONUP"
  - "WM_ messages"
ms.assetid: 96ecaaf1-6d13-4e12-a454-535635967489
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# WM_ Message Handlers: L - M
The following map entries on the left correspond to the function prototypes on the right:  
  
|Map entry|Function prototype|  
|---------------|------------------------|  
|ON_WM_LBUTTONDBLCLK()|afx_msg void [OnLButtonDblClk](../vs140/cwnd--onlbuttondblclk.md)(UINT, CPoint);|  
|ON_WM_LBUTTONDOWN()|afx_msg void [OnLButtonDown](../vs140/cwnd--onlbuttondown.md)(UINT, CPoint);|  
|ON_WM_LBUTTONUP()|afx_msg void [OnLButtonUp](../vs140/cwnd--onlbuttonup.md)(UINT, CPoint);|  
|ON_WM_MBUTTONDBLCLK()|afx_msg void [OnMButtonDblClk](../vs140/cwnd--onmbuttondblclk.md)(UINT, CPoint);|  
|ON_WM_MBUTTONDOWN()|afx_msg void [OnMButtonDown](../vs140/cwnd--onmbuttondown.md)(UINT, CPoint);|  
|ON_WM_MBUTTONUP()|afx_msg void [OnMButtonUp](../vs140/cwnd--onmbuttonup.md)(UINT, CPoint);|  
|ON_WM_MDIACTIVATE()|afx_msg void [OnMDIActivate](../vs140/cwnd--onmdiactivate.md)(BOOL, CWnd*, CWnd\*);|  
|ON_WM_MEASUREITEM()|afx_msg void [OnMeasureItem](../vs140/cwnd--onmeasureitem.md)(LPMEASUREITEMSTRUCT);|  
|ON_WM_MENUCHAR()|afx_msg LONG [OnMenuChar](../vs140/cwnd--onmenuchar.md)(UINT, UINT, CMenu*);|  
|ON_WM_MENUDRAG()|afx_msg UINT [OnMenuDrag](../vs140/cwnd--onmenudrag.md)(UINT, CMenu*);|  
|ON_WM_MENUGETOBJECT()|afx_msg UINT [OnMenuGetObject](../vs140/cwnd--onmenugetobject.md)(MENUGETOBJECTINFO*);|  
|ON_WM_MENURBUTTONUP()|afx_msg void [OnMenuRButtonUp](../vs140/cwnd--onmenurbuttonup.md)(UINT, CMenu*);|  
|ON_WM_MENUSELECT()|afx_msg void [OnMenuSelect](../vs140/cwnd--onmenuselect.md)(UINT, UINT, HMENU);|  
|ON_WM_MOUSEACTIVATE()|afx_msg int [OnMouseActivate](../vs140/cwnd--onmouseactivate.md)( CWnd*, UINT, UINT );|  
|ON_WM_MOUSEHOVER()|afx_msg void [OnMouseHover](../vs140/cwnd--onmousehover.md)(UINT, CPoint);|  
|ON_WM_MOUSEHWHEEL()|afx_msg void [OnMouseHWheel](../vs140/cwnd--onmousehwheel.md)(UINT, short, CPoint);|  
|ON_WM_MOUSELEAVE()|afx_msg void [OnMouseLeave](../vs140/cwnd--onmouseleave.md)();|  
|ON_WM_MOUSEMOVE()|afx_msg void [OnMouseMove](../vs140/cwnd--onmousemove.md)( UINT, CPoint);|  
|ON_WM_MOUSEWHEEL()|afx_msg BOOL [OnMouseWheel](../vs140/cwnd--onmousewheel.md)(UINT, short, CPoint);|  
|ON_WM_MOVE()|afx_msg void [OnMove](../vs140/cwnd--onmove.md)(int, int);|  
|ON_WM_MOVING()|afx_msg void [OnMoving](../vs140/cwnd--onmoving.md)(UINT, LPRECT);|  
  
## See Also  
 [Message Maps](../vs140/message-maps--mfc-.md)   
 [Handlers for WM_ Messages](../vs140/handlers-for-wm_-messages.md)