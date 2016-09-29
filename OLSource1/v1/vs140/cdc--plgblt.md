---
title: "CDC::PlgBlt"
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
  - "CDC.PlgBlt"
  - "CDC::PlgBlt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, bitmap functions"
  - "PlgBlt method"
ms.assetid: 7f1aa275-59df-4f27-85b3-4924eb546ebf
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::PlgBlt
Performs a bit-block transfer of the bits of color data from the specified rectangle in the source device context to the specified parallelogram in the given device context.  
  
## Syntax  
  
```  
  
      BOOL PlgBlt(  
   LPPOINT lpPoint,  
   CDC* pSrcDC,  
   int xSrc,  
   int ySrc,  
   int nWidth,  
   int nHeight,  
   CBitmap& maskBitmap,  
   int xMask,  
   int yMask   
);  
```  
  
#### Parameters  
 `lpPoint`  
 Points to an array of three points in logical space that identifies three corners of the destination parallelogram. The upper-left corner of the source rectangle is mapped to the first point in this array, the upper-right corner to the second point in this array, and the lower-left corner to the third point. The lower-right corner of the source rectangle is mapped to the implicit fourth point in the parallelogram.  
  
 `pSrcDC`  
 Identifies the source device context.  
  
 `xSrc`  
 Specifies the x-coordinate, in logical units, of the upper-left corner of the source rectangle.  
  
 `ySrc`  
 Specifies the y-coordinate, in logical units, of the upper-left corner of the source rectangle.  
  
 `nWidth`  
 Specifies the width, in logical units, of the source rectangle.  
  
 `nHeight`  
 Specifies the height, in logical units, of the source rectangle.  
  
 `maskBitmap`  
 Identifies an optional monochrome bitmap that is used to mask the colors of the source rectangle.  
  
 `xMask`  
 Specifies the x-coordinate of the upper-left corner of the monochrome bitmap.  
  
 `yMask`  
 Specifies the y-coordinate of the upper-left corner of the monochrome bitmap.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 If the given bitmask handle identifies a valid monochrome bitmap, the function uses this bitmap to mask the bits of color data from the source rectangle.  
  
 The fourth vertex of the parallelogram (D) is defined by treating the first three points (A, B, and C) as vectors and computing D = B + C - A.  
  
 If the bitmask exists, a value of 1 in the mask indicates that the source pixel color should be copied to the destination. A value of 0 in the mask indicates that the destination pixel color is not to be changed.  
  
 If the mask rectangle is smaller than the source and destination rectangles, the function replicates the mask pattern.  
  
 Scaling, translation, and reflection transformations are allowed in the source device context; however, rotation and shear transformations are not. If the mask bitmap is not a monochrome bitmap, an error occurs. The stretching mode for the destination device context is used to determine how to stretch or compress the pixels, if that is necessary. When an enhanced metafile is being recorded, an error occurs if the source device context identifies an enhanced-metafile device context.  
  
 The destination coordinates are transformed according to the destination device context; the source coordinates are transformed according to the source device context. If the source transformation has a rotation or shear, an error is returned. If the destination and source rectangles do not have the same color format, `PlgBlt` converts the source rectangle to match the destination rectangle. Not all devices support `PlgBlt`. For more information, see the description of the **RC_BITBLT** raster capability in the `CDC::GetDeviceCaps` member function.  
  
 If the source and destination device contexts represent incompatible devices, `PlgBlt` returns an error.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::BitBlt](../vs140/cdc--bitblt.md)   
 [CDC::GetDeviceCaps](../vs140/cdc--getdevicecaps.md)   
 [CDC::MaskBlt](../vs140/cdc--maskblt.md)   
 [CDC::StretchBlt](../vs140/cdc--stretchblt.md)   
 [SetStretchBltMode](http://msdn.microsoft.com/library/windows/desktop/dd145089)   
 [PlgBlt](http://msdn.microsoft.com/library/windows/desktop/dd162804)