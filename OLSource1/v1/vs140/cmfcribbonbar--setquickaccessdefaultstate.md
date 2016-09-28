---
title: "CMFCRibbonBar::SetQuickAccessDefaultState"
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
  - "CMFCRibbonBar::SetQuickAccessDefaultState"
  - "SetQuickAccessDefaultState"
  - "CMFCRibbonBar.SetQuickAccessDefaultState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetQuickAccessDefaultState method"
ms.assetid: 3e426794-9dc9-44d4-ab09-136a3fb9d67a
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::SetQuickAccessDefaultState
Sets the quick access toolbar to the default state.  
  
## Syntax  
  
```  
void SetQuickAccessDefaultState(  
   const CMFCRibbonQuickAccessToolBarDefaultState& state   
);  
```  
  
#### Parameters  
 [in] `state`  
 The quick access toolbar default state.  
  
## Remarks  
 The quick access toolbar state includes a list of commands and their visibility.  
  
## Example  
 The following example demonstrates how to use the `SetQuickAccessDefaultState` method in the `CMFCRibbonBar` class.  
  
 [!code[NVC_MFC_RibbonApp#9](../vs140/codesnippet/CPP/cmfcribbonbar--setquickaccessdefaultstate_1.cpp)]  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)