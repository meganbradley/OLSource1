---
title: "CMFCToolBarsCustomizeDialog::GetFlags"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCToolBarsCustomizeDialog.GetFlags
  - GetFlags
  - CMFCToolBarsCustomizeDialog::GetFlags
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetFlags method
ms.assetid: 0bb401bd-35a7-492f-b7e8-334833332912
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarsCustomizeDialog::GetFlags
Retrieves the set of flags that affect the behavior of the dialog box.  
  
## Syntax  
  
```  
UINT GetFlags() const;  
```  
  
## Return Value  
 The set of flags that affect the behavior of the dialog box.  
  
## Remarks  
 This method retrieves the value of the `uiFlags` parameter that is passed to the constructor. The return value can be one or more of the following values:  
  
 `AFX_CUSTOMIZE_MENU_SHADOWS`  
 Allows the user to specify the shadow appearance of the menu.  
  
 `AFX_CUSTOMIZE_TEXT_LABELS`  
 Allows the user to specify whether text labels are shown underneath the toolbar button images.  
  
 `AFX_CUSTOMIZE_MENU_ANIMATIONS`  
 Allows the user to specify the menu animation style.  
  
 `AFX_CUSTOMIZE_NOHELP`  
 Removes the help button from the customization dialog box.  
  
 `AFX_CUSTOMIZE_CONTEXT_HELP`  
 Enables the `WS_EX_CONTEXTHELP` visual style.  
  
 `AFX_CUSTOMIZE_NOTOOLS`  
 Removes the **Tools** page from the customization dialog box. This flag is valid if your application uses the `CUserToolsManager` class.  
  
 `AFX_CUSTOMIZE_MENUAMPERS`  
 Allows button captions to contain the ampersand (**&**) character.  
  
 `AFX_CUSTOMIZE_NO_LARGE_ICONS`  
 Removes the **Large Icons** option from the customization dialog box.  
  
 For more information about the `WS_EX_CONTEXTHELP` visual style, see [Extended Window Styles](../vs140/extended-window-styles.md).  
  
## Requirements  
 **Header:** afxtoolbarscustomizedialog.h  
  
## See Also  
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarsCustomizeDialog::CMFCToolBarsCustomizeDialog](../vs140/cmfctoolbarscustomizedialog--cmfctoolbarscustomizedialog.md)   
 [Extended Window Styles](../vs140/extended-window-styles.md)   
 [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md)