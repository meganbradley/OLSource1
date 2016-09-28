---
title: "CMFCToolBar::AddBasicCommand"
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
  - "CMFCToolBar.AddBasicCommand"
  - "CMFCToolBar::AddBasicCommand"
  - "AddBasicCommand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddBasicCommand method"
ms.assetid: 1a484ca0-4a4e-4795-af28-9235dbcb903c
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::AddBasicCommand
Adds a menu command to the list of commands that are always displayed when a user opens a menu.  
  
## Syntax  
  
```  
static void __stdcall AddBasicCommand(  
   UINT uiCmd   
);  
```  
  
#### Parameters  
 [in] `uiCmd`  
 Specifies the command to add.  
  
## Remarks  
 A basic command is always displayed when the menu is opened. This method is meaningful when the user chooses to view recently used commands.  
  
 Use the [CMFCToolBar::SetBasicCommands](../vs140/cmfctoolbar--setbasiccommands.md) method to set the list of commands that are always displayed when a user opens a menu. Use the [CMFCToolBar::GetBasicCommands](../vs140/cmfctoolbar--getbasiccommands.md) method to retrieve the list of basic commands that is used by your application.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::SetBasicCommands](../vs140/cmfctoolbar--setbasiccommands.md)   
 [CMFCToolBar::GetBasicCommands](../vs140/cmfctoolbar--getbasiccommands.md)