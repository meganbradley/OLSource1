---
title: "CMFCToolBarsCustomizeDialog::CMFCToolBarsCustomizeDialog"
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
  - CMFCToolBarsCustomizeDialog
  - CMFCToolBarsCustomizeDialog::CMFCToolBarsCustomizeDialog
  - CMFCToolBarsCustomizeDialog.CMFCToolBarsCustomizeDialog
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMFCToolBarsCustomizeDialog, constructor
ms.assetid: 8a4555db-4611-468e-8b1f-dd8db8006641
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarsCustomizeDialog::CMFCToolBarsCustomizeDialog
Constructs a `CMFCToolBarsCustomizeDialog` object.  
  
## Syntax  
  
```  
CMFCToolBarsCustomizeDialog(  
   CFrameWnd* pWndParentFrame,  
   BOOL bAutoSetFromMenus = FALSE,  
   UINT uiFlags = (AFX_CUSTOMIZE_MENU_SHADOWS | AFX_CUSTOMIZE_TEXT_LABELS | AFX_CUSTOMIZE_MENU_ANIMATIONS | AFX_CUSTOMIZE_NOHELP),  
   CList <CRuntimeClass*, CRuntimeClass*>* plistCustomPages = NULL  
);  
```  
  
#### Parameters  
 [in] `pWndParentFrame`  
 A pointer to the parent frame. This parameter must not be `NULL`.  
  
 [in] `bAutoSetFromMenus`  
 A Boolean value that specifies whether to add the menu commands from all menus to the list of commands on the **Commands** page. If this parameter is `TRUE`, the menu commands are added. Otherwise, the menu commands are not added.  
  
 [in] `uiFlags`  
 A combination of flags that affect the behavior of the dialog box. This parameter can be one or more of the following values:  
  
-   `AFX_CUSTOMIZE_MENU_SHADOWS`  
  
-   `AFX_CUSTOMIZE_TEXT_LABELS`  
  
-   `AFX_CUSTOMIZE_MENU_ANIMATIONS`  
  
-   `AFX_CUSTOMIZE_NOHELP`  
  
-   `AFX_CUSTOMIZE_CONTEXT_HELP`  
  
-   `AFX_CUSTOMIZE_NOTOOLS`  
  
-   `AFX_CUSTOMIZE_MENUAMPERS`  
  
-   `AFX_CUSTOMIZE_NO_LARGE_ICONS`  
  
 [in] `plistCustomPages`  
 A pointer to a list of `CRuntimeClass` objects that specify additional custom pages.  
  
## Remarks  
 The `plistCustomPages` parameter refers to the list of `CRuntimeClass` objects that specify additional custom pages. The constructor adds more pages to the dialog box by using the [CRuntimeClass::CreateObject](../vs140/cruntimeclass--createobject.md) method. See the CustomPages sample for an example that adds more pages to the **Customize** dialog box.  
  
 For more information about the values that you can pass in the `uiFlags` parameter, see [CMFCToolBarsCustomizeDialog::GetFlags](../vs140/cmfctoolbarscustomizedialog--getflags.md).  
  
## Example  
 The following example demonstrates how to construct an object of the `CMFCToolBarsCustomizeDialog` class. This code snippet is part of the [Custom Pages sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_CustomPages#3](../vs140/codesnippet/CPP/cmfctoolbarscustomizedialog--cmfctoolbarscustomizedialog_1.cpp)]
  
  
## Requirements  
 **Header:** afxtoolbarscustomizedialog.h  
  
## See Also  
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CRuntimeClass::CreateObject](../vs140/cruntimeclass--createobject.md)   
 [CMFCToolBarsCustomizeDialog::GetFlags](../vs140/cmfctoolbarscustomizedialog--getflags.md)