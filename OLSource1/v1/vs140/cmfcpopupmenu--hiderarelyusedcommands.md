---
title: "CMFCPopupMenu::HideRarelyUsedCommands"
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
  - "HideRarelyUsedCommands"
  - "CMFCPopupMenu.HideRarelyUsedCommands"
  - "CMFCPopupMenu::HideRarelyUsedCommands"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HideRarelyUsedCommands method"
ms.assetid: 414df65d-8a9c-4c33-8f7c-6285fce9b53d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPopupMenu::HideRarelyUsedCommands
Indicates whether the pop-up menu can hide rarely used commands.  
  
## Syntax  
  
```  
BOOL HideRarelyUsedCommands() const;  
```  
  
## Return Value  
 `TRUE` if the pop-up menu can hide the rarely used commands; otherwise `FALSE`.  
  
## Remarks  
 This method specifies only whether a pop-up menu can hide rarely used commands, not if that configuration is enabled. A pop-up menu can hide rarely used commands if it has a parent button and the parent window is derived from the [CMFCMenuBar Class](../vs140/cmfcmenubar-class.md). Use [CMFCMenuBar::SetRecentlyUsedMenus](../vs140/cmfcmenubar--setrecentlyusedmenus.md) to enable this feature and [CMFCMenuBar::IsRecentlyUsedMenus](../vs140/cmfcmenubar--isrecentlyusedmenus.md) to determine if this feature is currently enabled. You must call both of these methods for the parent window.  
  
## Requirements  
 **Header:** afxpopupmenu.h  
  
## See Also  
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCMenuBar::SetRecentlyUsedMenus](../vs140/cmfcmenubar--setrecentlyusedmenus.md)   
 [CMFCMenuBar::IsRecentlyUsedMenus](../vs140/cmfcmenubar--isrecentlyusedmenus.md)