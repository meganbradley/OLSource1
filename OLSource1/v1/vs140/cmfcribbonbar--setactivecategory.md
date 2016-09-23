---
title: "CMFCRibbonBar::SetActiveCategory"
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
  - SetActiveCategory
  - CMFCRibbonBar::SetActiveCategory
  - CMFCRibbonBar.SetActiveCategory
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetActiveCategory method
ms.assetid: b2170bdc-64a2-45e7-aa5a-f5409dbc2290
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonBar::SetActiveCategory
Sets the specified ribbon category as the active category.  
  
## Syntax  
  
```  
BOOL SetActiveCategory(  
   CMFCRibbonCategory* pCategory,  
   BOOL bForceRestore = FALSE  
);  
```  
  
#### Parameters  
 [in] `pCategory`  
 A ribbon category that is contained in the ribbon bar.  
  
 [in] `bForceRestore`  
 `TRUE` to maximize the ribbon bar if it is minimized; `FALSE` to display the active category in a pop-up window if the ribbon bar is minimized.  
  
## Return Value  
 `TRUE` if the specified category was set as the active category; otherwise `FALSE`.  
  
## Remarks  
 The main ribbon category cannot be the active category.  
  
 If the category specified by `pCategory` is not displayed, it cannot be set as the active category.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)