---
title: "CMenu::ModifyMenu"
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
  - "CMenu::ModifyMenu"
  - "CMenu.ModifyMenu"
  - "ModifyMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ModifyMenu method"
  - "CMenu class, menu item operations"
ms.assetid: b5bf8cda-d286-4004-afa4-43673f97f6e7
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::ModifyMenu
Changes an existing menu item at the position specified by `nPosition`.  
  
## Syntax  
  
```  
  
      BOOL ModifyMenu(  
   UINT nPosition,  
   UINT nFlags,  
   UINT_PTR nIDNewItem = 0,  
   LPCTSTR lpszNewItem = NULL   
);  
BOOL ModifyMenu(  
   UINT nPosition,  
   UINT nFlags,  
   UINT_PTR nIDNewItem,  
   const CBitmap* pBmp   
);  
```  
  
#### Parameters  
 `nPosition`  
 Specifies the menu item to be changed. The `nFlags` parameter can be used to interpret `nPosition` in the following ways:  
  
|nFlags|Interpretation of nPosition|  
|------------|---------------------------------|  
|**MF_BYCOMMAND**|Specifies that the parameter gives the command ID of the existing menu item. This is the default if neither **MF_BYCOMMAND** nor **MF_BYPOSITION** is set.|  
|**MF_BYPOSITION**|Specifies that the parameter gives the position of the existing menu item. The first item is at position 0.|  
  
 `nFlags`  
 Specifies how `nPosition` is interpreted and gives information about the changes to be made to the menu item. For a list of flags that may be set, see the [AppendMenu](../vs140/cmenu--appendmenu.md) member function.  
  
 `nIDNewItem`  
 Specifies either the command ID of the modified menu item or, if `nFlags` is set to **MF_POPUP**, the menu handle (`HMENU`) of a pop-up menu. The `nIDNewItem` parameter is ignored (not needed) if `nFlags` is set to **MF_SEPARATOR**.  
  
 `lpszNewItem`  
 Specifies the content of the new menu item. The `nFlags` parameter can be used to interpret `lpszNewItem` in the following ways:  
  
|nFlags|Interpretation of lpszNewItem|  
|------------|-----------------------------------|  
|`MF_OWNERDRAW`|Contains an application-supplied 32-bit value that the application can use to maintain additional data associated with the menu item. This 32-bit value is available to the application when it processes **MF_MEASUREITEM** and **MF_DRAWITEM**.|  
|**MF_STRING**|Contains a long pointer to a null-terminated string or to a `CString`.|  
|**MF_SEPARATOR**|The `lpszNewItem` parameter is ignored (not needed).|  
  
 *pBmp*  
 Points to a `CBitmap` object that will be used as the menu item.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The application specifies the new state of the menu item by setting values in `nFlags`. If this function replaces a pop-up menu associated with the menu item, it destroys the old pop-up menu and frees the memory used by the pop-up menu.  
  
 When `nIDNewItem` specifies a pop-up menu, it becomes part of the menu in which it is inserted. If that menu is destroyed, the inserted menu will also be destroyed. An inserted menu should be detached from a `CMenu` object to avoid conflict.  
  
 Whenever a menu that resides in a window is changed (whether or not the window is displayed), the application should call `CWnd::DrawMenuBar`. To change the attributes of existing menu items, it is much faster to use the `CheckMenuItem` and `EnableMenuItem` member functions.  
  
## Example  
 See the example for [CMenu::InsertMenu](../vs140/cmenu--insertmenu.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMenu::AppendMenu](../vs140/cmenu--appendmenu.md)   
 [CMenu::InsertMenu](../vs140/cmenu--insertmenu.md)   
 [CMenu::CheckMenuItem](../vs140/cmenu--checkmenuitem.md)   
 [CWnd::DrawMenuBar](../vs140/cwnd--drawmenubar.md)   
 [CMenu::EnableMenuItem](../vs140/cmenu--enablemenuitem.md)   
 [CMenu::SetMenuItemBitmaps](../vs140/cmenu--setmenuitembitmaps.md)   
 [CMenu::Detach](../vs140/cmenu--detach.md)   
 [ModifyMenu](http://msdn.microsoft.com/library/windows/desktop/ms647993)