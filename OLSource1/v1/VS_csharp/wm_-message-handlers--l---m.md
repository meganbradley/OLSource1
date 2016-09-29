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
|ON_WM_LBUTTONDBLCLK()|afx_msg void [OnLButtonDblClk](../Topic/CWnd::OnLButtonDblClk.md)(UINT, CPoint);|  
|ON_WM_LBUTTONDOWN()|afx_msg void [OnLButtonDown](../Topic/CWnd::OnLButtonDown.md)(UINT, CPoint);|  
|ON_WM_LBUTTONUP()|afx_msg void [OnLButtonUp](../Topic/CWnd::OnLButtonUp.md)(UINT, CPoint);|  
|ON_WM_MBUTTONDBLCLK()|afx_msg void [OnMButtonDblClk](../Topic/CWnd::OnMButtonDblClk.md)(UINT, CPoint);|  
|ON_WM_MBUTTONDOWN()|afx_msg void [OnMButtonDown](../Topic/CWnd::OnMButtonDown.md)(UINT, CPoint);|  
|ON_WM_MBUTTONUP()|afx_msg void [OnMButtonUp](../Topic/CWnd::OnMButtonUp.md)(UINT, CPoint);|  
|ON_WM_MDIACTIVATE()|afx_msg void [OnMDIActivate](../Topic/CWnd::OnMDIActivate.md)(BOOL, CWnd*, CWnd\*);|  
|ON_WM_MEASUREITEM()|afx_msg void [OnMeasureItem](../Topic/CWnd::OnMeasureItem.md)(LPMEASUREITEMSTRUCT);|  
|ON_WM_MENUCHAR()|afx_msg LONG [OnMenuChar](../Topic/CWnd::OnMenuChar.md)(UINT, UINT, CMenu*);|  
|ON_WM_MENUDRAG()|afx_msg UINT [OnMenuDrag](../Topic/CWnd::OnMenuDrag.md)(UINT, CMenu*);|  
|ON_WM_MENUGETOBJECT()|afx_msg UINT [OnMenuGetObject](../Topic/CWnd::OnMenuGetObject.md)(MENUGETOBJECTINFO*);|  
|ON_WM_MENURBUTTONUP()|afx_msg void [OnMenuRButtonUp](../Topic/CWnd::OnMenuRButtonUp.md)(UINT, CMenu*);|  
|ON_WM_MENUSELECT()|afx_msg void [OnMenuSelect](../Topic/CWnd::OnMenuSelect.md)(UINT, UINT, HMENU);|  
|ON_WM_MOUSEACTIVATE()|afx_msg int [OnMouseActivate](../Topic/CWnd::OnMouseActivate.md)( CWnd*, UINT, UINT );|  
|ON_WM_MOUSEHOVER()|afx_msg void [OnMouseHover](../Topic/CWnd::OnMouseHover.md)(UINT, CPoint);|  
|ON_WM_MOUSEHWHEEL()|afx_msg void [OnMouseHWheel](../Topic/CWnd::OnMouseHWheel.md)(UINT, short, CPoint);|  
|ON_WM_MOUSELEAVE()|afx_msg void [OnMouseLeave](../Topic/CWnd::OnMouseLeave.md)();|  
|ON_WM_MOUSEMOVE()|afx_msg void [OnMouseMove](../Topic/CWnd::OnMouseMove.md)( UINT, CPoint);|  
|ON_WM_MOUSEWHEEL()|afx_msg BOOL [OnMouseWheel](../Topic/CWnd::OnMouseWheel.md)(UINT, short, CPoint);|  
|ON_WM_MOVE()|afx_msg void [OnMove](../Topic/CWnd::OnMove.md)(int, int);|  
|ON_WM_MOVING()|afx_msg void [OnMoving](../Topic/CWnd::OnMoving.md)(UINT, LPRECT);|  
  
## See Also  
 [Message Maps](../VS_csharp/message-maps--mfc-.md)   
 [Handlers for WM_ Messages](../VS_csharp/handlers-for-wm_-messages.md)