---
title: "CMenu::CheckMenuItem"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMenu::CheckMenuItem
  - CMenu.CheckMenuItem
  - CheckMenuItem
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMenu class, menu item operations
  - CheckMenuItem method
ms.assetid: f916eca6-659a-4b65-865a-b310342f160e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMenu::CheckMenuItem
Adds check marks to or removes check marks from menu items in the pop-up menu.  
  
## Syntax  
  
```  
  
      UINT CheckMenuItem(  
   UINT nIDCheckItem,  
   UINT nCheck   
);  
```  
  
#### Parameters  
 `nIDCheckItem`  
 Specifies the menu item to be checked, as determined by `nCheck`.  
  
 `nCheck`  
 Specifies how to check the menu item and how to determine the item's position in the menu. The `nCheck` parameter can be a combination of **MF_CHECKED** or **MF_UNCHECKED** with **MF_BYPOSITION** or **MF_BYCOMMAND** flags. These flags can be combined by using the bitwise OR operator. They have the following meanings:  
  
-   **MF_BYCOMMAND** Specifies that the parameter gives the command ID of the existing menu item. This is the default.  
  
-   **MF_BYPOSITION** Specifies that the parameter gives the position of the existing menu item. The first item is at position 0.  
  
-   **MF_CHECKED** Acts as a toggle with **MF_UNCHECKED** to place the default check mark next to the item.  
  
-   **MF_UNCHECKED** Acts as a toggle with **MF_CHECKED** to remove a check mark next to the item.  
  
## Return Value  
 The previous state of the item: **MF_CHECKED** or **MF_UNCHECKED**, or 0xFFFFFFFF if the menu item did not exist.  
  
## Remarks  
 The `nIDCheckItem` parameter specifies the item to be modified.  
  
 The `nIDCheckItem` parameter may identify a pop-up menu item as well as a menu item. No special steps are required to check a pop-up menu item. Top-level menu items cannot be checked. A pop-up menu item must be checked by position since it does not have a menu-item identifier associated with it.  
  
## Example  
 See the example for [CMenu::GetMenuState](../vs140/cmenu--getmenustate.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMenu::GetMenuState](../vs140/cmenu--getmenustate.md)   
 [CheckMenuItem](http://msdn.microsoft.com/library/windows/desktop/ms647619)   
 [CMenu::CheckMenuRadioItem](../vs140/cmenu--checkmenuradioitem.md)