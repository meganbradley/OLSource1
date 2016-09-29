---
title: "CMenu::CreateMenu"
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
  - "CreateMenu"
  - "CMenu::CreateMenu"
  - "CMenu.CreateMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMenu class, initialization"
  - "CreateMenu method"
ms.assetid: 8169d40c-fa14-4ff0-8c2b-b73e848a446e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::CreateMenu
Creates a menu and attaches it to the `CMenu` object.  
  
## Syntax  
  
```  
  
BOOL CreateMenu( );  
```  
  
## Return Value  
 Nonzero if the menu was created successfully; otherwise 0.  
  
## Remarks  
 The menu is initially empty. Menu items can be added by using the `AppendMenu` or `InsertMenu` member function.  
  
 If the menu is assigned to a window, it is automatically destroyed when the window is destroyed.  
  
 Before exiting, an application must free system resources associated with a menu if the menu is not assigned to a window. An application frees a menu by calling the [DestroyMenu](../vs140/cmenu--destroymenu.md) member function.  
  
## Example  
 [!code[NVC_MFCWindowing#22](../vs140/codesnippet/CPP/cmenu--createmenu_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMenu::CMenu](../vs140/cmenu--cmenu.md)   
 [CMenu::DestroyMenu](../vs140/cmenu--destroymenu.md)   
 [CMenu::InsertMenu](../vs140/cmenu--insertmenu.md)   
 [CWnd::SetMenu](../vs140/cwnd--setmenu.md)   
 [CreateMenu](http://msdn.microsoft.com/library/windows/desktop/ms647624)   
 [CMenu::AppendMenu](../vs140/cmenu--appendmenu.md)