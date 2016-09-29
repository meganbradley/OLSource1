---
title: "WM_ Message Handlers: N - O"
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
  - "ON_WM_NCHITTEST"
  - "ON_WM_NCLBUTTONDOWN"
  - "ON_WM_NCCALCSIZE"
  - "ON_WM_NCLBUTTONUP"
  - "ON_WM_NCPAINT"
  - "ON_WM_NCMBUTTONUP"
  - "ON_WM_NCCREATE"
  - "ON_WM_NCACTIVATE"
  - "ON_WM_NCMOUSEMOVE"
  - "ON_WM_NCRBUTTONDBLCLK"
  - "ON_WM_NCLBUTTONDBLCLK"
  - "ON_WM_NCDESTROY"
  - "ON_WM_NCMBUTTONDBLCLK"
  - "ON_WM_NCRBUTTONDOWN"
  - "ON_WM_NCRBUTTONUP"
  - "ON_WM_NCMBUTTONDOWN"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_WM_NCCALCSIZE"
  - "ON_WM_NCMBUTTONDOWN"
  - "ON_WM_NCRBUTTONDBLCLK"
  - "ON_WM_NCMBUTTONDBLCLK"
  - "ON_WM_NCLBUTTONDBLCLK"
  - "ON_WM_NCDESTROY"
  - "ON_WM_NCRBUTTONDOWN"
  - "ON_WM_NCLBUTTONDOWN"
  - "ON_WM_NCCREATE"
  - "ON_WM_NCRBUTTONUP"
  - "ON_WM_NCLBUTTONUP"
  - "ON_WM_NCPAINT"
  - "ON_WM_NCACTIVATE"
  - "ON_WM_NCHITTEST"
  - "ON_WM_NCMOUSEMOVE"
  - "ON_WM_NCMBUTTONUP"
  - "WM_ messages"
ms.assetid: 4efd1cda-b642-4e8b-89e8-73255fa70d77
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# WM_ Message Handlers: N - O
The following map entries on the left correspond to the function prototypes on the right:  
  
|Map entry|Function prototype|  
|---------------|------------------------|  
|ON_WM_NCACTIVATE()|afx_msg BOOL [OnNcActivate](../vs140/cwnd--onncactivate.md)(BOOL);|  
|ON_WM_NCCALCSIZE()|afx_msg void [OnNcCalcSize](../vs140/cwnd--onnccalcsize.md)(BOOL, NCCALCSIZE_PARAMS FAR*);|  
|ON_WM_NCCREATE()|afx_msg BOOL [OnNcCreate](../vs140/cwnd--onnccreate.md)(LPCREATESTRUCT);|  
|ON_WM_NCDESTROY()|afx_msg void [OnNcDestroy](../vs140/cwnd--onncdestroy.md)();|  
|ON_WM_NCHITTEST()|afx_msg LRESULT [OnNcHitTest](../vs140/cwnd--onnchittest.md)(CPoint);|  
|ON_WM_NCLBUTTONDBLCLK()|afx_msg void [OnNcLButtonDblClk](../vs140/cwnd--onnclbuttondblclk.md)(UINT, CPoint);|  
|ON_WM_NCLBUTTONDOWN()|afx_msg void [OnNcLButtonDown](../vs140/cwnd--onnclbuttondown.md)(UINT, CPoint);|  
|ON_WM_NCLBUTTONUP()|afx_msg void [OnNcLButtonUp](../vs140/cwnd--onnclbuttonup.md)(UINT, CPoint);|  
|ON_WM_NCMBUTTONDBLCLK()|afx_msg void [OnNcMButtonDblClk](../vs140/cwnd--onncmbuttondblclk.md)(UINT, CPoint);|  
|ON_WM_NCMBUTTONDOWN()|afx_msg void [OnNcMButtonDown](../vs140/cwnd--onncmbuttondown.md)(UINT, CPoint);|  
|ON_WM_NCMBUTTONUP()|afx_msg void [OnNcMButtonUp](../vs140/cwnd--onncmbuttonup.md)(UINT, CPoint);|  
|ON_WM_NCMOUSEHOVER()|afx_msg void [OnNcMouseHover](../vs140/cwnd--onncmousehover.md)(UINT, CPoint);|  
|ON_WM_NCMOUSELEAVE()|afx_msg void [OnNcMouseLeave](../vs140/cwnd--onncmouseleave.md)();|  
|ON_WM_NCMOUSEMOVE()|afx_msg void [OnNcMouseMove](../vs140/cwnd--onncmousemove.md)(UINT, CPoint);|  
|ON_WM_NCPAINT()|afx_msg void [OnNcPaint](../vs140/cwnd--onncpaint.md)();|  
|ON_WM_NCRBUTTONDBLCLK()|afx_msg void [OnNcRButtonDblClk](../vs140/cwnd--onncrbuttondblclk.md)(UINT, CPoint);|  
|ON_WM_NCRBUTTONDOWN()|afx_msg void [OnNcRButtonDown](../vs140/cwnd--onncrbuttondown.md)(UINT, CPoint);|  
|ON_WM_NCRBUTTONUP()|afx_msg void [OnNcRButtonUp](../vs140/cwnd--onncrbuttonup.md)(UINT, CPoint);|  
|ON_WM_NCXBUTTONDBLCLK()|void [OnNcXButtonDblClk](../vs140/cwnd--onncxbuttondblclk.md)(short, UINT, CPoint);|  
|ON_WM_NCXBUTTONDOWN()|afx_msg void [OnNcXButtonDown](../vs140/cwnd--onncxbuttondown.md)(short, UINT, CPoint);|  
|ON_WM_NCXBUTTONUP()|afx_msg void [OnNcXButtonUp](../vs140/cwnd--onncxbuttonup.md)(short, UINT, CPoint);|  
|ON_WM_NEXTMENU()|afx_msg void [OnNextMenu](../vs140/cwnd--onnextmenu.md)(UINT, LPMDINEXTMENU);|  
|ON_WM_NOTIFYFORMAT()|afx_msg UINT [OnNotifyFormat](../vs140/cwnd--onnotifyformat.md)(CWnd*, UINT);|  
  
## See Also  
 [Message Maps](../vs140/message-maps--mfc-.md)   
 [Handlers for WM_ Messages](../vs140/handlers-for-wm_-messages.md)