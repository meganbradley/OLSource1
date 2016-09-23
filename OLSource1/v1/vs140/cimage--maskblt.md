---
title: "CImage::MaskBlt"
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
  - CImage.MaskBlt
  - CImage::MaskBlt
  - ATL.CImage.MaskBlt
  - ATL::CImage::MaskBlt
dev_langs: 
  - C++
helpviewer_keywords: 
  - MaskBlt method
ms.assetid: 7ad5fafa-c5f9-446b-843a-ce914196f8a3
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CImage::MaskBlt
Combines the color data for the source and destination bitmaps using the specified mask and raster operation.  
  
## Syntax  
  
```  
  
      BOOL MaskBlt(  
   HDC hDestDC,  
   int xDest,  
   int yDest,  
   int nDestWidth,  
   int nDestHeight,  
   int xSrc,  
   int ySrc,  
   HBITMAP hbmMask,  
   int xMask,  
   int yMask,  
   DWORD dwROP = SRCCOPY   
) const throw( );  
BOOL MaskBlt(  
   HDC hDestDC,  
   const RECT& rectDest,  
   const POINT& pointSrc,  
   HBITMAP hbmMask,  
   const POINT& pointMask,  
   DWORD dwROP = SRCCOPY   
) const throw( );  
BOOL MaskBlt(  
   HDC hDestDC,  
   int xDest,  
   int yDest,  
   HBITMAP hbmMask,  
   DWORD dwROP = SRCCOPY   
) const throw( );  
BOOL MaskBlt(  
   HDC hDestDC,  
   const POINT& pointDest,  
   HBITMAP hbmMask,  
   DWORD dwROP = SRCCOPY   
) const throw( );  
```  
  
#### Parameters  
 `hDestDC`  
 The handle to the module whose executable contains the resource.  
  
 `xDest`  
 The x-coordinate, in logical units, of the upper left corner of the destination rectangle.  
  
 `yDest`  
 The y-coordinate, in logical units, of the upper left corner of the destination rectangle.  
  
 `nDestWidth`  
 The width, in logical units, of the destination rectangle and source bitmap.  
  
 `nDestHeight`  
 The height, in logical units, of the destination rectangle and source bitmap.  
  
 `xSrc`  
 The logical x-coordinate of the upper left corner of the source bitmap.  
  
 `ySrc`  
 The logical y-coordinate of the upper left corner of the source bitmap.  
  
 `hbmMask`  
 Handle to the monochrome mask bitmap combined with the color bitmap in the source device context.  
  
 `xMask`  
 The horizontal pixel offset for the mask bitmap specified by the `hbmMask` parameter.  
  
 `yMask`  
 The vertical pixel offset for the mask bitmap specified by the `hbmMask` parameter.  
  
 `dwROP`  
 Specifies both foreground and background ternary raster operation codes that the method uses to control the combination of source and destination data. The background raster operation code is stored in the high-order byte of the high-order word of this value; the foreground raster operation code is stored in the low-order byte of the high-order word of this value; the low-order word of this value is ignored, and should be zero. For a discussion of foreground and background in the context of this method, see `MaskBlt` in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For a list of common raster operation codes, see `BitBlt` in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `rectDest`  
 A reference to a `RECT` structure, identifying the destination.  
  
 `pointSrc`  
 A `POINT` structure indicating the upper left corner of the source rectangle.  
  
 `pointMask`  
 A **POINT** structure indicating the upper left corner of the mask bitmap.  
  
 `pointDest`  
 A reference to a **POINT** structure that identifies the upper left corner of the destination rectangle, in logical units.  
  
## Return Value  
 Nonzero if successful, otherwise 0.  
  
## Remarks  
 This method applies to Windows NT, versions 4.0 and later only.  
  
 See `MaskBlt` in the [!INCLUDE[winsdkshort](../vs140/includes/winsdkshort_md.md)] and [CImage Limitations with Earlier Operating Systems](../vs140/cimage-limitations-with-earlier-operating-systems.md) for more detailed information.  
  
## Requirements  
 **Header:** atlimage.h  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)   
 [CImage::BitBlt](../vs140/cimage--bitblt.md)   
 [CImage::PlgBlt](../vs140/cimage--plgblt.md)   
 [MAKEROP4](http://msdn.microsoft.com/library/windows/desktop/dd145044)