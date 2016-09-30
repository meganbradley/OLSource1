---
title: "CMFCRibbonCategory::HighlightPanel"
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
  - "HighlightPanel"
  - "CMFCRibbonCategory.HighlightPanel"
  - "CMFCRibbonCategory::HighlightPanel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HighlightPanel method"
ms.assetid: c75a2414-84c7-4acd-bc0d-867d4508b7cd
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCategory::HighlightPanel
Highlights the specified ribbon panel.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the ribbon panel to highlight.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The x and y coordinates of the pointer, relative to the upper-left corner of the window.  
  
## Return Value  
 Pointer to the previously highlighted ribbon panel; otherwise <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if no ribbon panel is highlighted when this method is invoked.  
  
## Remarks  
 For more information about highlighting a ribbon panel, see [CMFCRibbonPanel::Highlight](../vs140/cmfcribbonpanel--highlight.md).  
  
## Requirements  
 **Header:** afxribboncategory.h  
  
## See Also  
 [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)