---
title: "CMFCRibbonCategory::GetImageCount"
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
  - "CMFCRibbonCategory::GetImageCount"
  - "CMFCRibbonCategory.GetImageCount"
  - "GetImageCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetImageCount method"
ms.assetid: b25cb2fb-b3ab-4a9e-9de2-18d5131d16ba
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCategory::GetImageCount
Retrieves the number of images in the specified image list that is contained in the ribbon category.  
  
## Syntax  
  
```  
int GetImageCount(  
   BOOL bIsLargeImage  
) const;  
```  
  
#### Parameters  
 [in] `bIsLargeImage`  
 `TRUE` for the number of images in the large image list; `FALSE` for the number of images in the small image list.  
  
## Return Value  
 The number of images in the specified image list.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribboncategory.h  
  
## See Also  
 [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)