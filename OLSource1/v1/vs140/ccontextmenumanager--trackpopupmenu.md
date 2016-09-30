---
title: "CContextMenuManager::TrackPopupMenu"
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
  - "CContextMenuManager::TrackPopupMenu"
  - "TrackPopupMenu"
  - "CContextMenuManager.TrackPopupMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TrackPopupMenu method"
ms.assetid: 9d27590a-c72b-4f4a-9421-c018d654c610
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CContextMenuManager::TrackPopupMenu
Displays the specified shortcut menu and returns the index of the selected shortcut menu command.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The handle of the shortcut menu that this method displays.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The horizontal offset for the shortcut menu in client coordinates.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The vertical offset for the shortcut menu in client coordinates.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to the parent window of the shortcut menu.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates how menu items are aligned. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the menu is right-aligned for right-to-left reading order. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the menu is left-aligned for left-to-right reading order.  
  
## Return Value  
 The menu command ID of the command that the user chooses; 0 if the user closes the shortcut menu without selecting a menu command.  
  
## Remarks  
 This method functions as a modal call to display a shortcut menu. The application will not continue to the following line in code until the user either closes the shortcut menu or selects a command. An alternative method that you can use to display a shortcut menu is [CContextMenuManager::ShowPopupMenu](../vs140/ccontextmenumanager--showpopupmenu.md). That method is not a modal call and will not return the ID of the selected command.  
  
## Requirements  
 **Header:** afxcontextmenumanager.h  
  
## See Also  
 [CContextMenuManager Class](../vs140/ccontextmenumanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CContextMenuManager::ShowPopupMenu](../vs140/ccontextmenumanager--showpopupmenu.md)