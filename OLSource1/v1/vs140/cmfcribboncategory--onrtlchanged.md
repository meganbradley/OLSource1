---
title: "CMFCRibbonCategory::OnRTLChanged"
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
  - "CMFCRibbonCategory.OnRTLChanged"
  - "CMFCRibbonCategory::OnRTLChanged"
  - "OnRTLChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnRTLChanged method"
ms.assetid: d04364a8-3f51-4c3c-8938-a371de61d89a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCategory::OnRTLChanged
Called by the framework when the layout changes direction.  
  
## Syntax  
  
```  
virtual void OnRTLChanged(  
   BOOL bIsRTL  
);  
```  
  
#### Parameters  
 [in] `bIsRTL`  
 `TRUE` if the layout is right-to-left; `FALSE` if the layout is left-to-right.  
  
## Remarks  
 This method adjusts the layout of all ribbon panels and ribbon elements that are contained in the ribbon category.  
  
## Requirements  
 **Header:** afxribboncategory.h  
  
## See Also  
 [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)