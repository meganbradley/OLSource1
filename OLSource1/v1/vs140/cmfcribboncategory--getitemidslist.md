---
title: "CMFCRibbonCategory::GetItemIDsList"
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
  - CMFCRibbonCategory.GetItemIDsList
  - GetItemIDsList
  - CMFCRibbonCategory::GetItemIDsList
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetItemIDsList method
ms.assetid: 58f00c46-f574-48af-ab88-1c1cf3c4d84a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonCategory::GetItemIDsList
Retrieves the command IDs for the ribbon elements that are contained in the ribbon category.  
  
## Syntax  
  
```  
void GetItemIDsList(  
   CList<UINT, UINT>& lstItems,  
   BOOL bHiddenOnly = FALSE  
) const;  
```  
  
#### Parameters  
 [out] `lstItems`  
 The list of command IDs for the ribbon elements in the ribbon category.  
  
 [in] `bHiddenOnly`  
 `TRUE` to exclude ribbon elements displayed on the ribbon panels in the ribbon category; `FALSE` to include all ribbon elements in the ribbon category.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribboncategory.h  
  
## See Also  
 [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)