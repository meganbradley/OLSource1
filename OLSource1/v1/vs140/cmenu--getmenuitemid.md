---
title: "CMenu::GetMenuItemID"
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
  - "GetMenuItemID"
  - "CMenu::GetMenuItemID"
  - "CMenu.GetMenuItemID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMenu class, menu item operations"
  - "GetMenuItemID method"
ms.assetid: 9a984cc6-8868-4585-ae46-ec3add80de1b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::GetMenuItemID
Obtains the menu-item identifier for a menu item located at the position defined by `nPos`.  
  
## Syntax  
  
```  
  
      UINT GetMenuItemID(  
   int nPos   
) const;  
```  
  
#### Parameters  
 `nPos`  
 Specifies the position (zero-based) of the menu item whose ID is being retrieved.  
  
## Return Value  
 The item ID for the specified item in a pop-up menu if the function is successful. If the specified item is a pop-up menu (as opposed to an item within the pop-up menu), the return value is –1. If `nPos` corresponds to a **SEPARATOR** menu item, the return value is 0.  
  
## Example  
 See the example for [CMenu::InsertMenu](../vs140/cmenu--insertmenu.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetMenu](../vs140/cwnd--getmenu.md)   
 [CMenu::GetMenuItemCount](../vs140/cmenu--getmenuitemcount.md)   
 [CMenu::GetSubMenu](../vs140/cmenu--getsubmenu.md)   
 [GetMenuItemID](http://msdn.microsoft.com/library/windows/desktop/ms647979)