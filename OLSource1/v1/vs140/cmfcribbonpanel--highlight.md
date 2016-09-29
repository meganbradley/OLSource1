---
title: "CMFCRibbonPanel::Highlight"
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
  - "CMFCRibbonPanel.Highlight"
  - "CMFCRibbonPanel::Highlight"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonPanel.Highlight"
  - "Highlight"
  - "CMFCRibbonPanel::Highlight"
ms.assetid: c145f7b5-cd88-4218-9905-bbb6cf2804d6
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonPanel::Highlight
Sets the highlight color for the selected ribbon panel and for the ribbon element specified by the point.  
  
## Syntax  
  
```  
virtual void Highlight(  
   BOOL bHighlight,  
   CPoint point  
);  
```  
  
#### Parameters  
 [in] `bHighlight`  
 `TRUE` to highlight the ribbon panel; `FALSE` to unhighlight the ribbon panel.  
  
 [in] `point`  
 The x and y coordinates of the pointer, relative to the upper-left corner of the window.  
  
## Remarks  
  
## Requirements  
 **Header**: afxRibbonPanel.h  
  
## See Also  
 [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)