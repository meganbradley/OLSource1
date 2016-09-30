---
title: "CContextMenuManager::ShowPopupMenu"
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
  - "CContextMenuManager.ShowPopupMenu"
  - "CContextMenuManager::ShowPopupMenu"
  - "ShowPopupMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShowPopupMenu method"
ms.assetid: e7de5697-27a6-45f3-9fc5-11057ad7e91c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CContextMenuManager::ShowPopupMenu
Displays the specified shortcut menu.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The resource ID of the menu that this method will display.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The horizontal offset for the shortcut menu in client coordinates.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The vertical offset for the shortcut menu in client coordinates  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to the parent window of the shortcut menu.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates how messages are routed. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, standard MFC routing is used. Otherwise, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> receives the messages.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The handle of the menu that this method will display.  
  
 [in] <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the menu will be automatically destroyed.  
  
 [in] <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates how the menu items are aligned. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the menu is right-aligned for right-to-left reading order.  
  
## Return Value  
 The first method overload returns nonzero if the method shows the menu successfully; otherwise 0. The second method overload returns a pointer to [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) if the shortcut menu displays correctly; otherwise <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method resembles the method [CContextMenuManager::TrackPopupMenu](../vs140/ccontextmenumanager--trackpopupmenu.md) in that both methods display a shortcut menu. However, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> returns the index of the selected menu command.  
  
 If the parameter <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, you must manually call the inherited <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> method to release memory resources. The default implementation of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> does not use the parameter <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. It is provided for future use or for custom classes derived from the [CContextMenuManager Class](../vs140/ccontextmenumanager-class.md).  
  
## Requirements  
 **Header:** afxcontextmenumanager.h  
  
## See Also  
 [CContextMenuManager Class](../vs140/ccontextmenumanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CContextMenuManager::TrackPopupMenu](../vs140/ccontextmenumanager--trackpopupmenu.md)