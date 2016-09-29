---
title: "CImage::StretchBlt"
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
  - "ATL::CImage::StretchBlt"
  - "CImage::StretchBlt"
  - "ATL.CImage.StretchBlt"
  - "CImage.StretchBlt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SRCCOPY method"
  - "StretchBlt method"
ms.assetid: 9d0b7aa5-2b4e-4153-8454-3ea034cf280e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImage::StretchBlt
Copies a bitmap from the source device context to this current device context.  
  
## Syntax  
  
```  
  
      BOOL StretchBlt(  
   HDC hDestDC,  
   int xDest,  
   int yDest,  
   int nDestWidth,  
   int nDestHeight,  
   DWORD dwROP = SRCCOPY   
) const throw( );  
BOOL StretchBlt(  
   HDC hDestDC,  
   const RECT& rectDest,  
   DWORD dwROP = SRCCOPY   
) const throw( );  
BOOL StretchBlt(  
   HDC hDestDC,  
   int xDest,  
   int yDest,  
   int nDestWidth,  
   int nDestHeight,  
   int xSrc,  
   int ySrc,  
   int nSrcWidth,  
   int nSrcHeight,  
   DWORD dwROP = SRCCOPY   
) const throw( );  
BOOL StretchBlt(  
   HDC hDestDC,  
   const RECT& rectDest,  
   const RECT& rectSrc,  
   DWORD dwROP = SRCCOPY   
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
  
 `dwROP`  
 The raster operation to be performed. Raster-operation codes define exactly how to combine the bits of the source, the destination, and the pattern (as defined by the currently selected brush) to form the destination. See [BitBlt](http://msdn.microsoft.com/library/windows/desktop/dd183370) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of other raster-operation codes and their descriptions.  
  
 `rectDest`  
 A reference to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure, identifying the destination.  
  
 `xSrc`  
 The x-coordinate, in logical units, of the upper left corner of the source rectangle.  
  
 `ySrc`  
 The y-coordinate, in logical units, of the upper left corner of the source rectangle.  
  
 `nSrcWidth`  
 The width, in logical units, of the source rectangle.  
  
 `nSrcHeight`  
 The height, in logical units, of the source rectangle.  
  
 `rectSrc`  
 A reference to a `RECT` structure, identifying the source.  
  
## Return Value  
 Nonzero if successful, otherwise 0.  
  
## Remarks  
 For more information, see [StretchBlt](http://msdn.microsoft.com/library/windows/desktop/dd145120) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlimage.h  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)   
 [CImage::BitBlt](../vs140/cimage--bitblt.md)   
 [CImage::MaskBlt](../vs140/cimage--maskblt.md)