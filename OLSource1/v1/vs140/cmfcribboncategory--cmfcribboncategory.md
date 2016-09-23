---
title: "CMFCRibbonCategory::CMFCRibbonCategory"
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
  - CMFCRibbonCategory
  - CMFCRibbonCategory::CMFCRibbonCategory
  - CMFCRibbonCategory.CMFCRibbonCategory
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMFCRibbonCategory class, constructor
ms.assetid: 1eaa9fac-8d2b-46ea-a0cc-b29a7023d1c4
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonCategory::CMFCRibbonCategory
Constructs and initializes a [CMFCRibbonCategory](../vs140/cmfcribboncategory-class.md) object.  
  
## Syntax  
  
```  
CMFCRibbonCategory(  
   CMFCRibbonBar* pParenrRibbonBar,  
   LPCTSTR lpszName,  
   UINT uiSmallImagesResID,  
   UINT uiLargeImagesResID,  
   CSize sizeSmallImage = CSize(16, 16),  
   CSize sizeLargeImage = CSize(32, 32)   
);  
```  
  
#### Parameters  
 [in] `pParenrRibbonBar`  
 Pointer to the parent ribbon bar of the ribbon category.  
  
 [in] `lpszName`  
 Name of the ribbon category.  
  
 [in] `uiSmallImagesResID`  
 Resource ID of the image list for small images that are used by ribbon elements in the ribbon category.  
  
 [in] `uiLargeImagesResID`  
 Resource ID of the image list for large images that are used by ribbon elements in the ribbon category.  
  
 [in] `sizeSmallImage`  
 Default size of small images for ribbon elements in the ribbon category.  
  
 [in] `sizeLargeImage`  
 Default size of large images for ribbon elements in the ribbon category.  
  
## Requirements  
 **Header:** afxribboncategory.h  
  
## See Also  
 [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)