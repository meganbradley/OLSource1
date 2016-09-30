---
title: "CMenu::RemoveMenu"
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
  - "RemoveMenu"
  - "CMenu.RemoveMenu"
  - "CMenu::RemoveMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveMenu method"
  - "CMenu class, menu item operations"
ms.assetid: e3d5f9af-f12f-4098-b8f9-af410fc4b465
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::RemoveMenu
Deletes a menu item with an associated pop-up menu from the menu.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the menu item to be removed. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter can be used to interpret <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in the following ways:  
  
|nFlags|Interpretation of nPosition|  
|------------|---------------------------------|  
|**MF_BYCOMMAND**|Specifies that the parameter gives the command ID of the existing menu item. This is the default if neither **MF_BYCOMMAND** nor **MF_BYPOSITION** is set.|  
|**MF_BYPOSITION**|Specifies that the parameter gives the position of the existing menu item. The first item is at position 0.|  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies how <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is interpreted.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 It does not destroy the handle for a pop-up menu, so the menu can be reused. Before calling this function, the application may call the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> member function to retrieve the pop-up <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object for reuse.  
  
 Whenever a menu that resides in a window is changed (whether or not the window is displayed), the application must call <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
 See the example for [CMenu::InsertMenu](../vs140/cmenu--insertmenu.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::DrawMenuBar](../vs140/cwnd--drawmenubar.md)   
 [CMenu::GetSubMenu](../vs140/cmenu--getsubmenu.md)   
 [RemoveMenu](http://msdn.microsoft.com/library/windows/desktop/ms647994)