---
title: "CMFCRibbonBar::GetActiveCategory"
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
  - "GetActiveCategory"
  - "CMFCRibbonBar::GetActiveCategory"
  - "CMFCRibbonBar.GetActiveCategory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetActiveCategory method"
ms.assetid: 13bd1a95-58eb-43e6-893e-4a540d9543ce
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::GetActiveCategory
Retrieves a pointer to the active ribbon category.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the active ribbon category; or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if no category is active.  
  
## Remarks  
 A category is active if it has the focus. By default, the active category is the first category on the left side of the ribbon bar.  
  
 The main category is displayed when the user presses the application button and it cannot be the active category.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)