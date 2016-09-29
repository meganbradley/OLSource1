---
title: "CMFCToolBarsCustomizeDialog::ReplaceButton"
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
  - "ReplaceButton"
  - "CMFCToolBarsCustomizeDialog.ReplaceButton"
  - "CMFCToolBarsCustomizeDialog::ReplaceButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReplaceButton method"
ms.assetid: c2d806da-f3a1-4369-998d-151da2e9ce40
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarsCustomizeDialog::ReplaceButton
Replaces a toolbar button in the list box of commands on the **Commands** page.  
  
## Syntax  
  
```  
void ReplaceButton(  
   UINT uiCmd,  
   const CMFCToolBarButton& button   
);  
```  
  
#### Parameters  
 [in] `uiCmd`  
 Specifies the command of the button to be replaced.  
  
 [in] `button`  
 A `const` reference to the toolbar button object that replaces the old button.  
  
## Remarks  
 When [CMFCToolBarsCustomizeDialog::AddMenu](../vs140/cmfctoolbarscustomizedialog--addmenu.md), [AddMenuCommands](../vs140/cmfctoolbarscustomizedialog--addmenucommands.md), or [AddToolbar](../vs140/cmfctoolbarscustomizedialog--addtoolbar.md) adds a command to the **Commands** page, that command is in the form of a [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md) object (or a [CMFCToolBarMenuButton](../vs140/cmfctoolbarmenubutton-class.md) object for a menu item that contains a submenu added by `AddMenuCommands`). The framework also calls these three methods to add commands automatically. If you want a command to be represented by a derived type instead, call `ReplaceButton` and pass in a button of the derived type.  
  
## Example  
 The following example demonstrates how to use the `ReplaceButton` method in the `CMFCToolBarsCustomizeDialog` class. This code snippet is part of the [Visual Studio Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#34](../vs140/codesnippet/CPP/cmfctoolbarscustomizedialog--replacebutton_1.cpp)]  
  
## Requirements  
 **Header:** afxToolBarsCustomizeDialog.h  
  
## See Also  
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)