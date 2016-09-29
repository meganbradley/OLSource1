---
title: "CMFCRibbonMiniToolBar::SetCommands"
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
  - "CMFCRibbonMiniToolBar::SetCommands"
  - "CMFCRibbonMiniToolBar.SetCommands"
  - "SetCommands"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCommands method"
ms.assetid: 8dd97c5b-2662-473b-89f1-fb62af1f7e1c
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonMiniToolBar::SetCommands
Sets the list of commands to be displayed on the toolbar.  
  
## Syntax  
  
```  
void SetCommands(  
    CMFCRibbonBar* pRibbonBar,  
    const CList<UINT,UINT>& lstCommands   
);  
```  
  
#### Parameters  
 [in] `pRibbonBar`  
 The ribbon bar that the mini toolbar searches for the buttons to display.  
  
 [in] `lstCommands`  
 The list of commands to be displayed on the mini toolbar. All ribbon categories are searched to find the associated buttons.  
  
## Remarks  
 Use this function to set the list of commands to be displayed in the mini toolbar.  
  
## Example  
 The following example demonstrates how to use the `SetCommands` method of the `CMFCRibbonMiniToolBar` class. This code snippet is part of the [MS Office 2007 Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_MSOffice2007Demo#9](../vs140/codesnippet/CPP/cmfcribbonminitoolbar--setcommands_1.cpp)]  
  
## Requirements  
 **Header:** afxRibbonMiniToolBar.h  
  
## See Also  
 [CMFCRibbonMiniToolBar Class](../vs140/cmfcribbonminitoolbar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)