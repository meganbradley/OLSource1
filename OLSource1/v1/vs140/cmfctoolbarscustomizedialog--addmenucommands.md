---
title: "CMFCToolBarsCustomizeDialog::AddMenuCommands"
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
  - "CMFCToolBarsCustomizeDialog::AddMenuCommands"
  - "CMFCToolBarsCustomizeDialog.AddMenuCommands"
  - "AddMenuCommands"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddMenuCommands method"
ms.assetid: 1d072fb0-81ea-4824-878b-8d2e7d906723
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarsCustomizeDialog::AddMenuCommands
Adds items to the list of commands in the **Commands** page to represent all the items in the specified menu.  
  
## Syntax  
  
```  
void AddMenuCommands(  
   const CMenu* pMenu,  
   BOOL bPopup,  
   LPCTSTR lpszCategory=NULL,  
   LPCTSTR lpszMenuPath=NULL   
);  
```  
  
#### Parameters  
 [in] `pMenu`  
 A pointer to the CMenu object to add.  
  
 [in] `bPopup`  
 Specifies whether to insert the popup menu items to the list of commands.  
  
 [in] `lpszCategory`  
 The name of the category to insert the menu.  
  
 [in] `lpszMenuPath`  
 A prefix that is added to the name when the command is shown in the **All Categories** list.  
  
## Remarks  
 The `AddMenuCommands` method loops over all menu items of `pMenu`. For each menu item that does not contain a submenu, this method creates a [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md) object and calls the [CMFCToolBarsCustomizeDialog::AddButton](../vs140/cmfctoolbarscustomizedialog--addbutton.md) method to add the menu item as a toolbar button to the list of commands on the **Commands** page. Separators are ignored in this process.  
  
 If `bPopup` is `TRUE`, for each menu item that contains a submenu this method creates a [CMFCToolBarMenuButton](../vs140/cmfctoolbarmenubutton-class.md) object and inserts it into the list of commands by calling `AddButton`. Otherwise menu items that contain submenus are not displayed in the list of commands. In either case, when `AddMenuCommands` encounters a menu item with a submenu it calls itself recursively, passing a pointer to the submenu as the `pMenu` parameter and appending the label of the submenu to `lpszMenuPath`.  
  
## Requirements  
 **Header:** afxToolBarsCustomizeDialog.h  
  
## See Also  
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)