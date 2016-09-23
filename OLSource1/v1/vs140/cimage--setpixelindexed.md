---
title: "CImage::SetPixelIndexed"
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
  - CImage.SetPixelIndexed
  - ATL::CImage::SetPixelIndexed
  - ATL.CImage.SetPixelIndexed
  - CImage::SetPixelIndexed
  - SetPixelIndexed
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetPixelIndexed method
ms.assetid: 483dd400-32e2-45cb-8f70-11be5335c197
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CImage::SetPixelIndexed
Sets the pixel color to the color located at `iIndex` in the color palette.  
  
## Syntax  
  
```  
  
      void SetPixelIndexed(  
   int x,  
   int y,  
   int iIndex   
) throw( );  
```  
  
#### Parameters  
 *x*  
 The horizontal location of the pixel to set.  
  
 *y*  
 The vertical location of the pixel to set.  
  
 `iIndex`  
 The index of a color in the color palette.  
  
## Requirements  
 **Header:** atlimage.h  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)   
 [CImage::SetPixel](../vs140/cimage--setpixel.md)   
 [CImage::SetPixelRGB](../vs140/cimage--setpixelrgb.md)