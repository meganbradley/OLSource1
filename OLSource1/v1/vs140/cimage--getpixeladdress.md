---
title: "CImage::GetPixelAddress"
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
  - "ATL.CImage.GetPixelAddress"
  - "CImage.GetPixelAddress"
  - "ATL::CImage::GetPixelAddress"
  - "CImage::GetPixelAddress"
  - "GetPixelAddress"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPixelAddress method"
ms.assetid: 8b65af22-3986-4e23-9513-ac1cd708238e
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImage::GetPixelAddress
Retrieves the exact address of a pixel.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *x*  
 The x-coordinate of the pixel.  
  
 *y*  
 The y-coordinate of the pixel.  
  
## Remarks  
 The address is determined according to the coordinates of a pixel, the pitch of the bitmap, and the bits per pixel.  
  
 For formats that have less than 8 bits per pixel, this method returns the address of the byte containing the pixel. For example, if your image format has 4 bits per pixel, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> returns the address of the first pixel in the byte, and you must calculate for 2 pixels per byte.  
  
> [!NOTE]
>  This method supports only DIB section bitmaps.  
  
## Requirements  
 **Header:** atlimage.h  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)