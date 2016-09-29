---
title: "CMFCRibbonCategory::GetMaxHeight"
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
  - "GetMaxHeight"
  - "CMFCRibbonCategory.GetMaxHeight"
  - "CMFCRibbonCategory::GetMaxHeight"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMaxHeight method"
ms.assetid: 2384a655-26f6-45dd-959b-0de6fa6ee35c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCategory::GetMaxHeight
Retrieves the maximum height of the ribbon panels that are contained in the ribbon category.  
  
## Syntax  
  
```  
int GetMaxHeight(  
   CDC* pDC  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 Pointer to a device context for the ribbon panels.  
  
## Return Value  
 The maximum height of the ribbon panels that are contained in the ribbon category.  
  
## Remarks  
 The value retrieved includes the height of the top and bottom margins for the ribbon panels.  
  
## Requirements  
 **Header:** afxribboncategory.h  
  
## See Also  
 [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)