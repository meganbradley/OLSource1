---
title: "CImage::TransparentBlt"
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
  - "ATL.CImage.TransparentBlt"
  - "CImage::TransparentBlt"
  - "ATL::CImage::TransparentBlt"
  - "CImage.TransparentBlt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CLR_INVALID method"
  - "TransparentBlt method"
ms.assetid: 04a8826b-5803-40ea-ab00-4b626867d328
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImage::TransparentBlt
Copies a bitmap from the source device context to this current device context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A handle to the destination device context.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The x-coordinate, in logical units, of the upper left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The y-coordinate, in logical units, of the upper left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The width, in logical units, of the destination rectangle.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The height, in logical units, of the destination rectangle.  
  
 *crTransparent*  
 The color in the source bitmap to treat as transparent. By default, **CLR_INVALID**, indicating that the color currently set as the transparent color of the image should be used.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A reference to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure, identifying the destination.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The x-coordinate, in logical units, of the upper left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The y-coordinate, in logical units, of the upper left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The width, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The height, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> structure, identifying the source.  
  
## Return Value  
 **TRUE** if successful, otherwise **FALSE**.  
  
## Remarks  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is supported for source bitmaps of 4 bits per pixel and 8 bits per pixel. Use [CImage::AlphaBlend](../vs140/cimage--alphablend.md) to specify 32 bits-per-pixel bitmaps with transparency.  
  
 This method is applicable to Microsoft Windows 2000, Windows 98, and later systems. See [TransparentBlt](http://msdn.microsoft.com/library/windows/desktop/dd145141) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] and [CImage Limitations with Earlier Operating Systems](../vs140/cimage-limitations-with-earlier-operating-systems.md) for more detailed information.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#199](../vs140/codesnippet/CPP/cimage--transparentblt_1.cpp)]  
  
## Requirements  
 **Header:** atlimage.h  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)   
 [CImage::StretchBlt](../vs140/cimage--stretchblt.md)   
 [CImage::MaskBlt](../vs140/cimage--maskblt.md)   
 [CImage::BitBlt](../vs140/cimage--bitblt.md)