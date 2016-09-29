---
title: "CMFCTasksPane::CreateMenu"
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
  - "CreateMenu"
  - "CMFCTasksPane.CreateMenu"
  - "CMFCTasksPane::CreateMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateMenu method"
ms.assetid: 364ed1fa-98fe-4253-b46b-fd1b61969ae2
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::CreateMenu
Creates a menu that appears when a user clicks the **Other Tasks Panes** menu button.  
  
## Syntax  
  
```  
HMENU CreateMenu() const;  
```  
  
## Return Value  
 A handle to the new menu.  
  
## Remarks  
 Override this method in a derived class to customize the menu for a task pane.  
  
 The pop-up menu  that this method creates contains the list of pages in the task pane. The menu displays a check mark next to the active page.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)