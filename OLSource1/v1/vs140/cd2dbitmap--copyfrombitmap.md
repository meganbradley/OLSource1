---
title: "CD2DBitmap::CopyFromBitmap"
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
  - "CopyFromBitmap"
  - "afxrendertarget/CD2DBitmap::CopyFromBitmap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CopyFromBitmap method"
ms.assetid: b0faa39f-7f17-4d2d-bfe1-d51ff78a603b
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DBitmap::CopyFromBitmap
Copies the specified region from the specified bitmap into the current bitmap  
  
## Syntax  
  
```  
HRESULT CopyFromBitmap(  
   const CD2DBitmap* pBitmap,  
   const CD2DPointU* destPoint = NULL,  
   const CD2DRectU* srcRect = NULL  
);  
```  
  
#### Parameters  
 `pBitmap`  
 The bitmap to copy from  
  
 `destPoint`  
 In the current bitmap, the upper-left corner of the area to which the region specified by srcRect is copied  
  
 `srcRect`  
 The area of bitmap to copy  
  
## Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DBitmap Class](../vs140/cd2dbitmap-class.md)