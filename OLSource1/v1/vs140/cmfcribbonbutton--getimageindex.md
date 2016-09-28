---
title: "CMFCRibbonButton::GetImageIndex"
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
  - "CMFCRibbonButton::GetImageIndex"
  - "GetImageIndex"
  - "CMFCRibbonButton.GetImageIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetImageIndex method"
ms.assetid: c955a04c-202d-43b6-afcd-4de037e93f8e
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonButton::GetImageIndex
Returns the index of the image that is associated with the button.  
  
## Syntax  
  
```  
int GetImageIndex(  
   BOOL bLargeImage   
) const;  
```  
  
#### Parameters  
 [in] `bLargeImage`  
 If `TRUE`, returns the image index in the image list that contains the large images; otherwise returns the image index in the image list that contains the small images.  
  
## Return Value  
 The index of the button's image in the associated image list.  
  
## Requirements  
 **Header:** afxribbonbutton.h  
  
## See Also  
 [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)