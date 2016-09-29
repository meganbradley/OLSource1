---
title: "CImage::CreateEx"
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
  - "CImage::CreateEx"
  - "ATL.CImage.CreateEx"
  - "ATL::CImage::CreateEx"
  - "CImage.CreateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateEx method"
ms.assetid: bd58318c-e3e2-4b72-9e0f-459dcfb502d8
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImage::CreateEx
Creates a `CImage` bitmap and attach it to the previously constructed `CImage` object.  
  
## Syntax  
  
```  
  
      BOOL CreateEx(  
   int nWidth,  
   int nHeight,  
   int nBPP,  
   DWORD eCompression,  
   const DWORD* pdwBitmasks = NULL,  
   DWORD dwFlags = 0   
) throw( );  
```  
  
#### Parameters  
 `nWidth`  
 The width of the `CImage` bitmap, in pixels.  
  
 `nHeight`  
 The height of the `CImage` bitmap, in pixels. If `nHeight` is positive, the bitmap is a bottom-up DIB and its origin is the lower left corner. If `nHeight` is negative, the bitmap is a top-down DIB and its origin is the upper left corner.  
  
 `nBPP`  
 The numbers of bits per pixel in the bitmap. Usually 4, 8, 16, 24, or 32. Can be 1 for monochrome bitmaps or masks.  
  
 `eCompression`  
 Specifies the type of compression for a compressed bottom-up bitmap (top-down DIBs cannot be compressed). Can be one of the following values:  
  
-   **BI_RGB** The format is uncompressed. Specifying this value when calling `CImage::CreateEx` is equivalent to calling `CImage::Create`.  
  
-   **BI_BITFIELDS** The format is uncompressed and the color table consists of three `DWORD` color masks that specify the red, green, and blue components, respectively, of each pixel. This is valid when used with 16- and 32-bpp bitmaps.  
  
 *pdwBitfields*  
 Only used if `eCompression` is set to **BI_BITFIELDS**, otherwise it must be **NULL**. A pointer to an array of three `DWORD` bitmasks, specifying which bits of each pixel are used for the red, green, and blue components of the color, respectively. For information on restrictions for the bitfields, see [BITMAPINFOHEADER](http://msdn.microsoft.com/library/windows/desktop/dd183376) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `dwFlags`  
 Specifies if the bitmap object has an alpha channel. Can be a combination of zero or more of the following values:  
  
-   **createAlphaChannel** Can only be used if `nBPP` is 32, and `eCompression` is **BI_RGB**. If specified, the created image has an alpha (transparency) value for each pixel, stored in the 4th byte of each pixel (unused in a non-alpha 32-bit image). This alpha channel is automatically used when calling [CImage::AlphaBlend](../vs140/cimage--alphablend.md).  
  
    > [!NOTE]
    >  In calls to [CImage::Draw](../vs140/cimage--draw.md), images with an alpha channel are automatically alpha blended to the destination.  
  
## Return Value  
 **TRUE** if successful. Otherwise **FALSE**.  
  
## Example  
 The following example creates a 100x100 pixel bitmap, using 16 bits to encode each pixel. In a given 16-bit pixel, bits 0-3 encode the red component, bits 4-7 encode green, and bits 8-11 encode blue. The remaining 4 bits are unused.  
  
 [!code[NVC_ATLMFC_Utilities#69](../vs140/codesnippet/CPP/cimage--createex_1.cpp)]  
  
## Requirements  
 **Header:** atlimage.h  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)   
 [CImage::CImage](../vs140/cimage--cimage.md)   
 [CImage::Create](../vs140/cimage--create.md)   
 [CImage::AlphaBlend](../vs140/cimage--alphablend.md)