---
title: "CD2DRoundedRect::CD2DRoundedRect"
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
  - "afxrendertarget/CD2DRoundedRect::CD2DRoundedRect"
  - "CD2DRoundedRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DRoundedRect class, constructor"
ms.assetid: 9f22cbc3-9c00-489a-af2d-cec9a3eb3185
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DRoundedRect::CD2DRoundedRect
Constructs a CD2DRoundedRect object from CD2DRectF object.  
  
## Syntax  
  
```  
CD2DRoundedRect(  
   const CD2DRectF& rectIn,  
   const CD2DSizeF& sizeRadius  
);  
CD2DRoundedRect(  
   const D2D1_ROUNDED_RECT& rectIn  
);  
CD2DRoundedRect(  
   const D2D1_ROUNDED_RECT* rectIn  
);  
```  
  
#### Parameters  
 `rectIn`  
 source rectangle  
  
 `sizeRadius`  
 radius size  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DRoundedRect Class](../vs140/cd2droundedrect-class.md)