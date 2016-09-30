---
title: "CMFCRibbonQuickAccessToolBarDefaultState::AddCommand"
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
  - "AddCommand"
  - "CMFCRibbonQuickAccessToolBarDefaultState.AddCommand"
  - "CMFCRibbonQuickAccessToolBarDefaultState::AddCommand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddCommand method"
ms.assetid: 331fbf97-c8d8-4550-ad5d-b0b420e89e09
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonQuickAccessToolBarDefaultState::AddCommand
Adds a command to the default state for the Quick Access Toolbar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies command ID.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Sets the visibility of the command when the Quick Access Toolbar is in the default state.  
  
## Remarks  
 Adding a command to the CMFCRibbonQuickAccessToolBarDefaultState accomplishes three results. First, each added command is listed on the dropdown on the right side of the Quick Access Toolbar. In this manner, a user can easily add or remove that command from the Quick Access Toolbar. Second, the Quick Access Toolbar is reset to show only those commands that are listed as visible in the default state when the user clicks the **Reset** button in the **Customize** dialog box. Third, if you have not called [CMFCRibbonBar::SetQuickAccessCommands](../vs140/cmfcribbonbar--setquickaccesscommands.md), the Quick Access Toolbar uses the visible commands from this list as the default visible commands the first time a user runs your application. After you have added all the commands that you want, call [CMFCRibbonBar::SetQuickAccessDefaultState](../vs140/cmfcribbonbar--setquickaccessdefaultstate.md) to set this instance as the default state for the Quick Access Toolbar of that Ribbon Bar.  
  
## Requirements  
 **Header:** afxribbonquickaccesstoolbar.h  
  
## See Also  
 [CMFCRibbonQuickAccessToolBarDefaultState Class](../vs140/cmfcribbonquickaccesstoolbardefaultstate-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)