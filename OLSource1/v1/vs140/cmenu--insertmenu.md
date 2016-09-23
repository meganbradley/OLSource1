---
title: "CMenu::InsertMenu"
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
  - CMenu::InsertMenu
  - InsertMenu
  - CMenu.InsertMenu
dev_langs: 
  - C++
helpviewer_keywords: 
  - InsertMenu method
  - CMenu class, menu item operations
ms.assetid: c2361804-e245-41e5-8b3c-704de517c57c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMenu::InsertMenu
Inserts a new menu item at the position specified by `nPosition` and moves other items down the menu.  
  
## Syntax  
  
```  
  
      BOOL InsertMenu(  
   UINT nPosition,  
   UINT nFlags,  
   UINT_PTR nIDNewItem = 0,  
   LPCTSTR lpszNewItem = NULL   
);  
BOOL InsertMenu(  
   UINT nPosition,  
   UINT nFlags,  
   UINT_PTR nIDNewItem,  
   const CBitmap* pBmp   
);  
```  
  
#### Parameters  
 `nPosition`  
 Specifies the menu item before which the new menu item is to be inserted. The `nFlags` parameter can be used to interpret `nPosition` in the following ways:  
  
|nFlags|Interpretation of nPosition|  
|------------|---------------------------------|  
|**MF_BYCOMMAND**|Specifies that the parameter gives the command ID of the existing menu item. This is the default if neither **MF_BYCOMMAND** nor **MF_BYPOSITION** is set.|  
|**MF_BYPOSITION**|Specifies that the parameter gives the position of the existing menu item. The first item is at position 0. If `nPosition` is –1, the new menu item is appended to the end of the menu.|  
  
 `nFlags`  
 Specifies how `nPosition` is interpreted and specifies information about the state of the new menu item when it is added to the menu. For a list of the flags that may be set, see the [AppendMenu](../vs140/cmenu--appendmenu.md) member function. To specify more than one value, use the bitwise OR operator to combine them with the **MF_BYCOMMAND** or **MF_BYPOSITION** flag.  
  
 `nIDNewItem`  
 Specifies either the command ID of the new menu item or, if `nFlags` is set to **MF_POPUP**, the menu handle (`HMENU`) of the pop-up menu. The `nIDNewItem` parameter is ignored (not needed) if `nFlags` is set to **MF_SEPARATOR**.  
  
 `lpszNewItem`  
 Specifies the content of the new menu item. `nFlags` can be used to interpret `lpszNewItem` in the following ways:  
  
|nFlags|Interpretation of lpszNewItem|  
|------------|-----------------------------------|  
|`MF_OWNERDRAW`|Contains an application-supplied 32-bit value that the application can use to maintain additional data associated with the menu item. This 32-bit value is available to the application in the **itemData** member of the structure supplied by the [WM_MEASUREITEM](http://msdn.microsoft.com/library/windows/desktop/bb775925) and [WM_DRAWITEM](http://msdn.microsoft.com/library/windows/desktop/bb775923) messages. These messages are sent when the menu item is initially displayed or is changed.|  
|**MF_STRING**|Contains a long pointer to a null-terminated string. This is the default interpretation.|  
|**MF_SEPARATOR**|The `lpszNewItem` parameter is ignored (not needed).|  
  
 *pBmp*  
 Points to a `CBitmap` object that will be used as the menu item.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The application can specify the state of the menu item by setting values in `nFlags`.  
  
 Whenever a menu that resides in a window is changed (whether or not the window is displayed), the application should call `CWnd::DrawMenuBar`.  
  
 When `nIDNewItem` specifies a pop-up menu, it becomes part of the menu in which it is inserted. If that menu is destroyed, the inserted menu will also be destroyed. An inserted menu should be detached from a `CMenu` object to avoid conflict.  
  
 If the active multiple document interface (MDI) child window is maximized and an application inserts a pop-up menu into the MDI application's menu by calling this function and specifying the **MF_BYPOSITION** flag, the menu is inserted one position farther left than expected. This happens because the Control menu of the active MDI child window is inserted into the first position of the MDI frame window's menu bar. To position the menu properly, the application must add 1 to the position value that would otherwise be used. An application can use the **WM_MDIGETACTIVE** message to determine whether the currently active child window is maximized.  
  
## Example  
 [!code[NVC_MFCWindowing#28](../vs140/codesnippet/CPP/cmenu--insertmenu_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMenu::AppendMenu](../vs140/cmenu--appendmenu.md)   
 [CWnd::DrawMenuBar](../vs140/cwnd--drawmenubar.md)   
 [CMenu::SetMenuItemBitmaps](../vs140/cmenu--setmenuitembitmaps.md)   
 [CMenu::Detach](../vs140/cmenu--detach.md)   
 [InsertMenu](http://msdn.microsoft.com/library/windows/desktop/ms647987)