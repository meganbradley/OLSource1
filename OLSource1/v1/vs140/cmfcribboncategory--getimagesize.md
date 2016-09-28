---
title: "CMFCRibbonCategory::GetImageSize"
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
  - "CMFCRibbonCategory::GetImageSize"
  - "CMFCRibbonCategory.GetImageSize"
  - "GetImageSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetImageSize method"
ms.assetid: 93eb5991-a77f-4eda-8a93-60151880ad62
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCategory::GetImageSize
Retrieves the size of an image in the specified image list that is contained in the ribbon category.  
  
## Syntax  
  
```  
CSize GetImageSize(  
   BOOL bIsLargeImage  
) const;  
```  
  
#### Parameters  
 [in] `bIsLargeImage`  
 `TRUE` for the size of large images; `FALSE` for the size of small images.  
  
## Return Value  
 The size of an image in the specified image list.  
  
## Remarks  
 The size retrieved includes the global image scale factor.  
  
## Requirements  
 **Header:** afxribboncategory.h  
  
## See Also  
 [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)