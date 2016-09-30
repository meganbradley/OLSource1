---
title: "CMenu::EnableMenuItem"
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
  - "CMenu::EnableMenuItem"
  - "CMenu.EnableMenuItem"
  - "EnableMenuItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableMenuItem method"
  - "CMenu class, menu item operations"
ms.assetid: e276ba57-98c5-4606-a0a4-9e8adfafafa2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::EnableMenuItem
Enables, disables, or dims a menu item.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *nIDEnableItem*  
 Specifies the menu item to be enabled, as determined by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. This parameter can specify pop-up menu items as well as standard menu items.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the action to take. It can be a combination of **MF_DISABLED**, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, or **MF_GRAYED**, with **MF_BYCOMMAND** or **MF_BYPOSITION**. These values can be combined by using the bitwise OR operator. These values have the following meanings:  
  
-   **MF_BYCOMMAND** Specifies that the parameter gives the command ID of the existing menu item. This is the default.  
  
-   **MF_BYPOSITION** Specifies that the parameter gives the position of the existing menu item. The first item is at position 0.  
  
-   **MF_DISABLED** Disables the menu item so that it cannot be selected but does not dim it.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> Enables the menu item so that it can be selected and restores it from its dimmed state.  
  
-   **MF_GRAYED** Disables the menu item so that it cannot be selected and dims it.  
  
## Return Value  
 Previous state (**MF_DISABLED**, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, or **MF_GRAYED**) or –1 if not valid.  
  
## Remarks  
 The [CreateMenu](../vs140/cmenu--createmenu.md), [InsertMenu](../vs140/cmenu--insertmenu.md), [ModifyMenu](../vs140/cmenu--modifymenu.md), and [LoadMenuIndirect](../vs140/cmenu--loadmenuindirect.md) member functions can also set the state (enabled, disabled, or dimmed) of a menu item.  
  
 Using the **MF_BYPOSITION** value requires an application to use the correct <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> of the menu bar is used, a top-level menu item (an item in the menu bar) is affected. To set the state of an item in a pop-up or nested pop-up menu by position, an application must specify the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> of the pop-up menu.  
  
 When an application specifies the **MF_BYCOMMAND** flag, Windows checks all pop-up menu items that are subordinate to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; therefore, unless duplicate menu items are present, using the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> of the menu bar is sufficient.  
  
## Example  
 [!code[NVC_MFCWindowing#25](../vs140/codesnippet/CPP/cmenu--enablemenuitem_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMenu::GetMenuState](../vs140/cmenu--getmenustate.md)   
 [EnableMenuItem](http://msdn.microsoft.com/library/windows/desktop/ms647636)