---
title: "CMFCMenuBar::IsShowAllCommands"
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
  - "IsShowAllCommands"
  - "CMFCMenuBar::IsShowAllCommands"
  - "CMFCMenuBar.IsShowAllCommands"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsShowAllCommands method"
ms.assetid: 63755dab-2675-4720-a54a-78e24a9fadfd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMenuBar::IsShowAllCommands
Indicates whether menus display all commands.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the [CMFCMenuBar](../vs140/cmfcmenubar-class.md) displays all commands; otherwise 0.  
  
## Remarks  
 A <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object can be configured to either show all commands or show only a subset of commands. For more information about this feature, see [CMFCMenuBar Class](../vs140/cmfcmenubar-class.md).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> will tell you how this feature is configured for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. To control which menu commands are shown, use the methods [CMFCMenuBar::SetShowAllCommands](../vs140/cmfcmenubar--setshowallcommands.md) and [CMFCMenuBar::SetRecentlyUsedMenus](../vs140/cmfcmenubar--setrecentlyusedmenus.md).  
  
## Requirements  
 **Header:** afxmenubar.h  
  
## See Also  
 [CMFCMenuBar Class](../vs140/cmfcmenubar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCMenuBar::SetShowAllCommands](../vs140/cmfcmenubar--setshowallcommands.md)   
 [CMFCMenuBar::SetRecentlyUsedMenus](../vs140/cmfcmenubar--setrecentlyusedmenus.md)