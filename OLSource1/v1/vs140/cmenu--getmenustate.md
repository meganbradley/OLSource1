---
title: "CMenu::GetMenuState"
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
  - "CMenu::GetMenuState"
  - "GetMenuState"
  - "CMenu.GetMenuState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMenu class, menu item operations"
  - "GetMenuState method"
ms.assetid: 9f4e34cd-802c-46fc-9fb6-7e6beb9dd219
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::GetMenuState
Returns the status of the specified menu item or the number of items in a pop-up menu.  
  
## Syntax  
  
```  
  
      UINT GetMenuState(  
   UINT nID,  
   UINT nFlags   
) const;  
```  
  
#### Parameters  
 `nID`  
 Specifies the menu item ID, as determined by `nFlags`.  
  
 `nFlags`  
 Specifies the nature of `nID`. It can be one of the following values:  
  
-   **MF_BYCOMMAND** Specifies that the parameter gives the command ID of the existing menu item. This is the default.  
  
-   **MF_BYPOSITION** Specifies that the parameter gives the position of the existing menu item. The first item is at position 0.  
  
## Return Value  
 The value 0xFFFFFFFF if the specified item does not exist. If *nId* identifies a pop-up menu, the high-order byte contains the number of items in the pop-up menu and the low-order byte contains the menu flags associated with the pop-up menu. Otherwise the return value is a mask (Boolean OR) of the values from the following list (this mask describes the status of the menu item that *nId* identifies):  
  
-   **MF_CHECKED** Acts as a toggle with **MF_UNCHECKED** to place the default check mark next to the item. When the application supplies check-mark bitmaps (see the `SetMenuItemBitmaps` member function), the "check mark on" bitmap is displayed.  
  
-   **MF_DISABLED** Disables the menu item so that it cannot be selected but does not dim it.  
  
-   `MF_ENABLED` Enables the menu item so that it can be selected and restores it from its dimmed state. Note that the value of this constant is 0; an application should not test against 0 for failure when using this value.  
  
-   **MF_GRAYED** Disables the menu item so that it cannot be selected and dims it.  
  
-   **MF_MENUBARBREAK** Places the item on a new line in static menus or in a new column in pop-up menus. The new pop-up menu column will be separated from the old column by a vertical dividing line.  
  
-   **MF_MENUBREAK** Places the item on a new line in static menus or in a new column in pop-up menus. No dividing line is placed between the columns.  
  
-   **MF_SEPARATOR** Draws a horizontal dividing line. Can only be used in a pop-up menu. This line cannot be dimmed, disabled, or highlighted. Other parameters are ignored.  
  
-   **MF_UNCHECKED** Acts as a toggle with **MF_CHECKED** to remove a check mark next to the item. When the application supplies check-mark bitmaps (see the `SetMenuItemBitmaps` member function), the "check mark off" bitmap is displayed. Note that the value of this constant is 0; an application should not test against 0 for failure when using this value.  
  
## Example  
 [!code[NVC_MFCWindowing#27](../vs140/codesnippet/CPP/cmenu--getmenustate_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetMenuState](http://msdn.microsoft.com/library/windows/desktop/ms647982)   
 [CMenu::CheckMenuItem](../vs140/cmenu--checkmenuitem.md)   
 [CMenu::EnableMenuItem](../vs140/cmenu--enablemenuitem.md)