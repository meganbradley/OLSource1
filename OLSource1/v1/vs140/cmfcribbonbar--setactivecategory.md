---
title: "CMFCRibbonBar::SetActiveCategory"
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
  - "SetActiveCategory"
  - "CMFCRibbonBar::SetActiveCategory"
  - "CMFCRibbonBar.SetActiveCategory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetActiveCategory method"
ms.assetid: b2170bdc-64a2-45e7-aa5a-f5409dbc2290
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::SetActiveCategory
Sets the specified ribbon category as the active category.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A ribbon category that is contained in the ribbon bar.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to maximize the ribbon bar if it is minimized; <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to display the active category in a pop-up window if the ribbon bar is minimized.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the specified category was set as the active category; otherwise <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 The main ribbon category cannot be the active category.  
  
 If the category specified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is not displayed, it cannot be set as the active category.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)