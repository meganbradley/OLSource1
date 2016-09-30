---
title: "CMenu::AppendMenu"
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
  - "AppendMenu"
  - "CMenu::AppendMenu"
  - "CMenu.AppendMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMenu class, menu item operations"
  - "AppendMenu method"
ms.assetid: 5414834b-ec85-405c-b598-3998b9b361f7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::AppendMenu
Appends a new item to the end of a menu.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies information about the state of the new menu item when it is added to the menu. It consists of one or more of the values listed in the Remarks section.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies either the command ID of the new menu item or, if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is set to **MF_POPUP**, the menu handle (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) of a pop-up menu. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter is ignored (not needed) if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is set to **MF_SEPARATOR**.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the content of the new menu item. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter is used to interpret <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in the following way:  
  
|nFlags|Interpretation of lpszNewItem|  
|------------|-----------------------------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Contains an application-supplied 32-bit value that the application can use to maintain additional data associated with the menu item. This 32-bit value is available to the application when it processes <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> messages. The value is stored in the **itemData** member of the structure supplied with those messages.|  
|**MF_STRING**|Contains a pointer to a null-terminated string. This is the default interpretation.|  
|**MF_SEPARATOR**|The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter is ignored (not needed).|  
  
 *pBmp*  
 Points to a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object that will be used as the menu item.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The application can specify the state of the menu item by setting values in <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. When <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> specifies a pop-up menu, it becomes part of the menu to which it is appended. If that menu is destroyed, the appended menu will also be destroyed. An appended menu should be detached from a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object to avoid conflict. Note that **MF_STRING** and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> are not valid for the bitmap version of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 The following list describes the flags that may be set in <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>:  
  
-   **MF_CHECKED** Acts as a toggle with **MF_UNCHECKED** to place the default check mark next to the item. When the application supplies check-mark bitmaps (see the [SetMenuItemBitmaps](../vs140/cmenu--setmenuitembitmaps.md) member function), the "check mark on" bitmap is displayed.  
  
-   **MF_UNCHECKED** Acts as a toggle with **MF_CHECKED** to remove a check mark next to the item. When the application supplies check-mark bitmaps (see the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> member function), the "check mark off" bitmap is displayed.  
  
-   **MF_DISABLED** Disables the menu item so that it cannot be selected but does not dim it.  
  
-   <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> Enables the menu item so that it can be selected and restores it from its dimmed state.  
  
-   **MF_GRAYED** Disables the menu item so that it cannot be selected and dims it.  
  
-   **MF_MENUBARBREAK** Places the item on a new line in static menus or in a new column in pop-up menus. The new pop-up menu column will be separated from the old column by a vertical dividing line.  
  
-   **MF_MENUBREAK** Places the item on a new line in static menus or in a new column in pop-up menus. No dividing line is placed between the columns.  
  
-   <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> Specifies that the item is an owner-draw item. When the menu is displayed for the first time, the window that owns the menu receives a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> message, which retrieves the height and width of the menu item. The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> message is the one sent whenever the owner must update the visual appearance of the menu item. This option is not valid for a top-level menu item.  
  
-   **MF_POPUP** Specifies that the menu item has a pop-up menu associated with it. The ID parameter specifies a handle to a pop-up menu that is to be associated with the item. This is used for adding either a top-level pop-up menu or a hierarchical pop-up menu to a pop-up menu item.  
  
-   **MF_SEPARATOR** Draws a horizontal dividing line. Can only be used in a pop-up menu. This line cannot be dimmed, disabled, or highlighted. Other parameters are ignored.  
  
-   **MF_STRING** Specifies that the menu item is a character string.  
  
 Each of the following groups lists flags that are mutually exclusive and cannot be used together:  
  
-   **MF_DISABLED**, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, and **MF_GRAYED**  
  
-   **MF_STRING**, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, **MF_SEPARATOR**, and the bitmap version  
  
-   **MF_MENUBARBREAK** and **MF_MENUBREAK**  
  
-   **MF_CHECKED** and **MF_UNCHECKED**  
  
 Whenever a menu that resides in a window is changed (whether or not the window is displayed), the application should call [CWnd::DrawMenuBar](../vs140/cwnd--drawmenubar.md).  
  
## Example  
 See the example for [CMenu::CreateMenu](../vs140/cmenu--createmenu.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::DrawMenuBar](../vs140/cwnd--drawmenubar.md)   
 [CMenu::InsertMenu](../vs140/cmenu--insertmenu.md)   
 [CMenu::RemoveMenu](../vs140/cmenu--removemenu.md)   
 [CMenu::SetMenuItemBitmaps](../vs140/cmenu--setmenuitembitmaps.md)   
 [CMenu::Detach](../vs140/cmenu--detach.md)   
 [AppendMenu](http://msdn.microsoft.com/library/windows/desktop/ms647616)