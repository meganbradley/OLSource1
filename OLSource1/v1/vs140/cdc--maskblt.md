---
title: "CDC::MaskBlt"
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
  - MaskBlt
  - CDC.MaskBlt
  - CDC::MaskBlt
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDC class, bitmap functions
  - MaskBlt method
ms.assetid: 9ff9b7b7-1539-485e-bc7c-51eb161fa91b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::MaskBlt
Combines the color data for the source and destination bitmaps using the given mask and raster operation.  
  
## Syntax  
  
```  
  
      BOOL MaskBlt(  
   int x,  
   int y,  
   int nWidth,  
   int nHeight,  
   CDC* pSrcDC,  
   int xSrc,  
   int ySrc,  
   CBitmap& maskBitmap,  
   int xMask,  
   int yMask,  
   DWORD dwRop   
);  
```  
  
#### Parameters  
 *x*  
 Specifies the logical x-coordinate of the upper-left corner of the destination rectangle.  
  
 *y*  
 Specifies the logical y-coordinate of the upper-left corner of the destination rectangle.  
  
 `nWidth`  
 Specifies the width, in logical units, of the destination rectangle and source bitmap.  
  
 `nHeight`  
 Specifies the height, in logical units, of the destination rectangle and source bitmap.  
  
 `pSrcDC`  
 Identifies the device context from which the bitmap is to be copied. It must be zero if the *dwRop* parameter specifies a raster operation that does not include a source.  
  
 `xSrc`  
 Specifies the logical x-coordinate of the upper-left corner of the source bitmap.  
  
 `ySrc`  
 Specifies the logical y-coordinate of the upper-left corner of the source bitmap.  
  
 `maskBitmap`  
 Identifies the monochrome mask bitmap combined with the color bitmap in the source device context.  
  
 `xMask`  
 Specifies the horizontal pixel offset for the mask bitmap specified by the `maskBitmap` parameter.  
  
 `yMask`  
 Specifies the vertical pixel offset for the mask bitmap specified by the `maskBitmap` parameter.  
  
 *dwRop*  
 Specifies both foreground and background ternary raster operation codes, which the function uses to control the combination of source and destination data. The background raster operation code is stored in the high byte of the high word of this value; the foreground raster operation code is stored in the low byte of the high word of this value; the low word of this value is ignored, and should be zero. The macro **MAKEROP4** creates such combinations of foreground and background raster operation codes. See the Remarks section for a discussion of foreground and background in the context of this function. See the `BitBlt` member function for a list of common raster operation codes.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 A value of 1 in the mask specified by `maskBitmap` indicates that the foreground raster operation code specified by *dwRop* should be applied at that location. A value of 0 in the mask indicates that the background raster operation code specified by *dwRop* should be applied at that location. If the raster operations require a source, the mask rectangle must cover the source rectangle. If it does not, the function will fail. If the raster operations do not require a source, the mask rectangle must cover the destination rectangle. If it does not, the function will fail.  
  
 If a rotation or shear transformation is in effect for the source device context when this function is called, an error occurs. However, other types of transformations are allowed.  
  
 If the color formats of the source, pattern, and destination bitmaps differ, this function converts the pattern or source format, or both, to match the destination format. If the mask bitmap is not a monochrome bitmap, an error occurs. When an enhanced metafile is being recorded, an error occurs (and the function returns 0) if the source device context identifies an enhanced-metafile device context. Not all devices support `MaskBlt`. An application should call `GetDeviceCaps` to determine whether a device supports this function. If no mask bitmap is supplied, this function behaves exactly like `BitBlt`, using the foreground raster operation code. The pixel offsets in the mask bitmap map to the point (0,0) in the source device context's bitmap. This is useful for cases in which a mask bitmap contains a set of masks; an application can easily apply any one of them to a mask-blitting task by adjusting the pixel offsets and rectangle sizes sent to `MaskBlt`.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::BitBlt](../vs140/cdc--bitblt.md)   
 [CDC::GetDeviceCaps](../vs140/cdc--getdevicecaps.md)   
 [CDC::PlgBlt](../vs140/cdc--plgblt.md)   
 [CDC::StretchBlt](../vs140/cdc--stretchblt.md)   
 [MaskBlt](http://msdn.microsoft.com/library/windows/desktop/dd145047)