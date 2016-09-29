---
title: "CMenu::DeleteMenu"
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
  - "DeleteMenu"
  - "CMenu.DeleteMenu"
  - "CMenu::DeleteMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMenu class, operations"
  - "DeleteMenu method"
ms.assetid: 80db110b-f2bd-406a-a4a4-6e25ddf54609
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::DeleteMenu
Deletes an item from the menu.  
  
## Syntax  
  
```  
  
      BOOL DeleteMenu(  
   UINT nPosition,  
   UINT nFlags   
);  
```  
  
#### Parameters  
 `nPosition`  
 Specifies the menu item that is to be deleted, as determined by `nFlags`.  
  
 `nFlags`  
 Is used to interpret `nPosition` in the following way:  
  
|nFlags|Interpretation of nPosition|  
|------------|---------------------------------|  
|**MF_BYCOMMAND**|Specifies that the parameter gives the command ID of the existing menu item. This is the default if neither **MF_BYCOMMAND** nor **MF_BYPOSITION** is set.|  
|**MF_BYPOSITION**|Specifies that the parameter gives the position of the existing menu item. The first item is at position 0.|  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 If the menu item has an associated pop-up menu, `DeleteMenu` destroys the handle to the pop-up menu and frees the memory used by the pop-up menu.  
  
 Whenever a menu that resides in a window is changed (whether or not the window is displayed), the application must call [CWnd::DrawMenuBar](../vs140/cwnd--drawmenubar.md).  
  
## Example  
 See the example for [CWnd::GetMenu](../vs140/cwnd--getmenu.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::DrawMenuBar](../vs140/cwnd--drawmenubar.md)   
 [DeleteMenu](http://msdn.microsoft.com/library/windows/desktop/ms647629)