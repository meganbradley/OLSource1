---
title: "CImage::SetPixelRGB"
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
  - "ATL::CImage::SetPixelRGB"
  - "ATL.CImage.SetPixelRGB"
  - "CImage::SetPixelRGB"
  - "CImage.SetPixelRGB"
  - "SetPixelRGB"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetPixelRGB method"
ms.assetid: 9a711cac-c3b2-44d8-8817-8962bdc2e46a
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImage::SetPixelRGB
Sets the pixel at the locations specified by *x* and *y* to the colors indicated by *r*, *g*, and *b*, in a red, green, blue (RGB) image.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *x*  
 The horizontal location of the pixel to set.  
  
 *y*  
 The vertical location of the pixel to set.  
  
 *r*  
 The intensity of the red color.  
  
 *g*  
 The intensity of the green color.  
  
 *b*  
 The intensity of the blue color.  
  
## Remarks  
 The red, green, and blue parameters are each represented by a number between 0 and 255. If you set all three parameters to zero, the combined resulting color is black. If you set all three parameters to 255, the combined resulting color is white.  
  
## Requirements  
 **Header:** atlimage.h  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)   
 [CImage::SetPixel](../vs140/cimage--setpixel.md)   
 [CImage::SetPixelIndexed](../vs140/cimage--setpixelindexed.md)