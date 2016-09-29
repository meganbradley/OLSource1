---
title: "CMFCRibbonCategory::HitTestScrollButtons"
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
  - "HitTestScrollButtons"
  - "CMFCRibbonCategory.HitTestScrollButtons"
  - "CMFCRibbonCategory::HitTestScrollButtons"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HitTestScrollButtons method"
ms.assetid: 9be71479-6f16-41b3-84ca-cbe9a161c834
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCategory::HitTestScrollButtons
If a point falls within a ribbon category’s left or right scroll button, returns a pointer to that button.  
  
## Syntax  
  
```  
CMFCRibbonBaseElement* HitTestScrollButtons(  
   CPoint point  
) const;  
```  
  
#### Parameters  
 [in] `point`  
 The point to test.  
  
## Return Value  
 If `point` falls within the bounding rectangle of either the left or the right scroll button of the ribbon category, returns a pointer to that button, or otherwise, returns `NULL`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribboncategory.h  
  
## See Also  
 [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)