---
title: "CMFCRibbonCategory::FindPanelWithElem"
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
  - "FindPanelWithElem"
  - "CMFCRibbonCategory.FindPanelWithElem"
  - "CMFCRibbonCategory::FindPanelWithElem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindPanelWithElem method"
ms.assetid: 44b1d3b6-5831-4fd1-aa8c-c1511868cecd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCategory::FindPanelWithElem
Retrieves the ribbon panel that contains the specified ribbon element.  
  
## Syntax  
  
```  
CMFCRibbonPanel* FindPanelWithElem(  
   const CMFCRibbonBaseElement* pElement  
);  
```  
  
#### Parameters  
 [in] `pElement`  
 Pointer to a ribbon element.  
  
## Return Value  
 Pointer to a ribbon panel if the method was successful; otherwise `NULL`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribboncategory.h  
  
## See Also  
 [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)