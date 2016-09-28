---
title: "CMFCToolBar::EnableCustomizeButton"
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
  - "EnableCustomizeButton"
  - "CMFCToolBar.EnableCustomizeButton"
  - "CMFCToolBar::EnableCustomizeButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableCustomizeButton method"
ms.assetid: 1ab6c056-55c5-4b02-a755-ae89feeca04b
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::EnableCustomizeButton
Enables or disables the Customize button that appears on the toolbar.  
  
## Syntax  
  
```  
void EnableCustomizeButton(  
   BOOL bEnable,  
   int iCustomizeCmd,  
   const CString& strCustomizeText,  
   BOOL bQuickCustomize=TRUE   
);  
void EnableCustomizeButton(  
   BOOL bEnable,  
   int iCustomizeCmd,  
   UINT uiCustomizeTextResId,  
   BOOL bQuickCustomize=TRUE   
);  
```  
  
#### Parameters  
 [in] `bEnable`  
 Enables or disables the Customize button.  
  
 [in] `iCustomizeCmd`  
 The command ID of the Customize button.  
  
 [in] `strCustomizeText`  
 The text label of the Customize button.  
  
 [in] `uiCustomizeTextResId`  
 The resource string ID of the Customize button label.  
  
 [in] `bQuickCustomize`  
 Enables or disables the **Add or Remove Buttons** option on the menu that drops down from the button.  
  
## Remarks  
 If `iCustomizeCmd` is -1, the framework displays the Customize button when multiple toolbar buttons do not fit in the toolbar area. The button displays a double left-pointing arrow, or chevron, which indicates that there are more buttons.  
  
 If `iCustomizeCmd` specifies a valid command ID, and `bEnable` is `TRUE`, the Customize button is always displayed. The button has a small down arrow and opens a menu that contains a command. This command uses the text label specified by `strCustomizeText`. If `bQuickCustomize` is also `TRUE`, the menu displays the **Add or Remove Buttons** option.  
  
 The framework dynamically adds to the menu any buttons that do not fit in the toolbar area before the item that is specified by `iCustomizeCmd`. The chevron is displayed next to the down arrow.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)