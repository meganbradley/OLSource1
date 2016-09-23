---
title: "CMFCRibbonBar::SetQuickAccessCommands"
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
  - CMFCRibbonBar.SetQuickAccessCommands
  - CMFCRibbonBar::SetQuickAccessCommands
  - SetQuickAccessCommands
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetQuickAccessCommands method
ms.assetid: e0fb7f12-14e3-4c1e-ba21-947ff837c6c8
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonBar::SetQuickAccessCommands
Adds one or more ribbon elements to the Quick Access Toolbar.  
  
## Syntax  
  
```  
void SetQuickAccessCommands(  
   const CList<UINT,UINT>& lstCommands,  
   BOOL bRecalcLayout=TRUE   
);  
```  
  
#### Parameters  
 [in] `lstCommands`  
 The list of commands to be placed on the Quick Access Toolbar.  
  
 [in] `bRecalcLayout`  
 `TRUE` if want to redraw the ribbon after you add the ribbon elements; `FALSE` otherwise.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## Example  
 The following example demonstrates how to use the `SetQuickAccessCommands` method in the `CMFCRibbonBar` class.  
  
 [!code[NVC_MFC_RibbonApp#8](../vs140/codesnippet/CPP/cmfcribbonbar--setquickaccesscommands_1.cpp)]
  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)