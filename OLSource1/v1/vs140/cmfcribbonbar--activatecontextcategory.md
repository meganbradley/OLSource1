---
title: "CMFCRibbonBar::ActivateContextCategory"
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
  - "CMFCRibbonBar.ActivateContextCategory"
  - "CMFCRibbonBar::ActivateContextCategory"
  - "ActivateContextCategory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ActivateContextCategory method"
ms.assetid: 2827724b-5bcc-466d-9577-5c6c3545a92c
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::ActivateContextCategory
Activates a context category that is already visible.  
  
## Syntax  
  
```  
BOOL ActivateContextCategory(  
   UINT uiContextID   
);  
```  
  
#### Parameters  
 [in] `uiContextID`  
 The context category ID.  
  
## Return Value  
 `TRUE` if a context category with `uiContextID` is found and activated; otherwise `FALSE`.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)