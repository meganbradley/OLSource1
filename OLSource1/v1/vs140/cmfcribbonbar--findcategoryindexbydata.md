---
title: "CMFCRibbonBar::FindCategoryIndexByData"
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
  - "CMFCRibbonBar.FindCategoryIndexByData"
  - "FindCategoryIndexByData"
  - "CMFCRibbonBar::FindCategoryIndexByData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindCategoryIndexByData method"
ms.assetid: aec23f8e-49cd-441d-b183-6689c0ae70ac
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::FindCategoryIndexByData
Retrieves the index of the ribbon category that contains the specified data.  
  
## Syntax  
  
```  
int FindCategoryIndexByData(  
   DWORD dwData   
) const;  
```  
  
#### Parameters  
 [in] `dwData`  
 The data associated with a ribbon category.  
  
## Return Value  
 The zero-based index of a ribbon category if the method was successful; otherwise -1.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)