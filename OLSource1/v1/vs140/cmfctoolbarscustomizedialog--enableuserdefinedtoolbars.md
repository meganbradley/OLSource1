---
title: "CMFCToolBarsCustomizeDialog::EnableUserDefinedToolbars"
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
  - "CMFCToolBarsCustomizeDialog.EnableUserDefinedToolbars"
  - "CMFCToolBarsCustomizeDialog::EnableUserDefinedToolbars"
  - "EnableUserDefinedToolbars"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableUserDefinedToolbars method"
ms.assetid: d047265c-c8b5-4795-9e46-587781b455ba
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarsCustomizeDialog::EnableUserDefinedToolbars
Enables or disables creating new toolbars by using the **Customize** dialog box.  
  
## Syntax  
  
```  
void EnableUserDefinedToolbars(  
   BOOL bEnable=TRUE   
);  
```  
  
#### Parameters  
 [in] `bEnable`  
 `TRUE` to enable the user-defined toolbars; `FALSE` to disable the toolbars.  
  
## Remarks  
 If `bEnable` is `TRUE`, the **New**, **Rename** and **Delete** buttons are displayed on the **Toolbars** page.  
  
 By default, or if `bEnable` is `FALSE`, these buttons are not displayed and the user cannot define new toolbars.  
  
## Requirements  
 **Header:** afxToolBarsCustomizeDialog.h  
  
## See Also  
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)