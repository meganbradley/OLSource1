---
title: "CWnd::SetMenu"
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
  - "CWnd::SetMenu"
  - "CWnd.SetMenu"
  - "SetMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "menus, new"
  - "SetMenu method"
  - "menus, setting"
ms.assetid: 548b9ec2-77f2-4127-8a46-ce96c4c269c9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::SetMenu
Sets the current menu to the specified menu.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Identifies the new menu. If this parameter is **NULL**, the current menu is removed.  
  
## Return Value  
 Nonzero if the menu is changed; otherwise 0.  
  
## Remarks  
 Causes the window to be redrawn to reflect the menu change.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> will not destroy a previous menu. An application should call the [CMenu::DestroyMenu](../vs140/cmenu--destroymenu.md) member function to accomplish this task.  
  
## Example  
 See the example for [CMenu::LoadMenu](../vs140/cmenu--loadmenu.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMenu::DestroyMenu](../vs140/cmenu--destroymenu.md)   
 [CMenu::LoadMenu](../vs140/cmenu--loadmenu.md)   
 [SetMenu](http://msdn.microsoft.com/library/windows/desktop/ms647995)   
 [CWnd::GetMenu](../vs140/cwnd--getmenu.md)