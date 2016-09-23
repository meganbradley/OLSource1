---
title: "CRenderTarget::FillOpacityMask"
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
  - FillOpacityMask
  - afxrendertarget/CRenderTarget::FillOpacityMask
dev_langs: 
  - C++
helpviewer_keywords: 
  - FillOpacityMask method
ms.assetid: 158d4370-a980-4308-9d1c-5f9956cdb852
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRenderTarget::FillOpacityMask
Applies the opacity mask described by the specified bitmap to a brush and uses that brush to paint a region of the render target.  
  
## Syntax  
  
```  
void FillOpacityMask(  
   CD2DBitmap* pOpacityMask,  
   CD2DBrush* pBrush,  
   D2D1_OPACITY_MASK_CONTENT content,  
   const CD2DRectF& rectDest,  
   const CD2DRectF& rectSrc  
);  
```  
  
#### Parameters  
 `pOpacityMask`  
 The position and radius, in device-independent pixels, of the ellipse to paint.  
  
 `pBrush`  
 The brush used to paint the region of the render target specified by destinationRectangle.  
  
 `content`  
 The type of content the opacity mask contains. The value is used to determine the color space in which the opacity mask is blended.  
  
 `rectDest`  
 The region of the render target to paint, in device-independent pixels.  
  
 `rectSrc`  
 The region of the bitmap to use as the opacity mask, in device-independent pixels.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CRenderTarget Class](../vs140/crendertarget-class.md)