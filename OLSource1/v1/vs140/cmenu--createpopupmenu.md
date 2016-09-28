---
title: "CMenu::CreatePopupMenu"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CreatePopupMenu"
  - "CMenu::CreatePopupMenu"
  - "CMenu.CreatePopupMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMenu class, initialization"
  - "CreatePopupMenu method"
ms.assetid: 09a587e0-698f-4d44-9cac-74bd9556531c
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::CreatePopupMenu
Creates a pop-up menu and attaches it to the `CMenu` object.  
  
## Syntax  
  
```  
  
BOOL CreatePopupMenu( );  
```  
  
## Return Value  
 Nonzero if the pop-up menu was successfully created; otherwise 0.  
  
## Remarks  
 The menu is initially empty. Menu items can be added by using the `AppendMenu` or `InsertMenu` member function. The application can add the pop-up menu to an existing menu or pop-up menu. The `TrackPopupMenu` member function may be used to display this menu as a floating pop-up menu and to track selections on the pop-up menu.  
  
 If the menu is assigned to a window, it is automatically destroyed when the window is destroyed. If the menu is added to an existing menu, it is automatically destroyed when that menu is destroyed.  
  
 Before exiting, an application must free system resources associated with a pop-up menu if the menu is not assigned to a window. An application frees a menu by calling the [DestroyMenu](../vs140/cmenu--destroymenu.md) member function.  
  
## Example  
 See the example for [CMenu::CreateMenu](../vs140/cmenu--createmenu.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMenu::CreateMenu](../vs140/cmenu--createmenu.md)   
 [CMenu::InsertMenu](../vs140/cmenu--insertmenu.md)   
 [CWnd::SetMenu](../vs140/cwnd--setmenu.md)   
 [CMenu::TrackPopupMenu](../vs140/cmenu--trackpopupmenu.md)   
 [CreatePopupMenu](http://msdn.microsoft.com/library/windows/desktop/ms647626)   
 [CMenu::AppendMenu](../vs140/cmenu--appendmenu.md)