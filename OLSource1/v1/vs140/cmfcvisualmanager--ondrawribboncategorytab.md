---
title: "CMFCVisualManager::OnDrawRibbonCategoryTab"
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
  - "CMFCVisualManager::OnDrawRibbonCategoryTab"
  - "CMFCVisualManager.OnDrawRibbonCategoryTab"
  - "OnDrawRibbonCategoryTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonCategoryTab method"
ms.assetid: dd11e7e2-9cb3-4036-9408-3c2e7544be13
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawRibbonCategoryTab
The framework calls this method when it draws the tab for a ribbon category.  
  
## Syntax  
  
```  
virtual COLORREF OnDrawRibbonCategoryTab(  
   CDC* pDC,  
   CMFCRibbonTab* pTab,  
   BOOL bIsActive  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `pTab`  
 A pointer to an instance of the `CMFCRibbonTab` class. The framework draws this tab.  
  
 [in] `bIsActive`  
 A Boolean parameter that indicates whether the tab is active.  
  
## Return Value  
 The color that is used for text on the ribbon category tab.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of a ribbon category tab. For more information about ribbon categories, see [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md).  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md)