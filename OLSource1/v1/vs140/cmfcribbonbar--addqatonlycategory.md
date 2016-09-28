---
title: "CMFCRibbonBar::AddQATOnlyCategory"
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
  - "AddQATOnlyCategory"
  - "CMFCRibbonBar::AddQATOnlyCategory"
  - "CMFCRibbonBar.AddQATOnlyCategory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddQATOnlyCategory method"
ms.assetid: 47f7e0d4-82aa-4415-bd25-674fe8861ca9
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::AddQATOnlyCategory
Creates a quick access toolbar ribbon category.  
  
## Syntax  
  
```  
CMFCRibbonCategory* AddQATOnlyCategory(  
   LPCTSTR lpszName,  
   UINT uiSmallImagesResID,  
   CSize sizeSmallImage = CSize(16,16)  
);  
```  
  
#### Parameters  
 [in] `lpszName`  
 Name of the category.  
  
 [in] `uiSmallImagesResID`  
 Resource ID of the image list for the category.  
  
 [in] `sizeSmallImage`  
 Size of images for ribbon elements in the category.  
  
## Return Value  
 A pointer to the new category if the method was successful; otherwise, `NULL`.  
  
## Remarks  
 The quick access toolbar ribbon category is only used on the quick access toolbar customization dialog box.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)