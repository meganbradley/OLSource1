---
title: "CMenu::GetDefaultItem"
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
  - "GetDefaultItem"
  - "CMenu.GetDefaultItem"
  - "CMenu::GetDefaultItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDefaultItem method"
ms.assetid: 998043e4-4110-427a-9faf-6999afdaaf07
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::GetDefaultItem
Determines the default menu item on the specified menu.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *gmdiFlags*  
 Value specifying how the function searches for menu items. This parameter can be none, one, or a combination of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|**GMDI_GOINTOPOPUPS**|Specifies that, if the default item is one that opens a submenu, the function is to search in the corresponding submenu recursively. If the submenu has no default item, the return value identifies the item that opens the submenu.\<br />\<br /> By default, the function returns the first default item on the specified menu, regardless of whether it is an item that opens a submenu.|  
|**GMDI_USEDISABLED**|Specifies that the function is to return a default item, even if it is disabled.\<br />\<br /> By default, the function skips disabled or grayed items.|  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Value specifying whether to retrieve the menu item's identifier or its position. If this parameter is **FALSE**, the identifier is returned. Otherwise, the position is returned.  
  
## Return Value  
 If the function succeeds, the return value is the identifier or position of the menu item. If the function fails, the return value is - 1.  
  
## Remarks  
 This member function implements the behavior of the Win32 function [GetMenuDefaultItem](http://msdn.microsoft.com/library/windows/desktop/ms647976), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CMenu::InsertMenu](../vs140/cmenu--insertmenu.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMenu::SetDefaultItem](../vs140/cmenu--setdefaultitem.md)