---
title: "CMFCRibbonBar::AddCategory"
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
  - "CMFCRibbonBar.AddCategory"
  - "CMFCRibbonBar::AddCategory"
  - "AddCategory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddCategory method"
ms.assetid: 50ae3e36-74a4-4a3c-8f55-bd4273a2a3ed
caps.latest.revision: 25
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::AddCategory
Creates and initializes a new ribbon category for the ribbon bar.  
  
## Syntax  
  
```  
CMFCRibbonCategory* AddCategory(  
   LPCTSTR lpszName,  
   UINT uiSmallImagesResID,  
   UINT uiLargeImagesResID,  
   CSize sizeSmallImage = CSize(16, 16),  
   CSize sizeLargeImage = CSize(32, 32),  
   int nInsertAt = -1,  
   CRuntimeClass* pRTI = NULL   
);  
```  
  
#### Parameters  
 [in] `lpszName`  
 Name of the ribbon category.  
  
 [in] `uiSmallImagesResID`  
 Resource ID of the small image list for the ribbon category.  
  
 [in] `uiLargeImagesResID`  
 Resource ID of the large image list for the ribbon category.  
  
 [in] `sizeSmallImage`  
 Specifies the size of small images for the ribbon category.  
  
 [in] `sizeLargeImage`  
 Specifies the size of large images for the ribbon category.  
  
 [in] `nInsertAt`  
 Zero based index of the category location.  
  
 [in] `pRTI`  
 Pointer to a [CMFCRibbonCategory](../vs140/cmfcribboncategory-class.md) run-time class to dynamically create a ribbon category at run-time.  
  
## Return Value  
 A pointer to the new ribbon category if the method was successful; otherwise, `NULL`.  
  
## Remarks  
 If the `pRTI` parameter is not `NULL`, the new ribbon category is created dynamically using the run-time class.  
  
## Example  
 The following example demonstrates how to use the `AddCategory` method in the `CMFCRibbonBar` class.  
  
 [!code[NVC_MFC_RibbonApp#5](../vs140/codesnippet/CPP/cmfcribbonbar--addcategory_1.cpp)]  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)