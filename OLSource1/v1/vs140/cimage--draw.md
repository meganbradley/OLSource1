---
title: "CImage::Draw"
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
  - CImage::Draw
  - CImage.Draw
  - ATL::CImage::Draw
  - ATL.CImage.Draw
dev_langs: 
  - C++
helpviewer_keywords: 
  - Draw method
ms.assetid: 35f87b0a-367f-4f64-b70b-1cfff88012d9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CImage::Draw
Copies a bitmap from the source device context to the current device context.  
  
## Syntax  
  
```  
  
      BOOL Draw(  
   HDC hDestDC,  
   int xDest,  
   int yDest,  
   int nDestWidth,  
   int nDestHeight,  
   int xSrc,  
   int ySrc,  
   int nSrcWidth,  
   int nSrcHeight   
) const throw( );  
BOOL Draw(  
   HDC hDestDC,  
   const RECT& rectDest,  
   const RECT& rectSrc   
) const throw( );  
BOOL Draw(  
   HDC hDestDC,  
   int xDest,  
   int yDest   
) const throw( );  
BOOL Draw(  
   HDC hDestDC,  
   const POINT& pointDest   
) const throw( );  
BOOL Draw(  
   HDC hDestDC,  
   int xDest,  
   int yDest,  
   int nDestWidth,  
   int nDestHeight   
) const throw( );  
BOOL Draw(  
   HDC hDestDC,  
   const RECT& rectDest   
) const throw( );  
```  
  
#### Parameters  
 `hDestDC`  
 A handle to the destination device context.  
  
 `xDest`  
 The x-coordinate, in logical units, of the upper left corner of the destination rectangle.  
  
 `yDest`  
 The y-coordinate, in logical units, of the upper left corner of the destination rectangle.  
  
 `nDestWidth`  
 The width, in logical units, of the destination rectangle.  
  
 `nDestHeight`  
 The height, in logical units, of the destination rectangle.  
  
 `xSrc`  
 The x-coordinate, in logical units, of the upper left corner of the source rectangle.  
  
 `ySrc`  
 The y-coordinate, in logical units, of the upper left corner of the source rectangle.  
  
 `nSrcWidth`  
 The width, in logical units, of the source rectangle.  
  
 `nSrcHeight`  
 The height, in logical units, of the source rectangle.  
  
 `rectDest`  
 A reference to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure, identifying the destination.  
  
 `rectSrc`  
 A reference to a `RECT` structure, identifying the source.  
  
 `pointDest`  
 A reference to a [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) structure that identifies the upper left corner of the destination rectangle, in logical units.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 **Draw** performs the same operation as [StretchBlt](../vs140/cimage--stretchblt.md), unless the image contains a transparent color or alpha channel. In that case, **Draw** performs the same operation as either [TransparentBlt](../vs140/cimage--transparentblt.md) or [AlphaBlend](../vs140/cimage--alphablend.md) as required.  
  
 For versions of **Draw** that do not specify a source rectangle, the entire source image is the default. For the version of **Draw** that does not specify a size for the destination rectangle, the size of the source image is the default and no stretching or shrinking occurs.  
  
## Requirements  
 **Header:** atlimage.h  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)