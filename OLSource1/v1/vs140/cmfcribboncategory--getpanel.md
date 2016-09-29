---
title: "CMFCRibbonCategory::GetPanel"
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
  - "GetPanel"
  - "CMFCRibbonCategory::GetPanel"
  - "CMFCRibbonCategory.GetPanel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPanel method"
ms.assetid: 6f96ce56-22a1-4aac-92c3-a172a3ece948
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCategory::GetPanel
Returns a pointer to the ribbon panel that is located at the specified index.  
  
## Syntax  
  
```  
CMFCRibbonPanel* GetPanel(  
   int nIndex   
);  
```  
  
#### Parameters  
 [in] `nIndex`  
 The zero-based index of a ribbon panel.  
  
## Return Value  
 Pointer to the ribbon panel that is located at the specified index.  
  
## Remarks  
 An exception is thrown if `nIndex` is out of range.  
  
## Requirements  
 **Header:** afxribboncategory.h  
  
## See Also  
 [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)