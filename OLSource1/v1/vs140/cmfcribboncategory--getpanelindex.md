---
title: "CMFCRibbonCategory::GetPanelIndex"
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
  - "CMFCRibbonCategory.GetPanelIndex"
  - "CMFCRibbonCategory::GetPanelIndex"
  - "GetPanelIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPanelIndex method"
ms.assetid: eca8334f-7328-4fdc-87d9-d4cc85241752
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCategory::GetPanelIndex
Retrieves the zero-based index of the specified ribbon panel.  
  
## Syntax  
  
```  
int GetPanelIndex(  
   const CMFCRibbonPanel* pPanel   
) const;  
```  
  
#### Parameters  
 [in] `pPanel`  
 Pointer to a ribbon panel.  
  
## Return Value  
 Zero-based index of the specified ribbon panel if the method was successful; otherwise -1.  
  
## Remarks  
 Only ribbon panels that are contained in the ribbon category are searched.  
  
## Requirements  
 **Header:** afxribboncategory.h  
  
## See Also  
 [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)