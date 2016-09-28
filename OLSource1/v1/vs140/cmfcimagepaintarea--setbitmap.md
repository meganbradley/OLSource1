---
title: "CMFCImagePaintArea::SetBitmap"
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
  - "CMFCImagePaintArea::SetBitmap"
  - "SetBitmap"
  - "CMFCImagePaintArea.SetBitmap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBitmap method"
ms.assetid: abe405b6-68a1-4f27-848e-ba57b0148797
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCImagePaintArea::SetBitmap
Sets the bitmap image for the picture area.  
  
## Syntax  
  
```  
void SetBitmap(  
   CBitmap* pBitmap  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `pBitmap`|The new bitmap image to display.|  
  
## Remarks  
 If `pBitmap` is `NULL`, this method sets the size of the modifiable paint area to zero. Otherwise, it sets the size of the modifiable paint area to the size of the provided bitmap image.  
  
## Requirements  
 **Header:** afximagepaintarea.h  
  
## See Also  
 [CMFCImagePaintArea Class](../vs140/cmfcimagepaintarea-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CBitmap Class](../vs140/cbitmap-class.md)