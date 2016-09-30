---
title: "CMFCToolBarsCustomizeDialog::AddMenu"
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
  - "CMFCToolBarsCustomizeDialog.AddMenu"
  - "CMFCToolBarsCustomizeDialog::AddMenu"
  - "AddMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddMenu method"
ms.assetid: b5157fac-2c1a-451a-81cd-8864a2e061a2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarsCustomizeDialog::AddMenu
Loads a menu from the resources and calls [CMFCToolBarsCustomizeDialog::AddMenuCommands](../vs140/cmfctoolbarscustomizedialog--addmenucommands.md) to add that menu to the list of commands on the **Commands** page.  
  
## Syntax  
  
```  
BOOL AddMenu(  
   UINT uiMenuResId   
);  
```  
  
#### Parameters  
 [in] `uiMenuResId`  
 Specifies the resource ID of a menu to load.  
  
## Return Value  
 `TRUE` if a menu was added successfully; otherwise `FALSE`.  
  
## Remarks  
 In the call to `AddMenuCommands`, `bPopup` is `FALSE`. As a result, that method does not add menu items that contain submenus to the list of commands. This method does add the menu items in the submenus to the list of commands.  
  
## Requirements  
 **Header:** afxToolBarsCustomizeDialog.h  
  
## See Also  
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)