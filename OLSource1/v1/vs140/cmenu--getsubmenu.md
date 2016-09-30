---
title: "CMenu::GetSubMenu"
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
  - "CMenu::GetSubMenu"
  - "CMenu.GetSubMenu"
  - "GetSubMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSubMenu method"
  - "CMenu class, menu item operations"
ms.assetid: 181aaf3f-3659-44f2-ae94-0e0fafe86832
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::GetSubMenu
Retrieves the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object of a pop-up menu.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the position of the pop-up menu contained in the menu. Position values start at 0 for the first menu item. The pop-up menu's identifier cannot be used in this function.  
  
## Return Value  
 A pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object whose <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member contains a handle to the pop-up menu if a pop-up menu exists at the given position; otherwise **NULL**. If a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object does not exist, then a temporary one is created. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> pointer returned should not be stored.  
  
## Example  
 See the example for [CMenu::TrackPopupMenu](../vs140/cmenu--trackpopupmenu.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetMenu](../vs140/cwnd--getmenu.md)   
 [CMenu::GetMenuItemID](../vs140/cmenu--getmenuitemid.md)   
 [GetSubMenu](http://msdn.microsoft.com/library/windows/desktop/ms647984)