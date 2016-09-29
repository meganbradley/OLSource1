---
title: "CImage::SetPixel"
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
  - "CImage::SetPixel"
  - "ATL.CImage.SetPixel"
  - "ATL::CImage::SetPixel"
  - "CImage.SetPixel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetPixel method"
ms.assetid: 0f3ec0bb-6d9d-4379-bcfd-f4d97c2d29ae
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImage::SetPixel
Sets the color of a pixel at a given location in the bitmap.  
  
## Syntax  
  
```  
  
      void SetPixel(  
   int x,  
   int y,  
   COLORREF color   
) throw( );  
```  
  
#### Parameters  
 *x*  
 The horizontal location of the pixel to set.  
  
 *y*  
 The vertical location of the pixel to set.  
  
 `color`  
 The color to which you set the pixel.  
  
## Remarks  
 This method fails if the pixel coordinates lie outside of the selected clipping region.  
  
## Requirements  
 **Header:** atlimage.h  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)   
 [CImage::GetPixel](../vs140/cimage--getpixel.md)   
 [CImage::SetPixelIndexed](../vs140/cimage--setpixelindexed.md)   
 [CImage::SetPixelRGB](../vs140/cimage--setpixelrgb.md)